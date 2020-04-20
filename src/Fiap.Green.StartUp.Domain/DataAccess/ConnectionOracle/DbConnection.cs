using System.IO;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Fiap.Green.StartUp.DataAccess.ConnectionOracle
{
    public class DbConnection
    {

        private static string connectionString = "Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = oracle.fiap.com.br)(PORT = 1521)))(CONNECT_DATA = (SID = orcl)));Persist Security Info=True;User ID=RM81792;Password=021293;Pooling=True;Connection Timeout=60;";
        public OracleConnection GetConnection()  
        {  
            var conn = new OracleConnection(connectionString);  
            if (conn.State == ConnectionState.Closed)  
            {  
                conn.Open();  
            }  
            return conn;    
        }  

        public static void CloseConnection(OracleConnection conn)  
        {  
            if (conn.State == ConnectionState.Open || conn.State == ConnectionState.Broken)  
            {  
                conn.Close();  
            }  
        }  
    }
}