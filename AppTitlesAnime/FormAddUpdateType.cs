using Microsoft.EntityFrameworkCore;
using AppContext = AppTitlesAnime.Models.AppContext;

namespace AppTitlesAnime
{
    public partial class FormAddUpdateType : Form
    {
        private AppContext db; // Добавляем поле для контекста базы данных
        public FormAddUpdateType()
        {
            InitializeComponent();
            this.db = new AppContext(); // Инициализация контекста в конструкторе
            this.db.Types.Load(); // Загрузка данных
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

            string newTypesAnime = textBoxTypeName.Text;

            bool exits = db.Types.Any(t => t.TypeName.ToLower() == newTypesAnime.ToLower());

            // Проверка на уникальность значения 
            if (exits)
            {
                btnSaveChanges.Enabled = false;
                errorProvider.SetError(textBoxTypeName, "Такой статус уже существует");
            }
            else
            {
                btnSaveChanges.Enabled = true;
            }
        }
    }
}
