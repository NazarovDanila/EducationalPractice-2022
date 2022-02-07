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
    public partial class WorkWithDriverDataPage : Form
    {
        public Model1 db { get; set; }
        public Driver drive { get; set; }
        public WorkWithDriverDataPage()
        {
            InitializeComponent();
        }

        private void WorkWithDriverDataPage_Load(object sender, EventArgs e)
        {
            if (drive == null)//Если emp задано значение null, то нужно создать новую запись
            {
                driverBindingSource.AddNew();// добавляем новую пустую запись в employeesBindingSource 
                PageNameLable.Text = "Добавление данных";// задаем название формы для вывода на экран
            }
            else //если ter присвоен объект, то нужно его корректировать
            {
                driverBindingSource.Add(drive);// добавляем переданный объект в employeesBindingSource                    
                PageNameLable.Text = "Изменение данных";// задаем название формы
                iDTextBox.ReadOnly = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (drive == null)// если создан новый объект, то 
            {
                drive = (Driver)productBindingSource.Current;//получаем его из локальной памяти                
                db.Driver.Add(drive);// добавляем созданный и заполненный объект в коллекцию модели
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
            this.Hide();
        }
    }
}
