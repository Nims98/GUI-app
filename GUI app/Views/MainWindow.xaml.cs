using GUI_app.Views;
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

namespace GUI_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tipline_button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LogIn loginWindow = new LogIn();
            loginWindow.Show();
            

            
        }

        private void complain_button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Complain complainWindow = new Complain();
            complainWindow.Show();
        }

        private void tipline_button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            TipLine tiplineWindow = new TipLine();
            tiplineWindow.Show();
        }
    }
}
