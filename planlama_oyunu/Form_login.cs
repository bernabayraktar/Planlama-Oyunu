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

    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = planlama oyunu db.mdb");
        OleDbCommand komut;
        OleDbDataReader oku;
        
        kullanıcı k = new kullanıcı();
        public static int usertype;
        private void cleaner()
        {
            txtad.Clear();
            txtsoyadı.Clear();
            txtkullanıcıad.Clear();
            txtşifre.Clear();
            txttc.Clear();
            txttelefon.Clear();
            txtemail.Clear();
            txtadres.Clear();
        }
        
        
        private void btn_üye_Click_1(object sender, EventArgs e)
        {
            k.kullanıcı_ekle(txtad.Text, txtsoyadı.Text, txtkullanıcıad.Text, txtşifre.Text, txttc.Text, txttelefon.Text, txtemail.Text, txtadres.Text);

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kullanıcılar where email like '" + txtemail.Text + "'", baglanti);

            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                usertype = Convert.ToInt32(oku["userID"]);
            }
            baglanti.Close();
            baglanti.Open();
            OleDbCommand oleDb = new OleDbCommand("insert into para values('" + usertype + "','" + 0 + "')", baglanti);
            oleDb.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt işleminiz gerçekleşti");
            cleaner();
            Form_bilgiler yeni = new Form_bilgiler();
            yeni.Show();
            this.Hide();
        }

        private void btn_giriş_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand();
            komut.CommandText = "select * from kullanıcılar where email=@mail and şifre=@parola";
            komut.Connection = baglanti;

            komut.Parameters.AddWithValue("@mail", txt_ent_mail.Text);
            komut.Parameters.AddWithValue("@parola", txt_ent_şifre.Text);
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                usertype = Convert.ToInt16(oku["userID"]);
                Form_bilgiler yeni = new Form_bilgiler();
                yeni.Show();
                this.Hide();
            }
            else if (txt_ent_mail.Text == "admin" && txt_ent_şifre.Text == "1234")
            {
                Form_admin_onay form_Admin_ = new Form_admin_onay();
                form_Admin_.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalı", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
    }
}
