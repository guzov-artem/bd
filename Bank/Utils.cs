using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;

namespace Bank
{


  static class Utils
  {
    public static User currentUser;
    public static string Encrypt(string clearText)
    {
      // rsa
      // публичным  ключом
      string EncryptionKey = "MAKV2SPBNI99212";
      byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
      using (Aes encryptor = Aes.Create())
      {
        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        encryptor.Key = pdb.GetBytes(32);
        encryptor.IV = pdb.GetBytes(16);
        using (MemoryStream ms = new MemoryStream())
        {
          using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
          {
            cs.Write(clearBytes, 0, clearBytes.Length);
            cs.Close();
          }
          clearText = Convert.ToBase64String(ms.ToArray());
        }
      }
      return clearText;
    }

    public static string Decrypt(string cipherText)
    {
      string EncryptionKey = "MAKV2SPBNI99212";
      byte[] cipherBytes = Convert.FromBase64String(cipherText);
      using (Aes encryptor = Aes.Create())
      {
        Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
        encryptor.Key = pdb.GetBytes(32);
        encryptor.IV = pdb.GetBytes(16);
        using (MemoryStream ms = new MemoryStream())
        {
          using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
          {
            cs.Write(cipherBytes, 0, cipherBytes.Length);
            cs.Close();
          }
          cipherText = Encoding.Unicode.GetString(ms.ToArray());
        }
      }
      return cipherText;
    }
    public static bool addTransaction(int SenserID, int RecieverID, int Sum, string SenderType, string RecieverType)
    {
      DB dB = new DB();
      dB.openConnection();
      String strSQL = "Insert Into Transactions ([SenderID], [RecieverID], [Sum], [Date], [SenderType], [RecieverType]) Values (?, ?, ?, ?, ?, ? )";
      OleDbCommand cmdIC = new OleDbCommand(strSQL, dB.getConnecion());
      cmdIC.Parameters.Add("@SenderID", SqlDbType.Int).Value = SenserID;
      cmdIC.Parameters.Add("@RecieverID", SqlDbType.Int).Value = RecieverID;
      cmdIC.Parameters.Add("@Sum", SqlDbType.Int).Value = Sum;
      cmdIC.Parameters.Add("@Date", MySqlDbType.VarChar).Value = DateTime.Now.ToString();
      cmdIC.Parameters.Add("@SenderType", SqlDbType.VarChar).Value = SenderType;
      cmdIC.Parameters.Add("@RecieverType", SqlDbType.VarChar).Value = RecieverType;
      if (cmdIC.ExecuteNonQuery() == 1)
      {
        dB.closeConnection();
        return true;
      }
      else
      {
        dB.closeConnection();
        return false;
      }

    }
  }

}
