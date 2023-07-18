using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
  public  class Connection
    {
        SqlDataAdapter da;
        SqlConnection test;
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
       public string Connect()
        {
            string chuoiketnoi = getConnection("GUI.Properties.Settings.phu29481_quanlyktxConnectionString");
            return chuoiketnoi; //@"Data Source=112.78.2.154;Initial Catalog=phu29481_quanlyktx;Persist Security Info=True;User ID=phu29481_quanlyktx; Password=Minhbao@2001"; 
        }
        public string getConnection(string name)
        {
            return config.ConnectionStrings.ConnectionStrings[name].ConnectionString;
        }
        public void setConnection(string name,string vaule)
        {
            config.ConnectionStrings.ConnectionStrings[name].ConnectionString = vaule;
            config.ConnectionStrings.ConnectionStrings[name].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
        public bool testConnection(string con)
        {
            try {
                test = new SqlConnection(con);
                test.Open();
                test.Close();
                return true;
            
            
            }
            catch(SqlException sql) {

                return false;
            }
        }
        public DataTable getDatabase(string sql)
        {
            da = new SqlDataAdapter(sql, Connect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //public SqlDataAdapter getSqlDataAdapter(string sql)
        //{
        //    da = new SqlDataAdapter(sql, Connect());
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

    }
}
