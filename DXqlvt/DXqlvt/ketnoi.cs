﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DXqlvt
{
    class ketnoi
    {
        public SqlConnection kn = new SqlConnection();
        public void kn_csdl()
        {
            string chuoikn = "Data Source=DESKTOP-7SU81BF\\SQLEXPRESS;Initial Catalog=QLVT;Integrated Security=True";
            
            kn.ConnectionString = chuoikn;
            kn.Open();
        }
        public string lay1giatri(string sql)
        {
            string kq = "";
            try
            {
                kn_csdl();

                SqlCommand sqlComm = new SqlCommand(sql, kn);
                SqlDataReader r = sqlComm.ExecuteReader();
                if (r.Read())
                {
                    kq = r["tong"].ToString();
                }
            }
            catch
            { }
            return kq;
        }


        public void dongketnoi()
        {
            if (kn.State == ConnectionState.Open)
            { kn.Close(); }
        }
        public DataTable bangdulieu = new DataTable();
        public DataTable laybang(string caulenh)
        {
            try
            {
                kn_csdl();
                SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, kn);
                DataSet ds = new DataSet();

                Adapter.Fill(bangdulieu);
            }
            catch (System.Exception)
            {
                bangdulieu = null;
            }
            finally
            {
                dongketnoi();
            }

            return bangdulieu;
        }

        public int xulydulieu(string caulenhsql)
        {
            int kq = 0;
            try
            {
                kn_csdl();
                SqlCommand lenh = new SqlCommand(caulenhsql, kn);
                kq = lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Thông báo lỗi ra!

                kq = 0;
            }
            finally
            {
                dongketnoi();
            }
            return kq;
        }

    }
}
