using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeautySalonApp.Pages;

namespace BeautySalonApp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //КНОПКИ
        private void btnProduct_Click(object sender, EventArgs e)
        {
            //Открывается страница с данными сотрудников
            ProductPage productPage = new ProductPage();
            productPage.Show();
            this.Hide();//Текущая страница скрывается
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//Закрытие приложения
        }
    }
}
