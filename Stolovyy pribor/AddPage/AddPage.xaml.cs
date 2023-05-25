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
using Stolovyy_pribor.AddPage;

namespace Stolovyy_pribor.AddPage
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
       
        public AddPage(Products selectedProd)
        {
            InitializeComponent();
            cbCat.ItemsSource = Entities.GetContext().TypeCategory.ToList();
        }
            private void Add_date(object sender, RoutedEventArgs e)
        {
            Product products = new Product();
            products.ProductName = tbName.Text;
            products.ProductQuantityInStock = Convert.ToInt32(tbColvo);
            products.ProductEdzm = tbEz.Text;
            products.TypeSuppluer.TypeSuppluerName = tbSup.Text;
            products.ProductDescription = tbOpis.Text;
            products.ProductCost = Convert.ToInt32(tbPrice);

            var CurrentCategory = cbCat.SelectedItem as TypeCategory;
            products.ProductCategory = CurrentCategory.TypeCategoryID;

            Entities.GetContext().Product.Add(products);
            Entities.GetContext().SaveChanges();
            MessageBox.Show("Данные успешно добавлены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
        public AddPage()
        {
            InitializeComponent();
            cbCat.ItemsSource = Entities.GetContext().TypeCategory.ToList();
        }
        private void Add_datee(object sender, RoutedEventArgs e)
        {
            Product products = new Product();
            products.ProductName = tbName.Text;
            //products.ProductQuantityInStock = tbColvo.Text;
            products.ProductEdzm = tbEz.Text;
            products.TypeSuppluer.TypeSuppluerName = tbSup.Text;
            products.ProductDescription = tbOpis.Text;
            //products.ProductCost = tbPrice.Text;
            var CurrentCategory = cbCat.SelectedItem as TypeCategory;
            products.ProductCategory = CurrentCategory.TypeCategoryID;

            Entities.GetContext().Product.Add(products);
            Entities.GetContext().SaveChanges();
            MessageBox.Show("Данные успешно добавлены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }


        private void AddProductImageProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Nazad_Click(object sender, RoutedEventArgs e)
        {

        }
    }


 }

