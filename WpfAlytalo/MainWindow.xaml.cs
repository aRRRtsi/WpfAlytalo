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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfAlytalo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Oliot
        Thermostat houseTemperature = new Thermostat();
        Sauna saunaTemperature = new Sauna();

        // Ajastimet
        public DispatcherTimer SaunaTempTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            // Ajastimien Tick
            SaunaTempTimer.Interval = TimeSpan.FromSeconds(1);

            txtSaunaTemperature.Text = txtHouseTemperature.Text;
        }

        // Talon lämpötilan säätö
        public void BtnSetNewTemperature_Click(object sender, RoutedEventArgs e)
        {
            houseTemperature.HouseTemperature = int.Parse(txtSetNewTemperature.Text);
            txtHouseTemperature.Text = txtSetNewTemperature.Text + " c";
            txtSetNewTemperature.Clear();
        }
    }
}
