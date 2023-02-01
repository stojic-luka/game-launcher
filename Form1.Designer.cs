
namespace Game_Launcher {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.profile_name_label = new System.Windows.Forms.Label();
            this.profile_picturebox = new System.Windows.Forms.Panel();
            this.search_games_textbox = new System.Windows.Forms.TextBox();
            this.drag_panel = new System.Windows.Forms.Panel();
            this.minimise_button_panel = new System.Windows.Forms.Panel();
            this.minimise_button_label = new System.Windows.Forms.Label();
            this.maximise_button_panel = new System.Windows.Forms.Panel();
            this.maximise_button_label = new System.Windows.Forms.Label();
            this.exit_button_panel = new System.Windows.Forms.Panel();
            this.exit_button_label = new System.Windows.Forms.Label();
            this.side_game_panel = new System.Windows.Forms.Panel();
            this.add_launchers_button = new System.Windows.Forms.Button();
            this.show_all_games_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pages_browser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.drag_panel.SuspendLayout();
            this.minimise_button_panel.SuspendLayout();
            this.maximise_button_panel.SuspendLayout();
            this.exit_button_panel.SuspendLayout();
            this.side_game_panel.SuspendLayout();
            this.show_all_games_panel.SuspendLayout();
            this.pages_browser.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.top_panel.Controls.Add(this.button1);
            this.top_panel.Controls.Add(this.profile_name_label);
            this.top_panel.Controls.Add(this.profile_picturebox);
            this.top_panel.Controls.Add(this.search_games_textbox);
            this.top_panel.Controls.Add(this.drag_panel);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1419, 70);
            this.top_panel.TabIndex = 0;
            // 
            // profile_name_label
            // 
            this.profile_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_name_label.Location = new System.Drawing.Point(1168, 28);
            this.profile_name_label.Name = "profile_name_label";
            this.profile_name_label.Size = new System.Drawing.Size(205, 35);
            this.profile_name_label.TabIndex = 8;
            this.profile_name_label.Text = "profile username";
            this.profile_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // profile_picturebox
            // 
            this.profile_picturebox.BackColor = System.Drawing.SystemColors.Control;
            this.profile_picturebox.Location = new System.Drawing.Point(1377, 28);
            this.profile_picturebox.Name = "profile_picturebox";
            this.profile_picturebox.Size = new System.Drawing.Size(35, 35);
            this.profile_picturebox.TabIndex = 7;
            // 
            // search_games_textbox
            // 
            this.search_games_textbox.AutoCompleteCustomSource.AddRange(new string[] {
            "steam",
            "epic games",
            "battle.net",
            "counter strike global offensive",
            "payday 2"});
            this.search_games_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.search_games_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.search_games_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_games_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_games_textbox.Location = new System.Drawing.Point(65, 35);
            this.search_games_textbox.Name = "search_games_textbox";
            this.search_games_textbox.Size = new System.Drawing.Size(295, 22);
            this.search_games_textbox.TabIndex = 3;
            // 
            // drag_panel
            // 
            this.drag_panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.drag_panel.Controls.Add(this.minimise_button_panel);
            this.drag_panel.Controls.Add(this.maximise_button_panel);
            this.drag_panel.Controls.Add(this.exit_button_panel);
            this.drag_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drag_panel.Location = new System.Drawing.Point(0, 0);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(1419, 23);
            this.drag_panel.TabIndex = 2;
            this.drag_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_panel_MouseDown);
            // 
            // minimise_button_panel
            // 
            this.minimise_button_panel.BackColor = System.Drawing.SystemColors.Control;
            this.minimise_button_panel.Controls.Add(this.minimise_button_label);
            this.minimise_button_panel.Location = new System.Drawing.Point(1310, 0);
            this.minimise_button_panel.Name = "minimise_button_panel";
            this.minimise_button_panel.Size = new System.Drawing.Size(21, 21);
            this.minimise_button_panel.TabIndex = 7;
            // 
            // minimise_button_label
            // 
            this.minimise_button_label.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimise_button_label.ForeColor = System.Drawing.Color.Black;
            this.minimise_button_label.Location = new System.Drawing.Point(2, 2);
            this.minimise_button_label.Name = "minimise_button_label";
            this.minimise_button_label.Size = new System.Drawing.Size(20, 20);
            this.minimise_button_label.TabIndex = 1;
            this.minimise_button_label.Tag = "";
            this.minimise_button_label.Text = "--";
            this.minimise_button_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimise_button_label.Click += new System.EventHandler(this.minimise_button_label_Click);
            this.minimise_button_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigation_button_label_MouseDown);
            this.minimise_button_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navigation_button_label_MouseUp);
            // 
            // maximise_button_panel
            // 
            this.maximise_button_panel.BackColor = System.Drawing.SystemColors.Control;
            this.maximise_button_panel.Controls.Add(this.maximise_button_label);
            this.maximise_button_panel.Location = new System.Drawing.Point(1339, 0);
            this.maximise_button_panel.Name = "maximise_button_panel";
            this.maximise_button_panel.Size = new System.Drawing.Size(21, 21);
            this.maximise_button_panel.TabIndex = 6;
            // 
            // maximise_button_label
            // 
            this.maximise_button_label.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximise_button_label.ForeColor = System.Drawing.Color.Black;
            this.maximise_button_label.Location = new System.Drawing.Point(1, 1);
            this.maximise_button_label.Name = "maximise_button_label";
            this.maximise_button_label.Size = new System.Drawing.Size(20, 20);
            this.maximise_button_label.TabIndex = 1;
            this.maximise_button_label.Tag = "";
            this.maximise_button_label.Text = "⬜";
            this.maximise_button_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maximise_button_label.Click += new System.EventHandler(this.maximise_button_label_Click);
            this.maximise_button_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigation_button_label_MouseDown);
            this.maximise_button_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navigation_button_label_MouseUp);
            // 
            // exit_button_panel
            // 
            this.exit_button_panel.BackColor = System.Drawing.SystemColors.Control;
            this.exit_button_panel.Controls.Add(this.exit_button_label);
            this.exit_button_panel.Location = new System.Drawing.Point(1366, 0);
            this.exit_button_panel.Name = "exit_button_panel";
            this.exit_button_panel.Size = new System.Drawing.Size(45, 21);
            this.exit_button_panel.TabIndex = 5;
            // 
            // exit_button_label
            // 
            this.exit_button_label.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button_label.ForeColor = System.Drawing.Color.Black;
            this.exit_button_label.Location = new System.Drawing.Point(2, 2);
            this.exit_button_label.Name = "exit_button_label";
            this.exit_button_label.Size = new System.Drawing.Size(43, 18);
            this.exit_button_label.TabIndex = 0;
            this.exit_button_label.Tag = "";
            this.exit_button_label.Text = "X";
            this.exit_button_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_button_label.Click += new System.EventHandler(this.exit_button_label_Click);
            this.exit_button_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navigation_button_label_MouseDown);
            this.exit_button_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navigation_button_label_MouseUp);
            // 
            // side_game_panel
            // 
            this.side_game_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.side_game_panel.Controls.Add(this.add_launchers_button);
            this.side_game_panel.Controls.Add(this.show_all_games_panel);
            this.side_game_panel.Location = new System.Drawing.Point(0, 70);
            this.side_game_panel.Name = "side_game_panel";
            this.side_game_panel.Size = new System.Drawing.Size(65, 515);
            this.side_game_panel.TabIndex = 1;
            // 
            // add_launchers_button
            // 
            this.add_launchers_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.add_launchers_button.FlatAppearance.BorderSize = 0;
            this.add_launchers_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_launchers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_launchers_button.Location = new System.Drawing.Point(0, 486);
            this.add_launchers_button.Name = "add_launchers_button";
            this.add_launchers_button.Size = new System.Drawing.Size(65, 25);
            this.add_launchers_button.TabIndex = 0;
            this.add_launchers_button.Text = "+";
            this.add_launchers_button.UseVisualStyleBackColor = false;
            // 
            // show_all_games_panel
            // 
            this.show_all_games_panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.show_all_games_panel.Controls.Add(this.label1);
            this.show_all_games_panel.Location = new System.Drawing.Point(8, 8);
            this.show_all_games_panel.Name = "show_all_games_panel";
            this.show_all_games_panel.Size = new System.Drawing.Size(49, 49);
            this.show_all_games_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "all";
            // 
            // pages_browser
            // 
            this.pages_browser.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.pages_browser.Controls.Add(this.tabPage1);
            this.pages_browser.Controls.Add(this.tabPage2);
            this.pages_browser.ItemSize = new System.Drawing.Size(10, 10);
            this.pages_browser.Location = new System.Drawing.Point(71, 76);
            this.pages_browser.Name = "pages_browser";
            this.pages_browser.SelectedIndex = 0;
            this.pages_browser.Size = new System.Drawing.Size(1341, 496);
            this.pages_browser.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.pages_browser.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 14);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1333, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 14);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1333, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1423, 584);
            this.Controls.Add(this.pages_browser);
            this.Controls.Add(this.side_game_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "w";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Resize += new System.EventHandler(this.setup_window);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.drag_panel.ResumeLayout(false);
            this.minimise_button_panel.ResumeLayout(false);
            this.maximise_button_panel.ResumeLayout(false);
            this.exit_button_panel.ResumeLayout(false);
            this.side_game_panel.ResumeLayout(false);
            this.show_all_games_panel.ResumeLayout(false);
            this.show_all_games_panel.PerformLayout();
            this.pages_browser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel side_game_panel;
        private System.Windows.Forms.Panel show_all_games_panel;
        private System.Windows.Forms.Panel drag_panel;
        private System.Windows.Forms.Panel exit_button_panel;
        private System.Windows.Forms.Label exit_button_label;
        private System.Windows.Forms.Panel minimise_button_panel;
        private System.Windows.Forms.Label minimise_button_label;
        private System.Windows.Forms.Panel maximise_button_panel;
        private System.Windows.Forms.Label maximise_button_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_launchers_button;
        private System.Windows.Forms.TextBox search_games_textbox;
        private System.Windows.Forms.Panel profile_picturebox;
        private System.Windows.Forms.Label profile_name_label;
        private System.Windows.Forms.TabControl pages_browser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}

