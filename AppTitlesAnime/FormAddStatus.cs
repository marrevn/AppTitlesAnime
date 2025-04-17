using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;


namespace AppTitlesAnime
{
    public partial class FormAddStatus : Form
    {
        private AppContext db; // Добавляем поле для контекста базы данных
        public FormAddStatus()
        {
            InitializeComponent();
            this.db = new AppContext(); // Инициализация контекста в конструкторе
            this.db.Statuses.Load(); // Загрузка данных
        }

        private void FormAddStatus_Load(object sender, EventArgs e)
        {

        }
        private void TextBoxStatusName_Validating(object sender, CancelEventArgs e)
        {
            // Проверка на пустую строку
            if (String.IsNullOrEmpty(textBoxStatusName.Text))
            {
                errorProvider1.SetError(textBoxStatusName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
                return;
            }

            // Проверка на уникальность значения (используем Any для поиска совпадений)
            if (db.Statuses.Local.Any(s => s.StatusName.Equals(textBoxStatusName.Text)))
            {
                errorProvider1.SetError(textBoxStatusName, "Такой статус уже существует");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void TextBoxStatusName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatusName.Text))
            {
                errorProvider1.SetError(textBoxStatusName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
                return;
            }

            // Проверка на уникальность 
            if (db.Statuses.Local.Any(s => s.StatusName.Equals(textBoxStatusName.Text)))
            {
                errorProvider1.SetError(textBoxStatusName, "Такой статус уже существует");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnSaveChanges.Enabled = true;
            }
        }
    }
}
