using diplom.WindowForm;
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

namespace diplom.WindowMenu
{
    /// <summary>
    /// Логика взаимодействия для WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        public WindowMenu()
        {
            InitializeComponent();
        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {
            var NewClient = new WindowClient();
            NewClient.ShowDialog();
        }

        private void BtnServices_Click(object sender, RoutedEventArgs e)
        {
            var NewServices = new WindowServices();
            NewServices.ShowDialog();
        }

        private void BtnNomer_Click(object sender, RoutedEventArgs e)
        {
            var NewNomer = new WindowNomer();
            NewNomer.ShowDialog();
        }

        private void BtnReservation_Click(object sender, RoutedEventArgs e)
        {
            var Reservation = new WindowReservation();
            Reservation.ShowDialog();
        }
        private void BtnNomerOtchet_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnPersonnel_Click(object sender, RoutedEventArgs e)
        {
            var Personnel = new WindowPersonnel();
            Personnel.ShowDialog();
        }

        private void BtnReservServices_Click(object sender, RoutedEventArgs e)
        {
            var ReservServices = new WindowReservServices();
            ReservServices.ShowDialog();
        }
    }
    }

