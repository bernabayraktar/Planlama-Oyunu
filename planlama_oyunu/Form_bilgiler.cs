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
        void gridDoldur()
        {
            DataTable tablo = new DataTable();
            OleDbConnection bağlantı = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
            bağlantı.Open();
            OleDbCommand command = new OleDbCommand("Select userID, item_ad, item_miktar, item_fiyat from kullanıcı_item where (item_ad= @itemad) and (userID <> @userid) order by item_fiyat", bağlantı);

            command.Parameters.AddWithValue("@itemad", comboBox1.SelectedItem);
            command.Parameters.AddWithValue("@userid", Form_login.usertype);

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            dataAdapter.Fill(tablo);
            dataGridView3.DataSource = tablo;
            this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bağlantı.Close();
        }

        private void Form_bilgiler_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form_login.usertype.ToString();
            gridDoldur();
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
            MessageBox.Show("Item başvuru talebiniz iletildi");
            başvuru_cleaner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            para.para_başvuru(Form_login.usertype, Convert.ToInt32(txt_para_başvuru.Text));
            MessageBox.Show("Para başvuru talebiniz iletildi");
            başvuru_cleaner();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int tutar = 0;

            int kalanKg = 0;

            bağlantı.Open();
            OleDbCommand command = new OleDbCommand("Select * from kullanıcı_item", bağlantı);
            OleDbDataReader oku;
            oku = command.ExecuteReader();



            while (oku.Read())
            {


                if (Convert.ToInt32(istenenKgTxt.Text) >= Convert.ToInt32(oku[3])) //kişinin almak istediği kg ilk satırdaki elemanın kg dan büyükse
                {
                    int fiyat1 = Convert.ToInt32(oku[3]) * Convert.ToInt32(oku[4]);
                    //PARA KONTROL
                    command = new OleDbCommand("Select * from para where userID=@userid", bağlantı);
                    command.Parameters.AddWithValue("@userid", Form_login.usertype);
                    OleDbDataReader yenioku;
                    yenioku = command.ExecuteReader();
                    //bakiye = fiyat1;
                    if (yenioku.Read())
                    {
                        if (Convert.ToInt32(yenioku[1]) > fiyat1)
                        {
                            gelenParaId = Convert.ToInt32(oku[1]);
                            yollananpara = Convert.ToInt32(oku[3]) * Convert.ToInt32(oku[4]);
                            paraekleme();
                            command = new OleDbCommand("update kullanıcı_item set [userID] = @userid where urunKodu = @urunkodu and item_ad = @itemad", bağlantı);
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
            bağlantı.Close();
        }
        void paraekleme()
        {
            OleDbCommand command = new OleDbCommand("select * from para where userID=@userid", bağlantı);
            command.Parameters.AddWithValue("@userid", gelenParaId);
            OleDbDataReader oku;
            oku = command.ExecuteReader();
            while (oku.Read())
            {

                command = new OleDbCommand("update para set [para_miktar] = @paramiktar where [userID] = @userid", bağlantı);
                command.Parameters.AddWithValue("@paramiktar", Convert.ToInt32(oku[1]) + yollananpara);
                command.Parameters.AddWithValue("@userid", gelenParaId);
                command.ExecuteNonQuery();
            }

        }
        void paracikarma()
        {
            OleDbCommand command = new OleDbCommand("select * from para where userID=@userid", bağlantı);
            command.Parameters.AddWithValue("@userid", gidenParaId);
            OleDbDataReader oku;
            oku = command.ExecuteReader();
            while (oku.Read())
            {

                command = new OleDbCommand("update para set [para_miktar] = @paramiktar where [userID] = @userid", bağlantı);
                command.Parameters.AddWithValue("@paramiktar", Convert.ToInt32(oku[1]) - yollananpara);
                command.Parameters.AddWithValue("@userid", gidenParaId);
                command.ExecuteNonQuery();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
