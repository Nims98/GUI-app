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
            using (DatabaseRepository repository = new DatabaseRepository())
            {

                FireArm gun = new FireArm()
                {
                    SerialNo = SerialNo.Text,
                    Model = Model.Text,
                   LastUsed=Lastused.DisplayDate,
                   LastServiced=Lastserviced.DisplayDate,
                    NewBullets = int.Parse(Newbullets.Text),
                    FiredBullets = int.Parse(Firedbullets.Text),
                    BalanceBullets = int.Parse(Balancebullets.Text),
                    Notes = notes.Text
                };
                repository.FireArms.Add(gun);
                repository.SaveChanges();
            }
            }
    }
}
