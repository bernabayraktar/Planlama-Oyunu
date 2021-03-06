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
    public partial class Form_admin_onay : Form
    {
        public Form_admin_onay()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void parabasvurugöster()
        {
            listView_para_sorgu.Items.Clear();
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = ("select * from para_başvuru");
            OleDbDataReader güncelle = komut.ExecuteReader();
            while (güncelle.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = güncelle["userID"].ToString();
                ekle.SubItems.Add(güncelle["para_miktar"].ToString());
                listView_para_sorgu.Items.Add(ekle);
            }
            baglantı.Close();
        }
        private void veri_temizle_para()
        {
            baglantı.Open();
            OleDbCommand oleDb;
            OleDbDataReader oku;
            string sqlkodu = "delete from para_başvuru where userID=@userıd";
            oleDb = new OleDbCommand(sqlkodu, baglantı);
            oleDb.Parameters.AddWithValue("@userıd", txtlist_ID.Text);
            oku = oleDb.ExecuteReader();
            if(oku.Read())
            {
                sqlkodu = "delete from para_başvuru where paraID=@paraıd";
                oleDb = new OleDbCommand(sqlkodu, baglantı);
                oleDb.Parameters.AddWithValue("@paraıd", oku[0]);
                oleDb.ExecuteNonQuery();
            }
            
            baglantı.Close();
        }
        private void veri_temizle_item()
        {
            baglantı.Open();

            OleDbCommand oleDbCommand;
            OleDbDataReader oku;
            string sqlkodu = "select *from item_başvuru where userID=@userıd";
            oleDbCommand = new OleDbCommand(sqlkodu, baglantı);
            oleDbCommand.Parameters.AddWithValue("@userıd", txt_list_item_ID.Text);
            oku = oleDbCommand.ExecuteReader();
           
            if(oku.Read())
            {
                sqlkodu = "delete from item_başvuru where item_başvuruID=@itemid";
                oleDbCommand = new OleDbCommand(sqlkodu, baglantı);
                oleDbCommand.Parameters.AddWithValue("@itemid", oku[0]);
                oleDbCommand.ExecuteNonQuery();
            }
            baglantı.Close();
        }
        private void temizle()
        {
            txtlist_ID.Clear();
            txtlist_mevcut_Para.Clear();
            txt_güncel_para.Clear();
            txtlist_transfer_Para.Clear();
        }
        private void temizle_item()
        {
            txt_list_item_ID.Clear();
            txt_list_item_itemad.Clear();
            txt_list_item_itemfiyat.Clear();
            txt_list_item_itemmiktar.Clear();
        }
        private void itembasvurugöster()
        {
            listView_item_sorgu.Items.Clear();
            baglantı.Open();
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Connection = baglantı;
            komut2.CommandText = "select * from item_başvuru";
            OleDbDataReader güncelle2 = komut2.ExecuteReader();
            while (güncelle2.Read())
            {
                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = güncelle2["userID"].ToString();
                ekle2.SubItems.Add(güncelle2["item_ad"].ToString());
                ekle2.SubItems.Add(güncelle2["item_miktar"].ToString());
                ekle2.SubItems.Add(güncelle2["item_fiyat"].ToString());
                listView_item_sorgu.Items.Add(ekle2);
            }
            baglantı.Close();
        }
        private void Form_admin_onay_Load(object sender, EventArgs e)
        {
            itembasvurugöster();
            parabasvurugöster();
        }

        private void listView_para_sorgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem lst in listView_para_sorgu.SelectedItems)
            {
                txtlist_ID.Text = lst.SubItems[0].Text;
                txtlist_transfer_Para.Text = lst.SubItems[1].Text;
            }
            baglantı.Open();
            komut.Connection = baglantı;
            komut.CommandText = "select * from para where userID like '" +txtlist_ID.Text + "'";
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                txtlist_mevcut_Para.Text = oku["para_miktar"].ToString();
            }
            baglantı.Close();
            int değer;
            değer = Convert.ToInt32(txtlist_transfer_Para.Text) + Convert.ToInt32(txtlist_mevcut_Para.Text);
            txt_güncel_para.Text = değer.ToString();
        }

        private void btnParaOnay_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            komut.Connection = baglantı;
            komut.CommandText = "update para set para_miktar=@para where userID=@ıd";
            komut.Parameters.AddWithValue("@para", Convert.ToInt32(txt_güncel_para.Text));
            komut.Parameters.AddWithValue("@ıd", txtlist_ID.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.Dispose();
            MessageBox.Show(txtlist_ID.Text + "userID li kullanıcının parasını"+ txt_güncel_para.Text +"olarak güncellediniz.");
            veri_temizle_para();
            temizle();
            parabasvurugöster();
        }

        private void btnParaRed_Click(object sender, EventArgs e)
        {
            veri_temizle_para();
            MessageBox.Show(txtlist_ID.Text + "userID li kullanıcının para başvurusunu reddettiniz.");
            temizle();
            parabasvurugöster();
        }

        private void listView_item_sorgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem lst in listView_item_sorgu.SelectedItems)
            {
                txt_list_item_ID.Text = lst.SubItems[0].Text;
                txt_list_item_itemad.Text = lst.SubItems[1].Text;
                txt_list_item_itemfiyat.Text = lst.SubItems[2].Text;
                txt_list_item_itemmiktar.Text = lst.SubItems[3].Text;
            }
        }

        private void btn_item_onay_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand dbCommand = new OleDbCommand();
            dbCommand.Connection = baglantı;
            dbCommand.CommandText = "insert into kullanıcı_item values('" + txt_list_item_ID.Text + "','" + txt_list_item_itemad.Text + "','" + Convert.ToInt32(txt_list_item_itemfiyat.Text) + "','" + Convert.ToInt32(txt_list_item_itemmiktar.Text) + "')";
            dbCommand.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(txt_list_item_ID.Text + "ID li kullanıcının item başvurusunu onayladınız");
            veri_temizle_item();
            temizle_item();
            itembasvurugöster();
        }

        private void btn_item_red_Click(object sender, EventArgs e)
        {
            veri_temizle_item();
            temizle_item();
            itembasvurugöster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
