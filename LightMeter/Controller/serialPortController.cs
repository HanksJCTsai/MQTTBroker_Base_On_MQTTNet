using LightMeter.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightMeter.Controller
{
    internal interface IserialPort
    {
        List<string> GetPcPorts();

        List<string> GetDefaultBaudRates();

        List<string> GetDefaultParities();

        List<string> GetDefaultDataBits();

        List<string> GetDefaultStopBits();

        List<string>GetDefaultCMDs();

        string GetDefaultPort();

        string GetDefaultBaudRate();

        string GetDefaultParity();

        string GetDefaultDataBit();

        string GetDefaultStopBit();

        string GetDefaultIntervalTime();

        bool SaveSerialPortParameter(string strSelectPort, string strSelectBaudRate, string strSelectParity, string strSelectDataBit, string strSelectStopBit,string strIntervalTime, string _appConfigPath);

        serialPortData GetSerialPortParameter(string _appConfigPath);
    }
}
