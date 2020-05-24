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
    /// Interaction logic for CalculationHistory.xaml
    /// </summary>
    public partial class CalculationHistoryWindow : Window
    {
        private DBWorker dbWorker;

        public CalculationHistoryWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        public CalculationHistoryWindow(DBWorker dbWorker)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.dbWorker = dbWorker;
            this.listViewHistory.ItemsSource = dbWorker.CalculationHistoryService.GetAll().ToList();

        }

        private void ToMenu_Click(object sender, RoutedEventArgs e)
        {
            var toMenu = new Menu(dbWorker);
            toMenu.Show();
            Close();
        }

        private void ToCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (this.listViewHistory.SelectedItem != null)
            {
                CalculationHistory cH = this.listViewHistory.SelectedItem as CalculationHistory;
                var toMenu = new CalculationMaterials(dbWorker, cH);
                toMenu.Show();
                Close();
            }
            else
            {

            }

        }

    }
}
