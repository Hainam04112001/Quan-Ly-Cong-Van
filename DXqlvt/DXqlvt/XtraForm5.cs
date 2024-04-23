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
    public partial class XtraForm5 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        public XtraForm5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraForm5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        public void loatdtgv()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from loaivanban", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtgvLVB.Rows.Clear();
            foreach (DataRow data in dt.Rows)
            {
                int aa = dtgvLVB.Rows.Add();
                dtgvLVB.Rows[aa].Cells[0].Value = "false";
                dtgvLVB.Rows[aa].Cells[1].Value = data["id"].ToString();
                dtgvLVB.Rows[aa].Cells[2].Value = data["TenLVB"].ToString();
                dtgvLVB.Rows[aa].Cells[3].Value = data["Ghichu"].ToString();
            }
            //     label1.Text = "label";
        }

        private void XtraForm5_Load(object sender, EventArgs e)
        {
            loatdtgv(); 
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
        int dong;
        private void dtgvLVB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txbMaLVB.Text = dtgvLVB.Rows[dong].Cells[1].Value.ToString();
                txbTenLVB.Text = dtgvLVB.Rows[dong].Cells[2].Value.ToString();
                txbGhiLVB.Text = dtgvLVB.Rows[dong].Cells[3].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int flag;
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

                        loatdtgv();
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

        private void XtraForm5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if ((dtgvLVB.SelectedRows.Count < 0) || (txbMaLVB.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn Loại văn bản muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dtgvLVB.Rows)
                {
                    if (bool.Parse(row.Cells[0].Value.ToString()))
                    {

                        conn.Open();
                        SqlCommand cmd = new SqlCommand("delete from loaivanban where id='" + row.Cells[1].Value.ToString() + "'", conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }


                }
                MessageBox.Show("SuccessFully Deleted...");
                loatdtgv();
                LamTuoi();

            }
        }

        private void txbMaLVB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mã loại văn bản chỉ được nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}