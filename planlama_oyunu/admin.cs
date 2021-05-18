using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace planlama_oyunu
{
    class admin
    {
        OleDbConnection baglantı = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
        
        private itemler itemler;
        private para para;
        public admin()
        {
            
            itemler = new itemler();
            para = new para();
        }
        public void veri_temizle_item(int id)
        {
            itemler.item_userID = id;
            baglantı.Open();
            OleDbCommand oleDbCommand;
            OleDbDataReader oku;
            string sqlkodu = "select *from item_başvuru where userID=@userıd";
            oleDbCommand = new OleDbCommand(sqlkodu, baglantı);
            oleDbCommand.Parameters.AddWithValue("@userıd", itemler.item_userID);
            oku = oleDbCommand.ExecuteReader();
            if (oku.Read())
            {
                sqlkodu = "delete from item_başvuru where item_başvuruID=@itemid";
                oleDbCommand = new OleDbCommand(sqlkodu, baglantı);
                oleDbCommand.Parameters.AddWithValue("@itemid", oku[0]);
                oleDbCommand.ExecuteNonQuery();
            }
            baglantı.Close();
        }
        public void vei_temizle_para(int id)
        {
            para.para_userID = id;
            baglantı.Open();
            OleDbCommand oleDb;
            OleDbDataReader oku;
            string sqlkodu = "delete from para_başvuru where userID=@userıd";
            oleDb = new OleDbCommand(sqlkodu, baglantı);
            oleDb.Parameters.AddWithValue("@userıd", para.para_userID);
            oku = oleDb.ExecuteReader();
            if (oku.Read())
            {
                sqlkodu = "delete from para_başvuru where paraID=@paraıd";
                oleDb = new OleDbCommand(sqlkodu, baglantı);
                oleDb.Parameters.AddWithValue("@paraıd", oku[0]);
                oleDb.ExecuteNonQuery();
            }

            baglantı.Close();
        }
        public void item_onay(int id, string item_ad, int fiyat, int miktar)
        {
            itemler.item_userID = id;
            itemler.item_adı = item_ad;
            itemler.item_fiyatı = fiyat;
            itemler.item_miktarı = miktar;
            baglantı.Open();
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.Connection = baglantı;
            dbCommand.CommandText = "insert into kullanıcı_item values('" + itemler.item_userID + "','" + itemler.item_adı + "','" + itemler.item_fiyatı + "','" + itemler.item_miktarı + "')";
            dbCommand.ExecuteNonQuery();
            baglantı.Close();
        }
        public void para_onay(int id, int para_miktar)
        {
            para.para_userID = id;
            para.para_miktar = para_miktar;
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "update para set para_miktar=@para where userID=@ıd";
            komut.Parameters.AddWithValue("@para", para.para_miktar);
            komut.Parameters.AddWithValue("@ıd", para.para_userID);
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.Dispose();
        }
        
    }
}
