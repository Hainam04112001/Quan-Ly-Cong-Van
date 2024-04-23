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

namespace DXqlvt
{
    public partial class fUser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
      
        public fUser()
        {
            InitializeComponent();
        }

        private void fUser_Load(object sender, EventArgs e)
        {
            skin();
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Whiteprint";
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void fUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn đăng xuất hay không ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            fProfileManager f = new fProfileManager(Class1.taikhoan,Class1.matkhau);
            f.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            fVanbandi f = new fVanbandi();
            f.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            fVanbanden f = new fVanbanden();
            f.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            fVanbannoibo f = new fVanbannoibo();
            f.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm5 f = new XtraForm5();
            f.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm6 f = new XtraForm6();
            f.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm3 f = new XtraForm3();
            f.ShowDialog();

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {

         //   XtraForm1 f = new XtraForm1();
           // f.Show();
            System.Diagnostics.Process.Start("Baocao.pptx");
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            fInddi f = new fInddi();
            f.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            fIndi f = new fIndi();
            f.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            fInnb f = new fInnb();
            f.ShowDialog();
        }

       
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            fTimkiemvanbanden f = new fTimkiemvanbanden();
            f.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            Timkiemdi f = new Timkiemdi();
            f.ShowDialog();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            fInddi f = new fInddi();
            f.ShowDialog();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            fIndi f = new fIndi();
            f.ShowDialog();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            fInnb f = new fInnb();
            f.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Timkiemvbnb f = new Timkiemvbnb();
            f.ShowDialog();
        }

     
     
        

      
    }
}