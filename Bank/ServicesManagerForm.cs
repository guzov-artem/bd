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
  public partial class ServicesManagerForm : MetroFramework.Forms.MetroForm
  {
    public ServicesManagerForm()
    {
      InitializeComponent();
      dB = new DB();
      providerIdList = new List<int>();
    }
    private DB dB;
    private List<int> providerIdList;

    private void ServicesManagerForm_Load(object sender, EventArgs e)
    {
      LoadServices();
      LoadCompanisBox();
    }
private void LoadCompanisBox() {
      dB.openConnection();
      String strSQL = "SELECT [Name], [ProviderID] FROM [ServiceProviders]";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      OleDbDataReader Reader = cmdIC.ExecuteReader();
      while (Reader.Read()) {
        companiesBox.Items.Add(Reader[0]);
        int temp;
        int.TryParse(Reader[1].ToString(), out temp);
        providerIdList.Add(temp);
      }
      dB.closeConnection();
    }

    private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      
    }
    private void LoadServices()
    {
      dB.openConnection();
      String strSQL = "SELECT [Price], [ServiceName], ServiceProviders.Name FROM[Services] JOIN[ServiceProviders] ON[Services].ProviderID = ServiceProviders.ProviderID";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      OleDbDataReader Reader = cmdIC.ExecuteReader();
      List<string[]> data = new List<string[]>();
      while (Reader.Read())
      {
        data.Add(new string[3]);
        data[data.Count - 1][0] = Reader[2].ToString();
        data[data.Count - 1][1] = Reader[1].ToString();
        data[data.Count - 1][2] = Reader[0].ToString();
      }
      for (int i = 0; i < data.Count; i++)
      {
        metroGrid1.Rows.Add(data[i]);
      }
      dB.closeConnection();
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      dB.openConnection();
      int price;
      int.TryParse(priceField.Text, out price);
      String strSQL = "Insert Into Services ([Price],[ServiceName],[ProviderID]) Values (?,?, ? )";

      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@Price", MySqlDbType.Int32).Value = price;
      cmdIC.Parameters.Add("@ServiceName", MySqlDbType.VarChar).Value = NameField.Text;
      cmdIC.Parameters.Add("@ProviderID", MySqlDbType.Int32).Value = providerIdList[companiesBox.SelectedIndex];

      cmdIC.ExecuteNonQuery();
      dB.closeConnection();
    }

    private void label1_Click(object sender, EventArgs e)
    {

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
