using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
  public partial class CompaniesForm : MetroFramework.Forms.MetroForm
  {
    public CompaniesForm()
    {
      InitializeComponent();
      dB = new DB();
    }
    private DB dB;

    private void CompaniesForm_Load(object sender, EventArgs e)
    {
      LoadCompanies();
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }
    private void LoadCompanies()
    {
      dB.openConnection();
      String strSQL = "SELECT [Name], [PhoneNumber] FROM [ServiceProviders]";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      OleDbDataReader Reader = cmdIC.ExecuteReader();
      List<string[]> data = new List<string[]>();
      while (Reader.Read())
      {
        data.Add(new string[2]);
        data[data.Count - 1][0] = Reader[0].ToString();
        data[data.Count - 1][1] = Reader[1].ToString();
      }
      for (int i = 0; i < data.Count; i++)
      {
        metroGrid1.Rows.Add(data[i]);
      }
      dB.closeConnection();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      dB.openConnection();
      String strSQL = "Insert Into [ServiceProviders] ([Name], [PhoneNumber]) Values (?, ? )";
      

      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@Name", SqlDbType.VarChar).Value = NameField.Text;
      cmdIC.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = telephoneField.Text;
      if (cmdIC.ExecuteNonQuery() == 1)
      {
        MessageBox.Show("Added");
      }
      else
      {
        MessageBox.Show("Failed");
      }
    }
    private void depositsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      CompaniesForm companiesForm = new CompaniesForm();
      companiesForm.Show();
    }

    private void creditsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      ServicesManagerForm servicesManagerForm = new ServicesManagerForm();
      servicesManagerForm.Show();
    }

    private void mainButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      MainMarketingForm servicesManagerForm = new MainMarketingForm();
      servicesManagerForm.Show();
    }
  }
}
