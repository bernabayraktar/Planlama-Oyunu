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
using System.Xml;
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
        admin admin = new admin();
        private void parabasvurugöster()
        {
            listView_para_sorgu.Items.Clear();
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = ("select * from para_başvuru");
            OleDbDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["userID"].ToString();
                ekle.SubItems.Add(reader["para_miktar"].ToString());
                ekle.SubItems.Add(reader["para_birim"].ToString());
                listView_para_sorgu.Items.Add(ekle);
            }
            baglantı.Close();
        }
      
        
        private void temizle()
        {
            txtlist_ID.Clear();
            txtlist_mevcut_Para.Clear();
            txt_guncel_para.Clear();
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
            para para = new para();
            foreach (ListViewItem lst in listView_para_sorgu.SelectedItems)
            {
                txtlist_ID.Text = lst.SubItems[0].Text;
                int a = Convert.ToInt32(lst.SubItems[1].Text);
                txtlist_transfer_Para.Text = Convert.ToString(para.para_birimi_planla(lst.SubItems[2].Text) * a); 
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
            int money_vl;
            money_vl = Convert.ToInt32(txtlist_transfer_Para.Text) + Convert.ToInt32(txtlist_mevcut_Para.Text);
            txt_guncel_para.Text = money_vl.ToString();
        }

        private void btnParaOnay_Click(object sender, EventArgs e)
        {
            if (txtlist_ID.Text == "" || txtlist_mevcut_Para.Text == "" || txtlist_transfer_Para.Text == "" || txt_guncel_para.Text == "")
            {
                MessageBox.Show("lütfen bir kullanıcı parası seçiniz");
            }
            else
            {
                admin.para_onay(Convert.ToInt32(txtlist_ID.Text), Convert.ToInt32(txt_guncel_para.Text));
                MessageBox.Show(txtlist_ID.Text + "userID li kullanıcının parasını" + txt_guncel_para.Text + "olarak güncellediniz.");

                admin.veri_temizle_para(Convert.ToInt32(txtlist_ID.Text));
                temizle();
                parabasvurugöster();
            }
            
        }

        private void btnParaRed_Click(object sender, EventArgs e)
        {
            if (txtlist_ID.Text == "" || txtlist_mevcut_Para.Text == "" || txtlist_transfer_Para.Text == "" || txt_guncel_para.Text == "")
            {
                MessageBox.Show("lütfen bir kullanıcı parası seçiniz");
            }
            else
            {
                admin.veri_temizle_para(Convert.ToInt32(txtlist_ID.Text));
                MessageBox.Show(txtlist_ID.Text + "userID li kullanıcının para başvurusunu reddettiniz.");
                temizle();
                parabasvurugöster();
            }
        }

        private void listView_item_sorgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem lst in listView_item_sorgu.SelectedItems)
            {
                txt_list_item_ID.Text = lst.SubItems[0].Text;
                txt_list_item_itemad.Text = lst.SubItems[1].Text;
                txt_list_item_itemmiktar.Text = lst.SubItems[2].Text;
                txt_list_item_itemfiyat.Text = lst.SubItems[3].Text;
            }
        }

        private void btn_item_onay_Click(object sender, EventArgs e)
        {
            if (txt_list_item_ID.Text == "" || txt_list_item_itemad.Text == "" || txt_list_item_itemfiyat.Text == "" || txt_list_item_itemmiktar.Text == "") 
            {
                MessageBox.Show("lütfen bir kullanıcı itemi seçiniz");
            }
            else
            {
                admin.item_onay(Convert.ToInt32(txt_list_item_ID.Text), txt_list_item_itemad.Text, Convert.ToInt32(txt_list_item_itemfiyat.Text), Convert.ToInt32(txt_list_item_itemmiktar.Text));
                MessageBox.Show(txt_list_item_ID.Text + " ID li kullanıcının item başvurusunu onayladınız");

                admin.veri_temizle_item(Convert.ToInt32(txt_list_item_ID.Text));
                temizle_item();
                itembasvurugöster();
            }
            
        }

        private void btn_item_red_Click(object sender, EventArgs e)
        {
            if (txt_list_item_ID.Text == "" || txt_list_item_itemad.Text == "" || txt_list_item_itemfiyat.Text == "" || txt_list_item_itemmiktar.Text == "")
            {
                MessageBox.Show("lütfen bir kullanıcı itemi seçiniz");
            }
            else
            {
                admin.veri_temizle_item(Convert.ToInt32(txt_list_item_ID.Text));
                MessageBox.Show(txt_list_item_ID.Text + " ID li kullanıcının item başvurusunu reddettiniz");
                temizle_item();
                itembasvurugöster();
            }
           
        }

        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            Form_login yeni = new Form_login();
            this.Close();
            yeni.Show();
        }

       
    }

}
