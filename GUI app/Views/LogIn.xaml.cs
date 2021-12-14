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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
            
        }
        public static string currentUserID = null;
        public static string currentUserName = null;
        public static string currentUserPoliceID = null;
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        
        private void Cancel_btn(object sender, RoutedEventArgs e)
        {
            this.Close();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void Login_btn(object sender, RoutedEventArgs e)
        {

            string NIC = nicNo.Text;
            string PWD = password.Password;

            DatabaseRepository repository = new DatabaseRepository();
            
               
                   Officer user = repository.Officers.Find(NIC);
            currentUserID = user.NIC;
            currentUserName = user.Name;
            currentUserPoliceID = user.Policeid;
            if (user != null)
                {
                    if(user.Password == PWD)
                    {
                        Dashboard dashWindow = new Dashboard();
                        dashWindow.Show();
                    
                        this.Close();
                    }
                    else
                    {
                        CustomMsgBox msgBx = new CustomMsgBox();
                        msgBx.Message.Text = "Incorrect Password, Try Again !";
                        msgBx.Show();
                        nicNo.Clear();
                        password.Clear();
                    }
                }
                else { 
                   
                    CustomMsgBox msgBx = new CustomMsgBox();
                    msgBx.Message.Text = "User does not exist";
                    msgBx.Show();
                    nicNo.Clear();
                    password.Clear();
                }
            }  
    }
}
