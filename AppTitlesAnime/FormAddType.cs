namespace AppTitlesAnime
{
    public partial class FormAddType : Form
    {
        public FormAddType()
        {
            InitializeComponent();
        }

        private void TextBoxTypeName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым!");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }

        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, "Поле не может быть пустым!");
                btnSaveChanges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btnSaveChanges.Enabled = true;
            }
        }
    }
}
