using GUI_app.Database;
using GUI_app.Models;
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

namespace GUI_app.Views
{
    /// <summary>
    /// Interaction logic for Complain.xaml
    /// </summary>
    public partial class Complain : Window
    {
        public Complain()
        {
            InitializeComponent();
        }
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void submit_button_Click(object sender, RoutedEventArgs e)
        {
            if (Agree.IsChecked != true)
            {
                CustomMsgBox msgBx = new CustomMsgBox();
                msgBx.Message.Text = "Please check the given Conditions before Submit";
                msgBx.Width = 400;
                msgBx.Show();
            }
            else { 
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                ComplainFile Complain = new ComplainFile()
                {
                    Name = name.Text,
                    Address = address.Text,
                    Telephone = int.Parse(tele.Text),
                    NIC = nic.Text,
                    PoliceDivision = policeDivision.Text,
                    ComplainText = complain.Text
                };

                repository.ComplainFiles.Add(Complain);
                repository.SaveChanges();
                    CustomMsgBox msgBx = new CustomMsgBox();
                    msgBx.Message.Text = "Your complain has been submitted";
                    msgBx.Width = 400;
                    msgBx.Show();
                    name.Clear();
                    address.Clear();
                    tele.Clear();
                    nic.Clear();
                    policeDivision.Clear();
                    complain.Clear();
                }
            }
        }
    }
}
