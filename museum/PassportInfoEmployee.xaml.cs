using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для PassportInfoEmployee.xaml
    /// </summary>
    public partial class PassportInfoEmployee : Window
    {
        public PassportInfoEmployee()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            PassportGrid.ItemsSource = Helper.db.Employees.Where(t => t.IdEmployee >= 1).Include(y => y.Passport).ToList();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            new AdminMenu().Show();
            this.Close();
        }
    }
}
