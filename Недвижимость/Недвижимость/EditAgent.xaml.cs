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

namespace Недвижимость
{
    /// <summary>
    /// Логика взаимодействия для EditAgent.xaml
    /// </summary>
    public partial class EditAgent : Window
    {
        int id;
        public EditAgent(bd.agent agent)
        {
            InitializeComponent();
            DataContext = agent;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var edit = App.entities.agents.FirstOrDefault(c => c.Id == id);
                edit.FirstName = fname.Text;
                edit.MiddleName = name.Text;
                edit.LastName = oname.Text;
                if (dolya.Text == "")
                {
                    edit.DealShare = Convert.ToInt32(null);
                }
                else
                {
                    edit.DealShare = Convert.ToInt32(dolya.Text);
                }
                App.entities.SaveChanges();
                MessageBox.Show("Данные успешно изменены");
                Close();
            }
            catch
            { }
        }
    }
}
