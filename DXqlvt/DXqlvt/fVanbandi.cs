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
using Microsoft.Reporting.WinForms;

namespace DXqlvt
{
    public partial class fVanbandi : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        int flag;
        public fVanbandi()
        {
            InitializeComponent();
            dtgvVanbandi.DataSource = LoadRecord(pageNumber, numberRecord);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fVanbandi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        void loadData()
        {
            using (ThongtinvanbandiDataContext db = new ThongtinvanbandiDataContext())
            {
                dtgvVanbandi.DataSource = db.View_2s.ToList();
            }
        }
        int pageNumber = 1;
        int numberRecord = 14;
        List<View_2> LoadRecord(int page, int recordNum)
        {
            List<View_2> resulf = new List<View_2>();
            //skip
            //take
            using (ThongtinvanbandiDataContext db = new ThongtinvanbandiDataContext())
            {
                resulf = db.View_2s.Skip((page - 1) * recordNum).Take(recordNum).ToList();
            }
            return resulf;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using (ThongtinvanbandiDataContext db = new ThongtinvanbandiDataContext())
            {
                totalRecord = db.View_2s.Count();
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
            dtgvVanbandi.DataSource = LoadRecord(pageNumber, numberRecord);
        }
        private void fVanbandi_Load(object sender, EventArgs e)
        {
           // loaddtgvVBdi();
            doitendtgv();
            laymaloaivanban();
            laymaNBH();
            LamTuoi();
            AnHienBtn(true);
            //doSearchBykeycode();
        }
      /*  public void loaddtgvVBdi()
        {
            ketnoi kn = new ketnoi();
            DataTable dt = new DataTable();
            dt = kn.laybang("select * from View_2");
            dtgvVanbandi.DataSource = dt;
        }*/
//laasyteen loại vb
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
//hiển - ẩn btn
        void AnHienBtn(bool dk)
        {
            btnThem.Enabled = dk;
            btnSua.Enabled = dk;
            btnXoa.Enabled = dk;
            btnLuu.Enabled = !dk;
            btnHuy.Enabled = !dk;
        }
//lấy tên nbn
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
    //đổi tên cột
        public void doitendtgv()
        {
            dtgvVanbandi.Columns[0].HeaderText = "Mã văn bản";

            dtgvVanbandi.Columns[1].HeaderText = "Tên loạivăn bản";
            dtgvVanbandi.Columns[2].HeaderText = "Tên cơ quan ban hành";
            dtgvVanbandi.Columns[3].HeaderText = "Số/Kí hiệu";
            dtgvVanbandi.Columns[4].HeaderText = "Người ký ";
            dtgvVanbandi.Columns[5].HeaderText = "Người duyệt";
            dtgvVanbandi.Columns[6].HeaderText = "Người gửi";
            dtgvVanbandi.Columns[7].HeaderText = "Lĩnh vực";
            dtgvVanbandi.Columns[8].HeaderText = "Số trang";
            dtgvVanbandi.Columns[9].HeaderText = "Số bản";
            dtgvVanbandi.Columns[10].HeaderText = "File tập tin";
            dtgvVanbandi.Columns[11].HeaderText = "Nội dung";
            dtgvVanbandi.Columns[12].HeaderText = "Tóm tắt";
            dtgvVanbandi.Columns[13].HeaderText = "Ngày ban hành";
            dtgvVanbandi.Columns[14].HeaderText = "Ngày gửi";
            dtgvVanbandi.Columns[15].HeaderText = "Nơi đến";


        }
       
//làm mới textbox
     
        public void LamTuoi() 
        {
            txbMa_vbd.Text = "";
            txbKi_vbd.Text = "";
            txbNguoigui.Text = "";
            txbTrichyeu_vbd.Text = "";
            txbNoidung_vbd.Text = "";
            cbLoaivb_vbd.Text = "";
            cbNoibh_vbd.Text = "";


            txbLinhvuc_vbd.Text = "";
            txbNguoiduyet_vbd.Text = "";
            txbNguoiky_vbd.Text = "";
            txbDD.Text = "";
            dtpBanhanh_vbd.Text = "";
            dtpNgaygui_vbd.Text = "";
            numericUpDownvbd1.Text = "";
            numericUpDownvbd2.Text = "";
            txbNoiden.Text = "";
            


           

        }
    //hiển thị từ dtgv->textbox
        int dong;
        private void dtgvVanbandi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;

                txbMa_vbd.Text = dtgvVanbandi.Rows[dong].Cells[0].Value.ToString();

                cbLoaivb_vbd.Text = dtgvVanbandi.Rows[dong].Cells[1].Value.ToString();
                cbNoibh_vbd.Text = dtgvVanbandi.Rows[dong].Cells[2].Value.ToString();
                txbKi_vbd.Text = dtgvVanbandi.Rows[dong].Cells[3].Value.ToString();
                txbNguoiky_vbd.Text = dtgvVanbandi.Rows[dong].Cells[4].Value.ToString();
                txbNguoiduyet_vbd.Text = dtgvVanbandi.Rows[dong].Cells[5].Value.ToString();
                txbNguoigui.Text = dtgvVanbandi.Rows[dong].Cells[6].Value.ToString();
                txbLinhvuc_vbd.Text = dtgvVanbandi.Rows[dong].Cells[7].Value.ToString();
                numericUpDownvbd1.Text = dtgvVanbandi.Rows[dong].Cells[8].Value.ToString();
                numericUpDownvbd2.Text = dtgvVanbandi.Rows[dong].Cells[9].Value.ToString();
                txbDD.Text = dtgvVanbandi.Rows[dong].Cells[10].Value.ToString();
                txbNoidung_vbd.Text = dtgvVanbandi.Rows[dong].Cells[11].Value.ToString();
                txbTrichyeu_vbd.Text = dtgvVanbandi.Rows[dong].Cells[12].Value.ToString();
                dtpBanhanh_vbd.Text = dtgvVanbandi.Rows[dong].Cells[13].Value.ToString();
                dtpNgaygui_vbd.Text = dtgvVanbandi.Rows[dong].Cells[14].Value.ToString();
               txbNoiden.Text = dtgvVanbandi.Rows[dong].Cells[15].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   //file

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
//btnThem
        private void btnThem_Click(object sender, EventArgs e)
        {
            txbMa_vbd.Enabled = true;
            AnHienBtn(false);
            flag = 0;//Thêm
            LamTuoi();
        }
//btnsua
        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((dtgvVanbandi.SelectedRows.Count < 0) || (txbMa_vbd.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Văn bản đi bạn muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnHienBtn(true);
            }
            else
            {
                AnHienBtn(false);

                txbMa_vbd.Enabled = false;
                flag = 1;//Sửa
                //LamTuoi();
            }
        }

    // btnLuu  
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
            if (txbMa_vbd.TextLength == 0) { MessageBox.Show("Mã  văn bản đi không thể để trống !"); }
            else
                if (txbKi_vbd.TextLength == 0) { MessageBox.Show("Số/Kí hiệu văn bản đi không thể để trống !"); }
                else
                    if (txbNguoigui.TextLength == 0) { MessageBox.Show("Người gửi văn bản đi không thể để trống !"); }
                    else
                        if (txbNguoiduyet_vbd.TextLength == 0) { MessageBox.Show("Người duyệt văn bản đi không thể để trống !"); }
                else
                    if (txbLinhvuc_vbd.TextLength == 0) { MessageBox.Show("Lĩnh vực văn bản đi không thể để trống !"); }
                    else
                        if (txbNguoiky_vbd.TextLength == 0) { MessageBox.Show("Người ký văn bản đi không thể để trống !"); }

                        else
                            if (txbMa_vbd.TextLength > 10) { MessageBox.Show(" Vượt quá số lượng cho phép  !"); }
                            else
                                if (txbTrichyeu_vbd.TextLength == 0) { MessageBox.Show("Nội dung tóm tắt văn bản đi không thể để trống !"); }
                            else
                                if (txbNoidung_vbd.TextLength == 0) { MessageBox.Show("Nội dung văn bản đi không thể để trống !"); }
                                else
                                {
                                    SqlCommand cmd = new SqlCommand();
                                    cmd.Connection = conn;
                                    cmd.CommandType = CommandType.Text;

                                    if (flag == 0)
                                    {
                                        DataTable dt = new DataTable();
                                        SqlDataAdapter ad = new SqlDataAdapter("Select id from vanbandi where id='" + txbMa_vbd.Text + "'", conn);
                                        ad.Fill(dt);
                                        if (dt.Rows.Count > 0)
                                        {
                                            MessageBox.Show("Mã  văn bản đi đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        else
                                        {

                                            cmd.CommandText = "insert into vanbandi(id,idLVB,idNBH,Kihieu,Nguoiky,Nguoiduyet,Nguoigui,Linhvuc,Sotrang,Soban,Filetaptin,NoidungVB,Trichyeu,NgayBH,Ngaygui,Noiden) values('" + txbMa_vbd.Text.ToString() + "','"
                + cbLoaivb_vbd.SelectedValue.ToString()
                + "','" + cbNoibh_vbd.SelectedValue.ToString()
                + "',N'" + txbKi_vbd.Text.ToString()
                + "',N'" + txbNguoiky_vbd.Text.ToString()
                + "',N'" + txbNguoiduyet_vbd.Text.ToString()
                + "',N'" + txbNguoigui.Text.ToString()
                + "',N'" + txbLinhvuc_vbd.Text.ToString()
                + "','" + numericUpDownvbd1.Value
                + "','" + numericUpDownvbd2.Value
                + "',N'" + txbDD.Text.ToString()
                + "',N'" + txbNoidung_vbd.Text.ToString()
                + "',N'" + txbTrichyeu_vbd.Text.ToString()
                + "','" + dtpBanhanh_vbd.Value.ToString("yyyy-MM-dd")
                + "','" + dtpNgaygui_vbd.Value.ToString("yyyy-MM-dd") 
                + "',N'" + txbNoiden.Text.ToString() +"')";

                                        }
                                    }
                                    else
                                    {
                                        cmd.CommandText = "Update vanbandi set idLVB=N'" + cbLoaivb_vbd.SelectedValue.ToString() + "',idNBH=N'" + cbNoibh_vbd.SelectedValue.ToString() + "',Kihieu=N'" + txbKi_vbd.Text.ToString() + "',Nguoiky=N'" + txbNguoiky_vbd.Text.ToString() + "',Nguoiduyet=N'" + txbNguoiduyet_vbd.Text.ToString() + "',Nguoigui=N'" + txbNguoigui.Text.ToString() + "',Linhvuc=N'" + txbLinhvuc_vbd.Text.ToString() + "',Sotrang='" + numericUpDownvbd1.Value + "',Soban='" + numericUpDownvbd2.Value + "',Filetaptin=N'" + txbDD.Text.ToString() + "',NoidungVB=N'" + txbNoidung_vbd.Text.ToString() + "',Trichyeu =N'" + txbTrichyeu_vbd.Text.ToString() + "',NgayBH='" + dtpBanhanh_vbd.Value.ToString("yyyy-MM-dd") + "',Ngaygui='" + dtpNgaygui_vbd.Value.ToString("yyyy-MM-dd") + "',Noiden=N'" + txbNoiden.Text.ToString() + "' where id='" + txbMa_vbd.Text.ToString() + "'";
                                    }
                                    cmd.Connection.Open();
                                    cmd.ExecuteNonQuery();
                                    cmd.Connection.Close();
                                    AnHienBtn(true);
                                    loadData();
                                   // loaddtgvVBdi();
                                    LamTuoi();
                                }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LamTuoi();
            AnHienBtn(true);

        }
//mã văn bản ko được nhập kí tự khác số
        private void txbMa_vbd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mã văn bản đi chỉ được nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
// tìm kiếm
        private void txbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doSearchBykeycode();
            }
        }
        private void doSearchBykeycode()
        {
            if (txbSearch.TextLength == 0) { MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!"); }
            else{
            ftimkiemvbdi sr = new ftimkiemvbdi(txbSearch.Text.ToString());
            sr.ShowDialog();}
        }
//click refesh loaddatagvew
        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }
//btn xóa 
        private void btnXoa_Click(object sender, EventArgs e)
        {
             
     
            if ((dtgvVanbandi.SelectedRows.Count < 0) || (txbMa_vbd.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Văn bản đi muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cmd.CommandText = "DELETE FROM vanbandi WHERE id= '" + txbMa_vbd.Text.ToString() + "'";
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

  
    }
}