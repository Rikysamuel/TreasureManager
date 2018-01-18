using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureManager.Business.Utils
{
    public class TMConstants
    {
        public class ConnectionString
        {
            public static string NAME = "TreasureContext";
        }

        public class Table
        {
            public static string PROPERTY = "Property";
            public static string CONFIGURATION = "Configuration";
            public static string SAVINGS = "Savings";
            public static string EMPLOYEE = "Employee";
            public static string LOGINS = "Logins";
        }

        public class Form
        {
            public static int PROPERTY = 1;
            public static int SAVINGS = 2;
            public static int CONFIGURATION = 3;
            public static int EMPLOYEE = 4;
            public static int REFERENCES = 5;
            public static int LOGINS = 6;
        }

        public class Dialog
        {
            public static string DELETE = "Anda yakin ingin menghapus {0}?\nAksi tidak dapat di undo.";
            public static string MANY_SELECTION = "Silahkan pilih 1 row.";

            public class Captions
            {
                public static string WARNING = "WARNING";
            }
        }

        public class Properties
        {
            public class Savings
            {
                public static int DEBET = 0;
                public static int KREDIT = 1;
            }
        }
    }
}
