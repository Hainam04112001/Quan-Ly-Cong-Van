namespace DXqlvt
{
    partial class fInddi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.View_5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet5 = new DXqlvt.QLVTDataSet5();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loaivanbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.loaivanbanTableAdapter = new DXqlvt.QLVTDataSet5TableAdapters.loaivanbanTableAdapter();
            this.View_5TableAdapter = new DXqlvt.QLVTDataSet5TableAdapters.View_5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaivanbanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // View_5BindingSource
            // 
            this.View_5BindingSource.DataMember = "View_5";
            this.View_5BindingSource.DataSource = this.qLVTDataSet5;
            // 
            // qLVTDataSet5
            // 
            this.qLVTDataSet5.DataSetName = "QLVTDataSet5";
            this.qLVTDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.loaivanbanBindingSource;
            this.comboBox1.DisplayMember = "TenLVB";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(402, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id";
            // 
            // loaivanbanBindingSource
            // 
            this.loaivanbanBindingSource.DataMember = "loaivanban";
            this.loaivanbanBindingSource.DataSource = this.qLVTDataSet5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(752, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chọn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(877, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kết thúc";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên loại công văn";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.View_5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DXqlvt.invanbandi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 114);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1192, 519);
            this.reportViewer1.TabIndex = 4;
            // 
            // loaivanbanTableAdapter
            // 
            this.loaivanbanTableAdapter.ClearBeforeFill = true;
            // 
            // View_5TableAdapter
            // 
            this.View_5TableAdapter.ClearBeforeFill = true;
            // 
            // fInddi
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
            this.Name = "fInddi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN CÔNG VĂN ĐI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fInddi_FormClosing);
            this.Load += new System.EventHandler(this.fInddi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaivanbanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLVTDataSet5 qLVTDataSet5;
        private System.Windows.Forms.BindingSource loaivanbanBindingSource;
        private QLVTDataSet5TableAdapters.loaivanbanTableAdapter loaivanbanTableAdapter;
        private System.Windows.Forms.BindingSource View_5BindingSource;
        private QLVTDataSet5TableAdapters.View_5TableAdapter View_5TableAdapter;
    }
}