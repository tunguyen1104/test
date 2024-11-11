﻿using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1.Classes
{
    internal class ConnectData
    {
        static string strConnect = "Data Source=TUNGUYEN;Initial Catalog=DuLieu2;Integrated Security=True";
        public SqlConnection sqlConn = null;
        // opening connect method
        public void OpenConnect()
        {
            sqlConn = new SqlConnection(strConnect);
            if(sqlConn.State != ConnectionState.Open)
                sqlConn.Open();
        }
        //Closing connect method
        public void CloseConnect()
        {
            if(sqlConn.State!=ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }
        //insert,update,delete data
        public void UpdateData(string sql)
        {
            OpenConnect();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = sql;
            sqlComm.ExecuteNonQuery();
            CloseConnect();
            sqlComm.Dispose();
        }
        //Select data to return a DataTable
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter sqldata = new SqlDataAdapter(sqlSelect, sqlConn);
            sqldata.Fill(dt);
            CloseConnect();
            sqldata.Dispose();
            return dt;
        }

    }
}
