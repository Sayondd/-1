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
using Недвижимость.bd;

namespace Недвижимость
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DGVclient.ItemsSource = App.entities.clients.ToList();
            DGVagent.ItemsSource = App.entities.agents.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddClient client = new AddClient();
            client.ShowDialog();
            DGVclient.ItemsSource = App.entities.clients.ToList();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var edit = DGVclient.SelectedItem as bd.client;
            if (edit != null)
            {
                EditClient client = new EditClient(edit);
                client.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не выбрана строка для редактирования");
            }
            DGVclient.ItemsSource = App.entities.clients.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddAgent agent = new AddAgent();
            agent.ShowDialog();
            DGVagent.ItemsSource = App.entities.agents.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var edit = DGVagent.SelectedItem as bd.agent;
            if (edit != null)
            {
                EditAgent agent = new EditAgent(edit);
                agent.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не выбрана строка для редактирования");
            }
            DGVagent.ItemsSource = App.entities.agents.ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                var del = DGVagent.SelectedItem as bd.agent;
                if (del != null)
                {
                    MessageBoxResult result = MessageBox.Show("Вы уверены что хотите удалить данные?", "Подтверждение удаления", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        App.entities.agents.Remove(del);
                        App.entities.SaveChanges();
                        DGVagent.ItemsSource = App.entities.agents.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали строку для удаления");
                }
            }
            catch
            { }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                var del = DGVclient.SelectedItem as bd.client;
                if (del != null)
                {
                    MessageBoxResult result = MessageBox.Show("Вы уверены что хотите удалить данные?", "Подтверждение удаления", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        App.entities.clients.Remove(del);
                        App.entities.SaveChanges();
                        DGVclient.ItemsSource = App.entities.clients.ToList();
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали строку для удаления");
                }
            }
            catch
            { }
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchAgent = App.entities.agents.Where(c => c.FirstName.
                Contains(search.Text) | c.MiddleName.Contains(search.Text)
                | c.LastName.Contains(search.Text)).ToList();
            DGVagent.ItemsSource = searchAgent;
            var searchClient = App.entities.agents.Where(c => c.FirstName.
                Contains(search.Text) | c.MiddleName.Contains(search.Text)
                | c.LastName.Contains(search.Text)).ToList();
            DGVclient.ItemsSource = searchAgent;
        }
    }
}
