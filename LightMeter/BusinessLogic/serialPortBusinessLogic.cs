using LightMeter.Controller;
using LightMeter.DataModel;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Management;
using System.IO.Ports;
using LightMeter.Model;
using System.Linq;

namespace LightMeter.BusinessLogic
{
    internal class serialPortBusinessLogic : IserialPort
    {
        private serialPortData _serialPortData = new serialPortData();
       
        public List<string> GetDefaultBaudRates()
        {
            return _serialPortData.BaudRateList;
        }

        public List<string> GetDefaultDataBits()
        {
            return _serialPortData.DataBitsList;
        }

        public List<string> GetDefaultParities()
        {
            return _serialPortData.ParityList;
        }

        public List<string> GetDefaultStopBits()
        {
            return _serialPortData.StopBitList;
        }

        public List<string> GetDefaultCMDs()
        {
            return _serialPortData.SendCMDList;
        }

        public string GetDefaultIntervalTime()
        {
            return _serialPortData.IntervalTime;
        }
        public string GetDefaultPort()
        {
            return _serialPortData.Port;
        }
        public string GetDefaultBaudRate()
        {
            return _serialPortData.BaudRate;
        }

        public string GetDefaultDataBit()
        {
            return _serialPortData.DataBits;
        }

        public string GetDefaultStopBit()
        {
            return _serialPortData.StopBit;
        }
        public string GetDefaultParity()
        {
            return _serialPortData.Patity;
        }

        public List<string> GetPcPorts()
        {
            List<string> ports = new List<string>();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                List<string> portName = SerialPort.GetPortNames().ToList();
                var portCaption = (searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString()));
                List<string> portList = (portName.Select(n => n + " - " + portCaption.FirstOrDefault(s => s.Contains(n))).ToList());
                foreach (string port in portList)
                {
                    ports.Add(port);
                }
            }

            return ports;
        }

        public serialPortData GetSerialPortParameter(string _appConfigPath)
        {
            _serialPortData = JsonConvert.DeserializeObject<serialPortData>(File.ReadAllText(_appConfigPath));
            return _serialPortData;
        }

        public bool SaveSerialPortParameter(string strSelectPort, string strSelectBaudRate, string strSelectParity, string strSelectDataBit, string strSelectStopBit, string strIntervalTime, string _appConfigPath)
        {
            bool result = false;

            serialPortData parameter = new serialPortData
            {
                Port = strSelectPort,
                BaudRate = strSelectBaudRate,
                Patity = strSelectParity,
                DataBits = strSelectDataBit,
                StopBit = strSelectStopBit,
                BaudRateList = _serialPortData.BaudRateList,
                ParityList = _serialPortData.ParityList,
                DataBitsList = _serialPortData.DataBitsList,
                StopBitList = _serialPortData.StopBitList,
                IntervalTime = strIntervalTime,
            };

            File.WriteAllText(_appConfigPath, JsonConvert.SerializeObject(parameter, Formatting.Indented));

            return result;
        }
    }
}
