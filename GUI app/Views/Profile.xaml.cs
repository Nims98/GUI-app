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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
            retrieveProfile();
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
            this.Close();
            Dashboard dashwin = new Dashboard();
            dashwin.Show();
        }

     public void retrieveProfile()
        {
            string nic = LogIn.currentUserID;
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                Officer profile = repository.Officers.Find(nic);

                name.Text = profile.Name;
                nicNo.Text = nic;
                policeId.Text = profile.Policeid;
                address.Text = profile.Address;
                mobile.Text = profile.Mobile.ToString();
                residance.Text = profile.HomePhone.ToString();
                policediv.Text = profile.PoliceDivision;
            }
        }


        private void UpdateBtn(object sender, RoutedEventArgs e)
        {
            string nic = LogIn.currentUserID;
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                Officer profile = repository.Officers.Find(nic);

                profile.Address = address.Text;
                profile.Mobile =int.Parse(mobile.Text);
                profile.HomePhone =int.Parse(residance.Text);

            repository.SaveChanges();
            }
            CustomMsgBox msgBx = new CustomMsgBox();
            msgBx.Message.Text = "User details Updated !";
            msgBx.Show();
            
           
        }
    }
}
