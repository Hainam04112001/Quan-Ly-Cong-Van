using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;

namespace DXqlvt
{
    public partial class ftimkiemvbden : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ftimkiemvbden(string keyword)
        {
            InitializeComponent();
            showfTKVBD(keyword);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
        private void showfTKVBD(string s)
        {

            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from View_3 where Kihieu like N'%" + s + "%' ", conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                dt.Columns["id"].ColumnName = "Mã văn bản";
                dt.Columns["Kihieu"].ColumnName = "Kí hiệu";
                dt.Columns["TenLVB"].ColumnName = "Loại văn bản";
                dt.Columns["TenNBH"].ColumnName = "Nơi ban hành";
                dt.Columns["Nguoiky"].ColumnName = "Người ký";
                dt.Columns["Nguoiduyet"].ColumnName = "Người duyệt";
                dt.Columns["Nguoinhan"].ColumnName = "Người nhận";
                dt.Columns["Linhvuc"].ColumnName = "Lĩnh vực";
                dt.Columns["Sotrang"].ColumnName = "Số trang";
                dt.Columns["Soban"].ColumnName = "Số bản";
                dt.Columns["Filetaptin"].ColumnName = "File đính kèm";
                dt.Columns["NoidungVB"].ColumnName = "Nội dung văn bản";
                dt.Columns["Trichyeu"].ColumnName = "Nội dung tóm tắt";
                dt.Columns["NgayBH"].ColumnName = "Ngày ban hành";
                dt.Columns["Ngaynhan"].ColumnName = "Ngày nhận";

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ftimkiemvbden_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}