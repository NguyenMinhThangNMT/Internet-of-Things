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
using System.Threading;

namespace ComPort
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort = null;
        

        string dataOUT;
        string dataIN;
        int state = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comPort.Items.AddRange(ports); 
            serialPort1.DtrEnable = false;
            serialPort1.RtsEnable = false;
            button1.Enabled = true;
            button2.Enabled = false;
            try { }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comBaudrate.Text);
                serialPort1.DataBits = Convert.ToInt32(comDatabit.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comStopbit.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comParity.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                button1.Enabled = false;
                button2.Enabled = true;
                labelStatus.Text = "ON";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, ("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = false;
                button2.Enabled = true;
            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                button1.Enabled = true;
                button2.Enabled = false;
                labelStatus.Text = "OFF";

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = textBox1.Text;
                serialPort1.WriteLine(dataOUT);
                if (textBox1.Text != "")
                {
                    textBox1.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.Text = "";
            }
        }

        // private void checkboxDTR_CheckedChanged(object sender, EventArgs e)
        //{
        //   if (checkboxDTR.Checked)
        //   {
        //      serialPort1.DtrEnable = true;
        // }
        //  else {serialPort1.DtrEnable = false; }
        //}

        //private void checkBoxRST_CheckedChanged(object sender, EventArgs e)
        //{
        // if (checkboxRST.Checked)
        // {
        //   serialPort1.RtsEnable = true;
        // }
        // else { serialPort1.RtsEnable = false; }
        // }

       private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(showData));

        }

        private void showData(object sender, EventArgs e)
        {
            textBox2.Text = dataIN;
            byte slaveAddress = 05;
            byte functionCode = 03;
            ushort startAddress = 00;
            ushort numberOfPoints = 05;

            byte[] frame = this.ReadHoldingRegister(slaveAddress, functionCode, startAddress, numberOfPoints);
            txtSend.Text = this.Display(frame);
            CRC_text.Text = string.Format("{0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]);
            serialPort1.Write(frame, 0, frame.Length);
            Thread.Sleep(100);

            if (serialPort1.BytesToRead >= 5)
            {
                frame = new byte[serialPort1.BytesToRead];
                int rs = serialPort1.Read(frame, 0, frame.Length);
                RecieveBox.Text = this.Display(frame);
                textBox3.Text = string.Format("{0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]);
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBinary.Checked)
            {
                textBox2.Text = binary(textBox2.Text);
            }

        }

        public string binary(string inp)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char L in inp.ToCharArray())
            {
                sb.Append(Convert.ToString(L, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "1";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "2";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "3";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "6";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "4";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "5";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "7";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "8";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "a";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "b";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "c";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "d";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "e";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "g";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "h";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = "f";
                serialPort1.WriteLine(dataOUT);

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            try
            {
                byte slaveAddress = 05;
                byte functionCode = 03;
                ushort startAddress = 00;
                ushort numberOfPoints = 05;

                byte[] frame = this.ReadHoldingRegister( slaveAddress, functionCode,startAddress, numberOfPoints);
                txtSend.Text = this.Display(frame);
                CRC_text.Text = string.Format("CRC(Send): {0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]);
                
                serialPort1.Write(frame, 0, frame.Length);
                Thread.Sleep(100);
                if (serialPort1.BytesToRead >= 5)
                {
                    frame = new byte[serialPort1.BytesToRead];
                    int rs = serialPort1.Read(frame, 0, frame.Length);
                    RecieveBox.Text = this.Display(frame);
                    textBox3.Text = string.Format(" {0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private byte[] ReadHoldingRegister(byte slaveAddress, byte functionCode, ushort startAddress, ushort numberOfPoints)
        {
            byte[] frame = new byte[8];
            frame[0] = slaveAddress;
            frame[1] = functionCode;
            frame[2] = (byte)(startAddress>>8);
            frame[3] = (byte)startAddress;
            frame[4] = (byte)(numberOfPoints>>8);
            frame[5] = (byte)numberOfPoints ;
            byte[] crc = this.CalculateCRC(frame);
            frame[6] = crc[0];
            frame[7] = crc[1];
            return frame;


        }
        private byte[] CalculateCRC(byte[] frame)
        {
            byte[] result = new byte[2];
            ushort CRCFull = 0xFFFF;
            char CRCLSB;
            for (int i = 0; i < frame.Length - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ frame[i]);
                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (Char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);
                    if (CRCLSB == 1)
                    {
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                    }
                }
            }
            result[1] = (byte)((CRCFull >> 8) & 0xFF);
            result[0] = (byte)((CRCFull & 0xFF));
            return result;
        }
        private string Display(byte[] frame)
        {
            string result = string.Empty;
            foreach (byte item in frame)
            {
                result += string.Format("{0:X2}", item);
            }
            return result;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (CRC_text.Text != "")
            {
                CRC_text.Text = "";
            }
            if (txtSend.Text != "")
            {
               txtSend.Text = "";
            }
            if (RecieveBox.Text != "")
            {
                RecieveBox.Text = "";
            }
            if (textBox3.Text != "")
            {
                textBox3.Text = "";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
    

