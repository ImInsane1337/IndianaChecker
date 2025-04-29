using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Checker checkerForm = new Checker();
            checkerForm.FormClosed += (s, args) => this.Close();
            checkerForm.Show();
        }
    }
}
