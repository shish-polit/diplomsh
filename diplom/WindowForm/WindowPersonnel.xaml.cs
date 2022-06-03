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
    /// Логика взаимодействия для WindowPersonnel.xaml
    /// </summary>
    
    public partial class WindowPersonnel : Window
    {
        gostinEntities context;
        public WindowPersonnel()
        {
            InitializeComponent();
            context = new gostinEntities();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridPersonnel.ItemsSource = context.Personnel.ToList();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
