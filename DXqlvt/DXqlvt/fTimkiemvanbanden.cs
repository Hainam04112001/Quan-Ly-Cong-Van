using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;


namespace DXqlvt
{
    public partial class fTimkiemvanbanden : DevExpress.XtraEditors.XtraForm
    {
        public fTimkiemvanbanden()
        {
            InitializeComponent();
        }

        private void fTimkiemvanbanden_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLVTDataSet10.View_3' table. You can move, or remove it, as needed.
            this.View_3TableAdapter.Fill(this.QLVTDataSet10.View_3);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fTimkiemvanbanden_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) { MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm"); }
            else
            {
                SetParameters(textBox1.Text.ToString());
                reportViewer1.RefreshReport();
            }
        }
        private void SetParameters(string Kihieu)
        {
            ReportParameter rp = new ReportParameter("Kihieu");

            rp.Values.Add(Kihieu);
            reportViewer1.LocalReport.SetParameters(rp);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}