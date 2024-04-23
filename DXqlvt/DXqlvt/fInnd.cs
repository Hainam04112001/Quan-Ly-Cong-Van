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
    public partial class fInnd : DevExpress.XtraEditors.XtraForm
    {
        public fInnd()
        {
            InitializeComponent();
        }

        private void fInnd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet1.nguoidung' table. You can move, or remove it, as needed.
            this.nguoidungTableAdapter.Fill(this.qLVTDataSet1.nguoidung);
            // TODO: This line of code loads data into the 'qLVTDataSet1.chucvu' table. You can move, or remove it, as needed.
            this.chucvuTableAdapter.Fill(this.qLVTDataSet1.chucvu);

            this.reportViewer1.RefreshReport();
            SetParameters(comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
        private void SetParameters(string id) 
        {
            ReportParameter rp = new ReportParameter("id");
          
            rp.Values.Add(id);
            reportViewer1.LocalReport.SetParameters(rp);
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            SetParameters(comboBox1.SelectedValue.ToString());
            reportViewer1.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fInnd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}