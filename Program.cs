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

            Utils.Euclids.Add(0, new Euclid(0.0, 1.0));
            Utils.Euclids.Add(30, new Euclid(0.5, 0.866025403784439));
            Utils.Euclids.Add(60, new Euclid(0.866025403784439, 0.5));
            Utils.Euclids.Add(90, new Euclid(1.0, 0.0));
            Utils.Euclids.Add(120, new Euclid(0.866025403784439, -0.5));
            Utils.Euclids.Add(150, new Euclid(0.5, -0.866025403784439));
            Utils.Euclids.Add(180, new Euclid(0.0, -1.0));
            Utils.Euclids.Add(210, new Euclid(-0.5, -0.866025403784439));
            Utils.Euclids.Add(240, new Euclid(-0.866025403784439, -0.5));
            Utils.Euclids.Add(270, new Euclid(-1.0, 0.0));
            Utils.Euclids.Add(300, new Euclid(-0.866025403784439, 0.5));
            Utils.Euclids.Add(330, new Euclid(-0.5, 0.866025403784439));
            Utils.Euclids.Add(360, new Euclid(0.0, 1.0));



            Application.Run(new Win());
        }
    }
}
