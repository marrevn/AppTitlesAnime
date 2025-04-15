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
            FormAddGenre formAddGenre = new FormAddGenre();
            formAddGenre.ShowDialog();
        }
    }
}
