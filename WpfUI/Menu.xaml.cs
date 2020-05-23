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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        DBWorker dBWorker;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(DBWorker dBWorker)
        {
            InitializeComponent();
            this.dBWorker = dBWorker;
        }

        private void CalculationMaterial_Click(object sender, RoutedEventArgs e)
        {
            var calcMat = new CalculationMaterials();
            calcMat.Show();
            Close();
        }

        private void CalculationCost_Click(object sender, RoutedEventArgs e)
        {
            var calcCost = new CalculationCost();
            calcCost.Show();
            Close();
        }

        private void TepesRenovation_Click(object sender, RoutedEventArgs e)
        {
            var tRen = new TypesRenovation();
            tRen.Show();
            Close();
        }

        private void TypesMaterials_Click(object sender, RoutedEventArgs e)
        {
            var tMat = new TypesMaterials();
            tMat.Show();
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            var about = new AboutSystem();
            about.Show();
            Close();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            var logout = new AutomatedSystemWindow();
            logout.Show();
            Close();
        }

    }
}
