using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using System.Xml.Linq;
using Недвижимость.bd;

namespace Недвижимость
{
    /// <summary>
    /// Логика взаимодействия для AddAgent.xaml
    /// </summary>
    public partial class AddAgent : Window
    {
        public AddAgent()
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
                if (fname.Text == "" || name.Text == "" || oname.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else
                {
                    agent agent = new agent
                    {
                        FirstName = fname.Text,
                        MiddleName = name.Text,
                        LastName = oname.Text,
                        DealShare = Convert.ToInt32(dolya.Text)
                    };
                    App.entities.agents.Add(agent);
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
