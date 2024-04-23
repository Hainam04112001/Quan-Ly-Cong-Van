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
    public partial class fInnb : DevExpress.XtraEditors.XtraForm
    {
        public fInnb()
        {
            InitializeComponent();
        }

        private void fInnb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVTDataSet9.View_7' table. You can move, or remove it, as needed.
            this.View_7TableAdapter.Fill(this.qLVTDataSet9.View_7);
            // TODO: This line of code loads data into the 'qLVTDataSet9.loaivanban' table. You can move, or remove it, as needed.
            this.loaivanbanTableAdapter1.Fill(this.qLVTDataSet9.loaivanban);

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
        private void button1_Click(object sender, EventArgs e)
        {
            SetParameters(comboBox1.SelectedValue.ToString());
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fInnb_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}