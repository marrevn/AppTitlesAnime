﻿using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormAddGenre : Form
    {
        private AppContext db; // Добавляем поле для контекста базы данных
        public FormAddGenre()
        {
            InitializeComponent();
            this.db = new AppContext(); // Инициализация контекста в конструкторе
            this.db.Genres.Load(); // Загрузка данных
        }
        private void FormAddGenre_Load(object sender, EventArgs e)
        {

        }
        private void TextBoxGenreName_Validating(object sender, CancelEventArgs e)
        {
            // Проверка на пустую строку
            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProvider1.SetError(textBoxGenreName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
                return;
            }
            string newGenreAnime = textBoxGenreName.Text;

            bool exits = db.Genres.Any(t => t.GenreName.ToLower() == newGenreAnime.ToLower());

            // Проверка на уникальность значения 
            if (exits)
            {
                btnSaveChanges.Enabled = false;
                errorProvider1.SetError(textBoxGenreName, "Такой статус уже существует");
            }
            else
            {
                btnSaveChanges.Enabled = true;
            }
        }

        private void TextBoxGenreName_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxGenreName.Text))
            {
                errorProvider1.SetError(textBoxGenreName, "Поле не может быть пустым");
                btnSaveChanges.Enabled = false;
                return;
            }

            if (db.Genres.Local.Any(s => s.GenreName.Equals(textBoxGenreName.Text)))
            {
                errorProvider1.SetError(textBoxGenreName, "Такой статус уже существует");
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
