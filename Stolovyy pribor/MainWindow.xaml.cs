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
using Stolovyy_pribor.AddPage;

namespace Stolovyy_pribor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.model0db = new Entities();
            AppFrame.frameMain = FrameMain;
            FrameMain.Navigate(new Autorizat());
        }
        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new Products());
        }
    }
}
