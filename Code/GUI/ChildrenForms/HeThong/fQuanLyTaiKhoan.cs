using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace GUI.ChildrenForms.HeThong
{
    public partial class fQuanLyTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt;
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dt = BLL_NGUOIDUNG.GetListUser();
            if (dt.Rows.Count == 0)
            {
                this.btn_sua.Enabled = false;
                this.btn_xoa.Enabled = false;
            }
            else
            {
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
            }

            this.DataGridView1.DataSource = dt;
            this.DataGridView1.Columns["DANGNHAPLANDAU"].Visible = false;
            this.DataGridView1.Columns["TENDN"].HeaderText = "Tên đăng nhập";
            this.DataGridView1.Columns["HO"].HeaderText = "Họ";
            this.DataGridView1.Columns["TEN"].HeaderText = "Tên";
            this.DataGridView1.Columns["QUYEN"].HeaderText = "Quyền";
            this.DataGridView1.Columns["MATKHAU"].HeaderText = "Mật khẩu";
        }

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
            DataBingDing(dt);
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.AllowUserToAddRows = false;
            btn_luu.Enabled = false;
        }
        void DataBingDing(DataTable pDT)
        {
            this.cb_quyen.DataBindings.Clear();
            this.txt_ho.DataBindings.Clear();
            this.txt_ten.DataBindings.Clear();
            this.txt_tenDN.DataBindings.Clear();
            this.txt_MK.DataBindings.Clear();
            //txt_quyen.DataBindings.Add("text", pDT, "QUYEN");
            this.cb_quyen.DataBindings.Add("text", pDT, "QUYEN");
            this.txt_ho.DataBindings.Add("text", pDT, "HO");
            this.txt_ten.DataBindings.Add("text", pDT, "TEN");
            this.txt_tenDN.DataBindings.Add("text", pDT, "TENDN");
            this.txt_MK.DataBindings.Add("text", pDT, "MATKHAU");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            this.btn_luu.Enabled = true;
            this.DataGridView1.AllowUserToAddRows = true;
            this.DataGridView1.ReadOnly = false;
            this.DataGridView1.Columns[0].ReadOnly = false;
            for (int i = 0; i < this.DataGridView1.Rows.Count - 1; i++)
            {
                DataGridView1.Rows[i].ReadOnly = true;
            }
            this.DataGridView1.FirstDisplayedScrollingRowIndex = this.DataGridView1.Rows.Count - 1;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            this.DataGridView1.ReadOnly = false;
            for (int i = 0; i < this.DataGridView1.Rows.Count - 1; i++)
                this.DataGridView1.Rows[i].ReadOnly = false;
            //this.DataGridView1.Columns[0].ReadOnly = true;
            this.DataGridView1.AllowUserToAddRows = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.DataGridView1.Rows.Remove(this.DataGridView1.CurrentRow);
                btn_luu_Click(sender, e);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txt_ho.Text == string.Empty)
                {
                    MessageBox.Show("Họ không được để trống");
                    txt_ho.Focus();
                    return;
                }
                if (txt_ten.Text == string.Empty)
                {
                    MessageBox.Show("Tên không được để trống");
                    txt_ten.Focus();
                    return;
                }
                if (txt_tenDN.Text == string.Empty)
                {
                    MessageBox.Show("Tên đăng nhập không được để trống");
                    txt_tenDN.Focus();
                    return;
                }
                if (txt_MK.Text == string.Empty)
                {
                    MessageBox.Show("Mật khẩu không được để trống");
                    txt_MK.Focus();
                    return;
                }
                if(cb_quyen.Text !="QLSV" && cb_quyen.Text != "QLDV" && cb_quyen.Text != "Admin")
                {
                    MessageBox.Show("Quyền không tồn tại");
                    return;
                }
                SqlDataAdapter da = new SqlDataAdapter("select * from NGUOIDUNG", new Connection().Connect() );
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("Lưu thành công");
                btn_luu.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Mã sinh viên bị trùng! Vui lòng thử lại!");
            }
        }

        //private void txt_quyen_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cb_quyen.Text = txt_quyen.Text;
        //        cb_quyen.SelectedItem = txt_quyen.Text;
        //    }
        //    catch
        //    {

        //    }
        //}
    }
}
