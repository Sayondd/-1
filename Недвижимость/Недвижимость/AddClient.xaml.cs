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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (fname.Text == "" || name.Text == "" || oname.Text == "" || phone.Text == "" || email.Text == "")
                {
                    MessageBox.Show("Не все поля занолнены");
                }
                else
                {
                    client client = new client
                    {
                        FirstName = fname.Text,
                        MiddleName = name.Text,
                        LastName = oname.Text,
                        Phone = phone.Text,
                        Email = email.Text
                    };
                    App.entities.clients.Add(client);
                    App.entities.SaveChanges();
                    MessageBox.Show("Данные успешно добавлены!");
                    Close();
                }
            }
            catch
            { }
        }
    }
}
