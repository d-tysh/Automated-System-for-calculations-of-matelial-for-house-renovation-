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
    /// Interaction logic for CalculationMaterials.xaml
    /// </summary>
    public partial class CalculationMaterials : Window
    {
        DBWorker dbWorker;

        public CalculationMaterials()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        public CalculationMaterials(DBWorker dbWorker)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.dbWorker = dbWorker;
        }

        public CalculationMaterials(DBWorker dbWorker, CalculationHistory calculationHistory)
        {
            InitializeComponent();
            this.dbWorker = dbWorker;

            this.widthInMeters.Text = calculationHistory.ObjectWidth.ToString();
            this.heightInMeters.Text = calculationHistory.ObjectHeight.ToString();
            this.lengthInMeters.Text = calculationHistory.ObjectLength.ToString();

            this.numberOfWindows.Text = calculationHistory.NuberWindow.ToString();
            this.widthOfWindow.Text = calculationHistory.WidthWindow.ToString();
            this.heightOfWindow.Text = calculationHistory.HeightWindow.ToString();

            this.numberOfDoors.Text = calculationHistory.NumberDoors.ToString();
            this.widthOfDoor.Text = calculationHistory.WidthDoors.ToString();
            this.heightOfDoor.Text = calculationHistory.HeightDoors.ToString();

        }

        private void ToMenu_Click(object sender, RoutedEventArgs e)
        {
            var toMenu = new Menu(dbWorker);
            toMenu.Show();
            Close();
        }

        private void ToCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (widthInMeters.Text.Length == 0)
            {
                MessageBox.Show("Enter width of object");
                return;
            }

            if (lengthInMeters.Text.Length == 0)
            {
                MessageBox.Show("Enter length of object");
                return;
            }



            double door = double.Parse(widthOfDoor.Text) * double.Parse(heightOfDoor.Text) * double.Parse(numberOfDoors.Text);
            double window = double.Parse(widthOfWindow.Text) * double.Parse(heightOfWindow.Text) * double.Parse(numberOfWindows.Text);
            double wallSquare = (double.Parse(widthInMeters.Text) + double.Parse(lengthInMeters.Text)) * double.Parse(heightInMeters.Text) * 2;
            double ceilingSquare = (double.Parse(lengthInMeters.Text) * double.Parse(widthInMeters.Text));

            double putty = Math.Round(((ceilingSquare * 1.2 * 2) + (ceilingSquare * 1.2 * 2) * 0.1), 2);
            puttyForSpackling.Text = putty.ToString() + " kilogram(s)";

            double primer = Math.Round(((wallSquare - door - window) * 0.7), 2);
            primerForWalls.Text = primer.ToString() + " liter(s)";

            double wallpaperCalc = Math.Round(((ceilingSquare + wallSquare - door - window) + (ceilingSquare + wallSquare - door - window) * 0.2), 2);
            wallpaper.Text = wallpaperCalc.ToString() + " square meter(s)";

            double glueWallpaper = Math.Round((wallSquare - door - window) * 0.01, 2);
            wallpaperGlue.Text = glueWallpaper.ToString() + " kilogram(s)";

            windowsSill.Text = (double.Parse(widthOfWindow.Text) * double.Parse(numberOfWindows.Text)).ToString() + " running meter(s)";

            cornice.Text = (double.Parse(widthOfWindow.Text) * double.Parse(numberOfWindows.Text) + (double.Parse(widthOfWindow.Text) * double.Parse(numberOfWindows.Text) * 0.2)).ToString() + " running meter(s)";

            baseBoard.Text = ((double.Parse(widthInMeters.Text) + double.Parse(lengthInMeters.Text)) * 2 - (double.Parse(widthOfDoor.Text) * double.Parse(numberOfDoors.Text))).ToString() + " running meter(s)";

            CalculationHistory cH;
            cH = new CalculationHistory()
            {
                CalcTime = DateTime.Now,
                UserId = dbWorker.UserId,

                HeightDoors = float.Parse(heightOfDoor.Text),
                WidthDoors = float.Parse(widthOfDoor.Text),
                NumberDoors = int.Parse(numberOfDoors.Text),

                ObjectLength = float.Parse(lengthInMeters.Text),
                ObjectHeight = float.Parse(heightInMeters.Text),
                ObjectWidth = float.Parse(widthInMeters.Text),

                NuberWindow = int.Parse(numberOfWindows.Text),
                WidthWindow = float.Parse(widthOfWindow.Text),
                HeightWindow = float.Parse(heightOfWindow.Text)
            };

            this.dbWorker.CalculationHistoryService.Add(cH);
        }
    }
}
