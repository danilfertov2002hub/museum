using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для NewMuseum.xaml
    /// </summary>
    public partial class NewMuseum : Window
    {
        public NewMuseum()
        {
            InitializeComponent();
        }

        private void AddMuseum_Click(object sender, RoutedEventArgs e)
        {
            string nameMuseum = NameMuseumBox.Text;
            string city = CityBox.Text;

            if (nameMuseum.Length < 3)
            {
                MessageBox.Show("Поля заполнены не корректно!");
            }
            else if (city.Length < 3)
            {
                MessageBox.Show("Поля заполнены не корректно!");
            }
            else
            {
                Museum museum = new Museum()
                {
                    NameMuseum = nameMuseum,
                    City = city,
                };
                Helper.db.Museums.Add(museum);
                Helper.db.SaveChanges();
                MessageBox.Show("Запись успешно добавлена!");   
                this.Close();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            new AdminMenu().Show();
            this.Close();
        }
    }
}
