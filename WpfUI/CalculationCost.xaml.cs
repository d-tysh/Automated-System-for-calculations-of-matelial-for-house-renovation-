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
    /// Interaction logic for CalculationCost.xaml
    /// </summary>
    public partial class CalculationCost : Window
    {
        DBWorker dbWorker;

        public CalculationCost()
        {
            InitializeComponent();
        }

        public CalculationCost(DBWorker dbWorker)
        {
            InitializeComponent();
            this.dbWorker = dbWorker;
        }

        private void ToMenu_Click(object sender, RoutedEventArgs e)
        {
            var toMenu = new Menu(dbWorker);
            toMenu.Show();
            Close();
        }

        private void ToCalculate_Click(object sender, RoutedEventArgs e)
        {
            costMaterials.Text = (double.Parse(enterNumber.Text) * double.Parse(enterPrice.Text)).ToString() + " conditional unit(s)";
        }
    }
}
