using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace Bank
{
  class DB
  {
    private OleDbConnection cn = new OleDbConnection();

    public void openConnection() {
      cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-CN6CMAM;Persist Security Info=True;Password=sa;User ID=sa;Initial Catalog=Kursach-testversion";
      if (cn.State == System.Data.ConnectionState.Closed) {
        cn.Open();
      }
    }

    public void closeConnection()
    {
      if (cn.State == System.Data.ConnectionState.Open)
      {
        cn.Close();
      }
    }

    public OleDbConnection getConnecion() {
      return cn;
    }
  }
}
