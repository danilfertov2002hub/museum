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
using Microsoft.EntityFrameworkCore;

namespace museum
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            MuseumGrid.ItemsSource = Helper.db.Museums.Where(t => t.IdMuseum >= 1).ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            new AdminMenu().Show();
            this.Close();
        }
    }
}
