namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }

        private void BtnShowGenre_Click(object sender, EventArgs e)
        {
            FormListGenre formListGenre = new FormListGenre();
            formListGenre.Show();
        }

        private void BtnShowStatus_Click(object sender, EventArgs e)
        {
            FormListStatus formListStatus = new FormListStatus();
            formListStatus.Show();
        }
    }
}
