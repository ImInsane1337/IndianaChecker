using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace ServerHelper
{
    public partial class Loading : Form
    {
        private const string GitHubReleasesUrl = "https://api.github.com/repos/ImInsane1337/IndianaChecker/releases/latest";
        private readonly HttpClient _httpClient;
        public string CurrentVersion = Program.GlobalVersion;

        public Loading()
        {
            InitializeComponent();
            VersionLabel.Text = "Версия: " + CurrentVersion;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "ServerHelper");
            CheckForUpdatesAsync();
        }

        private async void CheckForUpdatesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(GitHubReleasesUrl);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var jsonNode = JsonNode.Parse(json);
                string gitHubVersion = jsonNode?["tag_name"]?.GetValue<string>() ??
                                     jsonNode?["name"]?.GetValue<string>();

                if (string.IsNullOrWhiteSpace(gitHubVersion))
                {
                    MessageBox.Show("Не удалось определить версию из GitHub\nОтвет сервера:\n" +
                                  json.Substring(0, Math.Min(200, json.Length)) + "...",
                                  "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    OpenMainForm();
                    return;
                }
                string normalizedGitHub = gitHubVersion.Trim().TrimStart('v', 'V');
                string normalizedCurrent = CurrentVersion.Trim().TrimStart('v', 'V');

                if (!normalizedGitHub.Equals(normalizedCurrent, StringComparison.OrdinalIgnoreCase))
                {
                    var result = MessageBox.Show(
                        $"Доступна новая версия: {gitHubVersion}\n" +
                        $"Текущая версия: {CurrentVersion}\n\n" +
                        "Хотите перейти на страницу загрузки?",
                        "Обновление доступно",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        string htmlUrl = jsonNode?["html_url"]?.GetValue<string>();
                        if (!string.IsNullOrEmpty(htmlUrl))
                        {
                            Process.Start(new ProcessStartInfo(htmlUrl) { UseShellExecute = true });
                        }
                        Application.Exit();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка при проверке обновлений: {ex}");
                MessageBox.Show($"Ошибка при проверке обновлений: {ex.Message}",
                               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            OpenMainForm();
        }

        private void OpenMainForm()
        {
            var mainForm = new Auth();
            mainForm.Show();
            this.Hide();
        }
    }
}