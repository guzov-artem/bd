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
  public partial class MainForm : MetroFramework.Forms.MetroForm
  {
    public MainForm()
    {
      InitializeComponent();
      dB = new DB();
      dB.openConnection();
    }
    private DB dB;

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      LoadSum();
      LoadTransactions();

    }
    
    private void LoadSum() {
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
    }
    private void LoadTransactions() {
      String strSQL = "Select * FROM Transactions Where SenderID = ? And SenderType = 'client' OR RecieverID = ? and RecieverType = 'client'";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@ClientID", SqlDbType.Int).Value = Utils.currentUser.id;
      cmdIC.Parameters.Add("@ClientID", SqlDbType.Int).Value = Utils.currentUser.id;
      OleDbDataReader Reader =  cmdIC.ExecuteReader();
      
      List<string[]> data = new List<string[]>();
      while(Reader.Read()) {
        data.Add(new string[7]);
        for(int i = 0; i < 7; i++) {
          data[data.Count - 1][i] = Reader[i].ToString();
        }
      }
      List<string[]> gridVeiwList = new List<string[]>();
      for (int i = 0; i < data.Count; i++)
      {
        gridVeiwList.Add(new string[4]);

        gridVeiwList[i][0] = data[i][0];
        gridVeiwList[i][2] = data[i][4];

        if (data[i][6].Trim() == "client" && data[i][2] == Utils.currentUser.id.ToString()) {//если мы получатель
          gridVeiwList[i][3] = "+" + data[i][3];
          if (data[i][5].Trim() == "client") {
            gridVeiwList[i][1] = "Перевод от клиета номер " + data[i][1];
          }
          else if (data[i][5].Trim() == "deposit") {
            gridVeiwList[i][1] = "Снятие средств с депозита номер " + data[i][1];
          }
          else if (data[i][5].Trim() == "credit")
          {
            gridVeiwList[i][1] = "Пополнение счета с кредита номер " + data[i][1];
          }
          else if (data[i][5].Trim() == "service")
          {
            gridVeiwList[i][1] = "Возврат услуги номер " + data[i][2];
          }
        }
        else if (data[i][5].Trim() == "client" && data[i][1] == Utils.currentUser.id.ToString()) {//если мы отправитель
          gridVeiwList[i][3] = "-" + data[i][3];
          if (data[i][6].Trim() == "client")
          {
            gridVeiwList[i][1] = "Перевод клиету номер " + data[i][2];
          }
          else if (data[i][6].Trim() == "deposit")
          {
            gridVeiwList[i][1] = "Перевод  на депозит номер " + data[i][2];
          }
          else if (data[i][6].Trim() == "credit")
          {
            gridVeiwList[i][1] = "Платеж по кредиту номер " + data[i][2];
          }
          else if (data[i][6].Trim() == "service")
          {
            gridVeiwList[i][1] = "Покупка услуги номер " + data[i][2];
          }
        }
      }
      Reader.Close();

      foreach(string[] s in gridVeiwList) {
        metroGrid1.Rows.Add(s);

      }
      
    }
    

    private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

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

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }
}
