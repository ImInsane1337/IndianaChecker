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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CheckerStart_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(sid.Text) ||
                string.IsNullOrWhiteSpace(ds.Text) ||
                string.IsNullOrWhiteSpace(nick.Text) ||
                string.IsNullOrWhiteSpace(reason.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Создание экземпляра формы Checker
            Checker checkerForm = new Checker();

            // Установка текстов на новой форме
            checkerForm.sidtext.Text = $"SteamID: {sid.Text}";
            checkerForm.dstext.Text = $"Discord: {ds.Text}";
            checkerForm.nicktext.Text = $"Nickname: {nick.Text}";
            checkerForm.reasontext.Text = $"Причина проверки: {reason.Text}";

            // Показ новой формы и скрытие текущей
            checkerForm.Show();
            this.Hide();
        }
    }
}
