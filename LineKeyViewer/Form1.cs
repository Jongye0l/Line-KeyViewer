using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using Octokit;

namespace LineKeyViewer {
    public partial class App : Form {
        private IKeyboardMouseEvents hook = Hook.GlobalEvents();

        private StringCollection right_pressed = new StringCollection();
        private StringCollection left_pressed = new StringCollection();

        private string mode = Properties.Settings.Default.Mode;

        public string key1, key2, key3, key4, key5, key6, key7, key8, key9, key10, key11, key12, key13, key14, key15, key16;
        public StringCollection right = new StringCollection();
        public StringCollection left = new StringCollection();
        public bool mouse, table, headClick;

        private Bitmap bg = Properties.Resources.empty;
        private Bitmap front = Properties.Resources.empty;

        public App() {
            CheckUpdates();
            InitializeComponent();

            KeyPreview = true;
            KeyDown += AppKeyDown;
            hook.KeyDown += HookKeyDown;
            hook.KeyUp += HookKeyUp;
            hook.MouseDown += HookMouseDown;
            hook.MouseUp += HookMouseUp;

            Cat.Controls.Add(Hands);
            SetMode(mode);
            Winking();
        }

        private void CheckUpdates() {
            Task.Run(async () => {
                try {
                    GitHubClient client = new GitHubClient(new ProductHeaderValue("Line-KeyViewer"));
                    IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("Jongye0l", "Line-KeyViewer");
                    string message = "";
                    string version = 'v' + typeof(Program).Assembly.GetName().Version.ToString();
                    for(int i = 0; releases[i].TagName != version; ++i) 
                        message += "\n" + releases[i].TagName + ":\n" + releases[i].Body + "\n";
                    if(message != "") {
                        DialogResult result = MessageBox.Show("Updates avaliable:\n" + message + "\nWould you like to download now?", "Line KeyViewer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if(result == DialogResult.Yes) System.Diagnostics.Process.Start("https://github.com/Jongye0l/Line-Keyviewer/releases/download/" + releases[0].TagName + "/LineKeyViewer.exe");
                    }
                } catch {
                    // ignored
                }
            });
        }

        private void AppKeyDown(object sender, KeyEventArgs e) {
            if(e.KeyValue == 79) {
                Settings s = new Settings(this);
                s.Show();
            }
        }

        private void Winking() {
            Task.Run(async () => {
                Random rnd = new Random();
                while(Thread.CurrentThread.IsAlive) {
                    do {
                        await Task.Delay(rnd.Next(3000, 7000));
                    } while(headClick);
                    Cat.BackgroundImage = table ? Properties.Resources.line_wink : Properties.Resources.line_table_wink;
                    await Task.Delay(rnd.Next(100, 250));
                    if(!headClick) Cat.BackgroundImage = table ? Properties.Resources.line : Properties.Resources.line_table;
                }
            });
        }

        public void SetInstrument(string Instrument) {
            switch(Instrument) {
                case "None": Cat.Image = null; break;
                case "Bongo": Cat.Image = Properties.Resources.bongo; break;
                case "Keyboard": Cat.Image = Properties.Resources.keyboard; break;
                case "Controller": Cat.Image = Properties.Resources.controller; break;
                case "Piano": Cat.Image = Properties.Resources.piano; break;
            }
            Cat.Update();
        }

        public void TransparentTable(bool Value) {
            Cat.BackgroundImage = Value ?
                                      headClick ? Properties.Resources.empty : Properties.Resources.line :
                                      headClick ? Properties.Resources.table : Properties.Resources.line_table;
        }

        public void SetMode(string mode) {
            Hands.Image = Impose(front, Properties.Resources.unpressed_right, 0, 0);
            Hands.Image = Impose(front, Properties.Resources.unpressed_left, 270, 0);
            right_pressed.Clear();
            left_pressed.Clear();
            switch(mode) {
                case "Default":
                    this.mode = "Default";
                    right.Clear();
                    left.Clear();
                    foreach(string s in Properties.Settings.Default.defaultRight) right.Add(s);
                    foreach(string s in Properties.Settings.Default.defaultLeft) left.Add(s);
                    mouse = Properties.Settings.Default.defaultMouse;
                    table = Properties.Settings.Default.defaultTable;

                    Cat.BackColor = Properties.Settings.Default.defaultBackground;
                    TransparentTable(Properties.Settings.Default.defaultTable);
                    SetInstrument(Properties.Settings.Default.defaultInstrument);
                    break;
                case "Piano":
                    this.mode = "Piano";
                    key1 = Properties.Settings.Default.pianoKey1;
                    key2 = Properties.Settings.Default.pianoKey2;
                    key3 = Properties.Settings.Default.pianoKey3;
                    key4 = Properties.Settings.Default.pianoKey4;
                    key5 = Properties.Settings.Default.pianoKey5;
                    key6 = Properties.Settings.Default.pianoKey6;
                    key7 = Properties.Settings.Default.pianoKey7;
                    key8 = Properties.Settings.Default.pianoKey8;
                    key9 = Properties.Settings.Default.pianoKey9;
                    key10 = Properties.Settings.Default.pianoKey10;
                    key11 = Properties.Settings.Default.pianoKey11;
                    key12 = Properties.Settings.Default.pianoKey12;
                    key13 = Properties.Settings.Default.pianoKey13;
                    key14 = Properties.Settings.Default.pianoKey14;
                    key15 = Properties.Settings.Default.pianoKey15;
                    key16 = Properties.Settings.Default.pianoKey16;
                    table = Properties.Settings.Default.pianoTable;
                    mouse = false;

                    Cat.BackColor = Properties.Settings.Default.pianoBackground;
                    TransparentTable(Properties.Settings.Default.pianoTable);
                    SetInstrument("Piano");
                    break;
            }
        }

        private void RightHandPress(string Key) {
            if(!right_pressed.Contains(Key)) {
                right_pressed.Add(Key);
                Hands.Image = Impose(front, Properties.Resources.pressed_right_wave, 0, 0);
                Task.Run(async () => {
                    await Task.Delay(100);
                    if(right_pressed.Count > 0) Hands.Image = Impose(front, Properties.Resources.pressed_right, 0, 0);
                    else Hands.Image = Impose(front, Properties.Resources.unpressed_right, 0, 0);
                });
            }

        }

        private void LeftHandPress(string Key) {
            if(!left_pressed.Contains(Key)) {
                left_pressed.Add(Key);
                Hands.Image = Impose(front, Properties.Resources.pressed_left_wave, 270, 0);
                Task.Run(async () => {
                    await Task.Delay(100);
                    if(left_pressed.Count > 0) Hands.Image = Impose(front, Properties.Resources.pressed_left, 270, 0);
                    else Hands.Image = Impose(front, Properties.Resources.unpressed_left, 270, 0);
                });
            }

        }

        private void RightHandUnpress(string Key) {
            right_pressed.Remove(Key);
            if(right_pressed.Count == 0) Hands.Image = Impose(front, Properties.Resources.unpressed_right, 0, 0);
        }

        private void LeftHandUnpress(string Key) {
            left_pressed.Remove(Key);
            if(left_pressed.Count == 0) Hands.Image = Impose(front, Properties.Resources.unpressed_left, 270, 0);
        }

        private void HookKeyDown(object sender, KeyEventArgs e) {
            string keyCode = e.KeyCode.ToString();
            switch(mode) {
                case "Default":
                    if(right.Contains(keyCode)) RightHandPress(keyCode);
                    if(left.Contains(keyCode)) LeftHandPress(keyCode);
                    break;
                case "Piano":
                    if(key1 == keyCode) Press1();
                    if(key2 == keyCode) Press2();
                    if(key3 == keyCode) Press3();
                    if(key4 == keyCode) Press4();
                    if(key5 == keyCode) Press5();
                    if(key6 == keyCode) Press6();
                    if(key7 == keyCode) Press7();
                    if(key8 == keyCode) Press8();
                    if(key9 == keyCode) Press9();
                    if(key10 == keyCode) Press10();
                    if(key11 == keyCode) Press11();
                    if(key12 == keyCode) Press12();
                    if(key13 == keyCode) Press13();
                    if(key14 == keyCode) Press14();
                    if(key15 == keyCode) Press15();
                    if(key16 == keyCode) Press16();
                    CheckHeadClick();
                    break;
            }
        }

        private void HookKeyUp(object sender, KeyEventArgs e) {
            string keyCode = e.KeyCode.ToString();
            switch(mode) {
                case "Default":
                    if(right_pressed.Contains(keyCode)) RightHandUnpress(keyCode);
                    if(left_pressed.Contains(keyCode)) LeftHandUnpress(keyCode);
                    break;
                case "Piano":
                    if(key1 == keyCode && right_pressed.Contains(key1)) UnPress1();
                    if(key2 == keyCode && right_pressed.Contains(key2)) UnPress2();
                    if(key3 == keyCode && right_pressed.Contains(key3)) UnPress3();
                    if(key4 == keyCode && right_pressed.Contains(key4)) UnPress4();
                    if(key5 == keyCode && left_pressed.Contains(key5)) UnPress5();
                    if(key6 == keyCode && left_pressed.Contains(key6)) UnPress6();
                    if(key7 == keyCode && left_pressed.Contains(key7)) UnPress7();
                    if(key8 == keyCode && left_pressed.Contains(key8)) UnPress8();
                    if(key9 == keyCode && right_pressed.Contains(key9)) UnPress9();
                    if(key10 == keyCode && right_pressed.Contains(key10)) UnPress10();
                    if(key11 == keyCode && right_pressed.Contains(key11)) UnPress11();
                    if(key12 == keyCode && right_pressed.Contains(key12)) UnPress12();
                    if(key13 == keyCode && left_pressed.Contains(key13)) UnPress13();
                    if(key14 == keyCode && left_pressed.Contains(key14)) UnPress14();
                    if(key15 == keyCode && left_pressed.Contains(key15)) UnPress15();
                    if(key16 == keyCode && left_pressed.Contains(key16)) UnPress16();
                    CheckHeadClick();
                    break;
            }
        }

        private void HookMouseDown(object sender, MouseEventArgs e) {
            if(mode != "Default") return;
            if(mouse) {
                if(e.Button == MouseButtons.Left) RightHandPress(e.Button.ToString());
                if(e.Button == MouseButtons.Right) LeftHandPress(e.Button.ToString());
            }
        }

        private void HookMouseUp(object sender, MouseEventArgs e) {
            if(right_pressed.Contains(e.Button.ToString())) RightHandUnpress(e.Button.ToString());
            if(left_pressed.Contains(e.Button.ToString())) LeftHandUnpress(e.Button.ToString());
        }

        private void Press1() {
            if(!right_pressed.Contains(key1)) {
                right_pressed.Add(key1);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key1, 117, 232);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key1, 0, 0);
            }
        }

