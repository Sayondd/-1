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
using Недвижимость.bd;

namespace Недвижимость
{
    /// <summary>
    /// Логика взаимодействия для EditClient.xaml
    /// </summary>
    public partial class EditClient : Window
    {
        int id;
        public EditClient(bd.client client)
        {
            InitializeComponent();
            DataContext = client;
            id = client.Id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var edit = App.entities.clients.FirstOrDefault(c => c.Id == id);
                edit.FirstName = fname.Text;
                edit.MiddleName = name.Text;
                edit.LastName = oname.Text;
                edit.Phone = phone.Text;
                edit.Email = email.Text;
                App.entities.SaveChanges();
                MessageBox.Show("Данные успешно изменены");
                Close();
            }
            catch
            { }
        }
    }
}
