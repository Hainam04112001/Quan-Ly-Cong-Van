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
    public partial class fLoaivanban : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        
        int dong;
        int flag;
        public fLoaivanban()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLoaivanban_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void fLoaivanban_Load(object sender, EventArgs e)
        {
            loaddtgvLVB();
            doitendtgv();
            AnHienBtn(true);
            LamTuoi();
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
            txbMaLVB.Text = "";
            txbTenLVB.Text = "";
            txbGhiLVB.Text = "";


        }
        public void loaddtgvLVB()
        {
            ketnoi kn = new ketnoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select id,TenLVB,Ghichu from loaivanban");
            dtgvLVB.DataSource = dt;
        }
        public void doitendtgv()
        {
            dtgvLVB.Columns[0].HeaderText = "Mã loại văn bản";
            dtgvLVB.Columns[1].HeaderText = "Tên loại văn bản";
            dtgvLVB.Columns[2].HeaderText = "Ghi chú";

        }

        
      
        private void dtgvLVB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txbMaLVB.Text = dtgvLVB.Rows[dong].Cells[0].Value.ToString();
                txbTenLVB.Text = dtgvLVB.Rows[dong].Cells[1].Value.ToString();
                txbGhiLVB.Text = dtgvLVB.Rows[dong].Cells[2].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            if ((dtgvLVB.SelectedRows.Count < 0) || (txbMaLVB.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn Loại văn bản bạn muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnHienBtn(true);
            }
            else
            {
                AnHienBtn(false);
                //groupBox2.Enabled = true;
                txbMaLVB.Enabled = false;
                flag = 1;//Sửa
                //LamTuoi();
            }
        }

      


        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
             if (txbMaLVB.TextLength == 0) { MessageBox.Show("Mã loại văn bản không thể để trống !"); }
                 else
              if (txbMaLVB.TextLength > 10) { MessageBox.Show(" Vượt quá số lượng cho phép  !"); }
            
                else
                 if (txbTenLVB.TextLength == 0) { MessageBox.Show("Tên loại văn bản không thể để trống !"); }
                 else
                 {
                     SqlCommand cmd = new SqlCommand();
                     cmd.Connection = conn;
                     cmd.CommandType = CommandType.Text;

                     if (flag == 0)
                     {
                         DataTable dt = new DataTable();
                         SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM loaivanban WHERE id = '" + txbMaLVB.Text.ToString() + "'", conn);
                         ad.Fill(dt);
                         if (dt.Rows.Count > 0)
                         {
                             MessageBox.Show("Mã loại văn bản đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             return;
                         }
                         else
                         {

                             cmd.CommandText = "Insert Into loaivanban(id,TenLVB,Ghichu)" +
             "Values('" + txbMaLVB.Text + "',N'" + txbTenLVB.Text + "',N'" + txbGhiLVB.Text + "')";

                         }
                     }
                     else
                     {
                         cmd.CommandText = "Update loaivanban Set TenLVB=N'" + txbTenLVB.Text + "',Ghichu=N'" + txbGhiLVB.Text + "' where id='" + txbMaLVB.Text + "' ";
                     }
                     cmd.Connection.Open();
                     cmd.ExecuteNonQuery();
                     cmd.Connection.Close();
                     AnHienBtn(true);
                     
                     loaddtgvLVB();
                     LamTuoi();
                 }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
            LamTuoi();
            AnHienBtn(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txbMaLVB.Enabled = true;
            AnHienBtn(false);
            flag = 0;//Thêm
            LamTuoi();
        }

        private void txbMaLVB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mã loại văn bản chỉ được nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if ((dtgvLVB.SelectedRows.Count < 0) || (txbMaLVB.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn Loại văn bản muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cmd.CommandText = "delete from loaivanban where id='" + txbMaLVB.Text + "'";
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        loaddtgvLVB();
                        LamTuoi();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        
    }
}