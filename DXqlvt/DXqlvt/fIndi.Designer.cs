namespace DXqlvt
{
    partial class fIndi
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
            this.View_6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet8 = new DXqlvt.QLVTDataSet8();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loaivanbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.loaivanbanTableAdapter = new DXqlvt.QLVTDataSet8TableAdapters.loaivanbanTableAdapter();
            this.View_6TableAdapter = new DXqlvt.QLVTDataSet8TableAdapters.View_6TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaivanbanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // View_6BindingSource
            // 
            this.View_6BindingSource.DataMember = "View_6";
            this.View_6BindingSource.DataSource = this.qLVTDataSet8;
            // 
            // qLVTDataSet8
            // 
            this.qLVTDataSet8.DataSetName = "QLVTDataSet8";
            this.qLVTDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên loại công văn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(824, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Kết thúc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.loaivanbanBindingSource;
            this.comboBox1.DisplayMember = "TenLVB";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(349, 53);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "id";
            // 
            // loaivanbanBindingSource
            // 
            this.loaivanbanBindingSource.DataMember = "loaivanban";
            this.loaivanbanBindingSource.DataSource = this.qLVTDataSet8;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_6BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DXqlvt.invanbanden.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 128);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1192, 505);
            this.reportViewer1.TabIndex = 8;
            // 
            // loaivanbanTableAdapter
            // 
            this.loaivanbanTableAdapter.ClearBeforeFill = true;
            // 
            // View_6TableAdapter
            // 
            this.View_6TableAdapter.ClearBeforeFill = true;
            // 
            // fIndi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 647);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1062, 567);
            this.MinimumSize = new System.Drawing.Size(1048, 567);
            this.Name = "fIndi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN CÔNG VĂN ĐẾN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fIndi_FormClosing);
            this.Load += new System.EventHandler(this.fIndi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaivanbanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLVTDataSet8 qLVTDataSet8;
        private System.Windows.Forms.BindingSource loaivanbanBindingSource;
        private QLVTDataSet8TableAdapters.loaivanbanTableAdapter loaivanbanTableAdapter;
        private System.Windows.Forms.BindingSource View_6BindingSource;
        private QLVTDataSet8TableAdapters.View_6TableAdapter View_6TableAdapter;
    }
}