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
  public partial class MakeCreditPayment : Form
  {
    public MakeCreditPayment(int creditId)
    {
      InitializeComponent();
      this.creditID = creditId;
      this.dB = new DB();
    }
    private int creditID;
    private DB dB;

    private void MakeCreditPayment_Load(object sender, EventArgs e)
    {
      loadSumAccount();
      loadSumCredit();
    }
    private void loadSumCredit()
    {
      dB.openConnection();
      String strSQL = "Select Sum FROM Credits Where CreditID = ?";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@ClientID", SqlDbType.Int).Value = this.creditID;
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
      String strSQL = "Update Credits Set Sum = Sum - ? Where CreditID = ? \n" + "Update Clients Set Sum = Sum - ? Where ClientID = ?";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@Sum1", SqlDbType.Int).Value = sum;
      cmdIC.Parameters.Add("@CreditId", SqlDbType.Int).Value = creditID;
      cmdIC.Parameters.Add("@Sum2", SqlDbType.Int).Value = sum;
      cmdIC.Parameters.Add("@ClientId", SqlDbType.Int).Value = Utils.currentUser.id;
      if (cmdIC.ExecuteNonQuery() == 2 && Utils.addTransaction(Utils.currentUser.id, this.creditID, sum, "client", "credit"))
      {
        MessageBox.Show("Added");
      }
      else
      {
        MessageBox.Show("Failed");
      }
      dB.closeConnection();
      loadSumCredit();
      loadSumAccount();
    }
  }
}

