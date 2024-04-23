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
    public partial class XtraForm4 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        public XtraForm4()
        {
            InitializeComponent();
          //  dtGVNBH.DataSource = LoadRecord(pageNumber, numberRecord);
        }

        
        void loadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from noibanhanh", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtGVNBH.Rows.Clear();
            foreach (DataRow data in dt.Rows)
            {
                int aa = dtGVNBH.Rows.Add();
                dtGVNBH.Rows[aa].Cells[0].Value = "false";
                dtGVNBH.Rows[aa].Cells[1].Value = data["id"].ToString();
                dtGVNBH.Rows[aa].Cells[2].Value = data["TenNBH"].ToString();
                dtGVNBH.Rows[aa].Cells[3].Value = data["Ghichu"].ToString();
            }
        }

        private void XtraForm4_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtGVNBH.Rows)
            {
                if (bool.Parse(row.Cells[0].Value.ToString()))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from noibanhanh where id='" + row.Cells[1].Value.ToString() + "'", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }


            }
            MessageBox.Show("SuccessFully Deleted...");
            loadData();
        }
        
    }
}