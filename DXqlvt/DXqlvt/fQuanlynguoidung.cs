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
using DXqlvt.DAO;

namespace DXqlvt
{
    public partial class fQuanlynguoidung : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        public fQuanlynguoidung()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fQuanlynguoidung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void fQuanlynguoidung_Load(object sender, EventArgs e)
        {
            laymachucvu();
            loaddtgv();
           // doitendtgv();
            LamTuoi();
            AnHienBtn(true);

        }
        void AnHienBtn(bool dk)
        {
            btnThem.Enabled = dk;
            btnSua.Enabled = dk;
            btnXoa.Enabled = dk;
            btnLuu.Enabled = !dk;
            btnHuy.Enabled = !dk;
        }
        void LamTuoi()
        {
            txbUserName.Text = "";
            txbDisplayName.Text = "";
            txbdiachi.Text = "";
            cbCV.Text = "";
            numericUpDown1.Text = "";


        }
        public void loaddtgv()
        {
          /*  ketnoi kn = new ketnoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select UserName,DisplayName,quyen,Diachi,TenCV from View_4");
            dtgvAccount.DataSource = dt;*/
            SqlDataAdapter sda = new SqlDataAdapter("select UserName,DisplayName,quyen,Diachi,TenCV from View_4", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtgvAccount.Rows.Clear();
            foreach (DataRow data in dt.Rows)
            {
                int aa = dtgvAccount.Rows.Add();
                dtgvAccount.Rows[aa].Cells[0].Value = "false";
                dtgvAccount.Rows[aa].Cells[1].Value = data["UserName"].ToString();
                dtgvAccount.Rows[aa].Cells[2].Value = data["DisplayName"].ToString();
                dtgvAccount.Rows[aa].Cells[3].Value = data["Diachi"].ToString();
                dtgvAccount.Rows[aa].Cells[4].Value = data["quyen"].ToString();
                dtgvAccount.Rows[aa].Cells[5].Value = data["TenCV"].ToString();
            }
        }
       
        public void laymachucvu()
        {
            ketnoi kn = new ketnoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select * from chucvu";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbCV.DataSource = table_MK;
            cbCV.DisplayMember = table_MK.Columns["TenCV"].ToString();
            cbCV.ValueMember = table_MK.Columns["id"].ToString();


            kn.kn.Close();


        }
        int dong;
        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;

                txbUserName.Text = dtgvAccount.Rows[dong].Cells[1].Value.ToString();
                txbDisplayName.Text = dtgvAccount.Rows[dong].Cells[2].Value.ToString();
                numericUpDown1.Text = dtgvAccount.Rows[dong].Cells[4].Value.ToString();
                txbdiachi.Text = dtgvAccount.Rows[dong].Cells[3].Value.ToString();

                cbCV.Text = dtgvAccount.Rows[dong].Cells[5].Value.ToString();
           
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txbUserName.Enabled = true;
            AnHienBtn(false);
            flag = 0;//Thêm
            LamTuoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((dtgvAccount.SelectedRows.Count < 0) || (txbUserName.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Người dùng mà bạn muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnHienBtn(true);
            }
            else
            {
                AnHienBtn(false);

                txbUserName.Enabled = false;
                flag = 1;//Sửa
                //LamTuoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((dtgvAccount.SelectedRows.Count < 0) || (txbUserName.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Người dùng mà bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dtgvAccount.Rows)
                {
                    if (bool.Parse(row.Cells[0].Value.ToString()))
                    {

                        conn.Open();
                        SqlCommand cmd = new SqlCommand("delete from nguoidung where UserName='" + row.Cells[1].Value.ToString() + "'", conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }


                }
                MessageBox.Show("SuccessFully Deleted...");
                loaddtgv();
                LamTuoi();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var tanTest = "Tessting";
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
            if (txbUserName.TextLength == 0) { MessageBox.Show("Tên đăng nhập không thể để trống !"); }
            else
                if (txbDisplayName.TextLength == 0) { MessageBox.Show("Tên người dùng không thể để trống !"); }
              
                            
                                            else
                                            {
                                                SqlCommand cmd = new SqlCommand();
                                                cmd.Connection = conn;
                                                cmd.CommandType = CommandType.Text;

                                                if (flag == 0)
                                                {
                                                    DataTable dt = new DataTable();
                                                    SqlDataAdapter ad = new SqlDataAdapter("Select UserName from nguoidung where UserName='" + txbUserName.Text + "'", conn);
                                                    ad.Fill(dt);
                                                    if (dt.Rows.Count > 0)
                                                    {
                                                        MessageBox.Show("Tên đăng nhập đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        return;
                                                    }
                                                    else
                                                    {

                                                        cmd.CommandText = "Insert Into nguoidung(UserName,DisplayName,quyen,Diachi,idCV)" +
                "Values(N'" + txbUserName.Text + "',N'" + txbDisplayName.Text + "','" + numericUpDown1.Value + "',N'" + txbdiachi.Text + "','" + cbCV.SelectedValue + "')";

                                                    }
                                                }
                                                else
                                                {
                                                    cmd.CommandText = "Update nguoidung Set DisplayName=N'" + txbDisplayName.Text + "',quyen='" + numericUpDown1.Value + "',Diachi=N'" + txbdiachi.Text + "',idCV='" + cbCV.SelectedValue + "' where UserName=N'" + txbUserName.Text + "' ";
                                                }
                                                cmd.Connection.Open();
                                                cmd.ExecuteNonQuery();
                                                cmd.Connection.Close();
                                                AnHienBtn(true);

                                                loaddtgv();
                                                LamTuoi();
                                            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamTuoi();
            AnHienBtn(true);
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }else
            if (txbUserName.Text == "") { MessageBox.Show("Vui lòng chọn người dùng"); }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            ResetPass(userName);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        
//thêm
        /*
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select UserName from nguoidung where UserName=N'" + txbUserName.Text + "' ", conn);

            cm.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader dr = cm.ExecuteReader();


            errorProvider1.Clear();
            if (txbUserName.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên tài khoản"); 
            }
            else if (dr.Read())
            {
                {
                    MessageBox.Show("Tên tài khoản  đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbUserName.Focus();

                }


                //Tra tai nguyen 
                dr.Dispose();
                cm.Dispose();

            }
            else
            {
                dr.Dispose();
                cm.Dispose();
                // Thực hiện truy vấn



                string insert = "Insert Into nguoidung(UserName,DisplayName,Quyen,Diachi,idCV)" +
                "Values(N'" + txbUserName.Text + "',N'" + txbDisplayName.Text + "','" + numericUpDown1.Value + "',N'" + txbdiachi.Text + "','" + cbCV.SelectedValue.ToString()
                + "')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập thông tin thành công", "Thông báo!");

                // Trả tài nguyên


                cmd.Dispose();
                //Fill du lieu vao Database
                loaddtgv();
                LamTuoi();
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((dtgvAccount.SelectedRows.Count < 0) || (txbUserName.Text.Trim() == ""))
            {
                MessageBox.Show("Bạn chưa chọn dòng muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có chắc chọn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (System.Windows.Forms.DialogResult.Yes == kq)
                {
                    try
                    {

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM nguoidung WHERE UserName= '" + txbUserName.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        LamTuoi();
                        loaddtgv();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }*/
//-----------------------------------------------------------------------------------------------//








    }
}