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
using Praktika1DT.Praktika1DataSetTableAdapters;

namespace Praktika1DT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomersTableAdapter customers = new CustomersTableAdapter();
        DirectorsTableAdapter directors = new DirectorsTableAdapter();
        PurchasesTableAdapter purchases = new PurchasesTableAdapter();
        StoreTableAdapter store = new StoreTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable.ItemsSource = customers.GetData();
        }

        private void DirectorsButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable.ItemsSource = directors.GetData();
        }

        private void PurchasesButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable.ItemsSource = purchases.GetData();
        }

        private void StoreButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable.ItemsSource= store.GetData();
        }
    }
}
