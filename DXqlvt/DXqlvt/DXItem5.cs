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
    public partial class DXItem5 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        public DXItem5()
        {
            InitializeComponent(); 
            dtgvVbnb.DataSource = LoadRecord(pageNumber, numberRecord);
        }

        private void DXItem5_Load(object sender, EventArgs e)
        {

        }
        void loadData()
        {
            using (ThongtinvanbannoiboDataContext db = new ThongtinvanbannoiboDataContext())
            {
                dtgvVbnb.DataSource = db.View_1s.ToList();
            }
        }
        int pageNumber = 1;
        int numberRecord = 1;
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

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using (ThongtinvanbannoiboDataContext db = new ThongtinvanbannoiboDataContext())
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
        int dong;
        private void dtgvVbnb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
               // txbMa_vbnb.Text = dtgvVbnb.Rows[dong].Cells[0].Value.ToString();

                txbNd.Text = dtgvVbnb.Rows[dong].Cells[12].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}