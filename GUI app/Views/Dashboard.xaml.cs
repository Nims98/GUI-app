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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            officer.Text = LogIn.currentUserName;
            policeId.Text = LogIn.currentUserPoliceID;
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                Officer off1 = new Officer()
                {
                    Name = "example",
                    Policeid = "hh124234u",
                    NIC = "2734872134892",
                    Address = "naskjd",
                    Mobile = 27348924,
                    HomePhone = 32674634,
                    PoliceDivision = "jjhabsdas"
                };
                
            }
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void profile_btn(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Profile profileWin = new Profile();
            profileWin.Show();
        }

        private void armory_btn(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Armory armoryWin = new Armory();
            armoryWin.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ViewComplains complainsWin = new ViewComplains();
            complainsWin.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ViewTipline TiplineWin = new ViewTipline();
            TiplineWin.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddPrisoner AddPrisonerWin = new AddPrisoner();
            AddPrisonerWin.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
           PrisonerLog prisonerlogWin = new PrisonerLog();
            prisonerlogWin.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainwin = new MainWindow();
            mainwin.Show();
        }
    }
}
