using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautiesShopApp.ModelEF;
using BeautiesShopApp.Pages;

namespace BeautiesShopApp.Pages
{    
    public partial class WorkWithDataPege : Form
    {
        public Model1 db { get; set; }
        public Product pr { get; set; }
        public WorkWithDataPege()
        {
            InitializeComponent();
        }
        private void WorkWithDataPege_Load(object sender, EventArgs e)
        {
            if (pr == null)//Если emp задано значение null, то нужно создать новую запись
            {
                productBindingSource.AddNew();// добавляем новую пустую запись в employeesBindingSource 
                PageName.Text = "Добавление данных";// задаем название формы для вывода на экран
            }
            else //если ter присвоен объект, то нужно его корректировать
            {
                productBindingSource.Add(pr);// добавляем переданный объект в employeesBindingSource                    
                PageName.Text = "Изменение данных";// задаем название формы
                iDTextBox.ReadOnly = true;
            }            
        }
        //КНОПКИ
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pr == null)// если создан новый объект, то 
            {
                pr = (Product)productBindingSource.Current;//получаем его из локальной памяти                
                db.Product.Add(pr);// добавляем созданный и заполненный объект в коллекцию модели
            }
            try
            {
                db.SaveChanges();// пытаемся сохранить сделанные изменения в БД
                DialogResult = DialogResult.OK;// если задать значение свойству DialogResult, то форма закроется
            }
            catch (Exception ex)// если возникла ошибка, то показываем сообщение
            {
                MessageBox.Show("Ошибка " + ex.Message);// если DialogResult значение не задано, форма не закрывается
            }
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();//Текущая страница скрывается
        }
    }
}