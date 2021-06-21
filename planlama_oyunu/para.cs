using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Xml;
namespace planlama_oyunu
{
    class para
    {
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
        public int para_userID { get; set; }
        public double para_miktar { get; set; }
        public string para_birim { get; set; }

        public void para_başvuru(int id, double para_miktar, string birim)
        {
            this.para_userID = id;
            this.para_miktar = para_miktar;
            this.para_birim = birim;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into para_başvuru (userID,para_miktar,para_birim) values('" + this.para_userID + "','" + this.para_miktar + "', '" + this.para_birim + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public double para_birimi_planla(string money_type)
        {
            decimal money_tp = 1;
            if (money_type != "TRY")
            {
                XmlDocument xmldata = new XmlDocument();
                xmldata.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
                money_tp = Convert.ToDecimal(xmldata.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", money_type)).InnerText.Replace('.', ','));
                return Convert.ToInt32(money_tp);
            }
            else
            {
                return Convert.ToInt32(money_tp);
            }

        }
    }
}
