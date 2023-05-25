using Stolovyy_pribor.ApplicationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Stolovyy_pribor.Autorization;
using Microsoft.Win32;
using Stolovyy_pribor.AddPage;

namespace Stolovyy_pribor.Autorization
{
    /// <summary>
    /// Логика взаимодействия для Autorizat.xaml
    /// </summary>
    public partial class Autorizat : Page
    {
        public Autorizat()
        {
            InitializeComponent();
        }


        private void ВuttonRegister_Click(object sender, RoutedEventArgs e)
        {

        }
        public static bool check_user(string login, string password)
        {
            var allUser = Entities.GetContext().User.ToList();
            var user = AppConnect.model0db.User.FirstOrDefault(x => x.UserLogin == login && x.UserPassword == password);
            if (user == null)
                return false;
            return true;
        }
        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    var user = AppConnect.model0db.User.FirstOrDefault(x => x.UserLogin == passautoriz.Text && x.UserPassword == PasswordBox.Password);
                    if (user == null)
                    {
                        MessageBox.Show("Ошибка авторизации", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        MessageBox.Show("Добрый день, " + user.UserName.ToString(), "Успешная авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                        AppFrame.frameMain.Navigate(new Product());
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ошибка " + Ex.Message.ToString(), "Критическая ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}