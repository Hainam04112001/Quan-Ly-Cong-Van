using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DXqlvt.DTO;

namespace DXqlvt.DAO
{
   public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.nguoidung WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from nguoidung where UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass, string chucvu,string diachi)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword , @chucvu , @diachi ", new object[] { userName, displayName, pass, newPass, chucvu, diachi });

            return result > 0;
        }

        //lấy ds tài khoản
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, quyen FROM dbo.nguoidung");
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("update nguoidung set PassWord = N'0' where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
