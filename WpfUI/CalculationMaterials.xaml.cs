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
    /// Interaction logic for CalculationMaterials.xaml
    /// </summary>
    public partial class CalculationMaterials : Window
    {
        DBWorker dBWorker;

        public CalculationMaterials()
        {
            InitializeComponent();
        }

        public CalculationMaterials(DBWorker dBWorker)
        {
            InitializeComponent();
            this.dBWorker = dBWorker;
        }

        private void ToMenu_Click(object sender, RoutedEventArgs e)
        {
            var toMenu = new Menu();
            toMenu.Show();
            Close();
        }
    }
}
