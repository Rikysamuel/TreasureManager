using System;
using System.Data;
using Npgsql;
using TreasureManager.Business.Utils;

namespace TreasureManager.Business.Manager
{
    public class ModuleManager
    {
        private static ModuleManager instance;
        public static log4net.ILog log = log4net.LogManager.GetLogger("Module Manager");

        public static ModuleManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ModuleManager();
            }

            return instance;
        }

        private static NpgsqlConnection GetConnection()
        {
            return DbContext.GetConnection();
        }

        public DataTable Select(string from, string where = "", string select = "*")
        {
            try
            {
                var ds = new DataSet();

                string sql;
                if (String.IsNullOrEmpty(where))
                {
                    sql = "SELECT " + select + " FROM \"" + from + "\";";
                }
                else
                {
                    sql = "SELECT " + select + " FROM \"" + from + "\" WHERE " + where + ";";
                }

                var da = new NpgsqlDataAdapter(sql, GetConnection());
                ds.Reset();
                da.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                Logs.Debug(ex);
                return null;
            }
        }

        public void Insert(string table, string values)
        {
            try
            {
                string sql = "INSERT INTO \"" + table + "\" VALUES " + values + ";";
                var cmd = new NpgsqlCommand(sql, GetConnection());

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logs.Debug(ex);
            }
        }

        public void Delete(string table, string where)
        {
            try
            {
                string sql = "DELETE FROM \"" + table + "\" WHERE " + where + ";";
                var cmd = new NpgsqlCommand(sql, GetConnection());

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logs.Debug(ex);
            }
        }

        public void Update(string table, string set, string where)
        {
            try
            {
                string sql = "UPDATE \"" + table + "\" SET " + set + " WHERE " + where + ";";
                var cmd = new NpgsqlCommand(sql, GetConnection());

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logs.Debug(ex);
            }
        }
    }
}
