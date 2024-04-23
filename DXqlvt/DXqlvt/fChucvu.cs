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

namespace DXqlvt
{
    public partial class fChucvu : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        public fChucvu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void fChucvu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
       
        private void fChucvu_Load(object sender, EventArgs e)
        {
            loaddtgv();
        }

        public void loaddtgv()
        {
            ketnoi kn = new ketnoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select * from chucvu");
            dtgvCV.DataSource = dt;
        }

      
        /*
        private void fChucvu_Load(object sender, EventArgs e)
        {
            loaddtgv();
            doitendtgv();
           
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
            txbMa.Text = "";
            txbTen.Text = "";
            txbGhi.Text = "";
         


        }
        public void loaddtgv()
        {
            ketnoi kn = new ketnoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select * from chucvu");
            dtgvCV.DataSource = dt;
        }
        public void doitendtgv()
        {
            dtgvCV.Columns[0].HeaderText = "Mã chức vụ";
            dtgvCV.Columns[1].HeaderText = "Tên chức vụ";
            dtgvCV.Columns[2].HeaderText = "Ghi chú";
        }

    
        int dong;
        private void dtgvCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;

                txbMa.Text = dtgvCV.Rows[dong].Cells[0].Value.ToString();
                txbTen.Text = dtgvCV.Rows[dong].Cells[1].Value.ToString();
                txbGhi.Text = dtgvCV.Rows[dong].Cells[2].Value.ToString();
              

               

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txbMa.Enabled = true;
            AnHienBtn(false);
            flag = 0;//Thêm
            LamTuoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((dtgvCV.SelectedRows.Count < 0) || (txbMa.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Chức vụ muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnHienBtn(true);
            }
            else
            {
                AnHienBtn(false);

                txbMa.Enabled = false;
                flag = 1;//Sửa
                //LamTuoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((dtgvCV.SelectedRows.Count < 0) || (txbMa.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Chức vụ mà bạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thực sư muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (System.Windows.Forms.DialogResult.Yes == kq)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM chucvu WHERE id= '" + txbMa.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        loaddtgv();
                        LamTuoi();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
            if (txbMa.TextLength == 0) { MessageBox.Show("Mã chức vụ không thể để trống !"); }
            else
                if (txbTen.TextLength == 0) { MessageBox.Show("Tên chức vụ không thể để trống !"); }


                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    if (flag == 0)
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter ad = new SqlDataAdapter("Select id from chucvu where id='" + txbMa.Text + "'", conn);
                        ad.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Mã chức vụ đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {

                            cmd.CommandText = "Insert Into chucvu Values('" + txbMa.Text + "',N'" + txbTen.Text + "',N'" + txbGhi.Text + "')";

                        }
                    }
                    else
                    {
                        cmd.CommandText = "Update chucvu Set TenCV=N'" + txbTen.Text + "',Ghichu=N'" + txbGhi.Text + "' where id=N'" + txbMa.Text + "' ";
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

        private void txbMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mã chức vụ chỉ được nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/
    }
}