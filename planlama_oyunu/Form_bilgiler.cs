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
using System.IO;
using excel = Microsoft.Office.Interop.Excel;

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
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
        OleDbCommand komut;
        public static string istenenFiyat;

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

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kullanıcılar where userID like '" + Form_login.usertype + "'", baglanti);
            OleDbCommand oleDb = new OleDbCommand("select * from kullanıcı_item where userID like '" + Form_login.usertype + "'", baglanti);
            OleDbCommand ole = new OleDbCommand("select * from para where userID like '" + Form_login.usertype + "'", baglanti);

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
            baglanti.Close();
        }
        void gridDoldur()
        {
            DataTable tablo = new DataTable();
            OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
            baglanti.Open();
            OleDbCommand command = new OleDbCommand("Select userID, item_ad, item_miktar, item_fiyat from kullanıcı_item where (item_ad= @itemad) and (userID <> @userid) order by item_fiyat", baglanti);

            command.Parameters.AddWithValue("@itemad", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@userid", Form_login.usertype);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            dataAdapter.Fill(tablo);
            dataGridView3.DataSource = tablo;
            this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            baglanti.Close();
        }

        private void Form_bilgiler_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form_login.usertype.ToString();
            gridDoldur();
            listele();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            k.kullanıcı_güncelle(textBox1.Text, txtad.Text, txtsoyad.Text, txtkullanıcı.Text, txtşifre.Text, txttc.Text, txttelefon.Text, txtemail.Text, txtadres.Text);
            listele();
            MessageBox.Show("verileriniz güncellendi");
        }

        private void btn_item_başvuru_Click(object sender, EventArgs e)
        {
            if (txt_item_başvuru.Text == "" || txt_item_miktar.Text == "" || txt_item_fiyat_başvuru.Text == "")
            {
                MessageBox.Show("Bu işlemi yapabilmek için gerekli bilgileri giriniz!");
            }
            else
            {
                itemler.item_başvuru(Form_login.usertype, txt_item_başvuru.Text, Convert.ToInt32(txt_item_miktar.Text), Convert.ToInt32(txt_item_fiyat_başvuru.Text));

                MessageBox.Show("Item başvuru talebiniz iletildi");
                başvuru_cleaner();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_para_başvuru.Text == "" || cmbMoneyType.Text == "")
            {
                MessageBox.Show("Bu işlemi yapabilmek için gerekli bilgileri giriniz.");
            }
            else
            {
                para.para_başvuru(Form_login.usertype, Convert.ToDouble(txt_para_başvuru.Text), cmbMoneyType.Text);
                MessageBox.Show("Para başvuru talebiniz iletildi");
                başvuru_cleaner();
            }

        }

        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            Form_login yeni = new Form_login();
            this.Close();
            yeni.Show();
        }
        int bakiye = 0;
        int alinanMiktar = 0;
        int gelenParaId;
        int gidenParaId;
        int yollananpara = 0;
        int yollananParaMuhasebe = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            istenenFiyat = istenenFiyatTxt.Text;
            if (istenenFiyatTxt.Text == "")
            {
                int tutar = 0;

                int kalanKg = 0;

                baglanti.Open();
                OleDbCommand command = new OleDbCommand("Select * from kullanıcı_item", baglanti);
                OleDbDataReader oku;
                oku = command.ExecuteReader();
                while (oku.Read())
                {
                    if (Convert.ToInt32(istenenKgTxt.Text) >= Convert.ToInt32(oku[3])) //kişinin almak istediği kg ilk satırdaki elemanın kg dan büyükse
                    {
                        MessageBox.Show(" ctrl");
                        int fiyat1 = ((Convert.ToInt32(oku[3]) * Convert.ToInt32(oku[4])) + (Convert.ToInt32(oku[3]) * Convert.ToInt32(oku[4])) / 100);
                        //PARA KONTROL
                        command = new OleDbCommand("Select * from para where userID=@userid", baglanti);
                        command.Parameters.AddWithValue("@userid", Form_login.usertype);
                        OleDbDataReader yenioku;
                        yenioku = command.ExecuteReader();
                        //bakiye = fiyat1;
                        yollananParaMuhasebe = (Convert.ToInt32(oku[3]) * Convert.ToInt32(oku[4])) / 100;
                        if (yenioku.Read())
                        {
                            if (Convert.ToInt32(yenioku[1]) >= fiyat1) //alicinin parasinin yettigi durum 
                            {
                                gelenParaId = Convert.ToInt32(oku[1]);
                                yollananpara = Convert.ToInt32(oku[3]) * Convert.ToInt32(oku[4]);

                                paraekleme();
                                command = new OleDbCommand("update kullanıcı_item set [userID] = @userid where urunKodu = @urunkodu and item_ad = @itemad", baglanti);
                                command.Parameters.AddWithValue("@userid", Form_login.usertype);
                                command.Parameters.AddWithValue("@urunkodu", oku[0]);
                                command.Parameters.AddWithValue("@itemad", comboBox1.SelectedItem);
                                gidenParaId = Form_login.usertype;
                                paracikarma();
                                command.ExecuteNonQuery();
                                MessageBox.Show("satın alındı");
                                gridDoldur();
                                break;
                            }
                        }
                        alinanMiktar = Convert.ToInt32(istenenKgTxt.Text) - kalanKg;
                    }
                }
                baglanti.Close();
            }
            else
            {
                //kullanıcının seçtiği ürün bilgileri ve talep ettiği tutarı veritabanındaki kuyruk tablosuna ekle.
                MessageBox.Show("Seçtiginiz ürünü kuyruğa eklemek için Satın Alma Talebi Oluştur butonuna tıklayın");

            }
        }
        void paraekleme()
        {
            //satıcıya para gönderilir.
            OleDbCommand command = new OleDbCommand("select * from para where userID=@userid", baglanti);
            command.Parameters.AddWithValue("@userid", gelenParaId);
            OleDbDataReader oku;
            oku = command.ExecuteReader();
            while (oku.Read())
            {

                command = new OleDbCommand("update para set [para_miktar] = @paramiktar where [userID] = @userid", baglanti);
                command.Parameters.AddWithValue("@paramiktar", Convert.ToInt32(oku[1]) + yollananpara);
                command.Parameters.AddWithValue("@userid", gelenParaId);
                command.ExecuteNonQuery();
            }

            //muhasebe kullanıcısına para gönderilir.
            OleDbCommand com = new OleDbCommand("select * from para where userID=" + 17 + "", baglanti);
            OleDbDataReader okuMuhasebePara;
            okuMuhasebePara = com.ExecuteReader();
            while (okuMuhasebePara.Read())
            {
                command = new OleDbCommand("update para set [para_miktar] = @paramiktar where [userID] = " + 17 + "", baglanti);
                command.Parameters.AddWithValue("@paramiktar", yollananParaMuhasebe);
                command.ExecuteNonQuery();
            }
        }
        void paracikarma()
        {
            //alıcıdan para kesilir.
            OleDbCommand command = new OleDbCommand("select * from para where userID=@userid", baglanti);
            command.Parameters.AddWithValue("@userid", gidenParaId);
            OleDbDataReader oku;
            oku = command.ExecuteReader();
            while (oku.Read())
            {
                int gonder = yollananpara + yollananParaMuhasebe;
                command = new OleDbCommand("update para set [para_miktar] = @paramiktar where [userID] = @userid", baglanti);
                command.Parameters.AddWithValue("@paramiktar", Convert.ToInt32(oku[1]) - gonder);
                command.Parameters.AddWithValue("@userid", gidenParaId);
                command.ExecuteNonQuery();
            }

        }

        private void btnTalepOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand command = new OleDbCommand("insert into bekleyenSatinAlma(userID, item_ad, item_miktar, item_fiyat) values(@userid, @itemAd, @itemMiktar, @itemFiyat)", baglanti);
            command.Parameters.AddWithValue("@userId", Form_login.usertype);
            command.Parameters.AddWithValue("@itemAd", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@itemMiktar", istenenKgTxt.Text);
            command.Parameters.AddWithValue("@itemFiyat", istenenFiyatTxt.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Talep oluşturuldu.");
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            alisexcelAktar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            satisexcelAktar();
        }
        void alisListeleme()
        {
            baglanti.Open();
            DataTable tablo2 = new DataTable();


            OleDbCommand satisRaporCmd;//tarih >='" + dateTimePicker2.Value.ToString() + "' and tarih <='" + dateTimePicker3.Value.ToString() + "' where userID='" + lbl_userID + "'"
            satisRaporCmd = new OleDbCommand("Select * from satinAlmaGecmisi where ([tarih]>@tarihkucuk and [tarih]<@tarihbuyuk) and ([userID]=@userid)  ", baglanti);// and ([userID]=@userid)
            satisRaporCmd.Parameters.AddWithValue("@tarihkucuk", dateTimePicker3.Text);
            satisRaporCmd.Parameters.AddWithValue("@tarihbuyuk", dateTimePicker2.Text);
            satisRaporCmd.Parameters.AddWithValue("@userid", textBox1.Text);

            OleDbDataAdapter adapter = new OleDbDataAdapter(satisRaporCmd);
            adapter.Fill(tablo2);
            alisDGV.DataSource = tablo2;
            baglanti.Close();
        }
        void satisListeleme()
        {
            baglanti.Open();
            DataTable tablo3 = new DataTable();
            OleDbCommand satisRaporCmd;//tarih >='" + dateTimePicker2.Value.ToString() + "' and tarih <='" + dateTimePicker3.Value.ToString() + "' where userID='" + lbl_userID + "'"
            satisRaporCmd = new OleDbCommand("Select * from satisGecmisi where ([tarih]>@tarihkucuk and [tarih]<@tarihbuyuk) and ([userID]=@userid)", baglanti);// and ([userID]=@userid)
            satisRaporCmd.Parameters.AddWithValue("@tarihkucuk", dateTimePicker6.Text);
            satisRaporCmd.Parameters.AddWithValue("@tarihbuyuk", dateTimePicker5.Text);
            satisRaporCmd.Parameters.AddWithValue("@userid", textBox1.Text);
            //satisRaporCmd.Parameters.AddWithValue("@userid", lbl_userID.Text);

            OleDbDataAdapter adapter = new OleDbDataAdapter(satisRaporCmd);
            adapter.Fill(tablo3);
            satisDGV.DataSource = tablo3;
            baglanti.Close();
        }
        void alisexcelAktar()
        {
            excel.Application excelUygulamasi = new excel.Application();       //Excel uygulaması için yeni bir nesne oluşturuluyor.
            excelUygulamasi.Visible = true;                                  //Excel'in gözükmesini sağlar.  
            excel.Workbook kitaplık = excelUygulamasi.Workbooks.Add(System.Reflection.Missing.Value);
            excel.Worksheet sayfa = (excel.Worksheet)kitaplık.Sheets[1];    //1. sayfadan başlaması sağlandı.
            for (int i = 0; i < alisDGV.Columns.Count; i++)                // sütun sayısı kadar döngü döndürülüyor.
            {
                excel.Range range = (excel.Range)sayfa.Cells[1, i + 1];        //tablodaki kolonların başlıkları geçirildi.
                range.Value2 = alisDGV.Columns[i].HeaderText;
            }
            for (int i = 0; i < alisDGV.Columns.Count; i++)                // sütun sayısı kadar döngü döndürülüyor.
            {
                for (int j = 0; j < alisDGV.Rows.Count; j++)               //satır sayısı kadar döngü döndürülüyor.
                {
                    excel.Range range = (excel.Range)sayfa.Cells[j + 2, i + 1];  //tablodaki geri kalan değerler excel'e aktarıldı.
                    range.Value2 = alisDGV[i, j].Value;
                    range.Select();

                }
            }
        }
        void satisexcelAktar()
        {
            excel.Application excelUygulamasi = new excel.Application();       //Excel uygulaması için yeni bir nesne oluşturuluyor.
            excelUygulamasi.Visible = true;                                  //Excel'in gözükmesini sağlar.  
            excel.Workbook kitaplık = excelUygulamasi.Workbooks.Add(System.Reflection.Missing.Value);
            excel.Worksheet sayfa = (excel.Worksheet)kitaplık.Sheets[1];    //1. sayfadan başlaması sağlandı.
            for (int i = 0; i < satisDGV.Columns.Count; i++)                // sütun sayısı kadar döngü döndürülüyor.
            {
                excel.Range range = (excel.Range)sayfa.Cells[1, i + 1];        //tablodaki kolonların başlıkları geçirildi.
                range.Value2 = satisDGV.Columns[i].HeaderText;
            }
            for (int i = 0; i < satisDGV.Columns.Count; i++)                // sütun sayısı kadar döngü döndürülüyor.
            {
                for (int j = 0; j < satisDGV.Rows.Count; j++)               //satır sayısı kadar döngü döndürülüyor.
                {
                    excel.Range range = (excel.Range)sayfa.Cells[j + 2, i + 1];  //tablodaki geri kalan değerler excel'e aktarıldı.
                    range.Value2 = satisDGV[i, j].Value;
                    range.Select();

                }
            }
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            satisListeleme();
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            satisListeleme();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            alisListeleme();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            alisListeleme();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
