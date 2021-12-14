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
    /// Interaction logic for AddPrisoner.xaml
    /// </summary>
    public partial class AddPrisoner : Window
    {
        public AddPrisoner()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                Prisoner newprisoner = new Prisoner()
                {
                    Name = name.Text,
                    Address = address.Text,
                    NIC = nic.Text,
                    HomePhone=int.Parse(residance.Text),
                    Mobile = int.Parse(mobile.Text),
                    Crime = crime.Text,
                    MoreInfo=moreinfo.Text
                };
                repository.Prisoners.Add(newprisoner);
                repository.SaveChanges();

                CustomMsgBox msgBx = new CustomMsgBox();
                msgBx.Message.Text = "Prisoner added successfully";
                msgBx.Show();
                name.Clear();
                address.Clear();
                nic.Clear();
                residance.Clear();
                mobile.Clear();
                crime.Clear();
                moreinfo.Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            Dashboard dashWindow = new Dashboard();
            dashWindow.Show();
        }
    }
}
