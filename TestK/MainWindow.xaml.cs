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

namespace TestK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Service[] service = new[]
            {
               new Service {Name = "sdsd", FullPrice=123, Price = 100, Sale = 100,But1 = "Collapsed" ,But2 = "Visible"},
               new Service { FullPrice = 1000, Sale = 70, Price =234, Name = "jsdaopd", But1 = "Visible", But2 = "Visible"},
               new Service { FullPrice = 1432, Sale = -20, Price =23432, Name = "gfdgfdfgd",But1 = "Visible", But2 = "Collapsed"}
            };
            lb1.ItemsSource = service;
        }

        private void BRemove_Click(object sender, RoutedEventArgs e)
        {
            var t = e.OriginalSource as Button;
            var f = t.DataContext as Service;
            MessageBox.Show(f.ToString());
        }

        private void BRedact_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    sealed class Service
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Sale { get; set; }
        public int FullPrice { get; set; }
        public string ImagePath { get; set; }
        public string But1 { get; set; }
        public string But2 { get; set; }
        
    }
}
