using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LightMeter.DataModel
{
    internal class serialPortData
    {
        public string Port { get; set; }

        public string BaudRate { get; set; }

        public string Patity { get; set; }

        public string DataBits { get; set; }

        public string StopBit { get; set; }

        public string IntervalTime { get; set; }

        public List<string> BaudRateList { get; set; }

        public List<string> ParityList { get; set; }

        public List<string> DataBitsList { get; set; }

        private List<string> _stopbitlist;
        public List<string> StopBitList
        {
            get => _stopbitlist;
            set
            {
                _stopbitlist = value;
            }
        }

        public List<string> SendCMDList {  get; set; }
    }
}
