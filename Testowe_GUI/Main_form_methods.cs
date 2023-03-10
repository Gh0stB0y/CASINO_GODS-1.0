using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Testowe_GUI
{
    partial class Main_form : Form {
        //
        private void Open_new_form(Form New_form, object sender)
        {
            if (Active_form != null) { Active_form.TopMost = false; Active_form.Close(); }

            Active_form = New_form;
            New_form.TopMost = true;
            New_form.FormBorderStyle = FormBorderStyle.FixedSingle;
            New_form.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Clear();
            this.Main_panel.Controls.Add(New_form);
            this.Main_panel.Tag = New_form;
            New_form.BringToFront();
            New_form.Show();
        }
        private void Open_new_form(Form New_form)
        {
            if (Active_form != null) { Active_form.TopMost = false; Active_form.Close(); }
            Active_form = New_form;
            New_form.TopLevel = false;
            New_form.FormBorderStyle = FormBorderStyle.None;
            New_form.Dock = DockStyle.Fill;
            this.Main_panel.Controls.Add(New_form);
            this.Main_panel.Tag = New_form;
            New_form.BringToFront();
            New_form.Show();
        }
        public void play_music(string filename)
        {
            m_mediaPlayer = new MediaPlayer();
            m_mediaPlayer.Open(new Uri(filename));
            m_mediaPlayer.Play();
        }
        public void setVolume(int volume)
        {
            m_mediaPlayer.Volume = volume / 100.0f;
        }
        public int Get_min_form_size(){return Convert.ToInt32(min_size_to_resolution_ratio * 100);}
        public void set_form_size(int trackbar_val)
        {
            Size temp_size = this.Size;
            Point temp_location = this.Location;
            this.Bounds = new Rectangle(temp_location.X - (int)((Screen.PrimaryScreen.Bounds.Width * trackbar_val / 100)-temp_size.Width), temp_location.Y, (int)(Screen.PrimaryScreen.Bounds.Width * trackbar_val / 100), (int)(Screen.PrimaryScreen.Bounds.Height * trackbar_val / 100));              
        }
    }
}
