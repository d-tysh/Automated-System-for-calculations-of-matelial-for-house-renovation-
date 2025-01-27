﻿using BLL;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AutomatedSystemWindow : Window
    {
        DBWorker dbWorker;

        public AutomatedSystemWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.dbWorker = new DBWorker();
        }

        public AutomatedSystemWindow(DBWorker dbWorker)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.dbWorker = dbWorker;
        }

        private void EnterTheSystem_Click(object sender, RoutedEventArgs e)
        {
            var auth = new Authorization(dbWorker);
            auth.Show();
            Close();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            var reg = new Registration(dbWorker);
            reg.Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        //    dbWorker.
        }
    }
}
