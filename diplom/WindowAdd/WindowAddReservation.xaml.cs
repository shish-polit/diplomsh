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

namespace diplom.WindowAdd
{
    /// <summary>
    /// Логика взаимодействия для WindowAddReservation.xaml
    /// </summary>
    public partial class WindowAddReservation : Window
    {
        gostinEntities context;
        public WindowAddReservation( gostinEntities context1, Reservation reservation)
        {
            InitializeComponent();
            context = context1;
            CmbClient.ItemsSource = context.Client.ToList();
            CmbNomer.ItemsSource = context.Nomer.ToList();
            CmbPersonnel.ItemsSource = context.Personnel.Where(p => p.Post.Post1 == "Администратор").ToList();
            this.DataContext = reservation;
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Запись добавлена");
            this.Close();
        }

        private void CmbNomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbNomer.SelectedItem == null || TxtKolvoDay.Text == null)
            {
                return;
            }

            var selectedNumber = (Nomer)CmbNomer.SelectedItem;

            TxtCost.Text = (selectedNumber.Category.Price * int.Parse(TxtKolvoDay.Text)).ToString();
            (this.DataContext as Reservation).Cost = decimal.Parse(TxtCost.Text);
        }

        private void DateEviction_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DateCheck.SelectedDate == null) return;
            //Вычитаем из даты выезда дату въезда
            var raznitsa = DateEviction.SelectedDate.Value.Subtract(DateCheck.SelectedDate.Value);
            TxtKolvoDay.Text = raznitsa.Days.ToString();
            (this.DataContext as Reservation).KolvoDay = raznitsa.Days;
        }
    }
}
