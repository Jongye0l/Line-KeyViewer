using System;
using System.Drawing;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace LineKeyViewer {
    public partial class Settings : Form {
        private App app;

        private bool key1_trigger;
        private bool key2_trigger;
        private bool key3_trigger;
        private bool key4_trigger;
        private bool key5_trigger;
        private bool key6_trigger;
        private bool key7_trigger;
        private bool key8_trigger;
        private bool key9_trigger;
        private bool key10_trigger;
        private bool key11_trigger;
        private bool key12_trigger;
        private bool key13_trigger;
        private bool key14_trigger;
        private bool key15_trigger;
        private bool key16_trigger;
        private bool isSpace;

        private ColorDialog color = new ColorDialog();
        private IKeyboardMouseEvents hook = Hook.GlobalEvents();

        public Settings(App app) {
            this.app = app;
            Location = new Point(app.Location.X + 25, app.Location.Y + 25);
            InitializeComponent();
            if(Properties.Settings.Default.pianoTable) pianoTable.Checked = true;
            pianoBackground.BackColor = Properties.Settings.Default.pianoBackground;
            button1.Text = ((Keys) Properties.Settings.Default.pianoKey1).ToString();
            button2.Text = ((Keys) Properties.Settings.Default.pianoKey2).ToString();
            button3.Text = ((Keys) Properties.Settings.Default.pianoKey3).ToString();
            button4.Text = ((Keys) Properties.Settings.Default.pianoKey4).ToString();
            button5.Text = ((Keys) Properties.Settings.Default.pianoKey5).ToString();
            button6.Text = ((Keys) Properties.Settings.Default.pianoKey6).ToString();
            button7.Text = ((Keys) Properties.Settings.Default.pianoKey7).ToString();
            button8.Text = ((Keys) Properties.Settings.Default.pianoKey8).ToString();
            button9.Text = ((Keys) Properties.Settings.Default.pianoKey9).ToString();
            button10.Text = ((Keys) Properties.Settings.Default.pianoKey10).ToString();
            button11.Text = ((Keys) Properties.Settings.Default.pianoKey11).ToString();
            button12.Text = ((Keys) Properties.Settings.Default.pianoKey12).ToString();
            button13.Text = ((Keys) Properties.Settings.Default.pianoKey13).ToString();
            button14.Text = ((Keys) Properties.Settings.Default.pianoKey14).ToString();
            button15.Text = ((Keys) Properties.Settings.Default.pianoKey15).ToString();
            button16.Text = ((Keys) Properties.Settings.Default.pianoKey16).ToString();

            toolStripStatusLabel1.Text = (app.korean ? "버전 " : "Version ") + typeof(Program).Assembly.GetName().Version;
            if(app.korean) {
                groupBox3.Text = "기본 키";
                groupBox4.Text = "아래쪽 키";
                label12.Text = "배경 색";
                pianoTable.Text = "책상 가리기";
                Text = "설정";
            }

            KeyPreview = true;
            hook.KeyDown += Settings_KeyDown;
            Disposed += Settings_Disposed;
        }

        private void Settings_Disposed(object sender, EventArgs e) {
            hook.Dispose();
        }

        private void ChangeKey(int fromKey, int toKey) {
            if(app.key1 == fromKey) {
                Properties.Settings.Default.pianoKey1 = toKey;
                app.key1 = toKey;
                button1.Text = ((Keys) toKey).ToString();
            } else if(app.key2 == fromKey) {
                Properties.Settings.Default.pianoKey2 = toKey;
                app.key2 = toKey;
                button2.Text = ((Keys) toKey).ToString();
            } else if(app.key3 == fromKey) {
                Properties.Settings.Default.pianoKey3 = toKey;
                app.key3 = toKey;
                button3.Text = ((Keys) toKey).ToString();
            } else if(app.key4 == fromKey) {
                Properties.Settings.Default.pianoKey4 = toKey;
                app.key4 = toKey;
                button4.Text = ((Keys) toKey).ToString();
            } else if(app.key5 == fromKey) {
                Properties.Settings.Default.pianoKey5 = toKey;
                app.key5 = toKey;
                button5.Text = ((Keys) toKey).ToString();
            } else if(app.key6 == fromKey) {
                Properties.Settings.Default.pianoKey6 = toKey;
                app.key6 = toKey;
                button6.Text = ((Keys) toKey).ToString();
            } else if(app.key7 == fromKey) {
                Properties.Settings.Default.pianoKey7 = toKey;
                app.key7 = toKey;
                button7.Text = ((Keys) toKey).ToString();
            } else if(app.key8 == fromKey) {
                Properties.Settings.Default.pianoKey8 = toKey;
                app.key8 = toKey;
                button8.Text = ((Keys) toKey).ToString();
            } else if(app.key9 == fromKey) {
                Properties.Settings.Default.pianoKey9 = toKey;
                app.key9 = toKey;
                button9.Text = ((Keys) toKey).ToString();
            } else if(app.key10 == fromKey) {
                Properties.Settings.Default.pianoKey10 = toKey;
                app.key10 = toKey;
                button10.Text = ((Keys) toKey).ToString();
            } else if(app.key11 == fromKey) {
                Properties.Settings.Default.pianoKey11 = toKey;
                app.key11 = toKey;
                button11.Text = ((Keys) toKey).ToString();
            } else if(app.key12 == fromKey) {
                Properties.Settings.Default.pianoKey12 = toKey;
                app.key12 = toKey;
                button12.Text = ((Keys) toKey).ToString();
            } else if(app.key13 == fromKey) {
                Properties.Settings.Default.pianoKey13 = toKey;
                app.key13 = toKey;
                button13.Text = ((Keys) toKey).ToString();
            } else if(app.key14 == fromKey) {
                Properties.Settings.Default.pianoKey14 = toKey;
                app.key14 = toKey;
                button14.Text = ((Keys) toKey).ToString();
            } else if(app.key15 == fromKey) {
                Properties.Settings.Default.pianoKey15 = toKey;
                app.key15 = toKey;
                button15.Text = ((Keys) toKey).ToString();
            } else if(app.key16 == fromKey) {
                Properties.Settings.Default.pianoKey16 = toKey;
                app.key16 = toKey;
                button16.Text = ((Keys) toKey).ToString();
            }
        }

        private void Settings_KeyDown(object sender, KeyEventArgs e) {
            int keyCode = e.KeyValue;
            if(e.KeyCode == Keys.Space || e.KeyCode == Keys.Return) isSpace = true;
            if(key1_trigger) {
                key1_trigger = false;
                if(keyCode != app.key1) {
                    ChangeKey(keyCode, app.key1);
                    Properties.Settings.Default.pianoKey1 = keyCode;
                    app.key1 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button1.Text = ((Keys) app.key1).ToString();
            } else if(key2_trigger) {
                key2_trigger = false;
                if(keyCode != app.key2) {
                    ChangeKey(keyCode, app.key2);
                    Properties.Settings.Default.pianoKey2 = keyCode;
                    app.key2 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button2.Text = ((Keys) app.key2).ToString();
            } else if(key3_trigger) {
                key3_trigger = false;
                if(keyCode != app.key3) {
                    ChangeKey(keyCode, app.key3);
                    Properties.Settings.Default.pianoKey3 = keyCode;
                    app.key3 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button3.Text = ((Keys) app.key3).ToString();
            } else if(key4_trigger) {
                key4_trigger = false;
                if(keyCode != app.key4) {
                    ChangeKey(keyCode, app.key4);
                    Properties.Settings.Default.pianoKey4 = keyCode;
                    app.key4 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button4.Text = ((Keys) app.key4).ToString();
            } else if(key5_trigger) {
                key5_trigger = false;
                if(keyCode != app.key5) {
                    ChangeKey(keyCode, app.key5);
                    Properties.Settings.Default.pianoKey5 = keyCode;
                    app.key5 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button5.Text = ((Keys) app.key5).ToString();
            } else if(key6_trigger) {
                key6_trigger = false;
                if(keyCode != app.key6) {
                    ChangeKey(keyCode, app.key6);
                    Properties.Settings.Default.pianoKey6 = keyCode;
                    app.key6 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button6.Text = ((Keys) app.key6).ToString();
            } else if(key7_trigger) {
                key7_trigger = false;
                if(keyCode != app.key7) {
                    ChangeKey(keyCode, app.key7);
                    Properties.Settings.Default.pianoKey7 = keyCode;
                    app.key7 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button7.Text = ((Keys) app.key7).ToString();
            } else if(key8_trigger) {
                key8_trigger = false;
                if(keyCode != app.key8) {
                    ChangeKey(keyCode, app.key8);
                    Properties.Settings.Default.pianoKey8 = keyCode;
                    app.key8 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button8.Text = ((Keys) app.key8).ToString();
            } else if(key9_trigger) {
                key9_trigger = false;
                if(keyCode != app.key9) {
                    ChangeKey(keyCode, app.key9);
                    Properties.Settings.Default.pianoKey9 = keyCode;
                    app.key9 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button9.Text = ((Keys) app.key9).ToString();
            } else if(key10_trigger) {
                key10_trigger = false;
                if(keyCode != app.key10) {
                    ChangeKey(keyCode, app.key10);
                    Properties.Settings.Default.pianoKey10 = keyCode;
                    app.key10 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button10.Text = ((Keys) app.key10).ToString();
            } else if(key11_trigger) {
                key11_trigger = false;
                if(keyCode != app.key11) {
                    ChangeKey(keyCode, app.key11);
                    Properties.Settings.Default.pianoKey11 = keyCode;
                    app.key11 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button11.Text = ((Keys) app.key11).ToString();
            } else if(key12_trigger) {
                key12_trigger = false;
                if(keyCode != app.key12) {
                    ChangeKey(keyCode, app.key12);
                    Properties.Settings.Default.pianoKey12 = keyCode;
                    app.key12 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button12.Text = ((Keys) app.key12).ToString();
            } else if(key13_trigger) {
                key13_trigger = false;
                if(keyCode != app.key13) {
                    ChangeKey(keyCode, app.key13);
                    Properties.Settings.Default.pianoKey13 = keyCode;
                    app.key13 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button13.Text = ((Keys) app.key13).ToString();
            } else if(key14_trigger) {
                key14_trigger = false;
                if(keyCode != app.key14) {
                    ChangeKey(keyCode, app.key14);
                    Properties.Settings.Default.pianoKey14 = keyCode;
                    app.key14 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button14.Text = ((Keys) app.key14).ToString();
            } else if(key15_trigger) {
                key15_trigger = false;
                if(keyCode != app.key15) {
                    ChangeKey(keyCode, app.key15);
                    Properties.Settings.Default.pianoKey15 = keyCode;
                    app.key15 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button15.Text = ((Keys) app.key15).ToString();
            } else if(key16_trigger) {
                key16_trigger = false;
                if(keyCode != app.key16) {
                    ChangeKey(keyCode, app.key16);
                    Properties.Settings.Default.pianoKey16 = keyCode;
                    app.key16 = keyCode;
                    Properties.Settings.Default.Save();
                }
                button16.Text = ((Keys) app.key16).ToString();
            }
        }

        private void DisableTriggers() {
            if(key1_trigger) {
                key1_trigger = false;
                button1.Text = ((Keys) app.key1).ToString();
            } else if(key2_trigger) {
                key2_trigger = false;
                button2.Text = ((Keys) app.key2).ToString();
            } else if(key3_trigger) {
                key3_trigger = false;
                button3.Text = ((Keys) app.key3).ToString();
            } else if(key4_trigger) {
                key4_trigger = false;
                button4.Text = ((Keys) app.key4).ToString();
            } else if(key5_trigger) {
                key5_trigger = false;
                button5.Text = ((Keys) app.key5).ToString();
            } else if(key6_trigger) {
                key6_trigger = false;
                button6.Text = ((Keys) app.key6).ToString();
            } else if(key7_trigger) {
                key7_trigger = false;
                button7.Text = ((Keys) app.key7).ToString();
            } else if(key8_trigger) {
                key8_trigger = false;
                button8.Text = ((Keys) app.key8).ToString();
            } else if(key9_trigger) {
                key9_trigger = false;
                button9.Text = ((Keys) app.key9).ToString();
            } else if(key10_trigger) {
                key10_trigger = false;
                button10.Text = ((Keys) app.key10).ToString();
            } else if(key11_trigger) {
                key11_trigger = false;
                button11.Text = ((Keys) app.key11).ToString();
            } else if(key12_trigger) {
                key12_trigger = false;
                button12.Text = ((Keys) app.key12).ToString();
            } else if(key13_trigger) {
                key13_trigger = false;
                button13.Text = ((Keys) app.key13).ToString();
            } else if(key14_trigger) {
                key14_trigger = false;
                button14.Text = ((Keys) app.key14).ToString();
            } else if(key15_trigger) {
                key15_trigger = false;
                button15.Text = ((Keys) app.key15).ToString();
            } else if(key16_trigger) {
                key16_trigger = false;
                button16.Text = ((Keys) app.key16).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key1_trigger = true;
            button1.Text = "*Press";
        }

        private void button2_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key2_trigger = true;
            button2.Text = "*Press";
        }

        private void button3_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key3_trigger = true;
            button3.Text = "*Press";
        }

        private void button4_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key4_trigger = true;
            button4.Text = "*Press";
        }

        private void button5_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key5_trigger = true;
            button5.Text = "*Press";
        }

        private void button6_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key6_trigger = true;
            button6.Text = "*Press";
        }

        private void button7_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key7_trigger = true;
            button7.Text = "*Press";
        }

        private void button8_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key8_trigger = true;
            button8.Text = "*Press";
        }

        private void button9_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key9_trigger = true;
            button9.Text = "*Press";
        }

        private void button10_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key10_trigger = true;
            button10.Text = "*Press";
        }

        private void button11_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key11_trigger = true;
            button11.Text = "*Press";
        }

        private void button12_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key12_trigger = true;
            button12.Text = "*Press";
        }

        private void button13_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key13_trigger = true;
            button13.Text = "*Press";
        }

        private void button14_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key14_trigger = true;
            button14.Text = "*Press";
        }

        private void button15_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key15_trigger = true;
            button15.Text = "*Press";
        }

        private void button16_Click(object sender, EventArgs e) {
            if(isSpace) {
                isSpace = false;
                return;
            }
            DisableTriggers();
            key16_trigger = true;
            button16.Text = "*Press";
        }

        private void pianoBackground_Click(object sender, EventArgs e) {
            if(color.ShowDialog() == DialogResult.OK) {
                pianoBackground.BackColor = color.Color;
                Properties.Settings.Default.pianoBackground = color.Color;
                Properties.Settings.Default.Save();
                app.Cat.BackColor = color.Color;
            }
        }

        private void pianoTable_CheckedChanged(object sender, EventArgs e) {
            if(pianoTable.Checked) {
                Properties.Settings.Default.pianoTable = true;
                Properties.Settings.Default.Save();
                app.table = true;
                app.TransparentTable(true);
            } else {
                Properties.Settings.Default.pianoTable = false;
                Properties.Settings.Default.Save();
                app.table = false;
                app.TransparentTable(false);
            }
        }
    }
}