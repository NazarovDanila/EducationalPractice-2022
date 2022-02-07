using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateTrafficInspectorateApp.Pages
{
    public partial class PINCodePage : Form
    {
        public PINCodePage()
        {
            InitializeComponent();
            var r = new Random();
            int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int n = 4;
            int result = 0;
            int k = 9;
            while (n-- > 0)
            {
                int j = r.Next(k);
                result = result * 10 + digits[j];

                int t = digits[k];
                digits[k--] = digits[j];
                digits[j] = t;
            }
            PINlabel.Text = result.ToString();
        }       
        //КНОПКИ
        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            if (PINField.Text == PINlabel.Text)//Если PIN-код введён верно, то переходим на следующую страницу
            {
                MessageBox.Show("Успешно!");
                TransitionPage transitionPage = new TransitionPage();
                transitionPage.Show();
                this.Hide();//Форма скрывается
            }
            else//Иначе, выводится сообщение об ошибке, и создаётся новый PIN-код
            {
                MessageBox.Show("Неверно введённый PIN-код!");
                var r = new Random();
                int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
                int n = 4;
                int result = 0;
                int k = 9;
                while (n-- > 0)
                {
                    int j = r.Next(k);
                    result = result * 10 + digits[j];

                    int t = digits[k];
                    digits[k--] = digits[j];
                    digits[j] = t;
                }
                PINlabel.Text = result.ToString();
            }                
        }
        private void btnGoBack_Click(object sender, EventArgs e)
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
