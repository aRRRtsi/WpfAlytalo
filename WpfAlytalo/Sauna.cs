using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAlytalo
{
    public class Sauna
    {
        public int SaunaTemperature { get; set; }
        public int SaunaMaxTemperature { get; set; }
        public void SaunaMoreTemp()
        {
            SaunaTemperature++;
        }
        public void SaunaLessTemp()
        {
            SaunaTemperature--;
        }
        public Boolean SaunaSwitched { get; set; }
        public void SaunaOn()
        {
            SaunaSwitched = true;
        }
        public void SaunaOff()
        {
            SaunaSwitched = false;
        }
    }
}
