using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using BeautiesShopApp.ModelEF;
using BeautiesShopApp.Pages;

namespace BeautiesShopApp.Pages
{
    public partial class ProductPage : Form
    {
        //Вывод изображения вместо пути к нему
        //private static void ExportDataToDatabse()
        //{
        //    var fileData = File.ReadAllLines(@"C:\Users\User\Desktop\Задания на удалёнке\Задание 25.01.2022 - Магазин косметики\Мои результаты\BeautiesShopApp\BeautiesShopApp\Resources\Products");
        //    var images = 
        //}

        Model1 db = new Model1();
        public ProductPage()
        {
            InitializeComponent();
        }
        private void ProductPage_Load(object sender, EventArgs e)
        {
            //Передача данных из таблиц на страницу
            manufacturerBindingSource.DataSource = db.Manufacturer.ToList();
            //productBindingSource.DataSource = db.Product.ToList();
            
            List<string> lstTypes = db.Manufacturer.Select(c => c.Name).ToList();// создаем коллекцию названий категорий товаров, которые будем хранить в FiltrCombo
            lstTypes.Sort();// сортируем по алфавиту            
            lstTypes.Insert(0, "Все производители");// вставляем в начало коллекции (индекс = 0) значение «Все производители»
            // передаем созданную коллекцию в ЭУ ComboBox
            FiltrComboBox.DataSource = lstTypes;
            FiltrComboBox.SelectedIndex = 0;
            SortingComboBox.SelectedIndex = 0;            
            productBindingSource.DataSource = db.Product.ToList();// передаем данные о товарах в промежуточный объект
        }
        string sort = "Без сортировки"; // последнее значение сортировки
        string search = "";        // последнее значение поисковой строки
        string filter = "Все производители"; // последнее выбранное значение фильтрации
        public void DataPreparation()
        {            
            List<Product> lstProducts = db.Product.ToList();// вначале сохраняем все товары в коллекции
            if (filter != "Все производители")// выполняем фильтрацию по типам товаров
            {  // отбираем только товары заданной категории
                lstProducts = lstProducts.
                Where(p => (p.Manufacturer.Name == filter)).ToList();
            }
            if (search != "")// отбор с использованием поиска заданной строке
            { // поиск без учета регистра
              // отбираем товары с заданной строкой в названии
                search = search.ToUpper(); // делаем все буквы большими
                                           // отбираем объекты у которых в ProductName содержится строка search
                lstProducts = lstProducts.Where(p => (p.Title.ToUpper().Contains(search))).ToList();
            }
            if (sort != "Без сортировки")// сортировка по разным полям
            {
                if (sort == "Наименование")
                {   // сортируем отобранные товары по наименованию
                    if (!DownCheckBox.Checked) // нет галочки в чек-боксе
                        lstProducts = lstProducts.OrderBy(p => p.Title).ToList();
                    else
                        lstProducts = lstProducts.OrderByDescending(p => p.Title).ToList();
                }
                if (sort == "Стоимость")
                {   // сортируем отобранные товары по наименованию
                    if (!DownCheckBox.Checked) // нет галочки в чек-боксе
                        lstProducts = lstProducts.OrderBy(p => p.Cost).ToList();
                    else
                        lstProducts = lstProducts.OrderByDescending(p => p.Cost).ToList();
                }
            }            
            productBindingSource.DataSource = lstProducts;// передаем полученную коллекцию в промежуточный объект
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
        private void btnAddProduct_Click(object sender, EventArgs e)//ДОБАВИТЬ
        {
            WorkWithDataPege page = new WorkWithDataPege();//Создаем объект формы
            page.db = db;
            page.pr = null;//Передаем в WorkWithDataPage значение null для свойства usr т.е. сообщаем, что нужно создать новый объект
            DialogResult dr = page.ShowDialog();// показываем форму в диалоговом режиме            
            if (dr == DialogResult.OK)//Если пользователь DialogResut == OK
            {
                //Обновляем данные для ЭУ DataGridView
                productBindingSource.DataSource = null;
                productBindingSource.DataSource = db.Product.ToList();
            }
        }
        private void btnEditProduct_Click(object sender, EventArgs e)//ИЗМЕНИТЬ
        {
            Product pr = (Product)productBindingSource.Current;//Получаем текущий объект (на него указывается в DataGridView)
            WorkWithDataPege page = new WorkWithDataPege();//Создаем форму для работы с данными            
            page.db = db;
            page.pr = pr;//Передаем в форму объект
            DialogResult dr = page.ShowDialog();//Показываем форму в диалоговом режиме (возвращает DialogResult)
            if (dr == DialogResult.OK)//Если пользователь нажал кнопку «Сохранить» (у нее DialogResut = OK)
            {
                //Обновляем данные для ЭУ DataGridView
                productBindingSource.DataSource = null;
                productBindingSource.DataSource = db.Product.ToList();
            }
        }
        private void btnDelProduct_Click(object sender, EventArgs e)//УДАЛИТЬ
        {
            Product pr = (Product)productBindingSource.Current;//Получаем текущий объект (на него указывается в DataGridView)
            // показываем сообщение с заданием всех параметров
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись о товаре - " + pr.Title.ToString()
                + "?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Показываем диалоговое окно с кнопками Yes и No
            if (dr == DialogResult.Yes)//Если пользователь нажал кнопку «Yes»
            {
                db.Product.Remove(pr);//Удаляем выбранный объект из коллекции
                //Сохраняем сделанные изменения в БД
                try//Обрабатываем исключения
                {
                    db.SaveChanges();//Сохраняем сделанные изменения в БД                    
                    productBindingSource.DataSource = db.Product.ToList();//Обновляем содержание userBindingSource
                }
                catch (Exception ex)//Если ошибка, то попадаем сюда
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);//Выводим сообщение SQL Server об ошибке
                }
            }
        }
        private void btnGoBack_Click(object sender, EventArgs e)//НАЗАД
        {
            //Пользователь возвращается на предыдущую страницу
            MainPage mainPage = new MainPage();
            mainPage.FormClosed += formClosed;
            this.Hide();//Текущая страница скрывается
            mainPage.Show();
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }        
    }
}
