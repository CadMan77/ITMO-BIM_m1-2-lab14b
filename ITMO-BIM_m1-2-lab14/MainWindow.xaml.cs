using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ITMO_BIM_m1_2_lab14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Product> products;

        public MainWindow()
        {

            InitializeComponent();

            products = new ObservableCollection<Product>();

            products.Add(new Product()
            {
                Name = "Фен",
                Price = 1000,
                Photo = "Data/fen.png",
                Category = (Categories)1
            });

            products.Add(new Product()
            {
                Name = "Апельсин",
                Price = 100,
                Photo = "Data/orange.png",
                Category = (Categories)0
            });

            products.Add(new Product()
            {
                Name = "Чайник",
                Price = 1500,
                Photo = "Data/teapot.png",
                Category = (Categories)1
            });

            products.Add(new Product()
            {
                Name = "Арбуз",
                Price = 50,
                Photo = "Data/watermelon.png",
                Category = (Categories)0
            });

            listBox.ItemsSource = products;

        }
    }
}
