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
    public partial class TransitionPage : Form
    {
        Model1 db = new Model1();
        public TransitionPage()
        {
            InitializeComponent();
        }
        //КНОПКИ
        private void DriverButton_Click(object sender, EventArgs e)
        {
            DriverPage driverPage = new DriverPage();
            driverPage.Show();
            this.Hide();//Текущая страница скрывается
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            //Пользователь возвращается на предыдущую страницу
            AuthorizationPage autPage = new AuthorizationPage();
            autPage.FormClosed += formClosed;
            autPage.Show();
            this.Hide();//Текущая страница скрывается
        }
        void formClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
