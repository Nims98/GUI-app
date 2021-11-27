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
    }
}
