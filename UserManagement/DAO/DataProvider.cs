using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace User_Management.DAO
{ 
    public class DataProvider
    {
        private static DataProvider instance;
        string path = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = XE)))\" + \"; ";
        private static string connectionStr = "";
        public static DataProvider Instance 
        { 
            get {if (instance == null) instance = new DataProvider(); return DataProvider.instance;}
        }

        public string getConStr()
        {
            return connectionStr;
        }

        public void setConStr(string username, string password)
        {
            connectionStr = path + "User Id = " + username + ";password=" + password;
        }

        private DataProvider() {}

        public (bool, string) CreateConnection()
        {
            OracleConnection con = new OracleConnection(connectionStr);
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    return (true, "Connection successful!");
                }
                else
                {
                    return (false, "Connection failed!");
                }
            }
            catch (Exception ex)
            {
                return (false, "Connection failed! Exception: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable ExecQuery (string query)
        {
            DataTable dt = new DataTable();
            using (OracleConnection con = new OracleConnection(connectionStr))
            {
                con.Open();
                OracleCommand Command = new OracleCommand(query, con);

                OracleDataAdapter adapter = new OracleDataAdapter(Command);
                adapter.Fill(dt);
                con.Close();
            }
            return dt;
        }

        

        public void ExecuteOracleProcedure(string procedureName, OracleParameter[] parameters)
        {
            using (OracleConnection con = new OracleConnection(connectionStr))
            {
                con.Open();

                using (var command = new OracleCommand(procedureName, con))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                     
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
