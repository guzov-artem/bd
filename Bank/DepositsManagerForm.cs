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
  public partial class DepositsManagerForm : MetroFramework.Forms.MetroForm
  {
    public DepositsManagerForm()
    {
      InitializeComponent();
      this.dB = new DB();
    }
    private DB dB;

private void LoadRequest() {
      dB.openConnection();
      String strSQL = "Select RequestID, RequestsDeposit.ClientID, [Percent], [Term], Sum FROM RequestsDeposit JOIN Clients ON RequestsDeposit.ClientID = Clients.ClientID WHERE Status = 'waiting'";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      OleDbDataReader Reader = cmdIC.ExecuteReader();
      List<string[]> data = new List<string[]>();
      while(Reader.Read()) {
        data.Add(new string[7]);
        data[data.Count - 1][0] = Reader[0].ToString();
        data[data.Count - 1][1] = Reader[1].ToString();
        data[data.Count - 1][2] = Reader[4].ToString();
        data[data.Count - 1][3] = Reader[2].ToString();
        data[data.Count - 1][4] = Reader[3].ToString();
        data[data.Count - 1][5] ="Одобрить";
        data[data.Count - 1][6] = "Отклонить";
      }
      for(int i = 0; i < data.Count; i++) {
        metroGrid1.Rows.Add(data[i]);
      }
      dB.closeConnection();
    }

    private void DepositsManagerForm_Load(object sender, EventArgs e)
    {
      LoadRequest();
    }
    private void ReloadRequest()
    {
      metroGrid1.Rows.Clear();
      LoadRequest();
    }


      private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (metroGrid1.Columns[e.ColumnIndex].Name == "Approve")
      {
        dB.openConnection();
        double percent = 0;
        double.TryParse(metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString(), out percent);
        String strSQL = "Update RequestsDeposit Set status = 'approved' Where RequestID = ?";
        OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
        int i;
        int.TryParse((String)metroGrid1.Rows[e.RowIndex].Cells[0].Value, out i);
        cmdIC.Parameters.Add("@RequestID", SqlDbType.Int).Value = i;
        

        String strSQL1 = "Insert INTO Deposits ([ClientID], [Percent], [Sum], [Begin], [Term]) VALUES (?,?,?,?,?)";
        OleDbCommand cmdIC1 = new OleDbCommand(strSQL1, dB.getConnecion());
        cmdIC1.Parameters.Add("@ClientID", SqlDbType.Int).Value = metroGrid1.Rows[e.RowIndex].Cells[1].Value;
        cmdIC1.Parameters.Add("@Percent", SqlDbType.Real).Value = percent;
        cmdIC1.Parameters.Add("@Sum", SqlDbType.Int).Value = 0;
        cmdIC1.Parameters.Add("@Begin", MySqlDbType.VarChar).Value = DateTime.Now.ToString();
        cmdIC1.Parameters.Add("@Term", SqlDbType.Int).Value = metroGrid1.Rows[e.RowIndex].Cells[4].Value;

        if (cmdIC.ExecuteNonQuery() == 1 && cmdIC1.ExecuteNonQuery() == 1)
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
        String strSQL = "Update RequestsDeposit Set status = 'denied' Where RequestID = ?";
        OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
        int i;
        int.TryParse((String)metroGrid1.Rows[e.RowIndex].Cells[0].Value, out i);
        cmdIC.Parameters.Add("@RequestID", SqlDbType.Int).Value = i;
        if (cmdIC.ExecuteNonQuery() == 1)
        {
          MessageBox.Show("Approved");
        }
        else
        {
          MessageBox.Show("Failed");
        }
        dB.closeConnection();
      }
      ReloadRequest();
    }

    private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {

    }

    private void PassField_TextChanged(object sender, EventArgs e)
    {

    }

    private void LoginField_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

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
