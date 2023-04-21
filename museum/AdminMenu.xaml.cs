using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace museum
{
    /// <summary>
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void DeleteItems_Click(object sender, RoutedEventArgs e)
        {
            new DeleteItem().Show();
            
        }

        private void InfoItems_Click(object sender, RoutedEventArgs e)
        {
            new ListItem().Show();
            
        }

        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            new NewItem().Show();
            
        }

        private void DeleteMuseums_Click(object sender, RoutedEventArgs e)
        {
            new DeleteMuseum().Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Menu().Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new NewMuseum().Show();
            
        }

        private void InfoEmployees_Click(object sender, RoutedEventArgs e)
        {
            new PassportInfoEmployee().Show();
        }
    }
}
