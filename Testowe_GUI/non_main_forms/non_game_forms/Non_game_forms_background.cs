using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Testowe_GUI.non_main_forms.non_game_forms
{
    //
    public partial class Non_game_forms_background : Form
    {
        Main_form basic_form;
        public Non_game_forms_background(Main_form frm)
        {
            InitializeComponent();
            basic_form = frm;
        }

        private void Non_game_forms_background_Load(object sender, EventArgs e)
        {
            this.Size = Main_form.Form_size;

            settings_panel.BackColor = System.Drawing.Color.FromArgb(240, 0, 0, 0);
            settings_panel.Location = new Point(this.Width - settings_panel.Width, 0);
            settings_panel.Hide();

            volume_label.Font = form_size_label.Font;
            volume_trackbar.BackColor = form_size_trackbar.BackColor;
            volume_trackbar.Value = 50;
            volume_label.Text = "Głośność: " + volume_trackbar.Value;

            fullscreen_checkbox.Font = form_size_label.Font;
            fullscreen_checkbox.Padding = sound_checkbox.Padding;

            hide_settings_button.Font = form_size_label.Font;

            sound_checkbox.Font = form_size_label.Font;
            sound_checkbox.ForeColor = form_size_label.ForeColor;
            sound_checkbox.BackColor = form_size_trackbar.BackColor;

            non_game_panel.BackColor = System.Drawing.Color.FromArgb(125, 0, 0, 0);
            non_game_panel.Size = new Size(400, 450);
            non_game_panel.Location = new Point(this.Width / 2 - non_game_panel.Width / 2, this.Height / 2 - non_game_panel.Height / 2);
            non_game_panel.Anchor = AnchorStyles.None;

            setting_icon_button.Size = new Size(Main_form.settings_icon_size_pxl, Main_form.settings_icon_size_pxl);
            setting_icon_button.Location = new Point(this.Width - Main_form.settings_icon_size_pxl, 0);

            form_size_trackbar.Minimum = basic_form.Get_min_form_size();
            form_size_label.Text = "Rozmiar okna: " + form_size_trackbar.Value;
        }

        private void settings_icon_button_Click(object sender, EventArgs e)
        {
            setting_icon_button.Hide();
            settings_panel.Show();
            settings_panel.BringToFront();

        }

        private void form_size_trackbar_Scroll(object sender, EventArgs e)
        {
            form_size_label.Text = "Rozmiar okna: ";
        }
        private void sound_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            volume_panel.Enabled = !volume_panel.Enabled;
            if (volume_panel.Enabled) { basic_form.setVolume(volume_trackbar.Value); }
            else { basic_form.setVolume(0); }
        }
        private void fullscreen_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            form_size_panel.Enabled = !form_size_panel.Enabled;

            if (fullscreen_checkbox.Checked) {
                basic_form.FormBorderStyle = FormBorderStyle.None;
                basic_form.WindowState = FormWindowState.Maximized;
            }
            else {
                basic_form.WindowState = FormWindowState.Normal;
                basic_form.FormBorderStyle = FormBorderStyle.FixedSingle;
                basic_form.set_form_size(form_size_trackbar.Value);
            }
        }

        private void hide_settings_button_Click(object sender, EventArgs e)
        {
            settings_panel.Hide();
            setting_icon_button.BringToFront();
            setting_icon_button.Show();
        }

        private void volume_trackbar_Scroll(object sender, EventArgs e)
        {
            basic_form.setVolume(volume_trackbar.Value);
            volume_label.Text = "Głośność: " + volume_trackbar.Value;
        }

        private void form_size_trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            basic_form.set_form_size(form_size_trackbar.Value);
        }
        public void toggle_form_size_panel()
        {
        form_size_panel.Enabled = !form_size_panel.Enabled;
        }

        private void non_game_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
