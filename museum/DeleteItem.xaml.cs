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
    /// Логика взаимодействия для DeleteItem.xaml
    /// </summary>
    public partial class DeleteItem : Window
    {
        public DeleteItem()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ItemGrid.ItemsSource = Helper.db.Items.Where(t => t.IdItem >= 1).Include(u => u.Museum).ToList();
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалиь запись об экспонате?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ;
                    var Item = ItemGrid.SelectedItem as Item;
                    Helper.db.Items.Remove(Item); Helper.db.SaveChanges();
                    ItemGrid.ItemsSource = Helper.db.Items.ToList();
                    MessageBox.Show("Запись успешно удалена");
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить запись!", "Ошибка удаления записи!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
