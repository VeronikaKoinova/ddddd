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
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Page
    {
        //public Products()
        //{
        //    InitializeComponent();
        //    var allproducts = Entities.GetContext().Product.ToList();
        //    ComboBoxFiltr.Items.Add("vce");
        //    foreach (var product in AppConnect.model0db.TypeManufacturer);
        //    {
        //        ComboBoxFiltr.Items.Add(product.TypeManufacturerName);
        //    }
        //    ComboBoxFiltr.SelectedItem = 0;
        //    UpdateProducts();
        //}
        public Products()
        {
            InitializeComponent();
            var allProducts = Entities.GetContext().Product.ToList();
            ComboBoxFiltr.Items.Add("Все");
            foreach (var product in AppConnect.model0db.TypeManufacturer)
            {
                ComboBoxFiltr.Items.Add(product.TypeManufacturerName);
            }
            ComboBoxFiltr.SelectedIndex = 0;
            UpdateProducts();
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                listViewProducks.ItemsSource = Entities.GetContext().Product.ToList();
            }

        }
        private void UpdateProducts()
        {

        
            var currentProducts = Entities.GetContext().Product.ToList();
            //var allProducts = Entities.GetContext().Products.ToList();

            if (ComboBoxFiltr.SelectedIndex > 0)
            {
                var b = ComboBoxFiltr.SelectedItem.ToString();
        currentProducts = currentProducts.Where(x => x.TypeManufacturer.TypeManufacturerName == ComboBoxFiltr.SelectedItem.ToString()).ToList();
    }

    currentProducts = currentProducts.Where(a => a.TypeManufacturer.TypeManufacturerName.ToLower().Contains(ComboBoxPoisk.Text.ToLower())).ToList();

    listViewProducks.ItemsSource = currentProducts;

            switch (ComboBoxSort.SelectedIndex)
            {
                case 0:
                    currentProducts = currentProducts.OrderBy(a => a.ProductCost).ToList();
                    break;
                case 1:
                    currentProducts = currentProducts.OrderByDescending(a => a.ProductCost).ToList();
                    break;

            }

listViewProducks.ItemsSource = currentProducts;
            
        }

        private void ProductsDob_Click(object sender, RoutedEventArgs e)
{

}

private void ProductsRedak_Click(object sender, RoutedEventArgs e)
{
    AppFrame.frameMain.Navigate(new AddPage());
}


private void ComboBoxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    UpdateProducts();
}

private void ComboBoxFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    UpdateProducts();
}

private void ComboBoxPoisk_TextChanged(object sender, TextChangedEventArgs e)
{
    listViewProducks.ItemsSource = AppConnect.model0db.Product.Where(p => p.TypeManufacturer.TypeManufacturerName.ToLower() == ComboBoxPoisk.Text.ToLower()).ToList();
    listViewProducks.ItemsSource = AppConnect.model0db.Product.Where(p => p.TypeCategory.TypeCategoryNAme.ToLower() == ComboBoxPoisk.Text.ToLower()).ToList();
}
    }

}
