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
  public partial class CreditsForm : MetroFramework.Forms.MetroForm
  {
    public CreditsForm()
    {
      InitializeComponent();
      dB = new DB();
    }
    private DB dB;

    private void CreditsForm_Load(object sender, EventArgs e)
    {
      dB.openConnection();
      String strSQL = "Select * FROM Credits Where ClientID = ?";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@ClientID", SqlDbType.Int).Value = Utils.currentUser.id;
      OleDbDataReader Reader = cmdIC.ExecuteReader();

      List<string[]> data = new List<string[]>();
      while (Reader.Read())
      {
        data.Add(new string[6]);
        for (int i = 0; i < 6; i++)
        {
          data[data.Count - 1][i] = Reader[i].ToString();
        }
      }
      List<string[]> gridVeiwList = new List<string[]>();
      for (int i = 0; i < data.Count; i++)
      {
        gridVeiwList.Add(new string[6]);
        gridVeiwList[i][0] = data[i][0];
        gridVeiwList[i][1] = data[i][4];
        gridVeiwList[i][2] = data[i][2];
        gridVeiwList[i][3] = data[i][3];
        gridVeiwList[i][4] = data[i][5];
        gridVeiwList[i][5] = "Сделать платеж";
      }
      Reader.Close();
      dB.closeConnection();

      foreach (string[] s in gridVeiwList)
      {
        metroGrid1.Rows.Add(s);

      }
    }

    private void CreditsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
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


    private void button1_Click(object sender, EventArgs e)
    {
      dB.openConnection();
      int numMounths;
      if (termBox.Text == null) {
        MessageBox.Show("Please enter term of credit");
        return;
      }
      if (int.TryParse(termBox.Text, out numMounths) && numMounths >= 1 && numMounths <= 24)
      {
        String strSQL = "Select percents FROM CreditPercents Where ? >= BottomTerm AND ? < UpperTerm";
        OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
        cmdIC.Parameters.Add("@Mounths", SqlDbType.Int).Value = numMounths;
        cmdIC.Parameters.Add("@Mounths", SqlDbType.Int).Value = numMounths;
        OleDbDataReader Reader = cmdIC.ExecuteReader();
        if (Reader.Read())
        {
          percentLabel.Text = Reader[0].ToString();
        }
        else
        {
          MessageBox.Show("Something wrong with DB. Try again later!");
        }
      }
      else
      {
        MessageBox.Show("Please enter number of mounths! From 1 to 24");
      }
      dB.closeConnection();
    }

    private void makeRequest_Click(object sender, EventArgs e)
    {
      dB.openConnection();
      if (percentLabel.Text == null || termBox.Text == null)
      {
        MessageBox.Show("Please enter term of credit");
        return;
      }
      double percent = 0;
      if (!double.TryParse(percentLabel.Text, out percent))
      {
        MessageBox.Show("Please enter term");
        return;
      }
      if (dateTimePicker1.Value < DateTime.Now)
      {
        MessageBox.Show("Please time in future");
        return;
      }
      int creditSum = 0;
      if (!int.TryParse(sumCreditBox.Text, out creditSum) || creditSum <= 0)
      {
        MessageBox.Show("Please enter positive sum with numbers");
        return;
      }
      String strSQL = "Insert Into CreditRequests ([ClientID], [Status], [Percent], [Sum], [Begin], [Term]) Values (?, 'waiting', ?,?,?, ? )";

      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@ID", MySqlDbType.Int32).Value = Utils.currentUser.id;
      cmdIC.Parameters.Add("@percent", MySqlDbType.Double).Value = percent;
      cmdIC.Parameters.Add("@Sum", MySqlDbType.Int32).Value = creditSum;
      cmdIC.Parameters.Add("@date", MySqlDbType.DateTime).Value = dateTimePicker1.Value;
      cmdIC.Parameters.Add("@term", MySqlDbType.Int32).Value = termBox.Text;






      if (cmdIC.ExecuteNonQuery() == 1)
      {
        MessageBox.Show("Вы успешно подали заявку. Ожидайте решения по ней");
      }
      else
      {
        MessageBox.Show("Не удалось подать заявку. Попробуйте позже");
      }
      dB.closeConnection();
    }

    private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (metroGrid1.Columns[e.ColumnIndex].Name == "makePayment")
      {
        String str = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
        int i = 0;
        int.TryParse(str, out i);
        MakeCreditPayment makeCreditPayment = new MakeCreditPayment(i);
        makeCreditPayment.Show();
      }
    }

    private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
