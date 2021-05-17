using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace planlama_oyunu
{
    public partial class Form_bilgiler : Form
    {
        public Form_bilgiler()
        {
            InitializeComponent();
        }

        kullanıcı k = new kullanıcı();
        itemler itemler = new itemler();
        para para = new para();
        OleDbConnection bağlantı = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
        OleDbCommand komut;
        int kullaniciID = 0;
        int satinAlinmakIstenenMiktar;
        int satirSayisi = 0;
        bool urunlerGuncellendi = false;
        public static ListViewItem item;

        private void cleaner()
        {
            txtad.Clear();
            txtsoyad.Clear();
            txtkullanıcı.Clear();
            txtşifre.Clear();
            txttc.Clear();
            txttelefon.Clear();
            txtemail.Clear();
            txtadres.Clear();
        }
        private void başvuru_cleaner()
        {
            txt_item_başvuru.Clear();
            txt_item_miktar.Clear();
            txt_item_fiyat_başvuru.Clear();
            txt_para_başvuru.Clear();
        }
        private void listele()
        {
            cleaner();

            bağlantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from kullanıcılar where userID like '" + Form_login.usertype + "'", bağlantı);
            OleDbCommand oleDb = new OleDbCommand("select * from kullanıcı_item where userID like '" + Form_login.usertype + "'", bağlantı);
            OleDbCommand ole = new OleDbCommand("select * from para where userID like '" + Form_login.usertype + "'", bağlantı);

            OleDbDataReader oku = komut.ExecuteReader();
            OleDbDataReader reader = oleDb.ExecuteReader();
            OleDbDataReader dataReader = ole.ExecuteReader();
            while (dataReader.Read())
            {
                lbl_para.Text = dataReader["para_miktar"].ToString();
            }
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = reader["userID"].ToString();
                lst.SubItems.Add(reader["item_ad"].ToString());
                lst.SubItems.Add(reader["item_miktar"].ToString());
                lst.SubItems.Add(reader["item_fiyat"].ToString());
                listwiev_item.Items.Add(lst);
            }
            while (oku.Read())
            {
                txtad.Text = oku["ad"].ToString();
                txtsoyad.Text = oku["soyad"].ToString();
                txtkullanıcı.Text = oku["kullanıcı"].ToString();
                txtşifre.Text = oku["şifre"].ToString();
                txttc.Text = oku["tc"].ToString();
                txttelefon.Text = oku["telefon"].ToString();
                txtemail.Text = oku["email"].ToString();
                txtadres.Text = oku["adres"].ToString();
            }
            bağlantı.Close();
        }
        private void Form_bilgiler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            k.kullanıcı_güncelle(lbl_userID.Text, txtad.Text, txtsoyad.Text, txtkullanıcı.Text, txtşifre.Text, txttc.Text, txttelefon.Text, txtemail.Text, txtadres.Text);
            listele();
            MessageBox.Show("verileriniz güncellendi");
        }

        private void btn_item_başvuru_Click(object sender, EventArgs e)
        {
            itemler.item_başvuru(Form_login.usertype, txt_item_başvuru.Text, Convert.ToInt32(txt_item_miktar.Text), Convert.ToInt32(txt_item_fiyat_başvuru.Text));
            MessageBox.Show("Para başvuru talebiniz iletildi");
            başvuru_cleaner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            para.para_başvuru(Form_login.usertype, Convert.ToInt32(txt_para_başvuru.Text));
            MessageBox.Show("Item başvuru talebiniz iletildi");
            başvuru_cleaner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            int tiklayanID = Form_login.usertype;
            int kullaniciPara;
            int dongu = 0;
            int ilkMiktar = 0;
            string sql = "Select para_miktar from para where userID=" + tiklayanID;
            int aktarilacakParaMiktari;
            komut = new OleDbCommand(sql, bağlantı);
            komut.ExecuteNonQuery();
            kullaniciPara = (int)komut.ExecuteScalar();
            if (satinAlinmakIstenenMiktar == 0)
            {
                textBox3.Text = "Dostum Satın Almak İstediğin Miktar 0 Olamaz :))";
            }
            if (urunlerGuncellendi == false)
            {
                textBox3.Text = "Ürün Satın Almak İçin Öncelikle Ürünleri Listelemelisin.";
            }
            while (satinAlinmakIstenenMiktar == 0)
            {
                if (satirSayisi > 0)
                {
                    textBox3.Text = "Satın Alabileceğin Ürün Kalmadı";
                }
                if (kullaniciPara == 0 || kullaniciPara < 0)
                {
                    textBox3.Text = "Herhangi Bir Ürünü Almak İçin Yeterli Paranız Yok.";
                }
                listView2.Items[dongu].Selected = true;
                ListViewItem item = listView2.SelectedItems[dongu];
                if (Convert.ToInt32(item.SubItems[2]) < satinAlinmakIstenenMiktar)
                {
                    satinAlinmakIstenenMiktar = satinAlinmakIstenenMiktar - Convert.ToInt32(item.SubItems[2]);
                    string parasql = "Select para_miktar from para where userID =" + item.SubItems[0];
                    komut = new OleDbCommand(parasql, bağlantı);
                    komut.ExecuteNonQuery();
                    ilkMiktar = (int)komut.ExecuteScalar();
                    aktarilacakParaMiktari = Convert.ToInt32(item.SubItems[3]) + ilkMiktar;
                    kullaniciPara = kullaniciPara - aktarilacakParaMiktari;
                    string updateAlici = "update para set para_miktar=" + kullaniciPara + " where userID=" + kullaniciID;
                    string updateSatici = "update para set para_miktar=" + aktarilacakParaMiktari + " where userID=" + item.SubItems[0];
                    string satirSil = "delete from kullanici_item where userID=" + item.SubItems[0] + " and item_ad=" + item.SubItems[1] + " and item_miktar=" + item.SubItems[2] + " and item_fiyat=" + item.SubItems[3];
                    komut = new OleDbCommand(updateAlici, bağlantı);
                    komut.ExecuteNonQuery();
                    komut = new OleDbCommand(updateSatici, bağlantı);
                    komut.ExecuteNonQuery();
                    komut = new OleDbCommand(satirSil, bağlantı);
                    komut.ExecuteNonQuery();
                    satirSayisi--;
                }
                else
                {
                    satinAlinmakIstenenMiktar = satinAlinmakIstenenMiktar - Convert.ToInt32(item.SubItems[2]);

                    string parasql = "Select para_miktar from para where userID =" + item.SubItems[0];

                    komut = new OleDbCommand(parasql, bağlantı);
                    komut.ExecuteNonQuery();
                    ilkMiktar = (int)komut.ExecuteScalar();

                    aktarilacakParaMiktari = Convert.ToInt32(item.SubItems[3]) + ilkMiktar;

                    kullaniciPara = kullaniciPara - aktarilacakParaMiktari;

                    string updateAlici = "update para set para_miktar=" + kullaniciPara + " where userID=" + kullaniciID;
                    string updateSatici = "update para set para_miktar=" + aktarilacakParaMiktari + " where userID=" + item.SubItems[0];
                    string satirGuncelle = "delete from kullanici_item where userID=" + item.SubItems[0] + " and item_ad=" + item.SubItems[1] + " and item_miktar=" + item.SubItems[2] + " and item_fiyat=" + item.SubItems[3];

                    komut = new OleDbCommand(updateAlici, bağlantı);
                    komut.ExecuteNonQuery();
                    komut = new OleDbCommand(updateSatici, bağlantı);
                    komut.ExecuteNonQuery();
                    komut = new OleDbCommand(satirGuncelle, bağlantı);
                    komut.ExecuteNonQuery();
                }
                dongu++;
            }
            bağlantı.Close();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            urunlerGuncellendi = true;
            if (kullaniciID == 0)
            {
                listView2.Items.Clear();
                bağlantı.Open();
                komut = new OleDbCommand("Select * From kullanıcı_item order by item_fiyat", bağlantı);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem item = new ListViewItem(oku["userID"].ToString());
                    item.SubItems.Add(oku["item_ad"].ToString());
                    item.SubItems.Add(oku["item_miktar"].ToString());
                    item.SubItems.Add(oku["item_fiyat"].ToString());
                    listView2.Items.Add(item);
                    satirSayisi++;
                }
                bağlantı.Close();
            }
            else
            {
                listView2.Items.Clear();
                bağlantı.Open();
                komut = new OleDbCommand("Select * From kullanıcı_item where userID=" + kullaniciID + " order by item_fiyat", bağlantı);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem item = new ListViewItem(oku["userID"].ToString());
                    item.SubItems.Add(oku["item_ad"].ToString());
                    item.SubItems.Add(oku["item_miktar"].ToString());
                    item.SubItems.Add(oku["item_fiyat"].ToString());
                    listView2.Items.Add(item);
                    satirSayisi++;
                }
                bağlantı.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                kullaniciID = 0;
            }
            else
            {
                kullaniciID = Convert.ToInt32(textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                satinAlinmakIstenenMiktar = 0;
            }
            else
            {
                satinAlinmakIstenenMiktar = Convert.ToInt32(textBox2.Text);
            }
        }
    }
}



