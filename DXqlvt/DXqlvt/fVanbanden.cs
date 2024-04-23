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
    public partial class fVanbanden : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        int flag;
        public fVanbanden()
        {
            InitializeComponent();
            dtgvVanbanden.DataSource = LoadRecord(pageNumber, numberRecord);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void fVanbanden_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        void loadData()
        {
            using (ThongtinvanbandenDataContext db = new ThongtinvanbandenDataContext())
            {
                dtgvVanbanden.DataSource = db.View_3s.ToList();
            }
        } 
        int pageNumber = 1;
        int numberRecord = 14;
        List<View_3> LoadRecord(int page, int recordNum)
        {
            List<View_3> resulf = new List<View_3>();
            //skip
            //take
            using (ThongtinvanbandenDataContext db = new ThongtinvanbandenDataContext())
            {
                resulf = db.View_3s.Skip((page - 1) * recordNum).Take(recordNum).ToList();
            }
            return resulf;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using (ThongtinvanbandenDataContext db = new ThongtinvanbandenDataContext())
            {
                totalRecord = db.View_3s.Count();
            }
            NumericUpDown num = sender as NumericUpDown;
            num.Maximum = totalRecord / numberRecord + 1;

            if (num.Value > pageNumber)
            {
                pageNumber++;

            }
            else
            {
                pageNumber--;
            }
            dtgvVanbanden.DataSource = LoadRecord(pageNumber, numberRecord);
        }
        private void fVanbanden_Load(object sender, EventArgs e)
        {
          //  loaddtgvVBden();
            doitendtgv();
            laymaloaivanban();
            laymaNBH();
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
        public void LamTuoi()
        {
            txbMa.Text = "";
            txbKi_vbd.Text = "";
            txbNguoinhan.Text = "";
            txbTrichyeu_vbd.Text = "";
            txbNoidung_vbd.Text = "";
            cbLoaivb_vbd.Text = "";
            cbNoibh_vbd.Text = "";


            txbLinhvuc_vbd.Text = "";
            txbNguoiduyet_vbd.Text = "";
            txbNguoiky_vbd.Text = "";
            txbDD.Text = "";
            dtpBanhanh_vbd.Text = "";
            dtpNgaynhan_vbd.Text = "";
            numericUpDownvbd1.Text = "";
            numericUpDownvbd2.Text = "";






        }
       /* public void loaddtgvVBden()
        {
            ketnoi kn = new ketnoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select * from View_3");
            dtgvVanbanden.DataSource = dt;
        }*/
        public void laymaloaivanban()
        {
            ketnoi kn = new ketnoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select * from loaivanban";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbLoaivb_vbd.DataSource = table_MK;
            cbLoaivb_vbd.DisplayMember = table_MK.Columns["TenLVB"].ToString();
            cbLoaivb_vbd.ValueMember = table_MK.Columns["id"].ToString();


            kn.kn.Close();


        }
        public void laymaNBH()
        {
            ketnoi kn = new ketnoi();
            SqlCommand mysqlcommand = new SqlCommand();
            mysqlcommand.Connection = kn.kn;
            mysqlcommand.CommandText = "select * from noibanhanh";
            kn.kn_csdl();
            SqlDataAdapter mysqladatareader = new SqlDataAdapter();
            mysqladatareader.SelectCommand = mysqlcommand;
            DataSet mydataset = new DataSet();
            mysqladatareader.Fill(mydataset, "KQ");
            DataTable table_MK = new DataTable();
            table_MK = mydataset.Tables["KQ"];
            cbNoibh_vbd.DataSource = table_MK;
            cbNoibh_vbd.DisplayMember = table_MK.Columns["TenNBH"].ToString();
            cbNoibh_vbd.ValueMember = table_MK.Columns["id"].ToString();


            kn.kn.Close();


        }
        public void doitendtgv()
        {
            dtgvVanbanden.Columns[0].HeaderText = "Mã văn bản";
            dtgvVanbanden.Columns[1].HeaderText = "Số/Kí hiệu";
            dtgvVanbanden.Columns[2].HeaderText = "Tên loạivăn bản";
            dtgvVanbanden.Columns[3].HeaderText = "Tên cơ quan ban hành";

            dtgvVanbanden.Columns[4].HeaderText = "Người ký ";
            dtgvVanbanden.Columns[5].HeaderText = "Người duyệt";
            dtgvVanbanden.Columns[6].HeaderText = "Người nhận";
            dtgvVanbanden.Columns[7].HeaderText = "Lĩnh vực";
            dtgvVanbanden.Columns[8].HeaderText = "Số trang";
            dtgvVanbanden.Columns[9].HeaderText = "Số bản";
            dtgvVanbanden.Columns[10].HeaderText = "File tập tin";
            dtgvVanbanden.Columns[11].HeaderText = "Nội dung";
            dtgvVanbanden.Columns[12].HeaderText = "Trích yếu";
            dtgvVanbanden.Columns[13].HeaderText = "Ngày ban hành";
            dtgvVanbanden.Columns[14].HeaderText = "Ngày nhận";


        }

      
        int dong;
        private void dtgvVanbanden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;

                txbMa.Text = dtgvVanbanden.Rows[dong].Cells[0].Value.ToString();
                txbKi_vbd.Text = dtgvVanbanden.Rows[dong].Cells[1].Value.ToString();
                cbLoaivb_vbd.Text = dtgvVanbanden.Rows[dong].Cells[2].Value.ToString();
                cbNoibh_vbd.Text = dtgvVanbanden.Rows[dong].Cells[3].Value.ToString();

                txbNguoiky_vbd.Text = dtgvVanbanden.Rows[dong].Cells[4].Value.ToString();
                txbNguoiduyet_vbd.Text = dtgvVanbanden.Rows[dong].Cells[5].Value.ToString();
                txbNguoinhan.Text = dtgvVanbanden.Rows[dong].Cells[6].Value.ToString();
                txbLinhvuc_vbd.Text = dtgvVanbanden.Rows[dong].Cells[7].Value.ToString();
                numericUpDownvbd1.Text = dtgvVanbanden.Rows[dong].Cells[8].Value.ToString();
                numericUpDownvbd2.Text = dtgvVanbanden.Rows[dong].Cells[9].Value.ToString();
                txbNoidung_vbd.Text = dtgvVanbanden.Rows[dong].Cells[11].Value.ToString();
                txbDD.Text = dtgvVanbanden.Rows[dong].Cells[10].Value.ToString();
                txbTrichyeu_vbd.Text = dtgvVanbanden.Rows[dong].Cells[12].Value.ToString();
                dtpBanhanh_vbd.Text = dtgvVanbanden.Rows[dong].Cells[13].Value.ToString();
                dtpNgaynhan_vbd.Text = dtgvVanbanden.Rows[dong].Cells[14].Value.ToString();


            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Văn bản nội bộ";
            open.Filter = "|*.doc;*.pdf;*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {

                txbDD.Text = open.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txbMa.Enabled = true;
            AnHienBtn(false);
            flag = 0;//Thêm
            LamTuoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((dtgvVanbanden.SelectedRows.Count < 0) || (txbMa.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Văn bản đến bạn muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if ((dtgvVanbanden.SelectedRows.Count < 0) || (txbMa.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Văn bản đến muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cmd.CommandText = "DELETE FROM vanbanden WHERE id= '" + txbMa.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                        loadData();
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
            if (txbMa.TextLength == 0) { MessageBox.Show("Mã  văn bản đến không thể để trống !"); }
            else
                if (txbKi_vbd.TextLength == 0) { MessageBox.Show("Số/Kí hiệu văn bản đến không thể để trống !"); }
                else
                    if (txbNguoinhan.TextLength == 0) { MessageBox.Show("Người nhận văn bản đến không thể để trống !"); }
                    else
                        if (txbNguoiduyet_vbd.TextLength == 0) { MessageBox.Show("Người duyệt văn bản đên không thể để trống !"); }
                        else
                            if (txbLinhvuc_vbd.TextLength == 0) { MessageBox.Show("Lĩnh vực văn bản đến không thể để trống !"); }
                            else
                                if (txbNguoiky_vbd.TextLength == 0) { MessageBox.Show("Người ký văn bản đến không thể để trống !"); }
                                else
                                    if (txbMa.TextLength > 10) { MessageBox.Show(" Vượt quá số lượng cho phép  !"); }
                                   
                                        else
                                            if (txbTrichyeu_vbd.TextLength == 0) { MessageBox.Show("Nội dung tóm tắt văn bản đến không thể để trống !"); }
                                            else
                                                if (txbNoidung_vbd.TextLength == 0) { MessageBox.Show("Nội dung văn bản đến không thể để trống !"); }
                                                else
                                                {
                                                    SqlCommand cmd = new SqlCommand();
                                                    cmd.Connection = conn;
                                                    cmd.CommandType = CommandType.Text;

                                                    if (flag == 0)
                                                    {
                                                        DataTable dt = new DataTable();
                                                        SqlDataAdapter ad = new SqlDataAdapter("Select id from vanbanden where id='" + txbMa.Text + "'", conn);
                                                        ad.Fill(dt);
                                                        if (dt.Rows.Count > 0)
                                                        {
                                                            MessageBox.Show("Mã  văn bản đến đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            return;
                                                        }
                                                        else
                                                        {

                                                            cmd.CommandText = "insert into vanbanden(id,Kihieu,idLVB,idNBH,Nguoiky,Nguoiduyet,Nguoinhan,Linhvuc,Sotrang,Soban,Filetaptin,NoidungVB,Trichyeu,NgayBH,Ngaynhan) values('" + txbMa.Text.ToString() + "',N'" + txbKi_vbd.Text.ToString() + "','" + cbLoaivb_vbd.SelectedValue.ToString()
                + "','" + cbNoibh_vbd.SelectedValue.ToString()
                + "',N'" + txbNguoiky_vbd.Text.ToString()
                + "',N'" + txbNguoiduyet_vbd.Text.ToString()
                + "',N'" + txbNguoinhan.Text.ToString()
                + "',N'" + txbLinhvuc_vbd.Text.ToString()
                + "','" + numericUpDownvbd1.Value
                + "','" + numericUpDownvbd2.Value
                + "',N'" + txbDD.Text.ToString()
                + "',N'" + txbNoidung_vbd.Text.ToString()
                + "',N'" + txbTrichyeu_vbd.Text.ToString()
                + "','" + dtpBanhanh_vbd.Value.ToString("yyyy-MM-dd")
                + "','" + dtpNgaynhan_vbd.Value.ToString("yyyy-MM-dd") + "')";

                                                        }
                                                    }
                                                    else
                                                    {
                                                        cmd.CommandText = "Update vanbanden set Kihieu=N'" + txbKi_vbd.Text.ToString() + "',idLVB='" + cbLoaivb_vbd.SelectedValue.ToString() + "',idNBH='" + cbNoibh_vbd.SelectedValue.ToString() + "',Nguoiky=N'" + txbNguoiky_vbd.Text.ToString()
                + "',Nguoiduyet=N'" + txbNguoiduyet_vbd.Text.ToString()
                + "',Nguoinhan=N'" + txbNguoinhan.Text.ToString()
                + "',Linhvuc=N'" + txbLinhvuc_vbd.Text.ToString()
                + "',Sotrang='" + numericUpDownvbd1.Value
                + "',Soban='" + numericUpDownvbd2.Value
                + "',Filetaptin=N'" + txbDD.Text.ToString()
                + "',NoidungVB=N'" + txbNoidung_vbd.Text.ToString()
                + "',Trichyeu=N'" + txbTrichyeu_vbd.Text.ToString()
                + "',NgayBH='" + dtpBanhanh_vbd.Value.ToString("yyyy-MM-dd")
                + "',Ngaynhan='" + dtpNgaynhan_vbd.Value.ToString("yyyy-MM-dd") + "' where id='" + txbMa.Text.ToString() + "'";
                                                    }
                                                    cmd.Connection.Open();
                                                    cmd.ExecuteNonQuery();
                                                    cmd.Connection.Close();
                                                    AnHienBtn(true);
                                                    loadData();
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
                MessageBox.Show("Mã  văn bản đến chỉ được nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void doSearchBykeycode()
        {
            if (txbSearch.TextLength == 0) { MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!"); }
            else
            {
                ftimkiemvbden sr = new ftimkiemvbden(txbSearch.Text.ToString());
                sr.ShowDialog();
            }
        }

        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doSearchBykeycode();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

    }
}