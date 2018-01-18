using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;

namespace TreasureManager.Business.Utils
{
    public class Logs
    {
        private static string location = "Data\\Logs\\";

        public static void Debug(Exception ex)
        {
            var filename = location + "Logs-" + DateTime.Now.ToString("ddMMyyy") + ".txt";
            string[] lines = { DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss"), ex.ToString()};

            if (File.Exists(filename))
            {
                File.AppendAllLines(filename, lines);
            } else
            {

                File.WriteAllLines(filename, lines);
            }
        }
    }
}
