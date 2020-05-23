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
using System.Windows.Shapes;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        DBWorker dbWorker;

        public Registration()
        {
            InitializeComponent();
        }

        public Registration(DBWorker dbWorker)
        {
            InitializeComponent();
            this.dbWorker = dbWorker;
        }

        private void ToRegistr_Click(object sender, RoutedEventArgs e)
        {
            var toReg = new AutomatedSystemWindow();
            toReg.Show();
            Close();
        }
    }
}