        private void Press2() {
            if(!right_pressed.Contains(key2)) {
                right_pressed.Add(key2);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key2, 151, 239);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key2, 0, 0);
            }
        }

        private void Press3() {
            if(!right_pressed.Contains(key3)) {
                right_pressed.Add(key3);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key3, 186, 246);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key3, 0, 0);
            }
        }

        private void Press4() {
            if(!right_pressed.Contains(key4)) {
                right_pressed.Add(key4);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key4, 217, 254);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key4, 0, 0);
            }
        }

        private void Press5() {
            if(!left_pressed.Contains(key5)) {
                left_pressed.Add(key5);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key5, 247, 262);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key5, 270, 0);
            }
        }

        private void Press6() {
            if(!left_pressed.Contains(key6)) {
                left_pressed.Add(key6);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key6, 277, 269);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key6, 270, 0);
            }
        }

        private void Press7() {
            if(!left_pressed.Contains(key7)) {
                left_pressed.Add(key7);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key7, 307, 275);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key7, 270, 0);
            }
        }

        private void Press8() {
            if(!left_pressed.Contains(key8)) {
                left_pressed.Add(key8);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key8, 336, 283);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key8, 270, 0);
            }
        }

        private void Press9() {
            if(!right_pressed.Contains(key9)) {
                right_pressed.Add(key9);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key9, 158, 215);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key9, 0, 0);
            }
        }

        private void Press10() {
            if(!right_pressed.Contains(key10)) {
                right_pressed.Add(key10);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key10, 185, 221);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key10, 0, 0);
            }
        }

        private void Press11() {
            if(!right_pressed.Contains(key11)) {
                right_pressed.Add(key11);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key11, 215, 227);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key11, 0, 0);
            }
        }

        private void Press12() {
            if(!right_pressed.Contains(key12)) {
                right_pressed.Add(key12);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key12, 244, 234);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key12, 0, 0);
            }
        }

        private void Press13() {
            if(!left_pressed.Contains(key13)) {
                left_pressed.Add(key13);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key13, 273, 240);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key13, 270, 0);
            }
        }

        private void Press14() {
            if(!left_pressed.Contains(key14)) {
                left_pressed.Add(key14);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key14, 301, 247);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key14, 270, 0);
            }
        }

        private void Press15() {
            if(!left_pressed.Contains(key15)) {
                left_pressed.Add(key15);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key15, 330, 254);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key15, 270, 0);
            }
        }

        private void Press16() {
            if(!left_pressed.Contains(key16)) {
                left_pressed.Add(key16);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key16, 359, 261);
                if(!headClick) Hands.Image = Impose(front, Properties.Resources.pressed_key16, 270, 0);
            }
        }

        private void CheckHeadClick() {
            if((right_pressed.Count >= 8 || right_pressed.Contains(key1) && right_pressed.Contains(key2) && right_pressed.Contains(key3) && right_pressed.Contains(key4)) &&
               (left_pressed.Count >= 8 || left_pressed.Contains(key5) && left_pressed.Contains(key6) && left_pressed.Contains(key7) && left_pressed.Contains(key8))) {
                if(headClick) return;
                headClick = true;
                TransparentTable(Properties.Settings.Default.pianoTable);
                Hands.Image = Impose(front, Properties.Resources.line_head, 0, 0);
            } else if(headClick) {
                headClick = false;
                TransparentTable(Properties.Settings.Default.pianoTable);
                PressLastRight();
                PressLastLeft();
            }
        }

        private void UnPress1() {
            right_pressed.Remove(key1);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key1, 117, 232);
            PressLastRight();
        }

        private void UnPress2() {
            right_pressed.Remove(key2);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key2, 151, 239);
            PressLastRight();
        }

        private void UnPress3() {
            right_pressed.Remove(key3);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key3, 186, 246);
            PressLastRight();
        }

        private void UnPress4() {
            right_pressed.Remove(key4);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key4, 217, 254);
            PressLastRight();
        }

        private void UnPress5() {
            left_pressed.Remove(key5);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key5, 247, 262);
            PressLastLeft();
        }

        private void UnPress6() {
            left_pressed.Remove(key6);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key6, 277, 269);
            PressLastLeft();
        }

        private void UnPress7() {
            left_pressed.Remove(key7);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key7, 307, 275);
            PressLastLeft();
        }

        private void UnPress8() {
            left_pressed.Remove(key8);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key8, 336, 283);
            PressLastLeft();
        }

        private void UnPress9() {
            right_pressed.Remove(key9);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key9, 158, 215);
            PressLastRight();
        }

        private void UnPress10() {
            right_pressed.Remove(key10);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key10, 185, 221);
            PressLastRight();
        }

        private void UnPress11() {
            right_pressed.Remove(key11);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key11, 215, 227);
            PressLastRight();
        }

        private void UnPress12() {
            right_pressed.Remove(key12);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key12, 244, 234);
            PressLastRight();
        }

        private void UnPress13() {
            left_pressed.Remove(key13);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key13, 273, 240);
            PressLastLeft();
        }

        private void UnPress14() {
            left_pressed.Remove(key14);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key14, 301, 247);
            PressLastLeft();
        }

        private void UnPress15() {
            left_pressed.Remove(key15);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key15, 330, 254);
            PressLastLeft();
        }

        private void UnPress16() {
            left_pressed.Remove(key16);
            Hands.BackgroundImage = UnSuperimpose(bg, Properties.Resources.key16, 359, 261);
            PressLastLeft();
        }

        private void PressLastRight() {
            if(headClick) return;
            try {
                string k = right_pressed[right_pressed.Count - 1];
                Impose(front, k == key1  ? Properties.Resources.pressed_key1 :
                              k == key2  ? Properties.Resources.pressed_key2 :
                              k == key3  ? Properties.Resources.pressed_key3 :
                              k == key4  ? Properties.Resources.pressed_key4 :
                              k == key9  ? Properties.Resources.pressed_key9 :
                              k == key10 ? Properties.Resources.pressed_key10 :
                              k == key11 ? Properties.Resources.pressed_key11 :
                              k == key12 ? Properties.Resources.pressed_key12 : Properties.Resources.unpressed_right, 0, 0);
            } catch {
                Hands.Image = Impose(front, Properties.Resources.unpressed_right, 0, 0);
            }
        }

        private void PressLastLeft() {
            if(headClick) return;
            try {
                string k = left_pressed[left_pressed.Count - 1];
                Impose(front, k == key5  ? Properties.Resources.pressed_key5 :
                              k == key6  ? Properties.Resources.pressed_key6 :
                              k == key7  ? Properties.Resources.pressed_key7 :
                              k == key8  ? Properties.Resources.pressed_key8 :
                              k == key13 ? Properties.Resources.pressed_key13 :
                              k == key14 ? Properties.Resources.pressed_key14 :
                              k == key15 ? Properties.Resources.pressed_key15 :
                              k == key16 ? Properties.Resources.pressed_key16 : Properties.Resources.unpressed_left, 270, 0);
            } catch {
                Hands.Image = Impose(front, Properties.Resources.unpressed_left, 270, 0);
            }
        }

        private Bitmap Superimpose(Bitmap largeBmp, Bitmap smallBmp, int x, int y) {
            Graphics g = Graphics.FromImage(largeBmp);
            g.CompositingMode = CompositingMode.SourceOver;
            smallBmp.MakeTransparent();
            g.DrawImageUnscaled(smallBmp, new Point(x, y));
            return largeBmp;
        }

        private Bitmap Impose(Bitmap largeBmp, Bitmap smallBmp, int x, int y) {
            Graphics g = Graphics.FromImage(largeBmp);
            g.CompositingMode = CompositingMode.SourceCopy;
            g.DrawImageUnscaled(smallBmp, new Point(x, y));
            return largeBmp;
        }

        private Bitmap UnSuperimpose(Bitmap largeBpm, Bitmap smallBpm, int x, int y) {
            for(int i = 0; i < smallBpm.Width; i++) {
                for(int j = 0; j < smallBpm.Height; j++) {
                    if(x + i >= 0 && x + i < largeBpm.Width && y + j >= 0 && y + j < largeBpm.Height && smallBpm.GetPixel(i, j).A != 0) {
                        largeBpm.SetPixel(x + i, j + y, Color.Transparent);
                    }
                }
            }
            return largeBpm;
        }
    }
}