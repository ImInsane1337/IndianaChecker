using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ServerHelper
{
    public partial class Checker : Form
    {
        public Checker()
        {
            InitializeComponent();
        }

        private void RunEmbeddedExe(string resourceName, string outputName)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), outputName);
            if (File.Exists(tempPath))
                File.Delete(tempPath);
            using (Stream resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            using (FileStream file = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
            {
                resource.CopyTo(file);
            }
            Process.Start(tempPath);
        }

        private void Recent_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer", Path.GetTempPath());
                Process.Start("explorer", Environment.GetFolderPath(Environment.SpecialFolder.Recent));
                GMOD.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening folders:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSteamInstallPath()
        {
            string steamPath = string.Empty;
            try
            {
                // Открываем ключ реестра, где хранится путь установки Steam
                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam"))
                {
                    if (key != null)
                    {
                        // Читаем путь из значения "SteamPath"
                        steamPath = key.GetValue("SteamPath") as string;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing the registry: " + ex.Message);
            }
            return steamPath;
        }

        private void GMOD_Click(object sender, EventArgs e)
        {
            string steamPath = GetSteamInstallPath();

            if (!string.IsNullOrEmpty(steamPath))
            {
                string pathC = Path.Combine(steamPath, @"steamapps\common\GarrysMod\garrysmod\lua\bin");
                string pathD = @"D:\SteamLibrary\steamapps\common\GarrysMod\garrysmod\lua\bin";

                if (Directory.Exists(pathC))
                {
                    Process.Start("explorer", pathC);
                }
                else if (Directory.Exists(pathD))
                {
                    Process.Start("explorer", pathD);
                }
                else
                {
                    MessageBox.Show("Garry's Mod lua\\bin directory not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Steam is not installed or registry entry is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LastActivity.Visible = true;
        }

        private void usb_Click(object sender, EventArgs e)
        {
            var form = new AppInfo();
            form.SetInfo(
                "USBDeview",
                "USBDeview — утилита, отображающая список всех USB-устройств, подключённых к системе ранее или в данный момент. Позволяет отключать, удалять устройства, а также просматривать подробную информацию о каждом из них.",
                () =>
                {
                    RunEmbeddedExe("ServerHelper.Files.USB.USB.exe", "USB.exe");
                });
            form.ShowDialog();
        }

        private void ph_Click(object sender, EventArgs e)
        {
            var form = new AppInfo();
            form.SetInfo(
                "Process Hacker 2",
                "Process Hacker — продвинутый менеджер задач и процессов, предоставляющий расширенную информацию о работающих службах, процессах и использовании ресурсов. Полезен для диагностики и анализа системы.",
                () =>
                {
                    RunEmbeddedExe("ServerHelper.Files.PH.ProcessHacker.exe", "ProcessHacker.exe");
                });
            form.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new AppInfo();
            form.SetInfo(
                "Recuva",
                "Recuva — утилита для восстановления удалённых файлов с жёстких дисков, флешек и других накопителей. Простая и эффективная в использовании, поддерживает глубокий анализ и восстановление даже повреждённых данных.",
                () =>
                {
                    RunEmbeddedExe("ServerHelper.Files.RC.rc.exe", "rc.exe");
                });
            form.ShowDialog();
        }

        private void LastActivity_Click(object sender, EventArgs e)
        {
            var form = new AppInfo();
            form.SetInfo(
                "LastActivityView",
                "LastActivityView — инструмент для отображения последних действий пользователя: запусков программ, открытий файлов, системных событий и многого другого. Удобен при анализе поведения пользователя и отслеживании активности.",
                () =>
                {
                    RunEmbeddedExe("ServerHelper.Files.LA.LastActivityView.exe", "LastActivityView.exe");
                });
            form.ShowDialog();
        }
        private void Everything_Click(object sender, EventArgs e)
        {
            var form = new AppInfo();
            form.SetInfo(
                "Everything",
                "Everything — это быстрый и мощный инструмент для поиска файлов и папок на вашем компьютере. Он индексирует все файлы и позволяет выполнять поиск в реальном времени по всем доступным дискам и папкам. Подходит для пользователей, которые часто ищут файлы в больших объемах данных.",
                () =>
                {
                    RunEmbeddedExe("ServerHelper.Files.EV.ev.exe", "ev.exe");
                    string clipText = "(AOShax | hl2 | v2 | nj | dll | loader | inject | hack | Macros | чит | Cheat | Xore | Privat | Приват | Lua | \"Free The Skids\" | \"Lee Cheat\" | \"MethMine loader\" | FriendlyHack | \"Glua Loader\" | \"Bigpackets\" | \"FriendlyStealer (урбаничка)\" | \"Interium Glua Loader (урбаничка)\" | \"Other (урбаничка)\" | Exec | \"BigPackets\" | \"Cobalt и Refix\" | \"Exec Hack\" | \"Meta Hack\" | OneTap | \"LemiGmod\" | Lemi | Nixware | CFF | \".7z\" | \".rar\" | \".aos\" | \".vpcfg\" | \".cfgexec\" | \".otc\" | brokencore | \"Urbanichka\" | Noxis | rijin | bhop | bzhop | SimpleGmod | Gaztoof | GMOD) ";
                    Clipboard.SetText(clipText);
                });
            form.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/indiana_rp");
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/indianarp");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/indiana-rp");
        }

        private void chromium_Click(object sender, EventArgs e)
        {
            string steamPath = GetSteamInstallPath();

            if (!string.IsNullOrEmpty(steamPath))
            {
                string pathC = Path.Combine(steamPath, @"steamapps\common\GarrysMod\chromium.log");
                string pathD = @"D:\SteamLibrary\steamapps\common\GarrysMod\chromium.log";

                if (File.Exists(pathC))
                {
                    Process.Start("notepad.exe", pathC);
                }
                else if (File.Exists(pathD))
                {
                    Process.Start("notepad.exe", pathD);
                }
                else
                {
                    MessageBox.Show("Chromium log не найден!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Стим не установлен либо нету файлов в реестре", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LastActivity.Visible = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Открывает браузер с пустой страницей
                Process.Start("https://example.com");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
