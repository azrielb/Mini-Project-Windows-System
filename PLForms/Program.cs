using System;
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
            BL.IBL<List<Room>, List<Tour_Agency>, List<Reservation>> myBL = BL.FactoryBL.getBL;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(myBL));
        }
    }
}
