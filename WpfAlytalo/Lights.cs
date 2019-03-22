using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAlytalo
{
    public class Lights
    {
        public string KitchenLightsDimmer { get; set; }
        public string LivingRoomLightsDimmer { get; set; }

        public Boolean LightsSwitched { get; set; }
        public void LightsOn()
        {
            LightsSwitched = true;
        }
        public void LightsOff()
        {
            LightsSwitched = false;
        }
    }
}
