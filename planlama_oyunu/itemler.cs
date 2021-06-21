using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace planlama_oyunu
{
    class itemler
    {
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
        public int item_ID { get; set; }
        public int item_userID { get; set; }
        public string item_adı { get; set; }
        public int item_miktarı { get; set; }
        public int item_fiyatı { get; set; }
        
        public void item_başvuru(int ıd,string item_adı,int item_miktarı,int item_fiyatı)
        {
            this.item_userID = ıd;
            this.item_adı = item_adı;
            this.item_miktarı = item_miktarı;
            this.item_fiyatı = item_fiyatı;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into item_başvuru (userID,item_ad,item_miktar,item_fiyat) values('" + this.item_userID + "','" + this.item_adı + "','" + this.item_miktarı + "','" + this.item_fiyatı + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void item_kontrol(int ıd, string item_adı, int item_miktarı, int item_fiyatı)
        {
            this.item_userID = ıd;
            this.item_adı = item_adı;
            this.item_miktarı = item_miktarı;
            this.item_fiyatı = item_fiyatı;

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from bekleyenSatinAlma", baglanti);
            OleDbDataReader oku;
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string islemID = oku[0].ToString();
                string userID = oku[1].ToString();
                string item_ad = oku[2].ToString();
                int item_miktar = Convert.ToInt32(oku[3]);
                int item_fiyat = Convert.ToInt32(oku[4]);

                if (item_ad==item_adı&& item_miktar==item_miktarı&&item_fiyat==item_fiyatı)
                {
                    komut = new OleDbCommand("delete from bekleyenSatinAlma where kuyrukID=@kuyrukid", baglanti);
                    komut.Parameters.AddWithValue("@kuyrukid",islemID);
                    komut.ExecuteNonQuery();
                }
            }
            

            baglanti.Close();
        }


    }
}
