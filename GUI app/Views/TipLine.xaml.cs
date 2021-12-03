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
    /// Interaction logic for TipLine.xaml
    /// </summary>
    public partial class TipLine : Window
    {
        public TipLine()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged()
        {

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
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void submit_btn(object sender, RoutedEventArgs e)
        {
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                TipModel tip = new TipModel()
                {
                    TipText = tiptext.Text
                };

                repository.TipModels.Add(tip);
                repository.SaveChanges();
            }

            CustomMsgBox msgBx = new CustomMsgBox();
            msgBx.Width = 470;
            msgBx.Message.Text = "Thank you for your Information, We will take action accordingly";
            msgBx.Show();
            tiptext.Clear();
        }
    }
}
