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
    public partial class AppInfo : Form
    {
        public AppInfo()
        {
            InitializeComponent();
        }

        public void SetInfo(string name, string description, Action onStart)
        {
            Name.Text = name;
            Description.Text = description;
            AppStart.Click -= AppStart_Click; // Отключаем старые обработчики
            AppStart.Click += (s, e) => onStart();
        }


        private void AppStart_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
