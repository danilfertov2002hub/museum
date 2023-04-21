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
    /// Логика взаимодействия для DeleteMuseum.xaml
    /// </summary>
    public partial class DeleteMuseum : Window
    {
        public DeleteMuseum()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            MuseumGrid.ItemsSource = Helper.db.Museums.Where(t => t.IdMuseum >= 1).ToList();
        }

        private void DeleteMuseum_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалиь запись об музее?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ;
                    var Museum = MuseumGrid.SelectedItem as Museum;
                    Helper.db.Museums.Remove(Museum); Helper.db.SaveChanges();
                    MuseumGrid.ItemsSource = Helper.db.Museums.ToList();
                    MessageBox.Show("Запись успешно удалена");
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить запись!", "Ошибка удаления записи!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            new AdminMenu().Show();
            this.Close();
        }
    }
}
