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
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        public XtraForm2()
        {
            InitializeComponent();
        }
        public void loatdtgv() 
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from chucvu",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach(DataRow data in dt.Rows)
            {
                int aa = dataGridView1.Rows.Add();
                dataGridView1.Rows[aa].Cells[0].Value = "false";
                dataGridView1.Rows[aa].Cells[1].Value=data["id"].ToString();
                dataGridView1.Rows[aa].Cells[2].Value = data["TenCV"].ToString();
                dataGridView1.Rows[aa].Cells[3].Value = data["Ghichu"].ToString();
            }
       //     label1.Text = "label";
        }
        private void XtraForm2_Load(object sender, EventArgs e)
        {
            loatdtgv();
            AnHienBtn(true);
            LamTuoi();

        }
        void LamTuoi()
        {
            txbMa.Text = "";
            txbTen.Text = "";
            txbGhi.Text = "";



        }
        void AnHienBtn(bool dk)
        {
            btnThem.Enabled = dk;
            btnSua.Enabled = dk;
            btnXoa.Enabled = dk;
            btnLuu.Enabled = !dk;
            btnHuy.Enabled = !dk;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.SelectedRows.Count < 0) || (txbMa.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng đánh dấu tích vào ô vuông những dòng muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (bool.Parse(row.Cells[0].Value.ToString()))
                    {

                        conn.Open();
                        SqlCommand cmd = new SqlCommand("delete from chucvu where id='" + row.Cells[1].Value.ToString() + "'", conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }


                }
                MessageBox.Show("SuccessFully Deleted...");
                loatdtgv();
                LamTuoi();

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
            if ((dataGridView1.SelectedRows.Count < 0) || (txbMa.Text.Trim() == ""))
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

                   
                    LamTuoi();
                    loatdtgv();
                }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamTuoi();
            AnHienBtn(true);
        }
        int dong;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;

                txbMa.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
                txbTen.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
                txbGhi.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();




            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mã chức vụ chỉ được nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XtraForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}