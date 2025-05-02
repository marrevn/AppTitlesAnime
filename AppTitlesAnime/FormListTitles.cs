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
using Type = AppTitlesAnime.Models.Type;

namespace AppTitlesAnime
{
    public partial class FormListTitles : Form
    {
        private AppContext db;
        public FormListTitles()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.AnimeTitles.Load();
            this.dataGridViewTitles.DataSource = this.db.AnimeTitles
                .Include(i => i.Type)
                .Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.OriginalName,
                    i.Name,
                    i.CountSeries,
                    i.Duration,
                    i.Studio
                })
                .OrderBy(i => i.TypeName)
                .ThenBy(i => i.OriginalName).ToList();

            //скрытие стобцов
            dataGridViewTitles.Columns["id"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewTitles.Columns["TypeName"].HeaderText = "Тип";
            dataGridViewTitles.Columns["OriginalName"].HeaderText = "Оригинальное название";
            dataGridViewTitles.Columns["Name"].HeaderText = "Название";
            dataGridViewTitles.Columns["CountSeries"].HeaderText = "Количество серий";
            dataGridViewTitles.Columns["Duration"].HeaderText = "Продолжительность";
            dataGridViewTitles.Columns["Studio"].HeaderText = "Студия";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddTitle_Click(object sender, EventArgs e)
        {
            FormAddUpdateTitles formAddUpdateTitle = new FormAddUpdateTitles();


            this.db.Types.Load();
            List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();

            formAddUpdateTitle.comboBoxType.DataSource = types;
            formAddUpdateTitle.comboBoxType.DisplayMember = "TypeName";
            formAddUpdateTitle.comboBoxType.ValueMember = "Id";

            DialogResult result = formAddUpdateTitle.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            AnimeTitle animeTitle = new()
            {
                OriginalName = formAddUpdateTitle.textBoxOriginalName.Text,
                Name = formAddUpdateTitle.textBoxName.Text,
                CountSeries = Convert.ToInt16(formAddUpdateTitle.numericUpDowncountSeries.Value),
                Duration = Convert.ToInt16(formAddUpdateTitle.numericUpDownDuration.Value),
                Studio = formAddUpdateTitle.textBoxStudio.Text,
                Description = formAddUpdateTitle.textBoxDescription.Text,

            };

            Type type = (Type)formAddUpdateTitle.comboBoxType.SelectedItem!;
            animeTitle.IdType = type.Id;

            db.AnimeTitles.Add(animeTitle);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.dataGridViewTitles.DataSource = this.db.AnimeTitles
                .Include(i => i.Type)
                .Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.OriginalName,
                    i.Name,
                    i.CountSeries,
                    i.Duration,
                    i.Studio
                })
                .OrderBy(i => i.TypeName)
                .ThenBy(i => i.OriginalName).ToList();

        }
    }
}
