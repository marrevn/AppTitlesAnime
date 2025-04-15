using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormListStatus : Form
    {
        private AppContext db;
        public FormListStatus()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Statuses.Load();
            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();

            //скрытие столбцов
            dataGridViewStatus.Columns["Id"].Visible = false;
            dataGridViewStatus.Columns["TitlesStatuses"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewStatus.Columns["StatusName"].HeaderText = "Статус аниме";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void BtnAddStatus_Click(object sender, EventArgs e)
        {
            FormAddStatus formAddStatus = new FormAddStatus();
            formAddStatus.ShowDialog();
        }
    }
}
