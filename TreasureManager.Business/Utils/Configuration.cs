using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreasureManager.Business.Manager;

namespace TreasureManager.Business.Utils
{
    public class Configuration
    {
        public static string PropertyId = ModuleManager.GetInstance()
            .Select(TMConstants.Table.CONFIGURATION, "\"Key\"='PropertyId'")
            .Rows[0][1].ToString()
            .Replace("[year]", DateTime.Now.Year.ToString("0000"))
            .Replace("[month]", DateTime.Now.Month.ToString("00"))
            .Replace("[day]", DateTime.Now.Date.ToString("dd"));

        public static string SavingsId = ModuleManager.GetInstance()
            .Select(TMConstants.Table.CONFIGURATION, "\"Key\"='SavingsId'")
            .Rows[0][1].ToString()
            .Replace("[year]", DateTime.Now.Year.ToString("0000"))
            .Replace("[month]", DateTime.Now.Month.ToString("00"))
            .Replace("[day]", DateTime.Now.Date.ToString("dd"));

        public static string EmployeeId = ModuleManager.GetInstance()
            .Select(TMConstants.Table.CONFIGURATION, "\"Key\"='EmployeeId'")
            .Rows[0][1].ToString()
            .Replace("[year]", DateTime.Now.Year.ToString("0000"))
            .Replace("[month]", DateTime.Now.Month.ToString("00"))
            .Replace("[day]", DateTime.Now.Date.ToString("dd"));

        public static string GetId(string key, string tableName, string idColumnName)
        {
            var id = 1;
            var Id = String.Empty;
            Id = ModuleManager.GetInstance()
                .Select(TMConstants.Table.CONFIGURATION, "\"Key\"='" + key +"'")
                .Rows[0][1].ToString()
                .Replace("[year]", DateTime.Now.Year.ToString("0000"))
                .Replace("[month]", DateTime.Now.Month.ToString("00"))
                .Replace("[day]", DateTime.Now.Date.ToString("dd"))
                .Replace("[no]", id.ToString("000"));

            while (ModuleManager.GetInstance().Select(tableName, "\"" + idColumnName + "\"='" + Id + "'").Rows.Count > 0)
            {
                id++;
                Id = ModuleManager.GetInstance()
                    .Select(TMConstants.Table.CONFIGURATION, "\"Key\"='" + key + "'")
                    .Rows[0][1].ToString()
                    .Replace("[year]", DateTime.Now.Year.ToString("0000"))
                    .Replace("[month]", DateTime.Now.Month.ToString("00"))
                    .Replace("[day]", DateTime.Now.Date.ToString("dd"))
                    .Replace("[no]", id.ToString("000"));
            }

            return Id;
        }
    }
}
