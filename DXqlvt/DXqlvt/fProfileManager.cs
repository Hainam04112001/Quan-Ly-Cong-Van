using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DXqlvt.DTO;

namespace DXqlvt
{
    public partial class fProfileManager : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");

      
       public fProfileManager()
        {
            InitializeComponent();
        
        }
        string taikhoan;
        string matkhau;
        
        public fProfileManager(string taikhoan, string matkhau)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
          
            InitializeComponent();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fProfileManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fProfileManager_Load(object sender, EventArgs e)
        {

            txbUserName.Text = taikhoan;
            this.AcceptButton = btnSua;
            this.CancelButton = btnThoat;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            string select2 = "Select * From nguoidung where UserName='" + txbUserName.Text + "' and PassWord='" + txbPassWord.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select2, conn);
            SqlDataReader reader2;
            reader2 = cmd2.ExecuteReader();
            if (txbPassWord.Text == "") { MessageBox.Show("Vui lòng nhập mật khẩu cũ !"); txbPassWord.Focus(); }
            else
                if (txbNewPass.Text == "") { MessageBox.Show("Vui lòng nhập mật khẩu mới !"); txbNewPass.Focus(); }
                else
                    if (txbNewPass.TextLength < 5) { MessageBox.Show("Độ dài của mật khẩu không an toàn !"); txbNewPass.Focus(); }
            else
                    if (txbNhaplai.Text == "") { MessageBox.Show("Vui lòng nhập lại mật khẩu mới !"); txbNhaplai.Focus(); }
            else
                        if (txbNewPass.Text != txbNhaplai.Text) { MessageBox.Show("Bạn nhập lại password không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        else if (reader2.Read())
                        {
                           
                            cmd2.Dispose();
                            reader2.Dispose();
                            // Thực hiện truy vấn
                            string update = "Update nguoidung Set PassWord='" + txbNewPass.Text + "' where UserName='" + txbUserName.Text + "'";
                            SqlCommand cmd = new SqlCommand(update, conn);
                            cmd.ExecuteNonQuery();
                            if (conn.State == ConnectionState.Open)
                            {
                                conn.Close();
                            }
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo!");

                            // Trả tài nguyên
                            cmd.Dispose();
                        }

                        else
                        {
                            MessageBox.Show(" Mật khẩu sai! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txbPassWord.Focus();

                        }
            cmd2.Dispose();
            reader2.Dispose();
        }

       
    }
}