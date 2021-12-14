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
    /// Interaction logic for Armory.xaml
    /// </summary>
    public partial class Armory : Window
    {
        public Armory()
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

        private void Back_Btn(object sender, RoutedEventArgs e)
        {
            this.Close();
            Dashboard dashwin = new Dashboard();
            dashwin.Show();
        }
        
       private void Update_Btn(object sender, RoutedEventArgs e)
            {
             string search = SerialNo.Text;

             using (DatabaseRepository repository = new DatabaseRepository())
            {
                   string pid = LogIn.currentUserPoliceID;
                   string name = LogIn.currentUserName;
                   FireArm gun = repository.FireArms.Find(search);
                {
                    gun.LastUsed = (DateTime)Lastused.SelectedDate;
                    gun.LastServiced =(DateTime) Lastserviced.SelectedDate;
                    gun.NewBullets = int.Parse(Newbullets.Text);
                    gun.FiredBullets = int.Parse(Firedbullets.Text);
                    gun.BalanceBullets = int.Parse(Balancebullets.Text);
                    gun.Notes = notes.Text;
                    gun.LastUpdatedByid = pid;
                    gun.LastUpdatedByname = name;
                };
                
                repository.SaveChanges();
                CustomMsgBox msgBx = new CustomMsgBox();
                msgBx.Message.Text = "Details have been updated";
                msgBx.Show();
               
            }
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string search = SerialNo.Text;

            using (DatabaseRepository repository = new DatabaseRepository())
            {
                string nic = LogIn.currentUserID;
                FireArm gun = repository.FireArms.Find(search);
                {
                    Model.Text = gun.Model;
                    Lastused.SelectedDate = gun.LastUsed;
                    Lastserviced.SelectedDate = gun.LastServiced;
                    Newbullets.Text = gun.NewBullets.ToString();
                    Firedbullets.Text = gun.FiredBullets.ToString();
                    Balancebullets.Text = gun.BalanceBullets.ToString();
                    notes.Text = gun.Notes;
                    pID.Text = gun.LastUpdatedByid;
                    name.Text = gun.LastUpdatedByname;

                }
            }
        }
    }
}
