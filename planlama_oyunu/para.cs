using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace planlama_oyunu
{
    class para
    {
        OleDbConnection bağlantı = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
        public int para_userID { get; set; }
        public int para_miktar { get; set; }

        public void para_başvuru(int id,int para_miktar)
        {
            this.para_userID = id;
            this.para_miktar = para_miktar;
            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("insert into para_başvuru (userID,para_miktar) values('" + this.para_userID + "','" + this.para_miktar + "')", bağlantı);
            komut.ExecuteNonQuery();
            bağlantı.Close();
        }
    }
}
