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

namespace StateTrafficInspectorateApp
{
    public partial class AuthorizationPage : Form
    {
        Model1 db = new Model1();
        public AuthorizationPage()
        {
            InitializeComponent();            
        }
        //КНОПКИ
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Проверка на существование пользователя в базе данных по Логину и паролю
            if (loginField.Text == "" || passField.Text == "")//Проверяем, что все требуемые данные введены
            {
                MessageBox.Show(" Для входа в систему нужно ввести логин и пароль! ");//Выводится сообщение о том, что нужно заполнить все поля
                return;
            }
            //Проверяем, существует ли пользователь с введённым логином и паролем
            string log = loginField.Text;
            string pas = passField.Text;
            var listOfUsers = db.User.ToList();
            bool isFind = false;
            foreach (var user in listOfUsers)
            {
                if (user.Login == log && user.Password == pas)//Если логин и пароль совпадают, то
                {
                    isFind = true;
                    //Открытие главной страницы ввода PIN-кода
                    PINCodePage PINPage = new PINCodePage();
                    PINPage.Show();
                    this.Hide();//Форма для авторизации пользователя скрывается
                }
                //Поля для ввода логина и пароля очищаются
                loginField.Clear();
                passField.Clear();
            }
            if (!isFind)//Если пользователь с введённым логином и паролем не существует, то
            {
                MessageBox.Show("Такого пользователя не существует!");//Вывод сообщения об ошибке
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
