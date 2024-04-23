using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DXqlvt.DAO;
using DXqlvt.DTO;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DXqlvt
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
       
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
           
            SqlCommand cmd = new SqlCommand("Select * From nguoidung where UserName='" + txbUser.Text + "' and PassWord='" + txbPass.Text + "' and Quyen=1", conn);

            cmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               // Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
            //    MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                Class1.taikhoan = this.txbUser.Text;
               Class1.matkhau = this.txbPass.Text;
                
                
                DXTableManager f = new DXTableManager();
                
                this.Hide();
                f.ShowDialog();
                this.Show();

                cmd.Dispose();
                reader.Close();
                reader.Dispose();
            }

            else
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
                string select1 = "Select * From nguoidung where UserName='" + txbUser.Text + "' and PassWord='" + txbPass.Text + "' and Quyen=0";
                SqlCommand cmd1 = new SqlCommand(select1, conn);
                SqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {
                   // MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                    Class1.taikhoan = this.txbUser.Text;
                   Class1.matkhau = this.txbPass.Text;
                    fUser f = new fUser();
                    
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                   
                
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                cmd1.Dispose();
                reader1.Close();
                reader1.Dispose();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }


        /*  bool Login(string userName, string passWord)
          {
              //  return AccountDAO.Instance.Login(userName, passWord);
              return AccountDAO.Instance.Login(userName, passWord);
          }

          private void Form1_FormClosing(object sender, FormClosingEventArgs e)
          {
             
          }

          private void btnLogin_Click(object sender, EventArgs e)
          {
              string userName = txbUser.Text;
              string passWord = txbPass.Text;
              if (Login(userName, passWord))
              {
                 Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                  DXTableManager f = new DXTableManager(loginAccount);
                  this.Hide();
                  f.ShowDialog();
                  this.Show();
              }
              else
              {
                  MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
              }
          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }*/

        public string userName { get; set; }

    }
}
