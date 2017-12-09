using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Library
{

    static class Program
    {


        public static Header HEADER = new Header();
        public static Title TITLE = new Title();
        public static Publication PUBLICATION = new Publication();
        public static OutputData OUTPUTDATA = new OutputData();
        public static Series SERIES = new Series();
        public static PhysicalCharacteristics PHCHARACTERISTICS = new PhysicalCharacteristics();
        public static StandardNumber STANDARDNUMBER = new StandardNumber();
       

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
            Application.Exit();
        }
    }
}
