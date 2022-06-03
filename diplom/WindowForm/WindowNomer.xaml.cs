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
    /// Логика взаимодействия для WindowNomer.xaml
    /// </summary>
    public partial class WindowNomer : Window
    {
        gostinEntities context;
        string currentLetter = "";
        public WindowNomer()
        {
            InitializeComponent();
            context = new gostinEntities();
            ShowTable();
        }
        private void ShowTable()
        {
            DataGridNomer.ItemsSource = context.Nomer.ToList();
            if (TxtCategory.Text == null)
                return;
            List<Nomer> listNomer = context.Nomer.ToList();
            listNomer = listNomer.Where(x => x.Category.Category1.ToLower().Contains(TxtCategory.Text.ToLower())).ToList();
            if (currentLetter.Count() == 1)
            {
                listNomer = listNomer.Where(x => x.Category.Category1.Contains(currentLetter)).ToList();
            }
            DataGridNomer.ItemsSource = listNomer.OrderBy(x => x.Category.Category1).ToList();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ShowTable();
        }

        private void CmbKolvoSpace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbKolvoSpace.SelectedIndex == 0)
            {
                ShowTable();
            }
            if (CmbKolvoSpace.SelectedIndex == 1)
            {
                DataGridNomer.ItemsSource = context.Nomer.Where(x => x.KolvoSpace.Contains("1")).ToList();
            }
            if (CmbKolvoSpace.SelectedIndex == 2)
            {
                DataGridNomer.ItemsSource = context.Nomer.Where(x => x.KolvoSpace.Contains("2")).ToList();

            }
            if (CmbKolvoSpace.SelectedIndex == 3)
            {
                DataGridNomer.ItemsSource = context.Nomer.Where(x => x.KolvoSpace.Contains("3")).ToList();

            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxtCategory_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowTable();
        }
    }
}
