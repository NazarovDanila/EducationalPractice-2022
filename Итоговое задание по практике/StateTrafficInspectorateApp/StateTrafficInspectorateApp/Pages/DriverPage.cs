using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StateTrafficInspectorateApp.ModelEF;
using StateTrafficInspectorateApp.Pages;

namespace StateTrafficInspectorateApp.Pages
{
    public partial class DriverPage : Form
    {
        Model1 db = new Model1();
        public DriverPage()
        {
            InitializeComponent();
        }

        private void DriverPage_Load(object sender, EventArgs e)
        {
            //Передача данных из таблиц на страницу
            //manufacturerBindingSource.DataSource = db.Manufacturer.ToList();
            companyBindingSource.DataSource = db.Company.ToList();
            jobBindingSource.DataSource = db.Job.ToList();

            List<string> lstTypes = db.Driver.Select(c => c.LastName).ToList();// создаем коллекцию названий категорий товаров, которые будем хранить в FiltrCombo
            lstTypes.Sort();// сортируем по алфавиту            
            lstTypes.Insert(0, "Все компании");// вставляем в начало коллекции (индекс = 0) значение «Все производители»
            // передаем созданную коллекцию в ЭУ ComboBox
            FiltrComboBox.DataSource = lstTypes;
            FiltrComboBox.SelectedIndex = 0;
            SortingComboBox.SelectedIndex = 0;
            driverBindingSource.DataSource = db.Driver.ToList();// передаем данные о товарах в промежуточный объект
        }        
        //ПОИСК, ФИЛЬТРАЦИЯ И СОРТИРОВКА
        string sort = "Без сортировки"; // последнее значение сортировки
        string search = "";        // последнее значение поисковой строки
        string filter = "Все компании"; // последнее выбранное значение фильтрации
        public void DataPreparation()
        {
            List<Driver> lstProducts = db.Driver.ToList();// вначале сохраняем все товары в коллекции
            if (filter != "Все компании")// выполняем фильтрацию по типам товаров
            {  // отбираем только товары заданной категории
                lstProducts = lstProducts.
                Where(p => (p.Company1.CompanyName == filter)).ToList();
            }
            if (search != "")// отбор с использованием поиска заданной строке
            { // поиск без учета регистра
              // отбираем товары с заданной строкой в названии
                search = search.ToUpper(); // делаем все буквы большими
                                           // отбираем объекты у которых в ProductName содержится строка search
                lstProducts = lstProducts.Where(p => (p.FirstName.ToUpper().Contains(search)) || (p.LastName.ToUpper().Contains(search)) || (p.Patronymic.ToUpper().Contains(search))).ToList();
            }
            if (sort != "Без сортировки")// сортировка по разным полям
            {
                if (sort == "Фамилия")
                {   // сортируем отобранные товары по наименованию
                    if (!DownCheckBox.Checked) // нет галочки в чек-боксе
                        lstProducts = lstProducts.OrderBy(p => p.LastName).ToList();
                    else
                        lstProducts = lstProducts.OrderByDescending(p => p.LastName).ToList();
                }
                if (sort == "Имя")
                {   // сортируем отобранные товары по наименованию
                    if (!DownCheckBox.Checked) // нет галочки в чек-боксе
                        lstProducts = lstProducts.OrderBy(p => p.FirstName).ToList();
                    else
                        lstProducts = lstProducts.OrderByDescending(p => p.LastName).ToList();
                }
                if (sort == "Отчество")
                {   // сортируем отобранные товары по наименованию
                    if (!DownCheckBox.Checked) // нет галочки в чек-боксе
                        lstProducts = lstProducts.OrderBy(p => p.Patronymic).ToList();
                    else
                        lstProducts = lstProducts.OrderByDescending(p => p.LastName).ToList();
                }
            }
            driverBindingSource.DataSource = lstProducts;// передаем полученную коллекцию в промежуточный объект
        }

        private void FiltrComboBox_SelectedIndexChanged(object sender, EventArgs e)//ФИЛЬТРАЦИЯ
        {
            filter = FiltrComboBox.Text;
            DataPreparation();
        }
        private void SortingComboBox_SelectedIndexChanged(object sender, EventArgs e)//СОРТИРОВКА
        {
            sort = SortingComboBox.Text;
            DataPreparation();
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)//ПОИСК
        {
            search = SearchTextBox.Text;
            DataPreparation();
        }
        private void DownCheckBox_CheckedChanged(object sender, EventArgs e)//УБЫВАНИЕ
        {
            DataPreparation();
        }
        //КНОПКИ
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            //Пользователь возвращается на предыдущую страницу
            TransitionPage trPage = new TransitionPage();
            trPage.FormClosed += formClosed;
            trPage.Show();
            this.Hide();//Текущая страница скрывается
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            WorkWithDriverDataPage page = new WorkWithDriverDataPage();//Создаем объект формы
            page.db = db;
            page.drive = null;//Передаем в WorkWithDataPage значение null для свойства usr т.е. сообщаем, что нужно создать новый объект
            DialogResult dr = page.ShowDialog();// показываем форму в диалоговом режиме            
            if (dr == DialogResult.OK)//Если пользователь DialogResut == OK
            {
                //Обновляем данные для ЭУ DataGridView
                driverBindingSource.DataSource = null;
                driverBindingSource.DataSource = db.Driver.ToList();
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            Driver drive = (Driver)driverBindingSource.Current;//Получаем текущий объект (на него указывается в DataGridView)
            WorkWithDriverDataPage page = new WorkWithDriverDataPage();//Создаем форму для работы с данными            
            page.db = db;
            page.drive = drive;//Передаем в форму объект
            DialogResult dr = page.ShowDialog();//Показываем форму в диалоговом режиме (возвращает DialogResult)
            if (dr == DialogResult.OK)//Если пользователь нажал кнопку «Сохранить» (у нее DialogResut = OK)
            {
                //Обновляем данные для ЭУ DataGridView
                driverBindingSource.DataSource = null;
                driverBindingSource.DataSource = db.Driver.ToList();
            }
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            Driver pr = (Driver)driverBindingSource.Current;//Получаем текущий объект (на него указывается в DataGridView)
            // показываем сообщение с заданием всех параметров
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись о товаре - " + pr.LastName.ToString()
                + "?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Показываем диалоговое окно с кнопками Yes и No
            if (dr == DialogResult.Yes)//Если пользователь нажал кнопку «Yes»
            {
                db.Driver.Remove(pr);//Удаляем выбранный объект из коллекции
                //Сохраняем сделанные изменения в БД
                try//Обрабатываем исключения
                {
                    db.SaveChanges();//Сохраняем сделанные изменения в БД                    
                    driverBindingSource.DataSource = db.Driver.ToList();//Обновляем содержание userBindingSource
                }
                catch (Exception ex)//Если ошибка, то попадаем сюда
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);//Выводим сообщение SQL Server об ошибке
                }
            }
        }
    }
}
