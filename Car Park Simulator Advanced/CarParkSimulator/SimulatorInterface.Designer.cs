namespace CarParkSimulator
{
    partial class SimulatorInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatorInterface));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTicketMachine = new System.Windows.Forms.Label();
            this.btnCarEntersCarPark = new System.Windows.Forms.Button();
            this.btnDriverPressesForTicket = new System.Windows.Forms.Button();
            this.btnCarArrivesAtEntrance = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTicketValidator = new System.Windows.Forms.Label();
            this.btnCarExitsCarPark = new System.Windows.Forms.Button();
            this.btnDriverEntersTicket = new System.Windows.Forms.Button();
            this.btnCarArrivesAtExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstActiveTickets = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExitBarrier = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblExitSensor = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEntryBarrier = new System.Windows.Forms.Label();
            this.lblEntrySensor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSpaces = new System.Windows.Forms.Label();
            this.lblFullSign = new System.Windows.Forms.Label();
            this.payForIt = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.carParkTNum5 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.carPark5 = new System.Windows.Forms.ListView();
            this.carParkTNum4 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.carPark4 = new System.Windows.Forms.ListView();
            this.carParkTNum3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.carPark3 = new System.Windows.Forms.ListView();
            this.carParkTNum2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.carPark2 = new System.Windows.Forms.ListView();
            this.carParkTNum1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.carPark1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTicketMachine);
            this.groupBox1.Controls.Add(this.btnCarEntersCarPark);
            this.groupBox1.Controls.Add(this.btnDriverPressesForTicket);
            this.groupBox1.Controls.Add(this.btnCarArrivesAtEntrance);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance simulator";
            // 
            // lblTicketMachine
            // 
            this.lblTicketMachine.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketMachine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTicketMachine.Location = new System.Drawing.Point(6, 20);
            this.lblTicketMachine.Name = "lblTicketMachine";
            this.lblTicketMachine.Size = new System.Drawing.Size(188, 31);
            this.lblTicketMachine.TabIndex = 1;
            this.lblTicketMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarEntersCarPark
            // 
            this.btnCarEntersCarPark.Location = new System.Drawing.Point(6, 177);
            this.btnCarEntersCarPark.Name = "btnCarEntersCarPark";
            this.btnCarEntersCarPark.Size = new System.Drawing.Size(188, 54);
            this.btnCarEntersCarPark.TabIndex = 3;
            this.btnCarEntersCarPark.Text = "Car enters car park";
            this.btnCarEntersCarPark.UseVisualStyleBackColor = true;
            this.btnCarEntersCarPark.Visible = false;
            this.btnCarEntersCarPark.Click += new System.EventHandler(this.CarEntersCarPark);
            // 
            // btnDriverPressesForTicket
            // 
            this.btnDriverPressesForTicket.Location = new System.Drawing.Point(6, 117);
            this.btnDriverPressesForTicket.Name = "btnDriverPressesForTicket";
            this.btnDriverPressesForTicket.Size = new System.Drawing.Size(188, 54);
            this.btnDriverPressesForTicket.TabIndex = 1;
            this.btnDriverPressesForTicket.Text = "Driver presses for ticket";
            this.btnDriverPressesForTicket.UseVisualStyleBackColor = true;
            this.btnDriverPressesForTicket.Visible = false;
            this.btnDriverPressesForTicket.Click += new System.EventHandler(this.DriverPressesForTicket);
            // 
            // btnCarArrivesAtEntrance
            // 
            this.btnCarArrivesAtEntrance.Location = new System.Drawing.Point(6, 57);
            this.btnCarArrivesAtEntrance.Name = "btnCarArrivesAtEntrance";
            this.btnCarArrivesAtEntrance.Size = new System.Drawing.Size(188, 54);
            this.btnCarArrivesAtEntrance.TabIndex = 0;
            this.btnCarArrivesAtEntrance.Text = "Car arrives at entrance";
            this.btnCarArrivesAtEntrance.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtEntrance.Visible = false;
            this.btnCarArrivesAtEntrance.Click += new System.EventHandler(this.CarArrivesAtEntrance);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTicketValidator);
            this.groupBox2.Controls.Add(this.btnCarExitsCarPark);
            this.groupBox2.Controls.Add(this.btnDriverEntersTicket);
            this.groupBox2.Controls.Add(this.btnCarArrivesAtExit);
            this.groupBox2.Location = new System.Drawing.Point(226, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exit simulator";
            // 
            // lblTicketValidator
            // 
            this.lblTicketValidator.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketValidator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketValidator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTicketValidator.Location = new System.Drawing.Point(6, 20);
            this.lblTicketValidator.Name = "lblTicketValidator";
            this.lblTicketValidator.Size = new System.Drawing.Size(188, 31);
            this.lblTicketValidator.TabIndex = 1;
            this.lblTicketValidator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarExitsCarPark
            // 
            this.btnCarExitsCarPark.Location = new System.Drawing.Point(6, 177);
            this.btnCarExitsCarPark.Name = "btnCarExitsCarPark";
            this.btnCarExitsCarPark.Size = new System.Drawing.Size(188, 54);
            this.btnCarExitsCarPark.TabIndex = 2;
            this.btnCarExitsCarPark.Text = "Car exits car park";
            this.btnCarExitsCarPark.UseVisualStyleBackColor = true;
            this.btnCarExitsCarPark.Visible = false;
            this.btnCarExitsCarPark.Click += new System.EventHandler(this.CarExitsCarPark);
            // 
            // btnDriverEntersTicket
            // 
            this.btnDriverEntersTicket.Location = new System.Drawing.Point(6, 117);
            this.btnDriverEntersTicket.Name = "btnDriverEntersTicket";
            this.btnDriverEntersTicket.Size = new System.Drawing.Size(188, 54);
            this.btnDriverEntersTicket.TabIndex = 1;
            this.btnDriverEntersTicket.Text = "Driver enters ticket";
            this.btnDriverEntersTicket.UseVisualStyleBackColor = true;
            this.btnDriverEntersTicket.Visible = false;
            this.btnDriverEntersTicket.Click += new System.EventHandler(this.DriverEntersTicket);
            // 
            // btnCarArrivesAtExit
            // 
            this.btnCarArrivesAtExit.Location = new System.Drawing.Point(6, 57);
            this.btnCarArrivesAtExit.Name = "btnCarArrivesAtExit";
            this.btnCarArrivesAtExit.Size = new System.Drawing.Size(188, 54);
            this.btnCarArrivesAtExit.TabIndex = 0;
            this.btnCarArrivesAtExit.Text = "Car arrives at exit";
            this.btnCarArrivesAtExit.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtExit.Visible = false;
            this.btnCarArrivesAtExit.Click += new System.EventHandler(this.CarArrivesAtExit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 53);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car Park Simulator";
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnReset.Location = new System.Drawing.Point(18, 83);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(402, 54);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSystem);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblSpaces);
            this.groupBox3.Controls.Add(this.lblFullSign);
            this.groupBox3.Location = new System.Drawing.Point(440, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 238);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal data";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstActiveTickets);
            this.groupBox6.Location = new System.Drawing.Point(171, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(144, 211);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Active Tickets";
            // 
            // lstActiveTickets
            // 
            this.lstActiveTickets.FormattingEnabled = true;
            this.lstActiveTickets.Location = new System.Drawing.Point(6, 19);
            this.lstActiveTickets.Name = "lstActiveTickets";
            this.lstActiveTickets.Size = new System.Drawing.Size(132, 186);
            this.lstActiveTickets.TabIndex = 0;
            this.lstActiveTickets.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblExitBarrier);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lblExitSensor);
            this.groupBox5.Location = new System.Drawing.Point(11, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 67);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exit";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sensor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitBarrier
            // 
            this.lblExitBarrier.BackColor = System.Drawing.Color.White;
            this.lblExitBarrier.Location = new System.Drawing.Point(60, 41);
            this.lblExitBarrier.Name = "lblExitBarrier";
            this.lblExitBarrier.Size = new System.Drawing.Size(70, 20);
            this.lblExitBarrier.TabIndex = 0;
            this.lblExitBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Barrier";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitSensor
            // 
            this.lblExitSensor.BackColor = System.Drawing.Color.White;
            this.lblExitSensor.Location = new System.Drawing.Point(60, 16);
            this.lblExitSensor.Name = "lblExitSensor";
            this.lblExitSensor.Size = new System.Drawing.Size(70, 20);
            this.lblExitSensor.TabIndex = 0;
            this.lblExitSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblEntryBarrier);
            this.groupBox4.Controls.Add(this.lblEntrySensor);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(11, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 67);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entry";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sensor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntryBarrier
            // 
            this.lblEntryBarrier.BackColor = System.Drawing.Color.White;
            this.lblEntryBarrier.Location = new System.Drawing.Point(60, 41);
            this.lblEntryBarrier.Name = "lblEntryBarrier";
            this.lblEntryBarrier.Size = new System.Drawing.Size(70, 20);
            this.lblEntryBarrier.TabIndex = 0;
            this.lblEntryBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrySensor
            // 
            this.lblEntrySensor.BackColor = System.Drawing.Color.White;
            this.lblEntrySensor.Location = new System.Drawing.Point(60, 16);
            this.lblEntrySensor.Name = "lblEntrySensor";
            this.lblEntrySensor.Size = new System.Drawing.Size(70, 20);
            this.lblEntrySensor.TabIndex = 0;
            this.lblEntrySensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barrier";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Spaces";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Full Sign";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpaces
            // 
            this.lblSpaces.BackColor = System.Drawing.Color.White;
            this.lblSpaces.Location = new System.Drawing.Point(71, 205);
            this.lblSpaces.Name = "lblSpaces";
            this.lblSpaces.Size = new System.Drawing.Size(70, 20);
            this.lblSpaces.TabIndex = 0;
            this.lblSpaces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullSign
            // 
            this.lblFullSign.BackColor = System.Drawing.Color.White;
            this.lblFullSign.Location = new System.Drawing.Point(71, 172);
            this.lblFullSign.Name = "lblFullSign";
            this.lblFullSign.Size = new System.Drawing.Size(70, 20);
            this.lblFullSign.TabIndex = 0;
            this.lblFullSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payForIt
            // 
            this.payForIt.Location = new System.Drawing.Point(451, 83);
            this.payForIt.Margin = new System.Windows.Forms.Padding(2);
            this.payForIt.Name = "payForIt";
            this.payForIt.Size = new System.Drawing.Size(108, 54);
            this.payForIt.TabIndex = 5;
            this.payForIt.Text = "Pay";
            this.payForIt.UseVisualStyleBackColor = true;
            this.payForIt.Visible = false;
            this.payForIt.Click += new System.EventHandler(this.pay_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.carParkTNum5);
            this.groupBox7.Controls.Add(this.textBox10);
            this.groupBox7.Controls.Add(this.carPark5);
            this.groupBox7.Controls.Add(this.carParkTNum4);
            this.groupBox7.Controls.Add(this.textBox8);
            this.groupBox7.Controls.Add(this.carPark4);
            this.groupBox7.Controls.Add(this.carParkTNum3);
            this.groupBox7.Controls.Add(this.textBox6);
            this.groupBox7.Controls.Add(this.carPark3);
            this.groupBox7.Controls.Add(this.carParkTNum2);
            this.groupBox7.Controls.Add(this.textBox4);
            this.groupBox7.Controls.Add(this.carPark2);
            this.groupBox7.Controls.Add(this.carParkTNum1);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.carPark1);
            this.groupBox7.Location = new System.Drawing.Point(12, 392);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(756, 169);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Car Park Visualisation";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.richTextBox2);
            this.groupBox8.Controls.Add(this.richTextBox1);
            this.groupBox8.Location = new System.Drawing.Point(591, 32);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(152, 124);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Key";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Firebrick;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox2.Location = new System.Drawing.Point(15, 72);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(123, 31);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "  Space Taken";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Green;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Location = new System.Drawing.Point(15, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(123, 31);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "   Free Space";
            // 
            // carParkTNum5
            // 
            this.carParkTNum5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.carParkTNum5.Location = new System.Drawing.Point(482, 68);
            this.carParkTNum5.Name = "carParkTNum5";
            this.carParkTNum5.ReadOnly = true;
            this.carParkTNum5.Size = new System.Drawing.Size(96, 20);
            this.carParkTNum5.TabIndex = 35;
            this.carParkTNum5.Text = "Ticket # ";
            this.carParkTNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox10.Location = new System.Drawing.Point(482, 38);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(96, 20);
            this.textBox10.TabIndex = 34;
            this.textBox10.Text = "Parking Space #5";
            // 
            // carPark5
            // 
            this.carPark5.BackColor = System.Drawing.Color.Green;
            this.carPark5.Location = new System.Drawing.Point(475, 32);
            this.carPark5.Name = "carPark5";
            this.carPark5.Size = new System.Drawing.Size(110, 124);
            this.carPark5.TabIndex = 33;
            this.carPark5.UseCompatibleStateImageBehavior = false;
            // 
            // carParkTNum4
            // 
            this.carParkTNum4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.carParkTNum4.Location = new System.Drawing.Point(366, 68);
            this.carParkTNum4.Name = "carParkTNum4";
            this.carParkTNum4.ReadOnly = true;
            this.carParkTNum4.Size = new System.Drawing.Size(96, 20);
            this.carParkTNum4.TabIndex = 32;
            this.carParkTNum4.Text = "Ticket # ";
            this.carParkTNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox8.Location = new System.Drawing.Point(366, 38);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(96, 20);
            this.textBox8.TabIndex = 31;
            this.textBox8.Text = "Parking Space #4";
            // 
            // carPark4
            // 
            this.carPark4.BackColor = System.Drawing.Color.Green;
            this.carPark4.Location = new System.Drawing.Point(359, 32);
            this.carPark4.Name = "carPark4";
            this.carPark4.Size = new System.Drawing.Size(110, 124);
            this.carPark4.TabIndex = 30;
            this.carPark4.UseCompatibleStateImageBehavior = false;
            // 
            // carParkTNum3
            // 
            this.carParkTNum3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.carParkTNum3.Location = new System.Drawing.Point(250, 68);
            this.carParkTNum3.Name = "carParkTNum3";
            this.carParkTNum3.ReadOnly = true;
            this.carParkTNum3.Size = new System.Drawing.Size(96, 20);
            this.carParkTNum3.TabIndex = 29;
            this.carParkTNum3.Text = "Ticket # ";
            this.carParkTNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox6.Location = new System.Drawing.Point(250, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(96, 20);
            this.textBox6.TabIndex = 28;
            this.textBox6.Text = "Parking Space #3";
            // 
            // carPark3
            // 
            this.carPark3.BackColor = System.Drawing.Color.Green;
            this.carPark3.Location = new System.Drawing.Point(243, 32);
            this.carPark3.Name = "carPark3";
            this.carPark3.Size = new System.Drawing.Size(110, 124);
            this.carPark3.TabIndex = 27;
            this.carPark3.UseCompatibleStateImageBehavior = false;
            
            // 
            // carParkTNum2
            // 
            this.carParkTNum2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.carParkTNum2.Location = new System.Drawing.Point(134, 68);
            this.carParkTNum2.Name = "carParkTNum2";
            this.carParkTNum2.ReadOnly = true;
            this.carParkTNum2.Size = new System.Drawing.Size(96, 20);
            this.carParkTNum2.TabIndex = 26;
            this.carParkTNum2.Text = "Ticket # ";
            this.carParkTNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox4.Location = new System.Drawing.Point(134, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(96, 20);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = "Parking Space #2";
            // 
            // carPark2
            // 
            this.carPark2.BackColor = System.Drawing.Color.Green;
            this.carPark2.Location = new System.Drawing.Point(127, 32);
            this.carPark2.Name = "carPark2";
            this.carPark2.Size = new System.Drawing.Size(110, 124);
            this.carPark2.TabIndex = 24;
            this.carPark2.UseCompatibleStateImageBehavior = false;
            // 
            // carParkTNum1
            // 
            this.carParkTNum1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.carParkTNum1.Location = new System.Drawing.Point(18, 68);
            this.carParkTNum1.Name = "carParkTNum1";
            this.carParkTNum1.ReadOnly = true;
            this.carParkTNum1.Size = new System.Drawing.Size(96, 20);
            this.carParkTNum1.TabIndex = 23;
            this.carParkTNum1.Text = "Ticket # ";
            this.carParkTNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(18, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Parking Space #1";
            // 
            // carPark1
            // 
            this.carPark1.BackColor = System.Drawing.Color.Green;
            this.carPark1.Location = new System.Drawing.Point(11, 32);
            this.carPark1.Name = "carPark1";
            this.carPark1.Size = new System.Drawing.Size(110, 124);
            this.carPark1.TabIndex = 21;
            this.carPark1.UseCompatibleStateImageBehavior = false;
            // 
            // SimulatorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(780, 576);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.payForIt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulatorInterface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Park Simulator";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTicketMachine;
        private System.Windows.Forms.Button btnCarEntersCarPark;
        private System.Windows.Forms.Button btnDriverPressesForTicket;
        private System.Windows.Forms.Button btnCarArrivesAtEntrance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTicketValidator;
        private System.Windows.Forms.Button btnCarExitsCarPark;
        private System.Windows.Forms.Button btnDriverEntersTicket;
        private System.Windows.Forms.Button btnCarArrivesAtExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEntrySensor;
        private System.Windows.Forms.Label lblFullSign;
        private System.Windows.Forms.Label lblExitSensor;
        private System.Windows.Forms.Label lblSpaces;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEntryBarrier;
        private System.Windows.Forms.Label lblExitBarrier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstActiveTickets;
        private System.Windows.Forms.Button payForIt;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox carParkTNum5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ListView carPark5;
        private System.Windows.Forms.TextBox carParkTNum4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ListView carPark4;
        private System.Windows.Forms.TextBox carParkTNum3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListView carPark3;
        private System.Windows.Forms.TextBox carParkTNum2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView carPark2;
        private System.Windows.Forms.TextBox carParkTNum1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView carPark1;
    }
}

