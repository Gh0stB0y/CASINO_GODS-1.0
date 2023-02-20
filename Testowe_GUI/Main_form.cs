using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testowe_GUI.non_main_forms.non_game_forms;
using System.Windows.Media;
using System.IO;

namespace Testowe_GUI
{    
    public partial class Main_form : Form
    {
        public MediaPlayer m_mediaPlayer;
        public const double size_to_resolution_ratio = 0.65;
        public const double min_size_to_resolution_ratio = 0.5;
        private static double Screen_Width = Screen.PrimaryScreen.Bounds.Width;
        private static double Screen_Height = Screen.PrimaryScreen.Bounds.Height;
        private static double aspect_ratio = Screen_Width/ Screen_Height;
        private static FormWindowState last_window_state = FormWindowState.Normal;
        public const int settings_icon_size_pxl = 64;
        public static Size settings_window_size=new Size(125,200);
        public static bool Current_window_maximized { get; set; }
        private static bool Last_window_maximized { get; set; }
        public static Size Form_size { get; private set; } 
        static Form Active_form = null;
        
        public Main_form()
        {
            //
            InitializeComponent();
            this.Size = new System.Drawing.Size((int)(Screen.PrimaryScreen.Bounds.Width * size_to_resolution_ratio), (int)(Screen.PrimaryScreen.Bounds.Height * size_to_resolution_ratio));
            this.MinimumSize = new System.Drawing.Size((int)(Screen.PrimaryScreen.Bounds.Width * min_size_to_resolution_ratio), (int)(Screen.PrimaryScreen.Bounds.Height * min_size_to_resolution_ratio));
            Form_size = new Size(Main_panel.Size.Width,Main_panel.Size.Height);
            //play_music(@"F:\C#\PIERWSZY PROJEKT\Testowe_GUI\Testowe_GUI\Menu_music.wav");
            play_music(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Music_menu.mp3"));
        }
        private void Main_form_Load(object sender, EventArgs e)
        {
            
            Open_new_form(new Non_game_forms_background(this),Main_panel);
        }

    }
}

