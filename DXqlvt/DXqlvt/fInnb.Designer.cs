namespace DXqlvt
{
    partial class fInnb
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
            this.View_7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet9 = new DXqlvt.QLVTDataSet9();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loaivanbanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLVTDataSet6 = new DXqlvt.QLVTDataSet6();
            this.loaivanbanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaivanbanTableAdapter = new DXqlvt.QLVTDataSet6TableAdapters.loaivanbanTableAdapter();
            this.loaivanbanTableAdapter1 = new DXqlvt.QLVTDataSet9TableAdapters.loaivanbanTableAdapter();
            this.View_7TableAdapter = new DXqlvt.QLVTDataSet9TableAdapters.View_7TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaivanbanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaivanbanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // View_7BindingSource
            // 
            this.View_7BindingSource.DataMember = "View_7";
            this.View_7BindingSource.DataSource = this.qLVTDataSet9;
            // 
            // qLVTDataSet9
            // 
            this.qLVTDataSet9.DataSetName = "QLVTDataSet9";
            this.qLVTDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên loại công văn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(908, 33);
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
            this.button1.Location = new System.Drawing.Point(783, 33);
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
            this.comboBox1.DataSource = this.loaivanbanBindingSource1;
            this.comboBox1.DisplayMember = "TenLVB";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(433, 33);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "id";
            // 
            // loaivanbanBindingSource1
            // 
            this.loaivanbanBindingSource1.DataMember = "loaivanban";
            this.loaivanbanBindingSource1.DataSource = this.qLVTDataSet9;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_7BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DXqlvt.invbnb.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 102);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1192, 531);
            this.reportViewer1.TabIndex = 8;
            // 
            // qLVTDataSet6
            // 
            this.qLVTDataSet6.DataSetName = "QLVTDataSet6";
            this.qLVTDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaivanbanBindingSource
            // 
            this.loaivanbanBindingSource.DataMember = "loaivanban";
            this.loaivanbanBindingSource.DataSource = this.qLVTDataSet6;
            // 
            // loaivanbanTableAdapter
            // 
            this.loaivanbanTableAdapter.ClearBeforeFill = true;
            // 
            // loaivanbanTableAdapter1
            // 
            this.loaivanbanTableAdapter1.ClearBeforeFill = true;
            // 
            // View_7TableAdapter
            // 
            this.View_7TableAdapter.ClearBeforeFill = true;
            // 
            // fInnb
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
            this.Name = "fInnb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN CÔNG VĂN NỘI BỘ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fInnb_FormClosing);
            this.Load += new System.EventHandler(this.fInnb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaivanbanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet6)).EndInit();
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
        private QLVTDataSet6 qLVTDataSet6;
        private System.Windows.Forms.BindingSource loaivanbanBindingSource;
        private QLVTDataSet6TableAdapters.loaivanbanTableAdapter loaivanbanTableAdapter;
        private QLVTDataSet9 qLVTDataSet9;
        private System.Windows.Forms.BindingSource loaivanbanBindingSource1;
        private QLVTDataSet9TableAdapters.loaivanbanTableAdapter loaivanbanTableAdapter1;
        private System.Windows.Forms.BindingSource View_7BindingSource;
        private QLVTDataSet9TableAdapters.View_7TableAdapter View_7TableAdapter;
    }
}