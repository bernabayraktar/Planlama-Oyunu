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
        OleDbConnection bağlantı = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
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
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("insert into item_başvuru (userID,item_ad,item_miktar,item_fiyat) values('" + this.item_userID + "','" + this.item_adı + "','" + this.item_miktarı + "','" + this.item_fiyatı + "')", bağlantı);
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }
        
    }
}
