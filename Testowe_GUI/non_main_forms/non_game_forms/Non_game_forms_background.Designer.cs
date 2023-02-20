namespace Testowe_GUI.non_main_forms.non_game_forms
{
    partial class Non_game_forms_background
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
            this.non_game_panel = new System.Windows.Forms.Panel();
            this.setting_icon_button = new System.Windows.Forms.Button();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.hide_settings_button = new System.Windows.Forms.Button();
            this.fullscreen_checkbox = new System.Windows.Forms.CheckBox();
            this.sound_checkbox = new System.Windows.Forms.CheckBox();
            this.volume_panel = new System.Windows.Forms.Panel();
            this.volume_trackbar = new System.Windows.Forms.TrackBar();
            this.volume_label = new System.Windows.Forms.Label();
            this.form_size_panel = new System.Windows.Forms.Panel();
            this.form_size_label = new System.Windows.Forms.Label();
            this.form_size_trackbar = new System.Windows.Forms.TrackBar();
            this.settings_panel.SuspendLayout();
            this.volume_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackbar)).BeginInit();
            this.form_size_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form_size_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // non_game_panel
            // 
            this.non_game_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.non_game_panel.BackColor = System.Drawing.Color.DimGray;
            this.non_game_panel.Location = new System.Drawing.Point(260, 77);
            this.non_game_panel.Name = "non_game_panel";
            this.non_game_panel.Size = new System.Drawing.Size(400, 400);
            this.non_game_panel.TabIndex = 0;
            this.non_game_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.non_game_panel_Paint);
            // 
            // setting_icon_button
            // 
            this.setting_icon_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setting_icon_button.BackColor = System.Drawing.Color.Transparent;
            this.setting_icon_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.setting_icon_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting_icon_button.FlatAppearance.BorderSize = 0;
            this.setting_icon_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.setting_icon_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.setting_icon_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_icon_button.Image = global::Testowe_GUI.Properties.Resources.settings_64;
            this.setting_icon_button.Location = new System.Drawing.Point(828, 9);
            this.setting_icon_button.Margin = new System.Windows.Forms.Padding(0);
            this.setting_icon_button.Name = "setting_icon_button";
            this.setting_icon_button.Size = new System.Drawing.Size(64, 64);
            this.setting_icon_button.TabIndex = 0;
            this.setting_icon_button.UseMnemonic = false;
            this.setting_icon_button.UseVisualStyleBackColor = true;
            this.setting_icon_button.Click += new System.EventHandler(this.settings_icon_button_Click);
            // 
            // settings_panel
            // 
            this.settings_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings_panel.Controls.Add(this.hide_settings_button);
            this.settings_panel.Controls.Add(this.fullscreen_checkbox);
            this.settings_panel.Controls.Add(this.sound_checkbox);
            this.settings_panel.Controls.Add(this.volume_panel);
            this.settings_panel.Controls.Add(this.form_size_panel);
            this.settings_panel.ForeColor = System.Drawing.Color.Transparent;
            this.settings_panel.Location = new System.Drawing.Point(692, 77);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(200, 250);
            this.settings_panel.TabIndex = 1;
            // 
            // hide_settings_button
            // 
            this.hide_settings_button.BackColor = System.Drawing.Color.Transparent;
            this.hide_settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hide_settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide_settings_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hide_settings_button.FlatAppearance.BorderSize = 0;
            this.hide_settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hide_settings_button.Location = new System.Drawing.Point(0, 0);
            this.hide_settings_button.Name = "hide_settings_button";
            this.hide_settings_button.Size = new System.Drawing.Size(200, 40);
            this.hide_settings_button.TabIndex = 5;
            this.hide_settings_button.Text = "Zwiń menu";
            this.hide_settings_button.UseVisualStyleBackColor = false;
            this.hide_settings_button.Click += new System.EventHandler(this.hide_settings_button_Click);
            // 
            // fullscreen_checkbox
            // 
            this.fullscreen_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.fullscreen_checkbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fullscreen_checkbox.ForeColor = System.Drawing.Color.White;
            this.fullscreen_checkbox.Location = new System.Drawing.Point(0, 40);
            this.fullscreen_checkbox.Name = "fullscreen_checkbox";
            this.fullscreen_checkbox.Size = new System.Drawing.Size(200, 30);
            this.fullscreen_checkbox.TabIndex = 4;
            this.fullscreen_checkbox.Text = "Tryb pełnoekranowy";
            this.fullscreen_checkbox.UseVisualStyleBackColor = false;
            this.fullscreen_checkbox.CheckedChanged += new System.EventHandler(this.fullscreen_checkbox_CheckedChanged);
            // 
            // sound_checkbox
            // 
            this.sound_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.sound_checkbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sound_checkbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound_checkbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sound_checkbox.FlatAppearance.BorderSize = 0;
            this.sound_checkbox.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sound_checkbox.ForeColor = System.Drawing.Color.White;
            this.sound_checkbox.Location = new System.Drawing.Point(0, 70);
            this.sound_checkbox.Name = "sound_checkbox";
            this.sound_checkbox.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.sound_checkbox.Size = new System.Drawing.Size(200, 30);
            this.sound_checkbox.TabIndex = 3;
            this.sound_checkbox.Text = "Wycisz dźwięki";
            this.sound_checkbox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.sound_checkbox.UseVisualStyleBackColor = false;
            this.sound_checkbox.CheckedChanged += new System.EventHandler(this.sound_checkbox_CheckedChanged);
            // 
            // volume_panel
            // 
            this.volume_panel.BackColor = System.Drawing.Color.Transparent;
            this.volume_panel.Controls.Add(this.volume_trackbar);
            this.volume_panel.Controls.Add(this.volume_label);
            this.volume_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.volume_panel.Location = new System.Drawing.Point(0, 100);
            this.volume_panel.Name = "volume_panel";
            this.volume_panel.Size = new System.Drawing.Size(200, 75);
            this.volume_panel.TabIndex = 2;
            // 
            // volume_trackbar
            // 
            this.volume_trackbar.BackColor = System.Drawing.Color.Black;
            this.volume_trackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volume_trackbar.LargeChange = 1;
            this.volume_trackbar.Location = new System.Drawing.Point(0, 30);
            this.volume_trackbar.Maximum = 100;
            this.volume_trackbar.Name = "volume_trackbar";
            this.volume_trackbar.Size = new System.Drawing.Size(200, 45);
            this.volume_trackbar.TabIndex = 1;
            this.volume_trackbar.TickFrequency = 0;
            this.volume_trackbar.Value = 50;
            this.volume_trackbar.Scroll += new System.EventHandler(this.volume_trackbar_Scroll);
            // 
            // volume_label
            // 
            this.volume_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.volume_label.Location = new System.Drawing.Point(0, 0);
            this.volume_label.Name = "volume_label";
            this.volume_label.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.volume_label.Size = new System.Drawing.Size(200, 30);
            this.volume_label.TabIndex = 0;
            this.volume_label.Text = "Głośność:    ";
            this.volume_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form_size_panel
            // 
            this.form_size_panel.Controls.Add(this.form_size_label);
            this.form_size_panel.Controls.Add(this.form_size_trackbar);
            this.form_size_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.form_size_panel.Location = new System.Drawing.Point(0, 175);
            this.form_size_panel.Name = "form_size_panel";
            this.form_size_panel.Size = new System.Drawing.Size(200, 75);
            this.form_size_panel.TabIndex = 1;
            // 
            // form_size_label
            // 
            this.form_size_label.BackColor = System.Drawing.Color.Transparent;
            this.form_size_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_size_label.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_size_label.ForeColor = System.Drawing.Color.White;
            this.form_size_label.Location = new System.Drawing.Point(0, 0);
            this.form_size_label.Name = "form_size_label";
            this.form_size_label.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.form_size_label.Size = new System.Drawing.Size(200, 30);
            this.form_size_label.TabIndex = 1;
            this.form_size_label.Text = "Rozmiar okna: ";
            this.form_size_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form_size_trackbar
            // 
            this.form_size_trackbar.BackColor = System.Drawing.Color.Black;
            this.form_size_trackbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.form_size_trackbar.LargeChange = 1;
            this.form_size_trackbar.Location = new System.Drawing.Point(0, 30);
            this.form_size_trackbar.Maximum = 100;
            this.form_size_trackbar.Name = "form_size_trackbar";
            this.form_size_trackbar.Size = new System.Drawing.Size(200, 45);
            this.form_size_trackbar.TabIndex = 0;
            this.form_size_trackbar.TickFrequency = 0;
            this.form_size_trackbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.form_size_trackbar.Value = 65;
            this.form_size_trackbar.Scroll += new System.EventHandler(this.form_size_trackbar_Scroll);
            this.form_size_trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_size_trackbar_MouseUp);
            // 
            // Non_game_forms_background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Testowe_GUI.Properties.Resources.casino_roulette_cards_dice_chips_slot_machine_background_3d_illustration_505080_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 551);
            this.ControlBox = false;
            this.Controls.Add(this.settings_panel);
            this.Controls.Add(this.setting_icon_button);
            this.Controls.Add(this.non_game_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Non_game_forms_background";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Non_game_forms_background";
            this.Load += new System.EventHandler(this.Non_game_forms_background_Load);
            this.settings_panel.ResumeLayout(false);
            this.volume_panel.ResumeLayout(false);
            this.volume_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackbar)).EndInit();
            this.form_size_panel.ResumeLayout(false);
            this.form_size_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form_size_trackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel non_game_panel;
        private System.Windows.Forms.Button setting_icon_button;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.TrackBar form_size_trackbar;
        private System.Windows.Forms.Panel form_size_panel;
        private System.Windows.Forms.Label form_size_label;
        private System.Windows.Forms.Panel volume_panel;
        private System.Windows.Forms.Label volume_label;
        private System.Windows.Forms.TrackBar volume_trackbar;
        public System.Windows.Forms.CheckBox sound_checkbox;
        private System.Windows.Forms.CheckBox fullscreen_checkbox;
        private System.Windows.Forms.Button hide_settings_button;
    }
}