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
using Telerik.Windows.Controls;

namespace DrawerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {

        }
        private Dictionary<int, Product> MapProducts(List<Product> products)
        {
            Dictionary<int, Product> dict = new Dictionary<int, Product>();
            foreach (Product p in products) dict.Add(p.ID, p);
            return dict;
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> brands = new List<string>();
            brands.Add("Kryolan");
            brands.Add("Flormar");
            List<string> types = new List<string>();
            types.Add("Ruj");
            types.Add("Eyeliner");
            types.Add("Neutralizer");

            List<Product> productList = new List<Product>();
            productList.Add(new Product() { ID = 1, Brand = "Kryolan", Type = "Ruj", No = 12 });
            productList.Add(new Product() { ID = 2, Brand = "Flormar", Type = "Ruj", No = 24 });

            products = MapProducts(productList);
            foreach (var brand in brands) comboBrand.Items.Add(brand);
            foreach (var type in types) comboType.Items.Add(type);
        }
        public static Dictionary<int, Product> products;
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //int id = int.Parse(txtSearch.Text);
            //Product p = products[id];
            //MessageBox.Show(p.Brand);
            string s = txtSearch.Text;
            MessageBox.Show(""+products.Where(x => x.Value.Brand.Equals(s)).Count());
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new RadRibbonForm1().Show();
        }
    }
}
