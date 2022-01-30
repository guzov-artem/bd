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
  public partial class AddDepositForm : Form
  {
    public AddDepositForm(int depositId)
    {
      InitializeComponent();
      this.depositID = depositId;
      this.dB = new DB();
    }
    private int depositID;
    private DB dB;

    private void AddDepositForm_Load(object sender, EventArgs e)
    {
      loadSumDeposit();
      loadSumAccount();
    }
    private void loadSumDeposit()
    {
      dB.openConnection();
      String strSQL = "Select Sum FROM Deposits Where DepositID = ?";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@ClientID", SqlDbType.Int).Value = this.depositID;
      OleDbDataReader Reader = cmdIC.ExecuteReader();
      if (Reader.Read())
      {
        DepositSumLabel.Text = Reader[0].ToString();
      }
      dB.closeConnection();
    }
    private void loadSumAccount()
    {
      dB.openConnection();
      String strSQL = "Select Sum FROM Clients Where ClientID = ?";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@ClientID", SqlDbType.Int).Value = Utils.currentUser.id;
      OleDbDataReader Reader = cmdIC.ExecuteReader();
      if (Reader.Read())
      {
        accountSum.Text = Reader[0].ToString();
      }
      dB.closeConnection();
    }

    

    private void button1_Click(object sender, EventArgs e)
    {
      dB.openConnection();
      int sum = 0;
      int.TryParse(textBox1.Text, out sum);
      String strSQL = "Update Deposits Set Sum = Sum + ? Where DepositID = ? \n" + "Update Clients Set Sum = Sum - ? Where ClientID = ?";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@Sum1", SqlDbType.Int).Value = sum;
      cmdIC.Parameters.Add("@DepId", SqlDbType.Int).Value = depositID;
      cmdIC.Parameters.Add("@Sum2", SqlDbType.Int).Value = sum;
      cmdIC.Parameters.Add("@ClientId", SqlDbType.Int).Value = Utils.currentUser.id;
      if (cmdIC.ExecuteNonQuery() == 2 && Utils.addTransaction(Utils.currentUser.id, this.depositID, sum, "client", "deposit"))
      {
        MessageBox.Show("Added");
      }
      else
      {
        MessageBox.Show("Failed");
      }
      dB.closeConnection();
      loadSumDeposit();
      loadSumAccount();
    }
  }
}
