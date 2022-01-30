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
  public partial class MakeTransactionForm : MetroFramework.Forms.MetroForm
  {
    public MakeTransactionForm()
    {
      InitializeComponent();
      this.dB = new DB();
      this.listClientID = new List<int>();
    }
    private DB dB;
    private List<int> listClientID;

    private void MakeTransactionForm_Load(object sender, EventArgs e)
    {
      LoadSum();
      LoadClients();
     }
    private void LoadSum()
    {
      dB.openConnection();
      DataTable table = new DataTable();
      OleDbDataAdapter adapter = new OleDbDataAdapter();


      String strSQL = " Select Sum FROM Clients " + "WHERE ClientID = ?";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@ID", MySqlDbType.Int32).Value = Utils.currentUser.id;

      adapter.SelectCommand = cmdIC;
      adapter.Fill(table);
      Decimal sum = 0;
      if (table.Rows.Count > 0)
      {
        sum = (Decimal)table.Rows[0][0];
      }
      SumText.Text = sum.ToString();
      dB.closeConnection();
    }
    private void LoadClients()
    {
      dB.openConnection();
      DataTable table = new DataTable();
      OleDbDataAdapter adapter = new OleDbDataAdapter();


      String strSQL = " Select FIO, ClientID FROM Clients " + "WHERE NOT ClientID = ?";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@ID", MySqlDbType.Int32).Value = Utils.currentUser.id;

      OleDbDataReader reader = cmdIC.ExecuteReader();
      while(reader.Read()) {
        clientsBox.Items.Add(reader[0].ToString().Trim());
        int temp;
        int.TryParse(reader[1].ToString(), out temp);
        listClientID.Add(temp);
      }
      dB.closeConnection();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      dB.openConnection();
      int clientID = listClientID[clientsBox.SelectedIndex];
      int sum = 0;
      if (!int.TryParse(textBox1.Text, out sum) && sum < 0)
      {
        MessageBox.Show("Please enter correct sum");
        return;
      }

      String strSQL = "Update Clients Set Sum = Sum - ? Where ClientID = ? \n" + "Update Clients Set Sum = Sum + ? Where ClientID = ?";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@Sum1", SqlDbType.Int).Value = sum;
      cmdIC.Parameters.Add("@ClientId1", SqlDbType.Int).Value = Utils.currentUser.id;
      cmdIC.Parameters.Add("@Sum2", SqlDbType.Int).Value = sum;
      cmdIC.Parameters.Add("@ClientId2", SqlDbType.Int).Value = clientID;
      if (cmdIC.ExecuteNonQuery() == 2 && Utils.addTransaction(Utils.currentUser.id, clientID, sum, "client", "client"))
      {
        MessageBox.Show("Added");
      }
      else
      {
        MessageBox.Show("Failed");
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

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      MakeTransactionForm makeTransactionForm = new MakeTransactionForm();
      makeTransactionForm.Show();
    }
  }
}
