using Microsoft.EntityFrameworkCore.Diagnostics;
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
using System.Windows.Shapes;

namespace museum
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ListMuseum_Click(object sender, RoutedEventArgs e)
        {
            new Menu().Show();
            /*this.Close();*/
        }

        private void ListItem_Click(object sender, RoutedEventArgs e)
        {
            new ListItem().Show();
            //this.Close();
        }

        private void ListRecordMoving_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddMuseum_Click(object sender, RoutedEventArgs e)
        {
            new NewMuseum().Show();
            //this.Close();
        }

        private void DeleteMuseum_Click(object sender, RoutedEventArgs e)
        {
            new DeleteMuseum().Show();
            //this.Close();
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            new DeleteItem().Show();
            //this.Close();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            new NewItem().Show();
            //this.Close();
        }

        private void InfPassportEmployee_Click(object sender, RoutedEventArgs e)
        {
            new PassportInfoEmployee().Show();
            //this.Close();
        }

        private void MyProfile_Click(object sender, RoutedEventArgs e)
        {
            new Profile().Show();
            this.Close();
        }
    }
}
