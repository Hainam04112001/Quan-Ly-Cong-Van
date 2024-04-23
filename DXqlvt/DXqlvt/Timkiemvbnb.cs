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
    public partial class Timkiemvbnb : DevExpress.XtraEditors.XtraForm
    {
        public Timkiemvbnb()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timkiemvbnb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLVTDataSet11.View_8' table. You can move, or remove it, as needed.
            this.View_8TableAdapter.Fill(this.QLVTDataSet11.View_8);

            this.reportViewer1.RefreshReport();
        }

        private void Timkiemvbnb_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}