using BLL;
using DAL;
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
        DBWorker dbWorker;

        public Authorization()
        {
            InitializeComponent();
            dbWorker = new DBWorker();
        }

        public Authorization(DBWorker dbWorker)
        {
            InitializeComponent();
            this.dbWorker = dbWorker;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (userName.Text.Length == 0)
            {
                MessageBox.Show("Enter user name!");
                return;
            }

            if (password.Password.Length == 0)
            {
                MessageBox.Show("Enter password!");
                return;
            }

            try
            {
                var users = dbWorker.UserService.FindBy((User u) => u.Login == userName.Text && u.Password == password.Password);

                var count = users.ToList();

                if (count.Count != 0)
                {
                    var login = new Menu(dbWorker);
                    login.Show();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while DB requesting", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var back = new AutomatedSystemWindow(dbWorker);
            back.Show();
            Close();
        }
    }
}
