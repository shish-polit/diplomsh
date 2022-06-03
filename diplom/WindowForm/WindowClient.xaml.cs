using diplom.WindowAdd;
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

namespace diplom.WindowForm
{
    /// <summary>
    /// Логика взаимодействия для WindowClient.xaml
    /// </summary>
    public partial class WindowClient : Window
    {
        gostinEntities context;
        string currentLetter = "";
        public WindowClient()
        {
            InitializeComponent();
            context = new gostinEntities();
            DataGridClient.ItemsSource = context.Client.ToList();
            ShowTable();
        }
        private void ShowTable()
        {
        
            List<Client> listClient = context.Client.ToList();
            if (currentLetter.Count() == 1)
            {
                listClient = listClient.Where(x => x.Firstname.Contains(currentLetter)).ToList();
            }
            DataGridClient.ItemsSource = listClient.OrderBy(x=>x.Firstname).ToList();
        }

        private void ShowLetters()
        {
            for (char i = 'А'; i < 'Я'; i++)
            {
                TextBlock letter = new TextBlock
                {
                    Text = i.ToString(),
                    FontWeight = FontWeights.Bold,
                    Foreground = Brushes.White,
                    Margin = new Thickness(5)
                };
                letter.MouseLeftButtonDown += Letter_MouseLeftButtonDown;
                StackLetters.Children.Add(letter);
            }
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            var NewClient = new Client();
            context.Client.Add(NewClient);
            var EditWindows = new WindowAddClient(context, NewClient);
            EditWindows.ShowDialog();
            ShowTable();
        }

        private void BtnDeleteClientS_Click(object sender, RoutedEventArgs e)
        {
            var currentRegistr = DataGridClient.SelectedItem as Client;
            if (currentRegistr == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.Client.Remove(currentRegistr);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnBackClientS_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Letter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var label = (TextBlock)sender;
            currentLetter = label.Text;
            foreach (TextBlock letter in StackLetters.Children)
            {
                letter.Foreground = Brushes.White;
            }
            label.Foreground = Brushes.Gold;
            ShowTable();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button client = sender as Button;
            var currentRegistr = client.DataContext as Client;
            var cl = new WindowAddClient(context, currentRegistr);
            cl.ShowDialog();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ShowLetters();
        }
    }
}
