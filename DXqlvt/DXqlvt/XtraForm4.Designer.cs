namespace DXqlvt
{
    partial class XtraForm4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm4));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGhiNBH = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTenNBH = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaNBH = new System.Windows.Forms.TextBox();
            this.noibanhanhBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLVTDataSet1 = new DXqlvt.QLVTDataSet1();
            this.noibanhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noibanhanhTableAdapter = new DXqlvt.QLVTDataSet1TableAdapters.noibanhanhTableAdapter();
            this.dtGVNBH = new System.Windows.Forms.DataGridView();
            this.chkChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noibanhanhBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noibanhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNBH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnHuy);
            this.groupBox6.Controls.Add(this.btnLuu);
            this.groupBox6.Controls.Add(this.btnXoa);
            this.groupBox6.Controls.Add(this.btnThem);
            this.groupBox6.Controls.Add(this.btnSua);
            this.groupBox6.Controls.Add(this.btnThoat);
            this.groupBox6.Location = new System.Drawing.Point(600, 366);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(509, 251);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // btnHuy
            // 
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(350, 177);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 60);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(85, 177);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 60);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = " Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(350, 20);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 60);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(84, 20);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 60);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "         Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(85, 98);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 63);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "     Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(350, 98);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 63);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "    Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.panel7);
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.Location = new System.Drawing.Point(600, 62);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(509, 245);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txbGhiNBH);
            this.panel6.Location = new System.Drawing.Point(37, 144);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(463, 92);
            this.panel6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(27, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ghi chú";
            // 
            // txbGhiNBH
            // 
            this.txbGhiNBH.Location = new System.Drawing.Point(154, 4);
            this.txbGhiNBH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbGhiNBH.Multiline = true;
            this.txbGhiNBH.Name = "txbGhiNBH";
            this.txbGhiNBH.Size = new System.Drawing.Size(275, 84);
            this.txbGhiNBH.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txbTenNBH);
            this.panel7.Location = new System.Drawing.Point(37, 91);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(463, 49);
            this.panel7.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(27, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên nơi ban hành";
            // 
            // txbTenNBH
            // 
            this.txbTenNBH.Location = new System.Drawing.Point(154, 14);
            this.txbTenNBH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTenNBH.Name = "txbTenNBH";
            this.txbTenNBH.Size = new System.Drawing.Size(275, 23);
            this.txbTenNBH.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.txbMaNBH);
            this.panel8.Location = new System.Drawing.Point(37, 34);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(463, 49);
            this.panel8.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(27, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã nơi ban hành";
            // 
            // txbMaNBH
            // 
            this.txbMaNBH.Location = new System.Drawing.Point(154, 14);
            this.txbMaNBH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMaNBH.Name = "txbMaNBH";
            this.txbMaNBH.Size = new System.Drawing.Size(275, 23);
            this.txbMaNBH.TabIndex = 1;
            // 
            // noibanhanhBindingSource1
            // 
            this.noibanhanhBindingSource1.DataMember = "noibanhanh";
            this.noibanhanhBindingSource1.DataSource = this.qLVTDataSet1;
            // 
            // qLVTDataSet1
            // 
            this.qLVTDataSet1.DataSetName = "QLVTDataSet1";
            this.qLVTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noibanhanhBindingSource
            // 
            this.noibanhanhBindingSource.DataMember = "noibanhanh";
            this.noibanhanhBindingSource.DataSource = this.qLVTDataSet1;
            // 
            // noibanhanhTableAdapter
            // 
            this.noibanhanhTableAdapter.ClearBeforeFill = true;
            // 
            // dtGVNBH
            // 
            this.dtGVNBH.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            this.dtGVNBH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGVNBH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtGVNBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVNBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkChon,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtGVNBH.Location = new System.Drawing.Point(8, 23);
            this.dtGVNBH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGVNBH.Name = "dtGVNBH";
            this.dtGVNBH.RowHeadersWidth = 51;
            this.dtGVNBH.Size = new System.Drawing.Size(534, 518);
            this.dtGVNBH.TabIndex = 0;
            // 
            // chkChon
            // 
            this.chkChon.HeaderText = "Chọn";
            this.chkChon.MinimumWidth = 6;
            this.chkChon.Name = "chkChon";
            this.chkChon.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã nơi ban hành";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Tên nơi ban hành";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtGVNBH);
            this.groupBox2.Location = new System.Drawing.Point(14, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(550, 555);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách cơ quan ban hành công văn";
            // 
            // XtraForm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "XtraForm4";
            this.Text = "XtraForm4";
            this.Load += new System.EventHandler(this.XtraForm4_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noibanhanhBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noibanhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVNBH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGhiNBH;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTenNBH;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMaNBH;
        private QLVTDataSet1 qLVTDataSet1;
        private System.Windows.Forms.BindingSource noibanhanhBindingSource;
        private QLVTDataSet1TableAdapters.noibanhanhTableAdapter noibanhanhTableAdapter;
        private System.Windows.Forms.BindingSource noibanhanhBindingSource1;
        private System.Windows.Forms.DataGridView dtGVNBH;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}