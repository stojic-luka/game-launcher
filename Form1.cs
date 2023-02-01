using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Transitions;

namespace Game_Launcher {
    public partial class Form1 : Form {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void drag_panel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        private void setup_window(object sender, EventArgs e) {
            this.AllowTransparency = false;
            top_panel.Size = new Size(this.Width, 70);
            side_game_panel.Size = new Size(65, this.Height - 70);
            add_launchers_button.Location = new Point(0, this.Height - 95);
            exit_button_panel.Location = new Point(this.Width - 46, 0);
            maximise_button_panel.Location = new Point(this.Width - 68, 0);
            minimise_button_panel.Location = new Point(this.Width - 90, 0);
            profile_picturebox.Location = new Point(this.Width - 41, 28);
            search_games_textbox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, search_games_textbox.Width, search_games_textbox.Height, 4, 4));
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 8, 8));
            search_games_textbox.AutoCompleteCustomSource.Clear();
            search_games_textbox.AutoCompleteCustomSource.AddRange(new string[] {
                "Steam",
                "Team Fortress 2",
                "Payday2",
                "Steam 2",
                "Pay to me",
                "Team crafted",
                "Team nesto, ne znam"
            });
        }
        private void load_apps() {
            show_all_games_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, show_all_games_panel.Width, show_all_games_panel.Height, 6, 6));
            using (StreamReader file = File.OpenText(@"apps.json")) {
                JObject jobject = JObject.Parse(file.ReadToEnd());
                List<string> app_list = jobject.Value<JArray>("apps").ToObject<List<string>>();
                foreach (string app_name in app_list) {
                    Panel panel = panel_creator(app_name);
                    int panel_num = side_game_panel.Controls.Count - 1;
                    panel.Location = new Point(8, panel_num * 49 + (panel_num + 1) * 8);
                    panel.BackColor = Color.MediumAquamarine;
                    side_game_panel.Controls.Add(panel);
                }
            }
        }
        public Form1() {
            InitializeComponent();
            load_apps();
        }
        
        FormWindowState state_before_minimize;
        private void navigation_button_label_MouseDown(object sender, MouseEventArgs e) { var pnl = ((Label)sender).Parent; pnl.Location = new Point(pnl.Location.X, pnl.Location.Y + 1); }
        private void navigation_button_label_MouseUp(object sender, MouseEventArgs e) { var pnl = ((Label)sender).Parent; if (pnl != null) pnl.Location = new Point(pnl.Location.X, pnl.Location.Y - 1); }
        private void exit_button_label_Click(object sender, EventArgs e) { this.Close(); Environment.Exit(0); }
        private void maximise_button_label_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = state_before_minimize;
            else if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }
        private void minimise_button_label_Click(object sender, EventArgs e) {
            state_before_minimize = this.WindowState;
            this.WindowState = FormWindowState.Minimized;
        }

        bool draging = false; int currentY, starting_panel_pos; byte movement_speed = 200;
        private void game_platform_panel_MouseDown(object sender, MouseEventArgs e) { draging = true; currentY = e.Y; starting_panel_pos = ((Panel)sender).Location.Y; ((Panel)sender).BringToFront(); }
        private void game_platform_panel_MouseUp(object sender, MouseEventArgs e) { draging = false; Transition.run(sender, "Top", starting_panel_pos, new TransitionType_EaseInEaseOut(movement_speed)); }
        private void game_platform_panel_MouseMove(object sender, MouseEventArgs e) {
            if (draging) {
                Panel current_panel = (Panel)sender, changing_panel;
                current_panel.Top = current_panel.Top + (e.Y - currentY);
                if (current_panel.Location.Y <= 56) { draging = false; Transition.run(current_panel, "Top", 65, new TransitionType_EaseInEaseOut(250)); }
                if (starting_panel_pos - 28 > current_panel.Location.Y) {
                    changing_panel = find_game_platform_panel_by_location(starting_panel_pos - 57, current_panel.Name);
                    if (changing_panel != null) {
                        Transition.run(changing_panel, "Top", starting_panel_pos, new TransitionType_EaseInEaseOut(movement_speed));
                        starting_panel_pos = changing_panel.Location.Y;
                    }
                } else if (starting_panel_pos + 28 < current_panel.Location.Y) {
                    changing_panel = find_game_platform_panel_by_location(starting_panel_pos + 57, current_panel.Name);
                    if (changing_panel != null) {
                        Transition.run(changing_panel, "Top", starting_panel_pos, new TransitionType_EaseInEaseOut(movement_speed));
                        starting_panel_pos = changing_panel.Location.Y;
                    }
                }
            }
        }
        private Panel find_game_platform_panel_by_location(int target_pos, string panel_name) {
            foreach (var p in side_game_panel.Controls.OfType<Control>().ToArray())
                if (p.Location.Y == target_pos && p.Name != "show_all_games_panel" && p.Name != panel_name)
                    return (Panel)p;
            return null;
        }

        private Panel panel_creator(string app_name) {
            var panel = new Panel();
            panel.Size = new Size(49, 49);
            panel.Name = app_name;
            panel.MouseDown += game_platform_panel_MouseDown;
            panel.MouseUp += game_platform_panel_MouseUp;
            panel.MouseMove += game_platform_panel_MouseMove;
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 6, 6));
            var pictureBox = new PictureBox();
            pictureBox.Location = new Point(5, 5);
            pictureBox.Size = new Size(39, 39);
            pictureBox.Enabled = false;
            panel.Controls.Add(pictureBox);
            return panel;
        }
    }
}
