﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BE;


namespace PLForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BL_ServiceReference.BL_SOAPClient myBL = new BL_ServiceReference.BL_SOAPClient();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(myBL));
        }
    }
}
