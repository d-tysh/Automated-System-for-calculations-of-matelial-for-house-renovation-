using BLL;
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
            InitializeComponent();
        }

        public AutomatedSystemWindow(DBWorker dbWorker)
        {
            InitializeComponent();
            this.dbWorker = dbWorker;
        }

        private void EnterTheSystem_Click(object sender, RoutedEventArgs e)
        {
            var auth = new Authorization();
            auth.Show();
            Close();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            var reg = new Registration();
            reg.Show();
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
