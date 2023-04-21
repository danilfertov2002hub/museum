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

namespace museum
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

        private void AuthClick_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == "" || PasswordBox.Password == "")
            {
                MessageBox.Show("Пожалуйста, введите логин или пароль!", "Ошибка!");
            }
            else
            {
                Employee employee = Helper.db.Employees.FirstOrDefault(q => q.Login == LoginBox.Text && q.Password == PasswordBox.Password);
                if (employee != null)
                {
                    if (employee.PostId == 1)
                    {
                        Helper.employeeSession = employee;
                        Helper.db.SaveChanges();
                        MessageBox.Show("Вы успешно вошли!");
                        new MainMenu().Show();
                        this.Close();
                    }
                    else if (employee.PostId == 2)
                    {
                        Helper.employeeSession = employee;
                        Helper.db.SaveChanges();
                        MessageBox.Show("Вы успешно вошли!");
                        new AdminMenu().Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
        }
    }
}
