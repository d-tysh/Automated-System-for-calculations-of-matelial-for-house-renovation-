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
    /// Interaction logic for TypesMaterials.xaml
    /// </summary>
    public partial class TypesMaterials : Window
    {
        DBWorker dbWorker;

        public TypesMaterials()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        public TypesMaterials(DBWorker dbWorker)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.dbWorker = dbWorker;
            this.listViewMaterial.ItemsSource = dbWorker.TypesMaterialService.GetAll().ToList();
        }

        private void ToMenu_Click(object sender, RoutedEventArgs e)
        {
            var toMenu = new Menu(dbWorker);
            toMenu.Show();
            Close();
        }
    }
}
