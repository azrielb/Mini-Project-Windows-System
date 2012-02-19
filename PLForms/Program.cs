using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BE;

namespace PLForms
{
    /// <summary>
    /// Written by:
    /// Azriel Berger - ID no. 039677588
    /// Daniel Tal-Or - ID no. 330970591
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BL.IBL<List<Room>, List <Tour_Agency>, List<Reservation>> myBL = BL.FactoryBL.getBL;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main((BL.BL_imp)myBL));
        }
    }
}
