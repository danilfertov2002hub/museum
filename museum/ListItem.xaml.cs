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
    /// Логика взаимодействия для ListItem.xaml
    /// </summary>
    public partial class ListItem : Window
    {
        public ListItem()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            ItemGrid.ItemsSource = Helper.db.Items.Where(t => t.IdItem >= 1).Include(u => u.Museum).ToList();
        }
    }
}
