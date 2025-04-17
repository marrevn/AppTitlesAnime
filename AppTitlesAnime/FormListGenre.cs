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
    public partial class FormListGenre : Form
    {
        private AppContext db;
        public FormListGenre()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dataGridViewGenre.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();

            //скрытие столбцов
            dataGridViewGenre.Columns["Id"].Visible = false;
            dataGridViewGenre.Columns["TitlesGenres"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewGenre.Columns["GenreName"].HeaderText = "Жанр аниме";

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new();
            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Genre genre = new Genre();
            genre.GenreName = formAddGenre.textBoxGenreName.Text;

            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewGenre.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();

        }

        private void BtnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenre.SelectedRows.Count == 0)
                return;

            int index = dataGridViewGenre.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewGenre[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);
            FormAddGenre formAddGenre = new();
            formAddGenre.textBoxGenreName.Text = genre.GenreName;

            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            genre.GenreName = formAddGenre.textBoxGenreName.Text;
            db.Genres.Update(genre);
            db.SaveChanges();

            MessageBox.Show("Объект изменен");

            this.dataGridViewGenre.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }

        private void BtnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenre.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;

            int index = dataGridViewGenre.SelectedRows[0].Index;
            short id = 0;

            bool converted = Int16.TryParse(dataGridViewGenre[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Genre genre = db.Genres.Find(id);

            db.Genres.Remove(genre);
            db.SaveChanges();

            MessageBox.Show("Объект удален");

            this.dataGridViewGenre.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreName).ToList();
        }
    }
}
