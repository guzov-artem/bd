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
  public partial class CreditsManagerForm : MetroFramework.Forms.MetroForm
  {
    public CreditsManagerForm()
    {
      InitializeComponent();
      dB = new DB();
    }
    private DB dB;

    private void CreitsManagerForm_Load(object sender, EventArgs e)
    {
      LoadRequest();
    }

    private void LoadRequest()
    {
      dB.openConnection();
      String strSQL = "Select CreditRequestID, CreditRequests.ClientID, [Percent], [Term], CreditRequests.Sum, Clients.Sum  FROM CreditRequests JOIN Clients ON CreditRequests.ClientID = Clients.ClientID WHERE Status = 'waiting'";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      OleDbDataReader Reader = cmdIC.ExecuteReader();
      List<string[]> data = new List<string[]>();
      while (Reader.Read())
      {
        data.Add(new string[8]);
        data[data.Count - 1][0] = Reader[0].ToString();
        data[data.Count - 1][1] = Reader[1].ToString();
        data[data.Count - 1][2] = Reader[5].ToString();
        data[data.Count - 1][3] = Reader[4].ToString();
        data[data.Count - 1][4] = Reader[2].ToString();
        data[data.Count - 1][5] = Reader[3].ToString();
        data[data.Count - 1][6] = "Одобрить";
        data[data.Count - 1][7] = "Отклонить";
      }
      for (int i = 0; i < data.Count; i++)
      {
        metroGrid1.Rows.Add(data[i]);
      }
      dB.closeConnection();
    }
    private void ReloadRequest()
    {
      metroGrid1.Rows.Clear();
      LoadRequest();
    }

    private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (metroGrid1.Columns[e.ColumnIndex].Name == "Approve")
      {
        dB.openConnection();
        double percent = 0;
        double.TryParse(metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString(), out percent);
        String strSQL = "Update CreditRequests Set status = 'approved' Where [CreditRequestID] = ?";
        OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
        int i;
        int.TryParse((String)metroGrid1.Rows[e.RowIndex].Cells[0].Value, out i);
        cmdIC.Parameters.Add("@RequestID", SqlDbType.Int).Value = i;

        int clientID;
        int.TryParse(metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString(), out clientID);
        int sum;
        int.TryParse(metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString(), out sum);
        int term;
        int.TryParse(metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString(), out term);

        String strSQL1 = "Insert INTO Credits ([ClientID], [Percent], [Sum], [Begin], [Term]) OUTPUT Inserted.CreditID VALUES (?,?,?,?,?)";
        OleDbCommand cmdIC1 = new OleDbCommand(strSQL1, dB.getConnecion());
        cmdIC1.Parameters.Add("@ClientID", SqlDbType.Int).Value = clientID;
        cmdIC1.Parameters.Add("@Percent", SqlDbType.Real).Value = percent;
        cmdIC1.Parameters.Add("@Sum", SqlDbType.Int).Value = sum;
        cmdIC1.Parameters.Add("@Begin", MySqlDbType.VarChar).Value = DateTime.Now.ToString();
        cmdIC1.Parameters.Add("@Term", SqlDbType.Int).Value = term;
        OleDbDataReader Reader =  cmdIC1.ExecuteReader();
        int CreditID = -1;
        if (Reader.Read()) {
          CreditID = (int)Reader[0];
        }

        

        String strSQL2 = "Update Clients Set Sum = Sum + ? Where ClientID = ?";
        OleDbCommand cmdIC2 = new OleDbCommand(strSQL2, dB.getConnecion());
        cmdIC2.Parameters.Add("@Sum1", SqlDbType.Int).Value = sum;
        cmdIC2.Parameters.Add("@ClientID", SqlDbType.Int).Value = clientID;

        if (cmdIC.ExecuteNonQuery() == 1 && Utils.addTransaction(CreditID, clientID, sum, "credit", "client") && cmdIC2.ExecuteNonQuery() == 1)
        {
          MessageBox.Show("Approved");
        }
        else
        {
          MessageBox.Show("Failed");
        }
        dB.closeConnection();
      }
      else if (metroGrid1.Columns[e.ColumnIndex].Name == "Deny")
      {
        dB.openConnection();
        String strSQL = "Update [CreditRequests] Set status = 'denied' Where [CreditRequestID] = ?";
        OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
        int i;
        int.TryParse((String)metroGrid1.Rows[e.RowIndex].Cells[0].Value, out i);
        cmdIC.Parameters.Add("@RequestID", SqlDbType.Int).Value = i;
        if (cmdIC.ExecuteNonQuery() == 1)
        {
          MessageBox.Show("Denied");
        }
        else
        {
          MessageBox.Show("Failed");
        }
        dB.closeConnection();
      }
      ReloadRequest();
    }
    private void depositsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      DepositsManagerForm depositsManagerForm = new DepositsManagerForm();
      depositsManagerForm.Show();
    }

    private void creditsButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      CreditsManagerForm creditsManagerForm = new CreditsManagerForm();
      creditsManagerForm.Show();
    }

    private void mainButton_Click(object sender, EventArgs e)
    {
      this.Hide();
      MainFormFinance mainFormFinance = new MainFormFinance();
      mainFormFinance.Show();
    }
  }
}
