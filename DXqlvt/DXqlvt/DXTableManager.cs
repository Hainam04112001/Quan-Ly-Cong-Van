using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DXqlvt.DTO;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DXqlvt
{
    public partial class DXTableManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True");
      
       
      
        public DXTableManager()
        {
            InitializeComponent();
         //   this.loginAccount = acc;
        }
        private void DXTableManager_Load(object sender, EventArgs e)
        {
            skin();

        }
        public void skin() 
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Xmas 2008 Blue";
        }

        

        private void DXTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void barThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barDoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            fProfileManager f = new fProfileManager(Class1.taikhoan,Class1.matkhau);
            f.ShowDialog();
        }

        private void barVBdi_ItemClick(object sender, ItemClickEventArgs e)
        {
            fVanbandi f = new fVanbandi();
            f.ShowDialog();
        }

        private void barVBden_ItemClick(object sender, ItemClickEventArgs e)
        {
            fVanbanden f = new fVanbanden();
            f.ShowDialog();
        }

        private void barVBnoibo_ItemClick(object sender, ItemClickEventArgs e)
        {
            fVanbannoibo f = new fVanbannoibo();
            f.ShowDialog();
        }

        private void barLVB_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm5 f = new XtraForm5();
            f.ShowDialog();
        }

        private void barNBH_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm6 f = new XtraForm6();
            f.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm3 f = new XtraForm3();
            f.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            fQuanlynguoidung f = new fQuanlynguoidung();
            f.ShowDialog();
        }

      


        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Baocao.pptx");
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            fInnd f = new fInnd();
            f.ShowDialog();
        }

     

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            fTimkiemvanbanden f = new fTimkiemvanbanden();
            f.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
           // fTimkiemdi f = new fTimkiemdi();
          //  f.ShowDialog();
            Timkiemdi f = new Timkiemdi();
            f.ShowDialog();
        }

      

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            fXuly f = new fXuly();
            f.ShowDialog();
        }

        
        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm2 f = new XtraForm2();
            f.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            fInddi f = new fInddi();
            f.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            fIndi f = new fIndi();
            f.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            fInnb f = new fInnb();
            f.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            Timkiemvbnb f = new Timkiemvbnb();
            f.ShowDialog();
        }
    }
}