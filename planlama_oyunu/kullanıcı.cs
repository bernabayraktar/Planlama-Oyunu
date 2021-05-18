using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
//Provider=Microsoft.Jet.OLEDB.4.0;Data Source="|DataDirectory|\bin\Debug\planlama oyunu db.mdb"
namespace planlama_oyunu
{   
    class kullanıcı
    {
        OleDbConnection bağlantı = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
        private itemler itemler;
        private para Para;
        public int userID { get; set; }
        public string ad{ get; set; }
        public string soy_ad { get; set; }
        public string kullanıcı_ad { get; set; }
        public string password { get; set; }
        public string tc { get; set; }
        public string telefon { get; set; }
        public string e_mail { get; set; }
        public string adres { get; set; }
        public kullanıcı()
        {
            itemler = new itemler();
            Para = new para();
        }
        public void kullanıcı_ekle( string ad, string soyad, string kullanıcı, string password, string tc, string telefon,string mail,string adres)
        {
            this.ad = ad;
            this.soy_ad = soyad;
            this.kullanıcı_ad = kullanıcı;
            this.password = password;
            this.tc = tc;
            this.telefon = telefon;
            this.e_mail = mail;
            this.adres = adres;
            bağlantı.Open();
            OleDbCommand komut=new OleDbCommand("insert into kullanıcılar (ad,soyad,kullanıcı,şifre,tc,telefon,email,adres) values('" + this.ad + "','" + this.soy_ad + "','" + this.kullanıcı_ad + "','" + this.password + "','" + this.tc + "','" + this.telefon + "','" + this.e_mail + "','" + this.adres + "')", bağlantı);
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }
        public void kullanıcı_güncelle(string id,string ad, string soyad, string kullanıcı, string password, string tc, string telefon, string mail, string adres)
        {
            this.ad = ad;
            this.soy_ad = soyad;
            this.kullanıcı_ad = kullanıcı;
            this.password = password;
            this.tc = tc;
            this.telefon = telefon;
            this.e_mail = mail;
            this.adres = adres;

            bağlantı.Open();
            
            string sorgu = "update kullanıcılar set ad=@ad,soyad=@soyad,kullanıcı=@kullanıcı,şifre=@şifre,tc=@tc,telefon=@telefon,email=@email,adres=@adres where userID=@ıd";
            OleDbCommand komut = new OleDbCommand(sorgu,bağlantı);
            // komut = new OleDbCommand(sorgu, bağlantı);
            komut.Parameters.AddWithValue("@ad", this.ad);
            komut.Parameters.AddWithValue("@soyad", this.soy_ad);
            komut.Parameters.AddWithValue("@kullanıcı", this.kullanıcı_ad);
            komut.Parameters.AddWithValue("@şifre", this.password);
            komut.Parameters.AddWithValue("@tc", this.tc);
            komut.Parameters.AddWithValue("@telefon", this.telefon);
            komut.Parameters.AddWithValue("@email", this.e_mail);
            komut.Parameters.AddWithValue("@adres", this.adres);
            komut.Parameters.AddWithValue("@ıd", id);

            komut.ExecuteNonQuery();
            bağlantı.Close();
        }
        
        
    }
}
