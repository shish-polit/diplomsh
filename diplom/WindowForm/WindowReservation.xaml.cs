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
    /// Логика взаимодействия для WindowReservation.xaml
    /// </summary>
    public partial class WindowReservation : Window
    {
        gostinEntities context;
        public WindowReservation()
        {
            InitializeComponent();
            context = new gostinEntities();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridReservation.ItemsSource = context.Reservation.ToList();
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button Reservation = sender as Button;
            var currentRegistr = Reservation.DataContext as Reservation;
            var cl = new WindowAddReservation(context, currentRegistr);
            cl.ShowDialog();
        }

        private void BtnAddReservation_Click(object sender, RoutedEventArgs e)
        {
            var NewReservation = new Reservation();
            context.Reservation.Add(NewReservation);
            var EditWindows = new WindowAddReservation(context, NewReservation);
            EditWindows.ShowDialog();
            ShowTable();
        }

        private void BtnDeleteReservation_Click(object sender, RoutedEventArgs e)
        {
            var currentRegistr = DataGridReservation.SelectedItem as Reservation;
            if (currentRegistr == null)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.Reservation.Remove(currentRegistr);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnBackReservation_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
