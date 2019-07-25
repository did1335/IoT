using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LED_ON_OFF
{
    public partial class Form1 : Form
    {
        private SerialPort myport;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName = "COM9";
                myport.Open();

                button1.Enabled = true;
                button2.Enabled = false;
                myport.WriteLine("B");
            }
            catch
            {
                MessageBox.Show("Can't connect to MCU!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myport.WriteLine("A");

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myport.WriteLine("B");

            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
