using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ServerHelper
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info checkerForm = new Info();
            checkerForm.FormClosed += (s, args) => this.Close();
            checkerForm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/indiana_rp");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/indianarp");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/indiana-rp");
        }

        private void CheckerStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info checkerForm = new Info();
            checkerForm.FormClosed += (s, args) => this.Close();
            checkerForm.Show();
        }
    }
}
