using Azure.Messaging;
using Microsoft.EntityFrameworkCore;
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
using static System.Formats.Asn1.AsnWriter;

namespace museum
{
    /// <summary>
    /// Логика взаимодействия для NewItem.xaml
    /// </summary>
    public partial class NewItem : Window
    {
        public NewItem()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            MuseumBox.ItemsSource = Helper.db.Museums.Where(t => t.IdMuseum >= 1).ToList();
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            string nameItem = NameItemBox.Text;
            string age = AgeBox.Text;
            
            if (MuseumBox.SelectedIndex == -1)
            {
                MessageBox.Show("Поля заполнены не корректно!");
            }
            else if (age.Length < 1)
            {
                MessageBox.Show("Поля заполнены не корректно!");
            }
            else
            {
                int museumm = int.Parse(MuseumBox.SelectedValue.ToString());
                string StorageDate = DateStorageBox.Text;
                DateTime storageDate;
                if (DateTime.TryParse(StorageDate, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out storageDate))
                {
                }
                Item item = new Item()
                {
                    NameItem = nameItem,
                    Age = age,
                    StorageDate = storageDate,
                    MuseumId = museumm,
                };
                Helper.db.Items.Add(item);
                Helper.db.SaveChanges();
                MessageBox.Show("Запись успешно добавлена!");
                new ListItem().Show();
                this.Close();
            }
        }
    }
}
