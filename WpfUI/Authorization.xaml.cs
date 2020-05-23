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
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        DBWorker dBWorker;

        public Authorization()
        {
            InitializeComponent();
            dBWorker = new DBWorker();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var login = new Menu();
            if (userName.Text == "")
            {
                MessageBox.Show("Enter the data!");
            }
            else
            {
                login.Show();
                Close();
            }
        }
    }
}
