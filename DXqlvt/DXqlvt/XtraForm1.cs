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
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        public XtraForm1()
        {
            InitializeComponent();
            dtGVNBH.DataSource = LoadRecord(pageNumber, numberRecord);
        }
       int pageNumber = 1;
        int numberRecord = 10;
        void loadData()
        {
            using (ThongtinnoibanhanhDataContext db = new ThongtinnoibanhanhDataContext())
            {
                dtGVNBH.DataSource = db.noibanhanhs.ToList();
            }
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            doitencotdtgv();
            AnHienBtn(true);
            LamTuoi();
        }
        List<noibanhanh> LoadRecord(int page, int recordNum)
        {
            List<noibanhanh> resulf = new List<noibanhanh>();
            //skip
            //take
            using (ThongtinnoibanhanhDataContext db = new ThongtinnoibanhanhDataContext())
            {
                resulf = db.noibanhanhs.Skip((page - 1) * recordNum).Take(recordNum).ToList();
            }
            return resulf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using (ThongtinnoibanhanhDataContext db = new ThongtinnoibanhanhDataContext())
            {
                totalRecord = db.noibanhanhs.Count();
            }
            NumericUpDown num = sender as NumericUpDown;
            num.Maximum = totalRecord / numberRecord + 1;

            if(num.Value > pageNumber)
            {  
               pageNumber++;

            }
            else 
            {
                 pageNumber--;
            } 
            dtGVNBH.DataSource = LoadRecord(pageNumber, numberRecord);
        }

       /* private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            if (pageNumber - 1 > 0)
            {
            pageNumber--;
            dtGVNBH.DataSource = LoadRecord(pageNumber, numberRecord);}
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using (ThongtinnoibanhanhDataContext db = new ThongtinnoibanhanhDataContext())
            {
                totalRecord = db.noibanhanhs.Count();
            }
            if (pageNumber - 1 < totalRecord / numberRecord)
            {
                pageNumber++;
                dtGVNBH.DataSource = LoadRecord(pageNumber, numberRecord);}
           */
        public void doitencotdtgv()
        {
            dtGVNBH.Columns[0].HeaderText = "Mã cơ quan ";
            dtGVNBH.Columns[1].HeaderText = "Tên cơ quan";
            dtGVNBH.Columns[2].HeaderText = "Ghi chú";

        } int dong;

        private void dtGVNBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txbMaNBH.Text = dtGVNBH.Rows[dong].Cells[0].Value.ToString();
                txbTenNBH.Text = dtGVNBH.Rows[dong].Cells[1].Value.ToString();
                txbGhiNBH.Text = dtGVNBH.Rows[dong].Cells[2].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            txbMaNBH.Text = "";
            txbTenNBH.Text = "";
            txbGhiNBH.Text = "";


        }
        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txbMaNBH.Enabled = true;
            AnHienBtn(false);
            flag = 0;//Thêm
            LamTuoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((dtGVNBH.SelectedRows.Count < 0) || (txbMaNBH.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn Cơ quan ban hành văn bản bạn muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnHienBtn(true);
            }
            else
            {
                AnHienBtn(false);

                txbMaNBH.Enabled = false;
                flag = 1;//Sửa
                //LamTuoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((dtGVNBH.SelectedRows.Count < 0) || (txbMaNBH.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn Cơ quan ban hành văn bản muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cmd.CommandText = "delete from noibanhanh where id='" + txbMaNBH.Text + "'";
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        loadData();
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
            if (txbMaNBH.TextLength == 0) { MessageBox.Show("Mã cơ quan ban hành văn bản không thể để trống !"); }

            else
                if (txbTenNBH.TextLength == 0) { MessageBox.Show("Tên cơ quan ban hành văn bản không thể để trống !"); }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    if (flag == 0)
                    {
                        DataTable dt = new DataTable();
                        SqlDataAdapter ad = new SqlDataAdapter("Select id from noibanhanh where id='" + txbMaNBH.Text + "' ", conn);
                        ad.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Mã cơ quan ban hành văn bản đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {

                            cmd.CommandText = "Insert Into noibanhanh(id,TenNBH,Ghichu)" +
                "Values('" + txbMaNBH.Text + "',N'" + txbTenNBH.Text + "',N'" + txbGhiNBH.Text + "')";

                        }
                    }
                    else
                    {
                        cmd.CommandText = "Update noibanhanh Set TenNBH=N'" + txbTenNBH.Text + "',Ghichu=N'" + txbGhiNBH.Text + "' where id='" + txbMaNBH.Text + "' ";
                    }
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    AnHienBtn(true);

                    //loadData();
                    LamTuoi();
                }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            LamTuoi();
            AnHienBtn(true);
        }
    }
}