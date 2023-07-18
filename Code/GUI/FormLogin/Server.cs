using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;

namespace GUI.FormLogin
{
    public partial class Server : DevExpress.XtraEditors.XtraForm
    {
        public Server()
        {
            InitializeComponent();
        }
        Connection con = new Connection();
        string conect;
        private void btn_testconnect_Click(object sender, EventArgs e)
        {
            //CHAY.Show();
            conect = string.Format("Data Source={0};Initial Catalog={1};", txt_server.Text,txt_database.Text);
            if(string.IsNullOrEmpty(txt_user.Text))
            {
                conect += "Integrated Security=True";
            }
            else
            {
                conect += string.Format("Persist Security Info=True;User ID={0}; Password={1}",txt_user.Text,txt_pw.Text);
          
            }
            if (con.testConnection(conect))
                MessageBox.Show("Connection kết nối thành công");

            else MessageBox.Show("Lỗi Connection");
        }

        private void txt_server_Leave(object sender, EventArgs e)
        {
            //DataTable dt = con.getDatabase("select name from master.dbo.sysdatabases");
            //cb_Database.DataSource = dt;
            //cb_Database.DisplayMember = "name";

        }

        private void btn_saveconect_Click(object sender, EventArgs e)
        {
            // btn_saveconect_Click(sender,e);
            if (con.testConnection(conect))
            {
                if (string.IsNullOrEmpty(conect) == false)
                {
                    fLogin CHAY = new fLogin();
                    con.setConnection("GUI.Properties.Settings.phu29481_quanlyktxConnectionString", conect);
                    CHAY.ShowDialog();
                    
                }
               
            }
            else MessageBox.Show("Lỗi Connection");
        }

        private void Server_Load(object sender, EventArgs e)
        {
            cb_Authentication.Items.Add("Windows Authentication");
            cb_Authentication.Items.Add("SQL Server Authentication");
            cb_Authentication.SelectedIndex = 1;
            txt_user.Enabled = false;
            txt_pw.Enabled = false;
            txt_database.Enabled = false;
            txt_database.Text = "phu29481_quanlyktx";
            txt_server.Text = "112.78.2.154";
            txt_user.Text = "phu29481_quanlyktx";
            txt_pw.Text = "Minhbao@2001";

            //txt_database.Text = "QLKTX";
            //txt_server.Text = "MINHBAO-HUFI";
            //txt_user.Text = "sa";
            //txt_pw.Text = "123";


        }

        private void cb_Authentication_Leave(object sender, EventArgs e)
        {
           
                
        }

        private void cb_Authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Authentication.SelectedItem.ToString() == "SQL Server Authentication")
            {
                txt_user.Enabled = true;
                txt_pw.Enabled = true;
            }
            else
            {
                txt_user.Enabled = false;
                txt_pw.Enabled = false;
                txt_user.Text = string.Empty;
                txt_pw.Text = string.Empty;
            }
        }

        private void btn_suâNme_Click(object sender, EventArgs e)
        {
            txt_database.Enabled = true;
            txt_database.Text = string.Empty;

        }
    }
}
