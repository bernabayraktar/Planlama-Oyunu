
namespace planlama_oyunu
{
    partial class Form_login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_ent_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_giriş = new System.Windows.Forms.Button();
            this.txt_ent_şifre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_üye = new System.Windows.Forms.Button();
            this.txtkullanıcıad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtsoyadı = new System.Windows.Forms.TextBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.txt_ent_mail);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_giriş);
            this.panel2.Controls.Add(this.txt_ent_şifre);
            this.panel2.Location = new System.Drawing.Point(272, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 530);
            this.panel2.TabIndex = 31;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(589, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(60, 23);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // txt_ent_mail
            // 
            this.txt_ent_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ent_mail.ForeColor = System.Drawing.Color.Black;
            this.txt_ent_mail.Location = new System.Drawing.Point(422, 214);
            this.txt_ent_mail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ent_mail.Multiline = true;
            this.txt_ent_mail.Name = "txt_ent_mail";
            this.txt_ent_mail.Size = new System.Drawing.Size(131, 19);
            this.txt_ent_mail.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(371, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(381, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // btn_giriş
            // 
            this.btn_giriş.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_giriş.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giriş.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_giriş.Location = new System.Drawing.Point(478, 296);
            this.btn_giriş.Margin = new System.Windows.Forms.Padding(2);
            this.btn_giriş.Name = "btn_giriş";
            this.btn_giriş.Size = new System.Drawing.Size(75, 31);
            this.btn_giriş.TabIndex = 23;
            this.btn_giriş.Text = "Giriş Yap";
            this.btn_giriş.UseVisualStyleBackColor = false;
            this.btn_giriş.Click += new System.EventHandler(this.btn_giriş_Click_1);
            // 
            // txt_ent_şifre
            // 
            this.txt_ent_şifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_ent_şifre.ForeColor = System.Drawing.Color.Black;
            this.txt_ent_şifre.Location = new System.Drawing.Point(424, 253);
            this.txt_ent_şifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ent_şifre.Multiline = true;
            this.txt_ent_şifre.Name = "txt_ent_şifre";
            this.txt_ent_şifre.Size = new System.Drawing.Size(131, 19);
            this.txt_ent_şifre.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_üye);
            this.panel1.Controls.Add(this.txtkullanıcıad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtadres);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.txttelefon);
            this.panel1.Controls.Add(this.txtsoyadı);
            this.panel1.Controls.Add(this.txttc);
            this.panel1.Controls.Add(this.txtşifre);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 502);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(101, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Üye Olun";
            // 
            // btn_üye
            // 
            this.btn_üye.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_üye.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_üye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_üye.Location = new System.Drawing.Point(105, 428);
            this.btn_üye.Margin = new System.Windows.Forms.Padding(2);
            this.btn_üye.Name = "btn_üye";
            this.btn_üye.Size = new System.Drawing.Size(77, 34);
            this.btn_üye.TabIndex = 24;
            this.btn_üye.Text = "Üye Ol";
            this.btn_üye.UseVisualStyleBackColor = false;
            this.btn_üye.Click += new System.EventHandler(this.btn_üye_Click_1);
            // 
            // txtkullanıcıad
            // 
            this.txtkullanıcıad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtkullanıcıad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkullanıcıad.Location = new System.Drawing.Point(115, 151);
            this.txtkullanıcıad.Margin = new System.Windows.Forms.Padding(2);
            this.txtkullanıcıad.Multiline = true;
            this.txtkullanıcıad.Name = "txtkullanıcıad";
            this.txtkullanıcıad.Size = new System.Drawing.Size(126, 22);
            this.txtkullanıcıad.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(32, 153);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Kullanıcı Adı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(32, 114);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Soyadı:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(32, 189);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 7;
            this.label16.Text = "Şifre:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(32, 228);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 15);
            this.label17.TabIndex = 8;
            this.label17.Text = "TC Kimlik No:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(32, 267);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "Telefon:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(32, 305);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 15);
            this.label19.TabIndex = 10;
            this.label19.Text = "E-Mail:";
            // 
            // txtadres
            // 
            this.txtadres.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtadres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadres.Location = new System.Drawing.Point(120, 341);
            this.txtadres.Margin = new System.Windows.Forms.Padding(2);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(121, 49);
            this.txtadres.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(32, 343);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Adres:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Location = new System.Drawing.Point(120, 303);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(121, 22);
            this.txtemail.TabIndex = 17;
            // 
            // txtad
            // 
            this.txtad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtad.Location = new System.Drawing.Point(115, 77);
            this.txtad.Margin = new System.Windows.Forms.Padding(2);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(126, 22);
            this.txtad.TabIndex = 12;
            // 
            // txttelefon
            // 
            this.txttelefon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txttelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelefon.Location = new System.Drawing.Point(120, 265);
            this.txttelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefon.Multiline = true;
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(121, 22);
            this.txttelefon.TabIndex = 16;
            // 
            // txtsoyadı
            // 
            this.txtsoyadı.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtsoyadı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsoyadı.Location = new System.Drawing.Point(115, 115);
            this.txtsoyadı.Margin = new System.Windows.Forms.Padding(2);
            this.txtsoyadı.Multiline = true;
            this.txtsoyadı.Name = "txtsoyadı";
            this.txtsoyadı.Size = new System.Drawing.Size(126, 22);
            this.txtsoyadı.TabIndex = 13;
            // 
            // txttc
            // 
            this.txttc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txttc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttc.Location = new System.Drawing.Point(119, 226);
            this.txttc.Margin = new System.Windows.Forms.Padding(2);
            this.txttc.Multiline = true;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(122, 22);
            this.txttc.TabIndex = 15;
            // 
            // txtşifre
            // 
            this.txtşifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtşifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtşifre.Location = new System.Drawing.Point(115, 187);
            this.txtşifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtşifre.Multiline = true;
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(126, 22);
            this.txtşifre.TabIndex = 14;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TİCARET UYGULAMASI";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_ent_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_giriş;
        private System.Windows.Forms.TextBox txt_ent_şifre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_üye;
        private System.Windows.Forms.TextBox txtkullanıcıad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtsoyadı;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtşifre;
    }
}

