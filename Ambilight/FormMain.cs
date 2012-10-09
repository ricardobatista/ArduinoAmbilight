using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using Ambilight.Helpers;
namespace Ambilight
{
    public partial class FormAmbilight : Form
    {
        #region Properties
        
        // Serial Port Settings
        int baudRate = 9600;
        int dataBits = 8;
        StopBits stopBits = StopBits.One;
        Parity parity = Parity.None;
        const int REFRESHRATE = 100;
        SerialPortHelper serialPort = new SerialPortHelper();

        Thread t = null;
        bool continueThread = true;
        #endregion

        #region Constructor

        public FormAmbilight()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        #endregion

        #region Private Methods
        private void GetComPorts()
        {
            cmbPortName.Items.Clear();
            cmbPortName.Items.AddRange(OrderedPortNames());
        }

        private string[] OrderedPortNames()
        {
            int num;
            return SerialPort.GetPortNames().OrderBy(a => a.Length > 3 && int.TryParse(a.Substring(3), out num) ? num : 0).ToArray();
        }
        private void Start()
        {
            Color color;

            serialPort.OpenPort(baudRate, dataBits, stopBits, parity, cmbPortName.Text);

            continueThread = true;
            t = new Thread(delegate()
            {
                try
                {
                    while (continueThread)
                    {
                        Thread.Sleep(REFRESHRATE);
                        color = Ambilight.Helpers.ScreenAnalysisHelper.getAverageColor();
                        serialPort.SendColorToComPort(color.R, color.G, color.B);
                        picColor.BackColor = color;
                    }
                }
                catch (ThreadInterruptedException) { continueThread = false; }

            });
            t.Start();
        }

        private void Stop()
        {
            if (t != null)
                t.Interrupt();
            TurnLightsOff();
        }
        private void TurnLightsOff()
        {
            serialPort.SendColorToComPort(255, 255, 255);
            serialPort.ClosePort();
            picColor.BackColor = Color.White;
        }

        #endregion

        #region Private Events
     
        private void FormAmbilight_Load(object sender, EventArgs e)
        {
            GetComPorts();
        }



        private void btStart_Click(object sender, EventArgs e)
        {
            if (cmbPortName.Text != "")
                Start();
        }

     

        private void btStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

     

        private void FormAmbilight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
        }
        #endregion
    }
}
