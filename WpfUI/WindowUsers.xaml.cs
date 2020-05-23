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
    /// Interaction logic for WindowUsers.xaml
    /// </summary>
    public partial class WindowUsers : Window
    {
        DBWorker dBWorker;

        public WindowUsers()
        {
            InitializeComponent();
            dBWorker = new DBWorker();

            this.listViewUsers.ItemsSource = dBWorker.UserService.GetAll().ToList();


        }
    }
}
