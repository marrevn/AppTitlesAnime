using System.ComponentModel;
using System.Data;
using AppTitlesAnime.Models;
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
            this.db = new AppContext(); // инициализация контекста базы данных
            this.db.Statuses.Load(); // загрузка данных статусов из базы данных
            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList(); //загрузим список из
                                                                                                             //базы данных и отобразим

            //скрытие столбцов
            dataGridViewStatus.Columns["Id"].Visible = false;
            dataGridViewStatus.Columns["TitlesStatuses"].Visible = false;

            //изменение названий заголовков столбцов
            dataGridViewStatus.Columns["StatusName"].HeaderText = "Статус аниме";
        }
        protected override void OnClosing(CancelEventArgs e)   // Метод, вызываемый при закрытии формы
        {
            base.OnClosing(e);
            this.db?.Dispose(); // Если db не null, вызываем Dispose()
            this.db = null;// Обнуляем ссылку
        }

        private void BtnAddStatus_Click(object sender, EventArgs e)
        {
            FormAddStatus formAddStatus = new(); // Создание экземпляра формы добавления статуса
            DialogResult result = formAddStatus.ShowDialog(this);   // Отображение формы как диалогового окна и получение результата

            if (result == DialogResult.Cancel)  // Если результат Cancel - выходим из метода
                return;

            Status status = new Status(); // Создание нового объекта Status
            status.StatusName = formAddStatus.textBoxStatusName.Text;//заполняем из текстового поля 

            db.Statuses.Add(status); // Добавление нового статуса в контекст базы данны
            db.SaveChanges();//сохраняем

            MessageBox.Show("Новый объект добавлен");//выводим сообщение

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();//загрузим список из
                                                                                                            //базы данных и отобразим
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)//если строк 0, то выходим из метода
                return;

            //строки есть продолжаем код
            int index = dataGridViewStatus.SelectedRows[0].Index;//получаем индес выбранной строки
            short id = 0;//записывваем туда значение

            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);//значение конвертируем
                                                                                                   //в тип данных bool. Сначала столбец, потом строку
                                                                                                   //Если конвертация успешна - возвращаем в id
            if (!converted)//если конвертация прошла неуспешно, выходим из метода
                return;

            Status status = db.Statuses.Find(id);//если успешно, то создаем экземпляр класса статуса аниме
            FormAddStatus formAddStatus = new();
            formAddStatus.textBoxStatusName.Text = status.StatusName;//из полученной строки заполняем по идентификатору

            DialogResult result = formAddStatus.ShowDialog(this);//отображаем диалоговую форму заполненную

            if (result == DialogResult.Cancel)//обрабатываем результат. Если нажали отмена, выходим из действия
                return;

            status.StatusName = formAddStatus.textBoxStatusName.Text;//в экземпляр класса статус будем записывать все значения
                                                                     //из элементов с формы. (если есть изменения)

            db.Statuses.Update(status);//обновляем и сохраняем изменения
            db.SaveChanges();

            MessageBox.Show("Объект изменен");//сообщение выводим 

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();//загрузим список из
                                                                                                            //базы данных и отобразим
        }

        private void BtnDeleteStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)//проверяем выбраны ли строки
                return;
            //если да
            DialogResult result = MessageBox.Show(//вызываем и создаем диалоговое окно и выводим сообщение
                "Вы уверены, что хотите удалить объект? \nВсе связанные данные будут удалены.",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)//если результат отрицательный то выходим из метода
                return;

            int index = dataGridViewStatus.SelectedRows[0].Index;//если да, то получаем текущую строку по id
            short id = 0;//записываем

            bool converted = Int16.TryParse(dataGridViewStatus[0, index].Value.ToString(), out id);//значение конвертируем
                                                                                                   //в тип данных bool. Сначала столбец, потом строку
                                                                                                   //Если конвертация успешна - возвращаем в id
            if (!converted)//если конвертация прошла неуспешно, выходим из метода
                return;

            Status status = db.Statuses.Find(id);//если успешно, то создаем экземпляр класса статуса аниме

            db.Statuses.Remove(status);//обращаемся к бд к табл статус и вызываем метод remove 
            db.SaveChanges();// сохраняем изменения

            MessageBox.Show("Объект удален");// выводим сообщение

            this.dataGridViewStatus.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusName).ToList();//загружаем
                                                                                                       //обновленный список
        }
    }
}
