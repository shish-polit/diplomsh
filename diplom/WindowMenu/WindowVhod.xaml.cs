using System.Windows;

namespace diplom.WindowMenu
{
    /// <summary>
    /// Логика взаимодействия для WindowVhod.xaml
    /// </summary>
    public partial class WindowVhod : Window
    {

        public WindowVhod()
        {
            InitializeComponent();
        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            ClassCl classCla = new ClassCl();
            bool result = classCla.Check(login.Text, password.Text);
            MessageBox.Show(result.ToString());
            var menu = new WindowMenu();
            menu.ShowDialog();
          
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
