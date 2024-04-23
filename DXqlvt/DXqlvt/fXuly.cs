using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;

namespace DXqlvt
{
    public partial class fXuly : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        public fXuly()
        {
            InitializeComponent();
        }
        FileDialog dl;
        private void fXuly_Load(object sender, EventArgs e)
        {
            lamtuoi();
        }
        void lamtuoi() 
        {
            textBox1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)//chọn
        {
            if (rdobackup.Checked == true)
            {
                dl = new SaveFileDialog();

            }
            else
            {
                dl = new OpenFileDialog();
            }
            dl.Filter = "Flie type (*.bak)|*.bak";//lọc file
            dl.DefaultExt = "bak";//flie mặc định
            if(dl.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dl.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)//thực hiện
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng  chọn file");
            }else if(rdobackup.Checked == true)
            {
                //backup
                if (!Directory.Exists(Path.GetDirectoryName(textBox1.Text)))//tách tên thư mục và kiểm tra thư mục có tồn tại
                {
                    MessageBox.Show("Thư mục không tồn tại!");
                }
                else 
                {
                   // Program.KetNoi();
                    SqlCommand cmdbackup = new SqlCommand();
                    cmdbackup.Connection = conn;
                    cmdbackup.CommandType = CommandType.Text;
                    cmdbackup.CommandText = "BACKUP DATABASE QLVT TO DISK='" + textBox1.Text +"'WITH FORMAT";
                    cmdbackup.Connection.Open();
                    cmdbackup.ExecuteNonQuery();
                    MessageBox.Show("Sao lưu dữ liệu thành công");
                    lamtuoi();
                    cmdbackup.Connection.Close();
                }
            }else if(rdorestore.Checked == true)
            {//restore
                if (!File.Exists(textBox1.Text))
                {
                    MessageBox.Show("File không tồn tại !");
                }
                else 
                {
                    string database = conn.Database.ToString();
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    try
                    {
                        string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                        SqlCommand bu2 = new SqlCommand(sqlStmt2, conn);
                        bu2.ExecuteNonQuery();

                        string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox1.Text + "'WITH REPLACE;";
                        SqlCommand bu3 = new SqlCommand(sqlStmt3, conn);
                        bu3.ExecuteNonQuery();

                        string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                        SqlCommand bu4 = new SqlCommand(sqlStmt4, conn);
                        bu4.ExecuteNonQuery();

                        MessageBox.Show("Dữ liệu đã được khôi phục");
                        lamtuoi();
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fXuly_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát  hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}