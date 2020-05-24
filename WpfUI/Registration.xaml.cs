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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        DBWorker dbWorker;

        public Registration()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        public Registration(DBWorker dbWorker)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.dbWorker = dbWorker;
        }

        private void ToRegistr_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length > 0 && userName.Text.Length > 0)
            {
                if (password.SecurePassword.Length > 0 && repeatPassword.SecurePassword.Length > 0)
                {
                    if (password.Password != repeatPassword.Password)
                    {
                        MessageBox.Show("Passwords must be equals!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        var user = new User() { Name = name.Text, Login = userName.Text, Password = password.Password };
                        try
                        {
                            var aUser = dbWorker.UserService.Add(user);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error while DB requesting", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }

                        var toReg = new AutomatedSystemWindow(dbWorker);
                        toReg.Show();
                        Close();
                    }
                }
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
