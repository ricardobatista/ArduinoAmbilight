using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;

namespace Ambilight.Helpers
{
    public  class SerialPortHelper
    {
        private SerialPort comport = new SerialPort();
        public bool IsOpen { get { return comport.IsOpen; } }
     
        
        public  void OpenPort(int baudRate, int dataBits, StopBits stopBits, Parity parity, string comPortName)
        {

            if (comport.IsOpen) comport.Close();
            else
            {
                comport.BaudRate = baudRate;
                comport.DataBits = dataBits;
                comport.StopBits = stopBits;
                comport.Parity = parity;
                comport.PortName = comPortName;

                try
                {
                    comport.Open();
                }
                catch (UnauthorizedAccessException) { }
                catch (IOException) { }
                catch (ArgumentException) { }

            }

        }
        public void ClosePort()
        {
            if (comport.IsOpen) comport.Close();
        }
        public void SendColorToComPort(int red, int green, int blue)
        {

            byte[] data = new byte[4] { 255, (byte)red, (byte)green, (byte)blue };
            if(comport.IsOpen)
                comport.Write(data, 0, data.Length);
        }
    }
}
