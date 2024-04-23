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
    public partial class fVanbannoibo : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
    
        public fVanbannoibo()
        {
            InitializeComponent();
            dtgvVbnb.DataSource = LoadRecord(pageNumber, numberRecord);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fVanbannoibo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        void loadData() 
        {
            using (ThongtinvanbannoiboDataContext db = new ThongtinvanbannoiboDataContext())
            {
                dtgvVbnb.DataSource = db.View_1s.ToList();
            }
        }
        int pageNumber = 1;
        int numberRecord = 15 ;
        private void fVanbannoibo_Load(object sender, EventArgs e)
        {
          
            doitendtgv();
            laymaNBH();
            LamTuoi();
            AnHienBtn(true);
            laymaloaivanban();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }
       
        List<View_1> LoadRecord(int page, int recordNum)
        {
            List<View_1> resulf = new List<View_1>();
            //skip
            //take
            using (ThongtinvanbannoiboDataContext db = new ThongtinvanbannoiboDataContext())
            {
                resulf = db.View_1s.Skip((page - 1) * recordNum).Take(recordNum).ToList();
            }
            return resulf;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using(ThongtinvanbannoiboDataContext db= new ThongtinvanbannoiboDataContext())
            {
                totalRecord = db.View_1s.Count();
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
            dtgvVbnb.DataSource = LoadRecord(pageNumber, numberRecord);
        }
        public void doitendtgv()
        {
            dtgvVbnb.Columns[0].HeaderText = "Mã văn bản";
            dtgvVbnb.Columns[1].HeaderText = "Số/Kí hiệu";
            dtgvVbnb.Columns[2].HeaderText = "Tên loạivăn bản";
            dtgvVbnb.Columns[3].HeaderText = "Tên cơ quan ban hành";
            dtgvVbnb.Columns[4].HeaderText = "Lĩnh vực";
            dtgvVbnb.Columns[5].HeaderText = "Số trang";
            dtgvVbnb.Columns[6].HeaderText = "Số bản";
            dtgvVbnb.Columns[7].HeaderText = "File tập tin";
            dtgvVbnb.Columns[8].HeaderText = "Nội dung";
            dtgvVbnb.Columns[9].HeaderText = "Trích yếu";
            dtgvVbnb.Columns[10].HeaderText = "Ngày tạo";
            dtgvVbnb.Columns[11].HeaderText = "Tên văn bản";
            dtgvVbnb.Columns[12].HeaderText = "Nơi nhận";


        }public void laymaloaivanban()
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
            cblvb_vbnb.DataSource = table_MK;
            cblvb_vbnb.DisplayMember = table_MK.Columns["TenLVB"].ToString();
            cblvb_vbnb.ValueMember = table_MK.Columns["id"].ToString();


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
            cbnbh_vbnb.DataSource = table_MK;
            cbnbh_vbnb.DisplayMember = table_MK.Columns["TenNBH"].ToString();
            cbnbh_vbnb.ValueMember = table_MK.Columns["id"].ToString();


            kn.kn.Close();


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
            txbMa_vbnb.Text = "";
            txbKihieu_vbnb.Text = "";
            txbLinhvuc_vbnb.Text = "";
            txbTenVB.Text = "";
            txbTrich_vbnb.Text = "";
            txbNoidungvb_vbnb.Text = "";
            cblvb_vbnb.Text = "";
            cbnbh_vbnb.Text = "";
            dtpNgaytao.Text = "";
            numericUpDownvbnb1.Text = "";
            numericUpDownvbnb2.Text = "";
            txbDD.Text = "";
            txbNd.Text = "";


        }
        int flag;
        private void btnThem_Click(object sender, EventArgs e)
        {
            txbMa_vbnb.Enabled = true;
            AnHienBtn(false);
            flag = 0;//Thêm
            LamTuoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((dtgvVbnb.SelectedRows.Count < 0) || (txbMa_vbnb.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Văn bản bạn muốn sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AnHienBtn(true);
            }
            else
            {
                AnHienBtn(false);

                txbMa_vbnb.Enabled = false;
                flag = 1;//Sửa
                //LamTuoi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((dtgvVbnb.SelectedRows.Count < 0) || (txbMa_vbnb.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng chọn  Văn bản muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cmd.CommandText = "DELETE FROM vanbannoibo WHERE id= '" + txbMa_vbnb.Text.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                       // loaddtgvVBNB();
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
            if (txbMa_vbnb.TextLength == 0) { MessageBox.Show("Mã  văn bản nội bộ không thể để trống !"); }
            else
                if (txbKihieu_vbnb.TextLength == 0) { MessageBox.Show("Số/Kí hiệu văn bản nội bộ không thể để trống !"); }
                else
                    if (txbLinhvuc_vbnb.TextLength == 0) { MessageBox.Show("Lĩnh vực văn bản nội bộ không thể để trống !"); }
                    else
                        if (txbTenVB.TextLength == 0) { MessageBox.Show("Tên văn bản nội bộ không thể để trống !"); }
                      else
                            if (txbNd.TextLength == 0) { MessageBox.Show("Nơi nhận văn bản nội bộ không thể để trống !"); }
                        else
                            if (txbNd.TextLength == 0) { MessageBox.Show("Nơi nhận văn bản nội bộ không thể để trống !"); }
                            else
                                if (txbTrich_vbnb.TextLength == 0) { MessageBox.Show("Trích yếu văn bản nội bộ không thể để trống !"); }
                                else
                                    if (txbNoidungvb_vbnb.TextLength == 0) { MessageBox.Show("Nội dung văn bản nội bộ không thể để trống !"); }
                                    else
                                        if (txbMa_vbnb.TextLength > 10) { MessageBox.Show(" Vượt quá số lượng cho phép  !"); }
                                    else
                                    {
                                        SqlCommand cmd = new SqlCommand();
                                        cmd.Connection = conn;
                                        cmd.CommandType = CommandType.Text;

                                        if (flag == 0)
                                        {
                                            DataTable dt = new DataTable();
                                            SqlDataAdapter ad = new SqlDataAdapter("Select id from vanbannoibo where id='" + txbMa_vbnb.Text + "'", conn);
                                            ad.Fill(dt);
                                            if (dt.Rows.Count > 0)
                                            {
                                                MessageBox.Show("Mã  văn bản nội bộ đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                            }
                                            else
                                            {

                                                cmd.CommandText = "insert into vanbannoibo(id,Kihieu,idLVB,idNBH,Linhvuc,Sotrang,Soban,Filetaptin,NoidungVB,Trichyeu,Ngaytao,TenVB,Noinhan) values('" + txbMa_vbnb.Text.ToString() + "',N'" + txbKihieu_vbnb.Text.ToString() + "','"
                                    + cblvb_vbnb.SelectedValue.ToString()
                                    + "','" + cbnbh_vbnb.SelectedValue.ToString()
                                    + "',N'" + txbLinhvuc_vbnb.Text.ToString()
                                    + "','" + numericUpDownvbnb1.Value
                                    + "','" + numericUpDownvbnb2.Value
                                    + "',N'" + txbDD.Text.ToString()
                                    + "',N'" + txbNoidungvb_vbnb.Text.ToString()
                                    + "',N'" + txbTrich_vbnb.Text.ToString()
                                    + "','" + dtpNgaytao.Value.ToString("yyyy-MM-dd")
                                    + "',N'" + txbTenVB.Text.ToString()
                                    + "',N'" + txbNd.Text.ToString() + "')";

                                            }
                                        }
                                        else
                                        {
                                            cmd.CommandText = "Update vanbannoibo set Kihieu=N'" + txbKihieu_vbnb.Text.ToString() + "',idLVB=N'" + cblvb_vbnb.SelectedValue.ToString()
                                            + "',idNBH=N'" + cbnbh_vbnb.SelectedValue.ToString() + "',Linhvuc=N'" + txbLinhvuc_vbnb.Text.ToString() + "',Sotrang='" + numericUpDownvbnb1.Value + "',Soban='" + numericUpDownvbnb2.Value + "',Filetaptin=N'" + txbDD.Text.ToString() + "',NoidungVB=N'" + txbNoidungvb_vbnb.Text.ToString() + "',Trichyeu =N'" + txbTrich_vbnb.Text.ToString() + "',Ngaytao='" + dtpNgaytao.Value.ToString("yyyy-MM-dd") + "',TenVB=N'" + txbTenVB.Text.ToString() + "',Noinhan=N'" + txbNd.Text.ToString() + "' where id='" + txbMa_vbnb.Text.ToString() + "'";
                                        }
                                        cmd.Connection.Open();
                                        cmd.ExecuteNonQuery();
                                        cmd.Connection.Close();
                                        AnHienBtn(true);

                                        //loaddtgvVBNB();
                                        loadData();
                                        LamTuoi();
                                    }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
             LamTuoi();
            AnHienBtn(true);
        }
        int dong;
        private void dtgvVbnb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;

                txbMa_vbnb.Text = dtgvVbnb.Rows[dong].Cells[0].Value.ToString();
                txbKihieu_vbnb.Text = dtgvVbnb.Rows[dong].Cells[1].Value.ToString();
                cblvb_vbnb.Text = dtgvVbnb.Rows[dong].Cells[2].Value.ToString();
                cbnbh_vbnb.Text = dtgvVbnb.Rows[dong].Cells[3].Value.ToString();
                txbLinhvuc_vbnb.Text = dtgvVbnb.Rows[dong].Cells[4].Value.ToString();
                numericUpDownvbnb1.Text = dtgvVbnb.Rows[dong].Cells[5].Value.ToString();
                numericUpDownvbnb2.Text = dtgvVbnb.Rows[dong].Cells[6].Value.ToString();
                txbDD.Text = dtgvVbnb.Rows[dong].Cells[7].Value.ToString();
                txbNoidungvb_vbnb.Text = dtgvVbnb.Rows[dong].Cells[8].Value.ToString();
                txbTrich_vbnb.Text = dtgvVbnb.Rows[dong].Cells[9].Value.ToString();
                dtpNgaytao.Text = dtgvVbnb.Rows[dong].Cells[10].Value.ToString();
                txbTenVB.Text = dtgvVbnb.Rows[dong].Cells[11].Value.ToString();
                txbNd.Text = dtgvVbnb.Rows[dong].Cells[12].Value.ToString();
             
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Văn bản nội bộ";
            open.Filter = "|*.doc;*.pdf;*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {

                txbDD.Text = open.FileName;
            }
        }

        private void txbMa_vbnb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mã văn bản chỉ được nhập số !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}