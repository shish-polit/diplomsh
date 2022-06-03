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
    /// Логика взаимодействия для WindowReservServices.xaml
    /// </summary>
    public partial class WindowReservServices : Window
    {
        gostinEntities context;
        public WindowReservServices()
        {
            InitializeComponent();
            context = new gostinEntities();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridReservServ.ItemsSource = context.ReservationServices.ToList();
        }
     
        private void BtnAddReservServ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteReservServ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBackReservServ_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
