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
    public partial class Timkiemdi : DevExpress.XtraEditors.XtraForm
    {
        public Timkiemdi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timkiemdi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLVTDataSet3.View_2' table. You can move, or remove it, as needed.
            this.View_2TableAdapter.Fill(this.QLVTDataSet3.View_2);

            this.reportViewer1.RefreshReport();
        }
        private void SetParameters(string Kihieu)
        {
            ReportParameter rp = new ReportParameter("Kihieu");

            rp.Values.Add(Kihieu);
            reportViewer1.LocalReport.SetParameters(rp);
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
       
    }
}