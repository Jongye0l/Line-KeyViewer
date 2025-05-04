using System;
using System.Drawing;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace LineKeyViewer
{
    public partial class Settings : Form
    {
        private App app;
       
        private bool key1_trigger = false;
        private bool key2_trigger = false;
        private bool key3_trigger = false;
        private bool key4_trigger = false;
        private bool key5_trigger = false;
        private bool key6_trigger = false;
        private bool key7_trigger = false;
        private bool key8_trigger = false;
        private bool key9_trigger = false;
        private bool key10_trigger = false;
        private bool key11_trigger = false;
        private bool key12_trigger = false;
        private bool key13_trigger = false;
        private bool key14_trigger = false;
        private bool key15_trigger = false;
        private bool key16_trigger = false;

        private ColorDialog color = new ColorDialog();
        private IKeyboardMouseEvents hook = Hook.GlobalEvents();

        public Settings(App app)
        {
            this.app = app;
            Location = new Point(app.Location.X + 25, app.Location.Y + 25);
            InitializeComponent();
            if (Properties.Settings.Default.pianoTable) pianoTable.Checked = true;
            pianoBackground.BackColor = Properties.Settings.Default.pianoBackground;
            button1.Text = Properties.Settings.Default.pianoKey1;
            button2.Text = Properties.Settings.Default.pianoKey2;
            button3.Text = Properties.Settings.Default.pianoKey3;
            button4.Text = Properties.Settings.Default.pianoKey4;
            button5.Text = Properties.Settings.Default.pianoKey5;
            button6.Text = Properties.Settings.Default.pianoKey6;
            button7.Text = Properties.Settings.Default.pianoKey7;
            button8.Text = Properties.Settings.Default.pianoKey8;
            button9.Text = Properties.Settings.Default.pianoKey9;
            button10.Text = Properties.Settings.Default.pianoKey10;
            button11.Text = Properties.Settings.Default.pianoKey11;
            button12.Text = Properties.Settings.Default.pianoKey12;
            button13.Text = Properties.Settings.Default.pianoKey13;
            button14.Text = Properties.Settings.Default.pianoKey14;
            button15.Text = Properties.Settings.Default.pianoKey15;
            button16.Text = Properties.Settings.Default.pianoKey16;

            KeyPreview = true;
            hook.KeyDown += Settings_KeyDown;
            Disposed += Settings_Disposed;
        }
        
        private void Settings_Disposed(object sender, EventArgs e)
        {
            hook.Dispose();
        }
        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            string keyCode = e.KeyCode.ToString();
            if (key1_trigger)
            {
                key1_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey1 = keyCode;
                    app.key1 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button1.Text = app.key1;
            }
            if (key2_trigger)
            {
                key2_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey2 = keyCode;
                    app.key2 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button2.Text = app.key2;
            }
            if (key3_trigger)
            {
                key3_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey3 = keyCode;
                    app.key3 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button3.Text = app.key3;
            }
            if (key4_trigger)
            {
                key4_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey4 = keyCode;
                    app.key4 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button4.Text = app.key4;
            }
            if (key5_trigger)
            {
                key5_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey5 = keyCode;
                    app.key5 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button5.Text = app.key5;
            }
            if (key6_trigger)
            {
                key6_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey6 = keyCode;
                    app.key6 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button6.Text = app.key6;
            }
            if (key7_trigger)
            {
                key7_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey7 = keyCode;
                    app.key7 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button7.Text = app.key7;
            }
            if (key8_trigger)
            {
                key8_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey8 = keyCode;
                    app.key8 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button8.Text = app.key8;
            }
            if (key9_trigger)
            {
                key9_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey9 = keyCode;
                    app.key9 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button9.Text = app.key9;
            }
            if (key10_trigger)
            {
                key10_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey10 = keyCode;
                    app.key10 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button10.Text = app.key10;
            }
            if (key11_trigger)
            {
                key11_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey11 = keyCode;
                    app.key11 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button11.Text = app.key11;
            }
            if (key12_trigger)
            {
                key12_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey12 = keyCode;
                    app.key12 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button12.Text = app.key12;
            }
            if (key13_trigger)
            {
                key13_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey13 = keyCode;
                    app.key13 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button13.Text = app.key13;
            }
            if (key14_trigger)
            {
                key14_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey14 = keyCode;
                    app.key14 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button14.Text = app.key14;
            }
            if (key15_trigger)
            {
                key15_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey15 = keyCode;
                    app.key15 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button15.Text = app.key15;
            }
            if (key16_trigger)
            {
                key16_trigger = false;
                if (keyCode != app.key1 && keyCode != app.key2 && keyCode != app.key3 && keyCode != app.key4 && keyCode != app.key5 && keyCode != app.key6 && keyCode != app.key7 && keyCode != app.key8 &&
                    keyCode != app.key9 && keyCode != app.key10 && keyCode != app.key11 && keyCode != app.key12 && keyCode != app.key13 && keyCode != app.key14 && keyCode != app.key15 && keyCode != app.key16)
                {
                    Properties.Settings.Default.pianoKey16 = keyCode;
                    app.key16 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button16.Text = app.key16;
            }
        }
        private void DisableTriggers()
        {
            if (key1_trigger)
            {
                key1_trigger = false;
                button1.Text = app.key1;
            }
            if (key2_trigger)
            {
                key2_trigger = false;
                button2.Text = app.key2;
            }
            if (key3_trigger)
            {
                key3_trigger = false;
                button3.Text = app.key3;
            }
            if (key4_trigger)
            {
                key4_trigger = false;
                button4.Text = app.key4;
            }
            if (key5_trigger)
            {
                key5_trigger = false;
                button5.Text = app.key5;
            }
            if (key6_trigger)
            {
                key6_trigger = false;
                button6.Text = app.key6;
            }
            if (key7_trigger)
            {
                key7_trigger = false;
                button7.Text = app.key7;
            }
            if (key8_trigger)
            {
                key8_trigger = false;
                button8.Text = app.key8;
            }
            if (key9_trigger)
            {
                key9_trigger = false;
                button9.Text = app.key9;
            }
            if (key10_trigger)
            {
                key10_trigger = false;
                button10.Text = app.key10;
            }
            if (key11_trigger)
            {
                key11_trigger = false;
                button11.Text = app.key11;
            }
            if (key12_trigger)
            {
                key12_trigger = false;
                button12.Text = app.key12;
            }
            if (key13_trigger)
            {
                key13_trigger = false;
                button13.Text = app.key13;
            }
            if (key14_trigger)
            {
                key14_trigger = false;
                button14.Text = app.key14;
            }
            if (key15_trigger)
            {
                key15_trigger = false;
                button15.Text = app.key15;
            }
            if (key16_trigger)
            {
                key16_trigger = false;
                button16.Text = app.key16;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key1_trigger = true;
            button1.Text = "*Press";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key2_trigger = true;
            button2.Text = "*Press";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key3_trigger = true;
            button3.Text = "*Press";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key4_trigger = true;
            button4.Text = "*Press";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key5_trigger = true;
            button5.Text = "*Press";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key6_trigger = true;
            button6.Text = "*Press";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key7_trigger = true;
            button7.Text = "*Press";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key8_trigger = true;
            button8.Text = "*Press";
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key9_trigger = true;
            button9.Text = "*Press";
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key10_trigger = true;
            button10.Text = "*Press";
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key11_trigger = true;
            button11.Text = "*Press";
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key12_trigger = true;
            button12.Text = "*Press";
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key13_trigger = true;
            button13.Text = "*Press";
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key14_trigger = true;
            button14.Text = "*Press";
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key15_trigger = true;
            button15.Text = "*Press";
        }
        
        private void button16_Click(object sender, EventArgs e)
        {
            DisableTriggers();
            key16_trigger = true;
            button16.Text = "*Press";
        }

        private void pianoBackground_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                pianoBackground.BackColor = color.Color;
                Properties.Settings.Default.pianoBackground = color.Color;
                Properties.Settings.Default.Save();
                app.Cat.BackColor = color.Color;
            }
        }

        private void pianoTable_CheckedChanged(object sender, EventArgs e)
        {
            if (pianoTable.Checked)
            {
                Properties.Settings.Default.pianoTable = true;
                Properties.Settings.Default.Save();
                app.table = true;
                app.TransparentTable(true);
            }
            else
            {
                Properties.Settings.Default.pianoTable = false;
                Properties.Settings.Default.Save();
                app.table = false;
                app.TransparentTable(false);
            }
        }
    }
}
