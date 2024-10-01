using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTS_ControlarArduino
{
    public partial class Form1 : Form
    {
        public SerialPort FVOArduinoP { get; }

        public Form1()
        {
            InitializeComponent();

            //aqui va el arduino
            FVOArduinoP = new System.IO.Ports.SerialPort();
            FVOArduinoP.PortName = "COM4";
            FVOArduinoP.BaudRate = 9600;
            FVOArduinoP.Open();

            //vincular eventos
            this.FormClosing += CerrandoForm1;
            this.BTOff.Click += BTOff_Click;
            this.BTOff.Click += BTOff_Click;
        }

        private void BTOff_Click(object sender, EventArgs e)
        {
            FVOArduinoP.Write("a");
        }

        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            if (FVOArduinoP.IsOpen) FVOArduinoP.Close();
        }

        private void BTOn_Click(object sender, EventArgs e)
        {
            FVOArduinoP.Write("b");
        }
    }
}
