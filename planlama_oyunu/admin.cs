using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace planlama_oyunu
{
    class admin
    {
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");

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
            baglanti.Open();
            OleDbCommand oleDbCommand;
            OleDbDataReader oku;
            string sqlkodu = "select *from item_başvuru where userID=@userıd";
            oleDbCommand = new OleDbCommand(sqlkodu, baglanti);
            oleDbCommand.Parameters.AddWithValue("@userıd", itemler.item_userID);
            oku = oleDbCommand.ExecuteReader();
            if (oku.Read())
            {
                sqlkodu = "delete from item_başvuru where item_başvuruID=@itemid";
                oleDbCommand = new OleDbCommand(sqlkodu, baglanti);
                oleDbCommand.Parameters.AddWithValue("@itemid", oku[5]);
                oleDbCommand.ExecuteNonQuery();
            }
            baglanti.Close();
        }
        public void vei_temizle_para(int id)
        {
            para.para_userID = id;
            baglanti.Open();
            OleDbCommand oleDb;
            OleDbDataReader oku;
            string sqlkodu = "select *from para_başvuru where userID=@userıd";
            oleDb = new OleDbCommand(sqlkodu, baglanti);
            oleDb.Parameters.AddWithValue("@userıd", para.para_userID);
            oku = oleDb.ExecuteReader();
            if (oku.Read())
            {
                sqlkodu = "delete from para_başvuru where paraID=@paraıd";
                oleDb = new OleDbCommand(sqlkodu, baglanti);
                oleDb.Parameters.AddWithValue("@paraıd", oku[0]);
                oleDb.ExecuteNonQuery();
            }

            baglanti.Close();
        }
        public void item_onay(int id, string item_ad, int fiyat, int miktar)
        {
            itemler.item_userID = id;
            itemler.item_adı = item_ad;
            itemler.item_fiyatı = fiyat;
            itemler.item_miktarı = miktar;

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from bekleyenSatinAlma", baglanti);
            OleDbDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string islemID = oku[0].ToString();
                string userID = oku[1].ToString();
                string item_adi = oku[2].ToString();
                int item_miktar = Convert.ToInt32(oku[3]);
                int item_fiyat = Convert.ToInt32(oku[4]);

                if (item_ad == item_adi && item_miktar == miktar && item_fiyat == fiyat)
                {
                    OleDbCommand dbCommand = new OleDbCommand();
                    dbCommand.Connection = baglanti;
                    dbCommand.CommandText = "insert into kullanıcı_item(userID,item_ad,item_miktar,item_fiyat) values(@userID,'" + itemler.item_adı + "','" + itemler.item_miktarı + "','" + itemler.item_fiyatı + "')";
                    dbCommand.Parameters.AddWithValue("@userID", userID);
                    dbCommand.ExecuteNonQuery();

                    komut = new OleDbCommand("delete from bekleyenSatinAlma where kuyrukID=@kuyrukid", baglanti);
                    komut.Parameters.AddWithValue("@kuyrukid", islemID);
                    komut.ExecuteNonQuery();
                }
            }


            baglanti.Close();




            itemler.item_kontrol(id,item_ad,fiyat,miktar);
        }
        public void para_onay(int id, int para_miktar)
        {
            para.para_userID = id;
            para.para_miktar = para_miktar;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update para set para_miktar=@para where userID=@ıd";
            komut.Parameters.AddWithValue("@para", para.para_miktar);
            komut.Parameters.AddWithValue("@ıd", para.para_userID);
            komut.ExecuteNonQuery();
            baglanti.Close();
            komut.Dispose();
        }

    }
}
