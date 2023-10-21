using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LightMeter.Model
{
    internal class USBDeviceInfo
    {
        public string DEVICEID { get; set; }
        public string PNPDEVICEID { get; set; }
        public string NAME { get; set; }
        public string CAPTION { get; set; }
        public USBDeviceInfo(string _device, string _pnpdeviceid, string _name, string _caption)
        {
            this.DEVICEID = _device;
            this.PNPDEVICEID = _pnpdeviceid;
            this.NAME = _name;
            this.CAPTION = _caption;
        }
    }
}
