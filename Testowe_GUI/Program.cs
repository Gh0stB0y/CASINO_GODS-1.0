﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testowe_GUI
{
    internal static class Program
    {
        //
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
      
        [STAThread]
        static void Main()
          
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_form());

        }
    }
}
