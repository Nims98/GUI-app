﻿using GUI_app.Database;
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

     

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nic = search.Text;

            using (DatabaseRepository repository = new DatabaseRepository())
            {
                Officer searchResult = repository.Officers.Find(nic);

                name.Text = searchResult.Name;
                policeId.Text = searchResult.Policeid;
                address.Text = searchResult.Address;
                mobile.Text = searchResult.Mobile.ToString();
                residance.Text = searchResult.HomePhone.ToString();
                policediv.Text = searchResult.PoliceDivision;
            }
        }
    }
}
