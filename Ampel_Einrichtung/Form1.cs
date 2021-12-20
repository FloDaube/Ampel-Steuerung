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

namespace Ampel_Einrichtung
{
    public partial class Form1 : Form
    {
        string[] ports;
        SerialPort port = new SerialPort();
        string[] StartCenterEndCode = new string[3] {"#","&","\n" };
        public Form1()
        {
            InitializeComponent();
            ports = SerialPort.GetPortNames();
            comboBox_Ports.Items.AddRange(ports);
            label_UploadSettings.Text = "";
            timer_Read.Enabled = true;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (comboBox_Ports.SelectedItem != null)
            {
                Connect();
            }
            else
            {
                label_State.Text = "Kein Port ausgewählt";
            }
        }

        private void Connect()
        {
            if (port.IsOpen)
            {
                button_Connect.Text = "Verbinden";
                SendData("Connection", "Disconnect");
                port.Close();
            }
            else
            {
                port = new SerialPort(comboBox_Ports.GetItemText(comboBox_Ports.SelectedItem), 9600, Parity.None, 8, StopBits.One);
                port.Open();
                if (port.IsOpen)
                {
                    SendData("Connection","Connect");
                    string confirmation = ReadData();
                    // Debug Hilfe
                    confirmation = "Confirmation";
                    if(confirmation == "Confirmation")
                    {
                        button_Connect.Text = "Trennen";
                        label_State.Text = "Verbunden";
                        groupBox_Settings.Enabled = true;
                    }
                    else
                    {
                        label_State.Text = "Ampel Steuerung reagiert nicht";
                        port.Close();
                        SendData("Connection", "Error");
                        label_State.Text = "Keine verbindung";
                        groupBox_Settings.Enabled = false;
                    }
                }
            }
            
        }
        private void SendData(string Key, string Value)
        {
            string stringOut = StartCenterEndCode[0] + Key + StartCenterEndCode[1] + Value + StartCenterEndCode[2];
            if (port.IsOpen)
            {
                port.Write(stringOut);
            }
            var charsToRemove = new string[] { "#"};
            foreach (var c in charsToRemove)
            {
                stringOut = stringOut.Replace(c, string.Empty);
            }
            richTextBox_SerialMonitor.Text += "PC >>> " + stringOut;
        }

        private string ReadData()
        {
            string serialIn = port.ReadExisting();
            if(serialIn != String.Empty)
            {
                richTextBox_SerialMonitor.Text += "Ampel >>> " + serialIn;
                if (serialIn.Equals("Ampel_1"))
                {
                    if (serialIn.Equals("Red"))
                    {
                        if (serialIn.Equals("&0"))
                        {

                        }
                        else if (serialIn.Equals("&1"))
                        {

                        }
                    }
                    else if (serialIn.Equals("Yellow"))
                    {
                        if (serialIn.Equals("&0"))
                        {

                        }
                        else if (serialIn.Equals("&1"))
                        {

                        }
                    }
                    else if (serialIn.Equals("Green"))
                    {
                        if (serialIn.Equals("&0"))
                        {

                        }
                        else if (serialIn.Equals("&1"))
                        {

                        }
                    }
                }
                else if (serialIn.Equals("Ampel_2"))
                {
                    if (serialIn.Equals("Red"))
                    {
                        if (serialIn.Equals("&0"))
                        {

                        }
                        else if (serialIn.Equals("&1"))
                        {

                        }
                    }
                    else if (serialIn.Equals("Yellow"))
                    {
                        if (serialIn.Equals("&0"))
                        {

                        }
                        else if (serialIn.Equals("&1"))
                        {

                        }
                    }
                    else if (serialIn.Equals("Green"))
                    {
                        if (serialIn.Equals("&0"))
                        {

                        }
                        else if (serialIn.Equals("&1"))
                        {

                        }
                    }
                }
            }            
            return serialIn;
        }

        private void richTextBox_SerialMonitor_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_AutoScroll.Checked == true)
            {
                richTextBox_SerialMonitor.SelectionStart = richTextBox_SerialMonitor.Text.Length;
                richTextBox_SerialMonitor.ScrollToCaret();
            }            
        }

        private void button_SendSettings_Click(object sender, EventArgs e)
        {
            label_UploadSettings.Text = "Sende daten...";
            SendData("Setting_RG", numericUpDown_RG.Value.ToString());
            SendData("Setting_Y",numericUpDown_Y.Value.ToString());
            SendData("Setting_RR",numericUpDown_RR.Value.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            port.Close();
        }

        private void timer_Read_Tick(object sender, EventArgs e)
        {
            if(port.IsOpen == true)
            {
                ReadData();
            }
        }
    }
}
