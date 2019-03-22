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
        Lights mainLights = new Lights();

        // Ajastimet
        public DispatcherTimer SaunanAjastin = new DispatcherTimer();
        public DispatcherTimer SaunanAjastinMinus = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            // Talon lämpötila
            houseTemperature.HouseTemperature = 20;
            txtHouseTemperature.Text = houseTemperature.HouseTemperature.ToString();

            // Saunan lämpötila samaan kun huoneen lämpötila
            saunaTemperature.SaunaTemperature = houseTemperature.HouseTemperature;
            txtSaunaTemperature.Text = saunaTemperature.SaunaTemperature.ToString();

            // Ajastimien Tick
            SaunanAjastin.Tick += SaunanAjastin_Tick;
            SaunanAjastin.Interval = TimeSpan.FromSeconds(1);

            SaunanAjastinMinus.Tick += SaunanAjastinMinus_Tick;
            SaunanAjastinMinus.Interval = TimeSpan.FromSeconds(1);

            // Lights
            txtKitchenLightsValue.Background = Brushes.Red;
            txtKitchenLightsValue.Text = "0";

            txtLivingRoomLightsValue.Background = Brushes.Red;
            txtLivingRoomLightsValue.Text = "0";
        }

        private void SaunanAjastin_Tick(object sender, EventArgs e)
        {
            if(saunaTemperature.SaunaSwitched == true)
            {
                if (saunaTemperature.SaunaTemperature < saunaTemperature.SaunaMaxTemperature)
                {
                    saunaTemperature.SaunaMoreTemp();
                    txtSaunaTemperature.Text = saunaTemperature.SaunaTemperature.ToString();
                }
            } else
            {
                SaunanAjastin.Stop();
            }
        }

        private void SaunanAjastinMinus_Tick(object sender, EventArgs e)
        {
            if (saunaTemperature.SaunaSwitched == false)
            {
                if (saunaTemperature.SaunaTemperature > houseTemperature.HouseTemperature)
                {
                    saunaTemperature.SaunaLessTemp();
                    txtSaunaTemperature.Text = saunaTemperature.SaunaTemperature.ToString();
                }
            }
            else
            {
                SaunanAjastinMinus.Stop();
            }
        }

        // Talon lämpötilan säätö
        public void BtnSetNewTemperature_Click(object sender, RoutedEventArgs e)
        {
            houseTemperature.HouseTemperature = int.Parse(txtSetNewTemperature.Text);
            saunaTemperature.SaunaTemperature = houseTemperature.HouseTemperature;
            txtSaunaTemperature.Text = saunaTemperature.SaunaTemperature.ToString();
            txtHouseTemperature.Text = txtSetNewTemperature.Text + " c";
            txtSetNewTemperature.Clear();
        }

        // Saunan lämpötilan säätö
        public void BtnSetSaunaTemperature_Click(object sender, RoutedEventArgs e)
        {
            saunaTemperature.SaunaSwitched = true;
            saunaTemperature.SaunaTemperature = houseTemperature.HouseTemperature;
            saunaTemperature.SaunaMaxTemperature = int.Parse(txtSetSaunaTemperature.Text);
            txtSetSaunaTemperature.Clear();
            SaunanAjastin.Start();
        }

        // Sauna pois päältä
        public void BtnSetSaunaOff_Click(object sender, RoutedEventArgs e)
        {
            saunaTemperature.SaunaSwitched = false;
            txtSetSaunaTemperature.Clear();
            SaunanAjastinMinus.Start();
        }

        private void SliderKitchenLights_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mainLights.KitchenLightsDimmer = Math.Floor(sliderKitchenLights.Value).ToString();
            
            txtKitchenLightsValue.Text = mainLights.KitchenLightsDimmer;

            if(int.Parse(txtKitchenLightsValue.Text) > 0)
            {
                mainLights.LightsSwitched = true;
                txtKitchenLightsValue.Background = Brushes.Green;
            } else
            {
                txtKitchenLightsValue.Background = Brushes.Red;
            }
        }

        private void SliderLivingRoomLights_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mainLights.LivingRoomLightsDimmer = Math.Floor(sliderLivingRoomLights.Value).ToString();

            txtLivingRoomLightsValue.Text = mainLights.LivingRoomLightsDimmer;

            if (int.Parse(txtLivingRoomLightsValue.Text) > 0)
            {
                mainLights.LightsSwitched = true;
                txtLivingRoomLightsValue.Background = Brushes.Green;
            }
            else
            {
                txtLivingRoomLightsValue.Background = Brushes.Red;
            }
        }
    }
}
