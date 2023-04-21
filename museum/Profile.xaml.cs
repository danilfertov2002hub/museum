using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
            Employee currentEmployee = new Employee();
            currentEmployee = Helper.employeeSession;
            DataContext = currentEmployee;
            LoadData();
        }
        private void LoadData()
        {
            firstnamel.Content = Helper.employeeSession.Firstname;
            secondnamel.Content = Helper.employeeSession.Secondname;
            loginl.Content = Helper.employeeSession.Login;
            passwordl.Content = Helper.employeeSession.Password;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainMenu().Show();
            this.Close();
        }
    }
}
