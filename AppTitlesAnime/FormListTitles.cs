using AppTitlesAnime.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
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
            this.db.Studios.Load(); // Загружаем студии

            LoadTitlesAnime();

            //скрытие стобцов
            dataGridViewTitles.Columns["id"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewTitles.Columns["TypeName"].HeaderText = "Тип";
            dataGridViewTitles.Columns["OriginalName"].HeaderText = "Оригинальное название";
            dataGridViewTitles.Columns["Name"].HeaderText = "Название";
            dataGridViewTitles.Columns["CountSeries"].HeaderText = "Количество серий";
            dataGridViewTitles.Columns["Duration"].HeaderText = "Продолжительность";
            dataGridViewTitles.Columns["StudioName"].HeaderText = "Студия"; // изменено!
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

            this.db.Studios.Load();
            List<Studio> studios = this.db.Studios.Local.OrderBy(s => s.StudioName).ToList();
            formAddUpdateTitle.comboBoxStudio.DataSource = studios;
            formAddUpdateTitle.comboBoxStudio.DisplayMember = "StudioName";
            formAddUpdateTitle.comboBoxStudio.ValueMember = "Id";
         

            DialogResult result = formAddUpdateTitle.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            AnimeTitle animeTitle = new()
            {
                OriginalName = formAddUpdateTitle.textBoxOriginalName.Text,
                Name = formAddUpdateTitle.textBoxName.Text,
                CountSeries = Convert.ToInt16(formAddUpdateTitle.numericUpDowncountSeries.Value),
                Duration = Convert.ToInt16(formAddUpdateTitle.numericUpDownDuration.Value),
                Description = formAddUpdateTitle.textBoxDescription.Text
            };

            Type type = (Type)formAddUpdateTitle.comboBoxType.SelectedItem!;
            animeTitle.IdType = type.Id;

            Studio studio = (Studio)formAddUpdateTitle.comboBoxStudio.SelectedItem!;
            animeTitle.StudioId = studio.id;

            db.AnimeTitles.Add(animeTitle);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadTitlesAnime();
        }

        private void BtnUpdateTitle_Click(object sender, EventArgs e)
        {
            if (dataGridViewTitles.SelectedRows.Count == 0)
                return;

            int index = dataGridViewTitles.SelectedRows[0].Index;
            int id = 0;

            bool converted = Int32.TryParse(dataGridViewTitles[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            AnimeTitle animeTitle = db.AnimeTitles.Find(id)!;
            FormAddUpdateTitles formAddUpdateTitle = new();

            formAddUpdateTitle.textBoxOriginalName.Text = animeTitle.OriginalName;
            formAddUpdateTitle.textBoxName.Text = animeTitle.Name;
            formAddUpdateTitle.numericUpDowncountSeries.Value = animeTitle.CountSeries;
            formAddUpdateTitle.numericUpDownDuration.Value = animeTitle.Duration;
            formAddUpdateTitle.textBoxDescription.Text = animeTitle.Description;

            this.db.Types.Load();
            List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeName).ToList();
            formAddUpdateTitle.comboBoxType.DataSource = types;
            formAddUpdateTitle.comboBoxType.DisplayMember = "TypeName";
            formAddUpdateTitle.comboBoxType.ValueMember = "Id";
            formAddUpdateTitle.comboBoxType.SelectedItem = animeTitle.Type;

            this.db.Studios.Load();
            List<Studio> studios = this.db.Studios.Local.OrderBy(s => s.StudioName).ToList();
            formAddUpdateTitle.comboBoxStudio.DataSource = studios;
            formAddUpdateTitle.comboBoxStudio.DisplayMember = "StudioName";
            formAddUpdateTitle.comboBoxStudio.ValueMember = "Id";
            formAddUpdateTitle.comboBoxStudio.SelectedItem = animeTitle.Studio;

            DialogResult result = formAddUpdateTitle.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            animeTitle.OriginalName = formAddUpdateTitle.textBoxOriginalName.Text;
            animeTitle.Name = formAddUpdateTitle.textBoxName.Text;
            animeTitle.CountSeries = Convert.ToInt16(formAddUpdateTitle.numericUpDowncountSeries.Value);
            animeTitle.Duration = Convert.ToInt16(formAddUpdateTitle.numericUpDownDuration.Value);
            animeTitle.Description = formAddUpdateTitle.textBoxDescription.Text;

            Type type = (Type)formAddUpdateTitle.comboBoxType.SelectedItem!;
            animeTitle.IdType = type.Id;

            Studio studio = (Studio)formAddUpdateTitle.comboBoxStudio.SelectedItem!;
            animeTitle.StudioId = studio.id;

            db.AnimeTitles.Update(animeTitle);
            db.SaveChanges();

            MessageBox.Show("Объект изменен", "",
              MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadTitlesAnime();
        }

        private void BtnDeleteTitle_Click(object sender, EventArgs e)
        {
            if (dataGridViewTitles.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
                return;

            int index = dataGridViewTitles.SelectedRows[0].Index;
            int id = 0;

            bool converted = Int32.TryParse(dataGridViewTitles[0, index].Value.ToString(), out id);

            if (!converted)
                return;

            AnimeTitle animeTitle = db.AnimeTitles.Find(id)!;

            db.AnimeTitles.Remove(animeTitle);
            db.SaveChanges();

            MessageBox.Show("Объект удален", "",
             MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadTitlesAnime();
        }

        private void LoadTitlesAnime()
        {
            this.dataGridViewTitles.DataSource = this.db.AnimeTitles
                .Include(i => i.Type)
                .Include(i => i.Studio)
                .Select(i => new
                {
                    i.Id,
                    i.Type.TypeName,
                    i.OriginalName,
                    i.Name,
                    i.CountSeries,
                    i.Duration,
                    StudioName = i.Studio.StudioName
                })
                .OrderBy(i => i.TypeName)
                .ThenBy(i => i.OriginalName).ToList();
        }
    }
}







