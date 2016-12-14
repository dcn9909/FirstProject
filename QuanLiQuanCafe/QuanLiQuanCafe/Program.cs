using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafe
{
    static class Program
    {
        /*
         * Code by DCN9909
         * 14/12/2016
         * Phan Mem Quan Ly Quan Cafe 
         */
         


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
