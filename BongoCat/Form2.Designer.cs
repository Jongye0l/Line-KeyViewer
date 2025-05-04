namespace BongoCat
{
    partial class Settings
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
        private void InitializeComponent() {
            this.Modes = new System.Windows.Forms.TabControl();
            this.Default = new System.Windows.Forms.TabPage();
            this.Table = new System.Windows.Forms.CheckBox();
            this.Mouse = new System.Windows.Forms.CheckBox();
            this.Instrument = new System.Windows.Forms.ComboBox();
            this.Background = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLeft = new System.Windows.Forms.Button();
            this.AddRight = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Left = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Right = new System.Windows.Forms.ListBox();
            this.Piano = new System.Windows.Forms.TabPage();
            this.pianoTable = new System.Windows.Forms.CheckBox();
            this.pianoBackground = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Modes.SuspendLayout();
            this.Default.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Piano.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Modes
            // 
            this.Modes.Controls.Add(this.Default);
            this.Modes.Controls.Add(this.Piano);
            this.Modes.Location = new System.Drawing.Point(0, 0);
            this.Modes.Name = "Modes";
            this.Modes.SelectedIndex = 0;
            this.Modes.Size = new System.Drawing.Size(287, 251);
            this.Modes.TabIndex = 0;
            this.Modes.TabStop = false;
            // 
            // Default
            // 
            this.Default.Controls.Add(this.Table);
            this.Default.Controls.Add(this.Mouse);
            this.Default.Controls.Add(this.Instrument);
            this.Default.Controls.Add(this.Background);
            this.Default.Controls.Add(this.label3);
            this.Default.Controls.Add(this.label2);
            this.Default.Controls.Add(this.label1);
            this.Default.Controls.Add(this.AddLeft);
            this.Default.Controls.Add(this.AddRight);
            this.Default.Controls.Add(this.groupBox2);
            this.Default.Controls.Add(this.groupBox1);
            this.Default.Location = new System.Drawing.Point(4, 22);
            this.Default.Name = "Default";
            this.Default.Padding = new System.Windows.Forms.Padding(3);
            this.Default.Size = new System.Drawing.Size(279, 225);
            this.Default.TabIndex = 0;
            this.Default.Text = "Default";
            this.Default.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.Location = new System.Drawing.Point(177, 207);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(80, 16);
            this.Table.TabIndex = 10;
            this.Table.TabStop = false;
            this.Table.Text = "Hide table";
            this.Table.UseVisualStyleBackColor = true;
            this.Table.CheckedChanged += new System.EventHandler(this.Table_CheckedChanged);
            // 
            // Mouse
            // 
            this.Mouse.AutoSize = true;
            this.Mouse.Location = new System.Drawing.Point(7, 207);
            this.Mouse.Name = "Mouse";
            this.Mouse.Size = new System.Drawing.Size(130, 16);
            this.Mouse.TabIndex = 9;
            this.Mouse.TabStop = false;
            this.Mouse.Text = "Track mouse input";
            this.Mouse.UseVisualStyleBackColor = true;
            this.Mouse.CheckedChanged += new System.EventHandler(this.Mouse_CheckedChanged);
            // 
            // Instrument
            // 
            this.Instrument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Instrument.FormattingEnabled = true;
            this.Instrument.Items.AddRange(new object[] {
                "None", "Bongo", "Controller", "Keyboard"
            });
            this.Instrument.Location = new System.Drawing.Point(90, 182);
            this.Instrument.Name = "Instrument";
            this.Instrument.Size = new System.Drawing.Size(180, 20);
            this.Instrument.TabIndex = 8;
            this.Instrument.TabStop = false;
            this.Instrument.SelectedIndexChanged += new System.EventHandler(this.Instrument_SelectedIndexChanged);
            // 
            // Background
            // 
            this.Background.Location = new System.Drawing.Point(90, 156);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(181, 21);
            this.Background.TabIndex = 7;
            this.Background.TabStop = false;
            this.Background.UseVisualStyleBackColor = true;
            this.Background.Click += new System.EventHandler(this.Background_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Instrument:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Backbround:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(36, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doubleclick on key value to delete it";
            // 
            // AddLeft
            // 
            this.AddLeft.Location = new System.Drawing.Point(90, 97);
            this.AddLeft.Name = "AddLeft";
            this.AddLeft.Size = new System.Drawing.Size(98, 21);
            this.AddLeft.TabIndex = 3;
            this.AddLeft.TabStop = false;
            this.AddLeft.Text = "Add =>";
            this.AddLeft.UseVisualStyleBackColor = true;
            this.AddLeft.Click += new System.EventHandler(this.AddLeft_Click);
            // 
            // AddRight
            // 
            this.AddRight.Location = new System.Drawing.Point(90, 30);
            this.AddRight.Name = "AddRight";
            this.AddRight.Size = new System.Drawing.Size(98, 21);
            this.AddRight.TabIndex = 2;
            this.AddRight.TabStop = false;
            this.AddRight.Text = "<= Add";
            this.AddRight.UseVisualStyleBackColor = true;
            this.AddRight.Click += new System.EventHandler(this.AddRight_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Left);
            this.groupBox2.Location = new System.Drawing.Point(195, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(76, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key 2";
            // 
            // Left
            // 
            this.Left.FormattingEnabled = true;
            this.Left.ItemHeight = 12;
            this.Left.Location = new System.Drawing.Point(7, 18);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(61, 100);
            this.Left.TabIndex = 1;
            this.Left.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Right);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key 1";
            // 
            // Right
            // 
            this.Right.FormattingEnabled = true;
            this.Right.ItemHeight = 12;
            this.Right.Location = new System.Drawing.Point(7, 18);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(61, 100);
            this.Right.TabIndex = 0;
            this.Right.TabStop = false;
            // 
            // Piano
            // 
            this.Piano.Controls.Add(this.pianoTable);
            this.Piano.Controls.Add(this.pianoBackground);
            this.Piano.Controls.Add(this.label12);
            this.Piano.Controls.Add(this.groupBox4);
            this.Piano.Controls.Add(this.groupBox3);
            this.Piano.Location = new System.Drawing.Point(4, 22);
            this.Piano.Name = "Piano";
            this.Piano.Size = new System.Drawing.Size(279, 225);
            this.Piano.TabIndex = 1;
            this.Piano.Text = "Piano";
            this.Piano.UseVisualStyleBackColor = true;
            // 
            // pianoTable
            // 
            this.pianoTable.AutoSize = true;
            this.pianoTable.Location = new System.Drawing.Point(180, 185);
            this.pianoTable.Name = "pianoTable";
            this.pianoTable.Size = new System.Drawing.Size(80, 16);
            this.pianoTable.TabIndex = 4;
            this.pianoTable.Text = "Hide table";
            this.pianoTable.UseVisualStyleBackColor = true;
            this.pianoTable.CheckedChanged += new System.EventHandler(this.pianoTable_CheckedChanged);
            // 
            // pianoBackground
            // 
            this.pianoBackground.Location = new System.Drawing.Point(9, 200);
            this.pianoBackground.Name = "pianoBackground";
            this.pianoBackground.Size = new System.Drawing.Size(257, 21);
            this.pianoBackground.TabIndex = 3;
            this.pianoBackground.UseVisualStyleBackColor = true;
            this.pianoBackground.Click += new System.EventHandler(this.pianoBackground_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "Background:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(138, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 180);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Left Hand";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(51, 152);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 21);
            this.button16.TabIndex = 23;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(51, 132);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 21);
            this.button15.TabIndex = 22;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(51, 112);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 21);
            this.button14.TabIndex = 21;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(51, 92);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 21);
            this.button13.TabIndex = 20;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 157);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 12);
            this.label20.TabIndex = 19;
            this.label20.Text = "Key16";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 137);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 12);
            this.label19.TabIndex = 18;
            this.label19.Text = "Key15";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 12);
            this.label18.TabIndex = 17;
            this.label18.Text = "Key14";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 12);
            this.label17.TabIndex = 16;
            this.label17.Text = "Key13";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(51, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 21);
            this.button8.TabIndex = 15;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "Key8";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(51, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 21);
            this.button7.TabIndex = 13;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "Key7";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(51, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 21);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "Key6";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 21);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Key5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(9, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 180);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Right Hand";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(51, 152);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 21);
            this.button12.TabIndex = 15;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(51, 132);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 21);
            this.button11.TabIndex = 14;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(51, 112);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 21);
            this.button10.TabIndex = 13;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(51, 92);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 21);
            this.button9.TabIndex = 12;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "Key12";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "Key11";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "Key10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "Key9";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(51, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 21);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Key4";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 21);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Key3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Key2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Key1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel1, this.toolStripStatusLabel2
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 247);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(285, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabel1.Text = "Version 1.2.1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel2.Text = "App by PunyFlash";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 269);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Modes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.Modes.ResumeLayout(false);
            this.Default.ResumeLayout(false);
            this.Default.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Piano.ResumeLayout(false);
            this.Piano.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;

        #endregion

        private System.Windows.Forms.TabControl Modes;
        private System.Windows.Forms.TabPage Default;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.CheckBox Table;
        private System.Windows.Forms.CheckBox Mouse;
        private System.Windows.Forms.ComboBox Instrument;
        private System.Windows.Forms.Button Background;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddLeft;
        private System.Windows.Forms.Button AddRight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Left;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Right;
        private System.Windows.Forms.TabPage Piano;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pianoBackground;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox pianoTable;
    }
}