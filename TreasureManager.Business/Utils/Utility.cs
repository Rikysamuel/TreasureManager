using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TreasureManager.Business.DataModel;
using TreasureManager.Business.Manager;

namespace TreasureManager.Business.Utils
{
    public class Utility
    {
        public static string Escape(string unescapedString)
        {
            return HttpUtility.HtmlEncode(unescapedString);
        }

        public static List<Employee> GetEmployees()
        {
            var list = new List<Employee>();

            var employee = new Employee()
            {
                Value = "-",
                Text = "None"
            };

            list.Add(employee);

            string selection = "\"UserId\", \"Name\"";
            var dt = ModuleManager.GetInstance().Select(TMConstants.Table.EMPLOYEE, "", selection);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Employee()
                {
                    Value = row[0].ToString(),
                    Text = row[1].ToString()
                });
            }

            return list;
        }

        public static string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}
