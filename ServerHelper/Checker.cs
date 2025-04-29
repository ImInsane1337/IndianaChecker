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

            // Скрываем всё кроме первой кнопки
            GMOD.Visible = false;
            LastActivity.Visible = false;
            Everything.Visible = false;
            ph.Visible = false;
            recuva.Visible = false;
            exit.Visible = false;
            usb.Visible = false;
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

        private void GMOD_Click(object sender, EventArgs e)
        {
            string pathC = @"C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\lua\bin";
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

            LastActivity.Visible = true;
        }

        private void LastActivity_Click(object sender, EventArgs e)
        {
            RunEmbeddedExe("ServerHelper.Files.LA.LastActivityView.exe", "LastActivityView.exe");
            Everything.Visible = true;
        }

        private void Everything_Click(object sender, EventArgs e)
        {
            RunEmbeddedExe("ServerHelper.Files.EV.ev.exe", "ev.exe");
            string clipText = "AOShax | hl2 | v2 | nj | dll | loader | inject | hack | Macros | чит | Cheat | Xore | Privat | Приват | Lua | Free The Skids | Lee Cheat | MethMine loader | FriendlyHack | Glua Loader | Bigpackets | FriendlyStealer (урбаничка) | Interium Glua Loader (урбаничка) | Other (урбаничка) | Exec | BigPackets | Cobalt и Refix | Exec Hack | Meta Hack | OneTap | LemiGmod | Lemi | Nixware | CFF | .7z | .rar | .aos | .vpcfg | .cfgexec | .otc | brokencore | Urbanichka | Noxis | rijin | bhop | bzhop | SimpleGmod | Gaztoof | GMOD";
            Clipboard.SetText(clipText);

            ph.Visible = true;
        }

        private void ph_Click(object sender, EventArgs e)
        {
            RunEmbeddedExe("ServerHelper.Files.PH.ProcessHacker.exe", "ProcessHacker.exe");
            recuva.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RunEmbeddedExe("ServerHelper.Files.RC.rc.exe", "rc.exe");
            usb.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void usb_Click(object sender, EventArgs e)
        {
            RunEmbeddedExe("ServerHelper.Files.USB.USB.exe", "USB.exe");
            exit.Visible = true;
        }
    }
}
