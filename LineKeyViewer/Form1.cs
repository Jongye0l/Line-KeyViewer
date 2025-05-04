using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Net;
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

        public string key1, key2, key3, key4, key5, key6, key7, key8, key9, key10, key11, key12, key13, key14, key15, key16;
        public bool table, headClick;

        private Bitmap bg = Properties.Resources.empty;
        private Bitmap front = Properties.Resources.empty;
        private bool korean = CultureInfo.CurrentCulture.Name == "ko-KR";

        public App() {
            Task.Run(CheckUpdates);
            Task.Run(CheckMods);
            InitializeComponent();

            KeyPreview = true;
            KeyDown += AppKeyDown;
            hook.KeyDown += HookKeyDown;
            hook.KeyUp += HookKeyUp;
            Disposed += OnDispose;

            Cat.Controls.Add(Hands);
            SetupMode();
            Task.Run(Winking);
        }

        private void OnDispose(object sender, EventArgs e) {
            hook.Dispose();
        }

        private async void CheckUpdates() {
            try {
                GitHubClient client = new GitHubClient(new ProductHeaderValue("Line-KeyViewer"));
                IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("Jongye0l", "Line-KeyViewer");
                string message = "";
                string version = 'v' + typeof(Program).Assembly.GetName().Version.ToString();
                for(int i = 0; releases[i].TagName != version; ++i) 
                    message += "\n" + releases[i].TagName + ":\n" + releases[i].Body + "\n";
                if(message != "") {
                    DialogResult result = MessageBox.Show(string.Format(korean ? "새 버전 발견:\n{0}\n새 버전으로 설치하시겠습니까?" : "Updates avaliable:\n{0}\nWould you like to download now?", message), "Line KeyViewer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if(result == DialogResult.Yes) System.Diagnostics.Process.Start("https://github.com/Jongye0l/Line-Keyviewer/releases/download/" + releases[0].TagName + "/LineKeyViewer.exe");
                }
            } catch {
                // ignored
            }
        }

        private async void CheckMods() {
            try {
                if(Properties.Settings.Default.NotificationMod) return;
                WebClient webClient = new WebClient();
                byte[] data = await webClient.DownloadDataTaskAsync("http://jalib.jongyeol.kr/modInfoV2/LineKeyViewer/latest/0");
                if(data[0] == 0) return;
                int size = data[1] << 24 | data[2] << 16 | data[3] << 8 | data[4];
                Console.WriteLine("Found string size :" + size);
                byte[] stringData = new byte[size];
                Array.Copy(data, 5, stringData, 0, size);
                string version = System.Text.Encoding.UTF8.GetString(stringData);
                DialogResult result = MessageBox.Show(string.Format(korean ? "얼불춤 모드 발견\n버전: {0}\n얼불춤 모드를 적용하시겠습니까?" : "Adofai mod available:\n{0}\nWould you like to apply mod now?", version), "Line KeyViewer Adofai Mods", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                if(result == DialogResult.Yes) System.Diagnostics.Process.Start("http://jalib.jongyeol.kr/modApplicator/LineKeyViewer/latest");
                else if(result == DialogResult.No) {
                    Properties.Settings.Default.NotificationMod = true;
                    Properties.Settings.Default.Save();
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        private void AppKeyDown(object sender, KeyEventArgs e) {
            if(e.KeyValue == 79) {
                Settings s = new Settings(this);
                s.Show();
            }
        }

        private async void Winking() {
            Random rnd = new Random();
            while(IsDisposed) {
                do {
                    await Task.Delay(rnd.Next(3000, 7000));
                } while(headClick);
                Cat.BackgroundImage = table ? Properties.Resources.line_wink : Properties.Resources.line_table_wink;
                await Task.Delay(rnd.Next(100, 250));
                if(!headClick) Cat.BackgroundImage = table ? Properties.Resources.line : Properties.Resources.line_table;
            }
        }

        public void TransparentTable(bool Value) {
            Cat.BackgroundImage = Value ?
                                      headClick ? Properties.Resources.empty : Properties.Resources.line :
                                      headClick ? Properties.Resources.table : Properties.Resources.line_table;
        }

        public void SetupMode() {
            Hands.Image = Impose(front, Properties.Resources.unpressed_right, 0, 0);
            Hands.Image = Impose(front, Properties.Resources.unpressed_left, 270, 0);
            right_pressed.Clear();
            left_pressed.Clear();
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
            Cat.BackColor = Properties.Settings.Default.pianoBackground;
            TransparentTable(Properties.Settings.Default.pianoTable);
            Cat.Image = Properties.Resources.piano;
            Cat.Update();
        }

        private async void HookKeyDown(object sender, KeyEventArgs e) {
            try {
                await Task.Yield();
                string keyCode = e.KeyCode.ToString();
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
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        private async void HookKeyUp(object sender, KeyEventArgs e) {
            try {
                await Task.Yield();
                string keyCode = e.KeyCode.ToString();
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
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }

        private void Press1() {
            if(!right_pressed.Contains(key1)) {
                right_pressed.Add(key1);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key1, 117, 232);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key1, 0, 0);
            }
        }

        private void Press2() {
            if(!right_pressed.Contains(key2)) {
                right_pressed.Add(key2);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key2, 151, 239);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key2, 0, 0);
            }
        }

        private void Press3() {
            if(!right_pressed.Contains(key3)) {
                right_pressed.Add(key3);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key3, 186, 246);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key3, 0, 0);
            }
        }

        private void Press4() {
            if(!right_pressed.Contains(key4)) {
                right_pressed.Add(key4);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key4, 217, 254);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key4, 0, 0);
            }
        }

        private void Press5() {
            if(!left_pressed.Contains(key5)) {
                left_pressed.Add(key5);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key5, 247, 262);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key5, headClick ? 0 : 270, 0);
            }
        }

        private void Press6() {
            if(!left_pressed.Contains(key6)) {
                left_pressed.Add(key6);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key6, 277, 269);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key6, headClick ? 0 : 270, 0);
            }
        }

        private void Press7() {
            if(!left_pressed.Contains(key7)) {
                left_pressed.Add(key7);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key7, 307, 275);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key7, headClick ? 0 : 270, 0);
            }
        }

        private void Press8() {
            if(!left_pressed.Contains(key8)) {
                left_pressed.Add(key8);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key8, 336, 283);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key8, headClick ? 0 : 270, 0);
            }
        }

        private void Press9() {
            if(!right_pressed.Contains(key9)) {
                right_pressed.Add(key9);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key9, 158, 215);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key9, 0, 0);
            }
        }

        private void Press10() {
            if(!right_pressed.Contains(key10)) {
                right_pressed.Add(key10);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key10, 185, 221);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key10, 0, 0);
            }
        }

        private void Press11() {
            if(!right_pressed.Contains(key11)) {
                right_pressed.Add(key11);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key11, 215, 227);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key11, 0, 0);
            }
        }

        private void Press12() {
            if(!right_pressed.Contains(key12)) {
                right_pressed.Add(key12);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key12, 244, 234);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key12, 0, 0);
            }
        }

        private void Press13() {
            if(!left_pressed.Contains(key13)) {
                left_pressed.Add(key13);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key13, 273, 240);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key13, headClick ? 0 : 270, 0);
            }
        }

        private void Press14() {
            if(!left_pressed.Contains(key14)) {
                left_pressed.Add(key14);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key14, 301, 247);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key14, headClick ? 0 : 270, 0);
            }
        }

        private void Press15() {
            if(!left_pressed.Contains(key15)) {
                left_pressed.Add(key15);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key15, 330, 254);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key15, headClick ? 0 : 270, 0);
            }
        }

        private void Press16() {
            if(!left_pressed.Contains(key16)) {
                left_pressed.Add(key16);
                Hands.BackgroundImage = Superimpose(bg, Properties.Resources.key16, 359, 261);
                Hands.Image = Impose(front, headClick ? Properties.Resources.line_head : Properties.Resources.pressed_key16, headClick ? 0 : 270, 0);
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
            if(headClick) {
                Hands.Image = Impose(front, Properties.Resources.line_head, 0, 0);
                return;
            }
            try {
                string k = right_pressed[right_pressed.Count - 1];
                Hands.Image = Impose(front, k == key1  ? Properties.Resources.pressed_key1 :
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
            if(headClick) {
                Hands.Image = Impose(front, Properties.Resources.line_head, 0, 0);
                return;
            }
            try {
                string k = left_pressed[left_pressed.Count - 1];
                Hands.Image = Impose(front, k == key5  ? Properties.Resources.pressed_key5 :
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