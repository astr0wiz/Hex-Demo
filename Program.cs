using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hex1.core;

namespace Hex1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Utils.Directions.Add(new Hex(1, 0, -1));
            Utils.Directions.Add(new Hex(1, -1, 0));
            Utils.Directions.Add(new Hex(0, -1, 1));
            Utils.Directions.Add(new Hex(-1, 0, 1));
            Utils.Directions.Add(new Hex(-1, 1, 0));
            Utils.Directions.Add(new Hex(0, 1, -1));

            double rad = Math.PI / 180.0;
            for (int m = 0; m < 6; m++)
            {
                int deg = m * 60; // + (isPointyTop ? 30 : 0);
                Utils.Euclids.Add(deg, new Euclid(Math.Sin(deg * rad), Math.Cos(deg * rad)));
            }



            Application.Run(new Win());
        }
    }
}
