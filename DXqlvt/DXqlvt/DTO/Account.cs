
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DXqlvt.DAO;
using System.Data.SqlClient;

namespace DXqlvt.DTO
{
   public class Account
   {
       public Account(string userName, string displayName, int quyen,string diachi, string password = null)
       {
           this.UserName = userName;
           this.DisplayName = displayName;
           this.Password = password;
           this.Quyen = quyen;
           //this.Chucvu = chucvu;
           this.Diachi = diachi;

       }
       public Account(DataRow row)
       {
           this.UserName = row["userName"].ToString();
           this.DisplayName = row["displayName"].ToString();
           this.Password = row["password"].ToString();
           this.Quyen = (int)row["quyen"];
          // this.Chucvu = row["chucvu"].ToString();
           this.Diachi = row["diachi"].ToString();

       }
       private string password;

       public string Password
       {
           get { return password; }
           set { password = value; }
       }
      

       private string diachi;

       public string Diachi
       {
           get { return diachi; }
           set { diachi = value; }
       }
       private int quyen;

       public int Quyen
       {
           get { return quyen; }
           set { quyen = value; }
       }
       private string displayName;

       public string DisplayName
       {
           get { return displayName; }
           set { displayName = value; }
       }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
