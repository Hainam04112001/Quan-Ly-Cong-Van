namespace DXqlvt
{
    partial class fInnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.nguoidungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet1 = new DXqlvt.QLVTDataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chucvuTableAdapter = new DXqlvt.QLVTDataSet1TableAdapters.chucvuTableAdapter();
            this.nguoidungTableAdapter = new DXqlvt.QLVTDataSet1TableAdapters.nguoidungTableAdapter();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nguoidungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nguoidungBindingSource
            // 
            this.nguoidungBindingSource.DataMember = "nguoidung";
            this.nguoidungBindingSource.DataSource = this.qLVTDataSet1;
            // 
            // qLVTDataSet1
            // 
            this.qLVTDataSet1.DataSetName = "QLVTDataSet1";
            this.qLVTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.chucvuBindingSource;
            this.comboBox1.DisplayMember = "TenCV";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id";
            // 
            // chucvuBindingSource
            // 
            this.chucvuBindingSource.DataMember = "chucvu";
            this.chucvuBindingSource.DataSource = this.qLVTDataSet1;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(469, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(79, 24);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "Chọn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nguoidungBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DXqlvt.fInnd.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 61);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(804, 413);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // chucvuTableAdapter
            // 
            this.chucvuTableAdapter.ClearBeforeFill = true;
            // 
            // nguoidungTableAdapter
            // 
            this.nguoidungTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(588, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Kết thúc";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fInnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 486);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 524);
            this.MinimizeBox = false;
            this.Name = "fInnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NGƯỜI DÙNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fInnd_FormClosing);
            this.Load += new System.EventHandler(this.fInnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nguoidungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnIn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLVTDataSet1 qLVTDataSet1;
        private System.Windows.Forms.BindingSource chucvuBindingSource;
        private QLVTDataSet1TableAdapters.chucvuTableAdapter chucvuTableAdapter;
        private System.Windows.Forms.BindingSource nguoidungBindingSource;
        private QLVTDataSet1TableAdapters.nguoidungTableAdapter nguoidungTableAdapter;
        private System.Windows.Forms.Button btnThoat;
    }
}