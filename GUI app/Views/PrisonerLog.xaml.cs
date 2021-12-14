using GUI_app.Database;
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
    /// Interaction logic for PrisonerLog.xaml
    /// </summary>
    public partial class PrisonerLog : Window
    {
        public PrisonerLog()
        {
            InitializeComponent();
            retrievePrisoners();
        }
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        public void retrievePrisoners()
        {
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                var prisonerList = repository.Prisoners.ToList();
                dataGrid.ItemsSource = prisonerList;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Dashboard dashWindow = new Dashboard();
            dashWindow.Show();
        }
    }
}
