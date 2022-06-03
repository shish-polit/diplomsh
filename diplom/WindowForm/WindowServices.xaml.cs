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
    /// Логика взаимодействия для WindowServices.xaml
    /// </summary>
    public partial class WindowServices : Window
    {
        gostinEntities context;
        public WindowServices()
        {
            InitializeComponent();
            context = new gostinEntities(); 
        
            ShowTable();
        }
        private void ShowTable()
        {  
            DataGridServices.ItemsSource = context.Services.ToList();
          
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CmbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (CmbType.SelectedIndex == 0)
            {
                ShowTable();
            }
            if (CmbType.SelectedIndex == 1)
            {
                DataGridServices.ItemsSource = context.Services.Where(x => x.TypeServices.Type.Contains("Беспланый")).ToList();
            }
            if (CmbType.SelectedIndex == 2)
            {
                DataGridServices.ItemsSource = context.Services.Where(x => x.TypeServices.Type.Contains("Платный")).ToList();

            }
        }
    }
}
