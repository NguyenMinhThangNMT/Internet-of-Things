namespace ComPort
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comParity = new System.Windows.Forms.ComboBox();
            this.comStopbit = new System.Windows.Forms.ComboBox();
            this.comDatabit = new System.Windows.Forms.ComboBox();
            this.comBaudrate = new System.Windows.Forms.ComboBox();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBinary = new System.Windows.Forms.CheckBox();
            this.butON1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.RecieveBox = new System.Windows.Forms.TextBox();
            this.CRC_text = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comParity);
            this.groupBox1.Controls.Add(this.comStopbit);
            this.groupBox1.Controls.Add(this.comDatabit);
            this.groupBox1.Controls.Add(this.comBaudrate);
            this.groupBox1.Controls.Add(this.comPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "PARTY BIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "STOP BIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "DATA BIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comParity
            // 
            this.comParity.FormattingEnabled = true;
            this.comParity.Items.AddRange(new object[] {
            "None",
            "Obb",
            "Even"});
            this.comParity.Location = new System.Drawing.Point(131, 162);
            this.comParity.Name = "comParity";
            this.comParity.Size = new System.Drawing.Size(121, 24);
            this.comParity.TabIndex = 0;
            // 
            // comStopbit
            // 
            this.comStopbit.FormattingEnabled = true;
            this.comStopbit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comStopbit.Location = new System.Drawing.Point(131, 127);
            this.comStopbit.Name = "comStopbit";
            this.comStopbit.Size = new System.Drawing.Size(121, 24);
            this.comStopbit.TabIndex = 0;
            // 
            // comDatabit
            // 
            this.comDatabit.DisplayMember = "9600";
            this.comDatabit.FormattingEnabled = true;
            this.comDatabit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comDatabit.Location = new System.Drawing.Point(131, 93);
            this.comDatabit.Name = "comDatabit";
            this.comDatabit.Size = new System.Drawing.Size(121, 24);
            this.comDatabit.TabIndex = 0;
            // 
            // comBaudrate
            // 
            this.comBaudrate.DisplayMember = "9600";
            this.comBaudrate.FormattingEnabled = true;
            this.comBaudrate.Items.AddRange(new object[] {
            "9600",
            "11400",
            "115200",
            "19200"});
            this.comBaudrate.Location = new System.Drawing.Point(131, 58);
            this.comBaudrate.Name = "comBaudrate";
            this.comBaudrate.Size = new System.Drawing.Size(121, 24);
            this.comBaudrate.TabIndex = 0;
            this.comBaudrate.SelectedIndexChanged += new System.EventHandler(this.comBaudrate_SelectedIndexChanged);
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(131, 28);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(121, 24);
            this.comPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 71);
            this.button3.TabIndex = 0;
            this.button3.Text = "SEND";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 397);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 71);
            this.textBox1.TabIndex = 2;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(777, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 68);
            this.button4.TabIndex = 2;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelStatus);
            this.groupBox4.Location = new System.Drawing.Point(279, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 99);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ComPort Status";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(44, 42);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(35, 17);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "OFF";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(436, 35);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 433);
            this.textBox2.TabIndex = 2;
            // 
            // checkBinary
            // 
            this.checkBinary.AutoSize = true;
            this.checkBinary.Location = new System.Drawing.Point(782, 238);
            this.checkBinary.Name = "checkBinary";
            this.checkBinary.Size = new System.Drawing.Size(70, 21);
            this.checkBinary.TabIndex = 2;
            this.checkBinary.Text = "Binary";
            this.checkBinary.UseVisualStyleBackColor = true;
            this.checkBinary.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // butON1
            // 
            this.butON1.Location = new System.Drawing.Point(11, 504);
            this.butON1.Name = "butON1";
            this.butON1.Size = new System.Drawing.Size(113, 51);
            this.butON1.TabIndex = 3;
            this.butON1.Text = "ON 1";
            this.butON1.UseVisualStyleBackColor = true;
            this.butON1.Click += new System.EventHandler(this.button5_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 504);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "ON 2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(249, 506);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 51);
            this.button6.TabIndex = 4;
            this.button6.Text = "ON 3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(368, 506);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 51);
            this.button7.TabIndex = 5;
            this.button7.Text = "ON 4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(606, 506);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 51);
            this.button8.TabIndex = 6;
            this.button8.Text = "ON 6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(725, 506);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 51);
            this.button9.TabIndex = 7;
            this.button9.Text = "ON 7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(844, 507);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 48);
            this.button10.TabIndex = 8;
            this.button10.Text = "ON 8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(487, 506);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(113, 51);
            this.button11.TabIndex = 9;
            this.button11.Text = "ON 5";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(14, 570);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(110, 51);
            this.button12.TabIndex = 10;
            this.button12.Text = "OFF1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(130, 570);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(113, 50);
            this.button13.TabIndex = 11;
            this.button13.Text = "OFF 2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(249, 570);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(113, 50);
            this.button14.TabIndex = 12;
            this.button14.Text = "OFF 3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(368, 567);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(113, 54);
            this.button15.TabIndex = 13;
            this.button15.Text = "OFF 4";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(487, 567);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(113, 54);
            this.button16.TabIndex = 14;
            this.button16.Text = "OFF 5";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(725, 570);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(113, 50);
            this.button18.TabIndex = 16;
            this.button18.Text = "OFF 7";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(844, 571);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(113, 50);
            this.button19.TabIndex = 17;
            this.button19.Text = "OFF 8";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(606, 570);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(113, 50);
            this.button17.TabIndex = 18;
            this.button17.Text = "OFF 6";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click_1);
            // 
            // RecieveBox
            // 
            this.RecieveBox.Location = new System.Drawing.Point(997, 129);
            this.RecieveBox.Multiline = true;
            this.RecieveBox.Name = "RecieveBox";
            this.RecieveBox.Size = new System.Drawing.Size(309, 40);
            this.RecieveBox.TabIndex = 2;
            // 
            // CRC_text
            // 
            this.CRC_text.Location = new System.Drawing.Point(996, 204);
            this.CRC_text.Multiline = true;
            this.CRC_text.Name = "CRC_text";
            this.CRC_text.Size = new System.Drawing.Size(310, 41);
            this.CRC_text.TabIndex = 2;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(996, 50);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(309, 39);
            this.txtSend.TabIndex = 2;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(1031, 323);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(94, 67);
            this.Calculate.TabIndex = 19;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(1203, 323);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 67);
            this.button21.TabIndex = 20;
            this.button21.Text = "Clear";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(932, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Send";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(932, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Recieve";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(913, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "CRC_Send";
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM8";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(997, 276);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(310, 41);
            this.textBox3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(895, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "CRC_Recieve";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 662);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.butON1);
            this.Controls.Add(this.checkBinary);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CRC_text);
            this.Controls.Add(this.RecieveBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comParity;
        private System.Windows.Forms.ComboBox comStopbit;
        private System.Windows.Forms.ComboBox comDatabit;
        private System.Windows.Forms.ComboBox comBaudrate;
        private System.Windows.Forms.ComboBox comPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBinary;
        private System.Windows.Forms.Button butON1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button17;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.TextBox RecieveBox;
        private System.Windows.Forms.TextBox CRC_text;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
    }
}

