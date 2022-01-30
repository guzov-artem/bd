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
  public partial class ServicesForm : MetroFramework.Forms.MetroForm
  {
    public ServicesForm()
    {
      InitializeComponent();
      dB = new DB();
      serviceIdList = new List<int>();
    }
    private DB dB;
    private List<int> serviceIdList;

    private void ServicesForm_Load(object sender, EventArgs e)
    {
      LoadServices();
    }

    private void ServicesForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
    private void LoadServices()
    {
      dB.openConnection();
      String strSQL = "SELECT [Price], [ServiceName], ServiceProviders.Name, Services.ServiceID FROM[Services] JOIN[ServiceProviders] ON[Services].ProviderID = ServiceProviders.ProviderID";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      OleDbDataReader Reader = cmdIC.ExecuteReader();
      List<string[]> data = new List<string[]>();
      while (Reader.Read())
      {
        data.Add(new string[4]);
        data[data.Count - 1][0] = Reader[2].ToString();
        data[data.Count - 1][1] = Reader[1].ToString();
        data[data.Count - 1][2] = Reader[0].ToString();
        data[data.Count - 1][3] = "Купить";
        int temp;
        int.TryParse(Reader[0].ToString(), out temp);
        serviceIdList.Add(temp);
      }
      for (int i = 0; i < data.Count; i++)
      {
        metroGrid1.Rows.Add(data[i]);
      }
      dB.closeConnection();
    }
    private void mainButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      MainForm mainForm = new MainForm();
      mainForm.Show();
    }

    private void depositsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      DepositsForm depositsForm = new DepositsForm();
      depositsForm.Show();
    }

    private void creditsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      CreditsForm creditsForm = new CreditsForm();
      creditsForm.Show();
    }

    private void servicesButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      ServicesForm servicesForm = new ServicesForm();
      servicesForm.Show();
    }


    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (metroGrid1.Columns[e.ColumnIndex].Name == "Buy")
      {
        dB.openConnection();
        int sum = 0;
        int.TryParse(metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString(), out sum);
        int serviceId = serviceIdList[e.RowIndex];
        
        String strSQL = "Update Clients Set Sum = Sum - ? Where ClientID = ?";
        OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
        cmdIC.Parameters.Add("@Sum", SqlDbType.Int).Value = sum;
        cmdIC.Parameters.Add("@ClientID", SqlDbType.Int).Value = Utils.currentUser.id;
        if (cmdIC.ExecuteNonQuery() == 1 && Utils.addTransaction(Utils.currentUser.id, serviceId, sum, "client", "service"))
        {
          MessageBox.Show("Bought");
        }
        else
        {
          MessageBox.Show("Failed");
        }
      }
    }

    private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
