
namespace planlama_oyunu
{
    partial class Form_admin_onay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_para_sorgu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtlist_transfer_Para = new System.Windows.Forms.TextBox();
            this.btnParaRed = new System.Windows.Forms.Button();
            this.txtlist_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_güncel_para = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlist_mevcut_Para = new System.Windows.Forms.TextBox();
            this.btnParaOnay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_item_red = new System.Windows.Forms.Button();
            this.btn_item_onay = new System.Windows.Forms.Button();
            this.txt_list_item_itemmiktar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_list_item_itemfiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_list_item_itemad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_list_item_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView_item_sorgu = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_çıkış = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.listView_para_sorgu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtlist_transfer_Para);
            this.groupBox1.Controls.Add(this.btnParaRed);
            this.groupBox1.Controls.Add(this.txtlist_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_güncel_para);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtlist_mevcut_Para);
            this.groupBox1.Controls.Add(this.btnParaOnay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 493);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Transfer Paneli";
            // 
            // listView_para_sorgu
            // 
            this.listView_para_sorgu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_para_sorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_para_sorgu.FullRowSelect = true;
            this.listView_para_sorgu.HideSelection = false;
            this.listView_para_sorgu.Location = new System.Drawing.Point(10, 43);
            this.listView_para_sorgu.Name = "listView_para_sorgu";
            this.listView_para_sorgu.Size = new System.Drawing.Size(286, 177);
            this.listView_para_sorgu.TabIndex = 0;
            this.listView_para_sorgu.UseCompatibleStateImageBehavior = false;
            this.listView_para_sorgu.View = System.Windows.Forms.View.Details;
            this.listView_para_sorgu.SelectedIndexChanged += new System.EventHandler(this.listView_para_sorgu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "userID";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "para_miktar";
            this.columnHeader2.Width = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Güncel Miktar";
            // 
            // txtlist_transfer_Para
            // 
            this.txtlist_transfer_Para.Location = new System.Drawing.Point(162, 342);
            this.txtlist_transfer_Para.Name = "txtlist_transfer_Para";
            this.txtlist_transfer_Para.Size = new System.Drawing.Size(130, 26);
            this.txtlist_transfer_Para.TabIndex = 8;
            // 
            // btnParaRed
            // 
            this.btnParaRed.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnParaRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaRed.Location = new System.Drawing.Point(162, 436);
            this.btnParaRed.Name = "btnParaRed";
            this.btnParaRed.Size = new System.Drawing.Size(130, 54);
            this.btnParaRed.TabIndex = 3;
            this.btnParaRed.Text = "Transferi Reddet";
            this.btnParaRed.UseVisualStyleBackColor = false;
            this.btnParaRed.Click += new System.EventHandler(this.btnParaRed_Click);
            // 
            // txtlist_ID
            // 
            this.txtlist_ID.Location = new System.Drawing.Point(162, 242);
            this.txtlist_ID.Name = "txtlist_ID";
            this.txtlist_ID.Size = new System.Drawing.Size(130, 26);
            this.txtlist_ID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı ID";
            // 
            // txt_güncel_para
            // 
            this.txt_güncel_para.Location = new System.Drawing.Point(162, 392);
            this.txt_güncel_para.Name = "txt_güncel_para";
            this.txt_güncel_para.Size = new System.Drawing.Size(130, 26);
            this.txt_güncel_para.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Transfer Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mevcut Miktar";
            // 
            // txtlist_mevcut_Para
            // 
            this.txtlist_mevcut_Para.Location = new System.Drawing.Point(162, 292);
            this.txtlist_mevcut_Para.Name = "txtlist_mevcut_Para";
            this.txtlist_mevcut_Para.Size = new System.Drawing.Size(130, 26);
            this.txtlist_mevcut_Para.TabIndex = 5;
            // 
            // btnParaOnay
            // 
            this.btnParaOnay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnParaOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaOnay.Location = new System.Drawing.Point(6, 436);
            this.btnParaOnay.Name = "btnParaOnay";
            this.btnParaOnay.Size = new System.Drawing.Size(122, 54);
            this.btnParaOnay.TabIndex = 2;
            this.btnParaOnay.Text = "Transferi Onayla";
            this.btnParaOnay.UseVisualStyleBackColor = false;
            this.btnParaOnay.Click += new System.EventHandler(this.btnParaOnay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_item_red);
            this.groupBox2.Controls.Add(this.btn_item_onay);
            this.groupBox2.Controls.Add(this.txt_list_item_itemmiktar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_list_item_itemfiyat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_list_item_itemad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_list_item_ID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listView_item_sorgu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(306, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 546);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mal Beyan Paneli";
            // 
            // btn_item_red
            // 
            this.btn_item_red.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_item_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_item_red.Location = new System.Drawing.Point(240, 385);
            this.btn_item_red.Name = "btn_item_red";
            this.btn_item_red.Size = new System.Drawing.Size(122, 43);
            this.btn_item_red.TabIndex = 24;
            this.btn_item_red.Text = "Transferi Reddet";
            this.btn_item_red.UseVisualStyleBackColor = false;
            this.btn_item_red.Click += new System.EventHandler(this.btn_item_red_Click);
            // 
            // btn_item_onay
            // 
            this.btn_item_onay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_item_onay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_item_onay.Location = new System.Drawing.Point(240, 267);
            this.btn_item_onay.Name = "btn_item_onay";
            this.btn_item_onay.Size = new System.Drawing.Size(122, 54);
            this.btn_item_onay.TabIndex = 23;
            this.btn_item_onay.Text = "Transferi Onayla";
            this.btn_item_onay.UseVisualStyleBackColor = false;
            this.btn_item_onay.Click += new System.EventHandler(this.btn_item_onay_Click);
            // 
            // txt_list_item_itemmiktar
            // 
            this.txt_list_item_itemmiktar.Location = new System.Drawing.Point(83, 414);
            this.txt_list_item_itemmiktar.Name = "txt_list_item_itemmiktar";
            this.txt_list_item_itemmiktar.Size = new System.Drawing.Size(130, 26);
            this.txt_list_item_itemmiktar.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Item miktarı:";
            // 
            // txt_list_item_itemfiyat
            // 
            this.txt_list_item_itemfiyat.Location = new System.Drawing.Point(83, 360);
            this.txt_list_item_itemfiyat.Name = "txt_list_item_itemfiyat";
            this.txt_list_item_itemfiyat.Size = new System.Drawing.Size(130, 26);
            this.txt_list_item_itemfiyat.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Item fiyatı:";
            // 
            // txt_list_item_itemad
            // 
            this.txt_list_item_itemad.Location = new System.Drawing.Point(83, 307);
            this.txt_list_item_itemad.Name = "txt_list_item_itemad";
            this.txt_list_item_itemad.Size = new System.Drawing.Size(130, 26);
            this.txt_list_item_itemad.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Item adı:";
            // 
            // txt_list_item_ID
            // 
            this.txt_list_item_ID.Location = new System.Drawing.Point(83, 253);
            this.txt_list_item_ID.Name = "txt_list_item_ID";
            this.txt_list_item_ID.Size = new System.Drawing.Size(130, 26);
            this.txt_list_item_ID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kullanıcı ID";
            // 
            // listView_item_sorgu
            // 
            this.listView_item_sorgu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_item_sorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_item_sorgu.FullRowSelect = true;
            this.listView_item_sorgu.HideSelection = false;
            this.listView_item_sorgu.Location = new System.Drawing.Point(6, 43);
            this.listView_item_sorgu.Name = "listView_item_sorgu";
            this.listView_item_sorgu.Size = new System.Drawing.Size(376, 177);
            this.listView_item_sorgu.TabIndex = 13;
            this.listView_item_sorgu.UseCompatibleStateImageBehavior = false;
            this.listView_item_sorgu.View = System.Windows.Forms.View.Details;
            this.listView_item_sorgu.SelectedIndexChanged += new System.EventHandler(this.listView_item_sorgu_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "userID";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "item_ad";
            this.columnHeader4.Width = 153;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "item_miktar";
            this.columnHeader5.Width = 158;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "item_fiyat";
            this.columnHeader6.Width = 179;
            // 
            // btn_çıkış
            // 
            this.btn_çıkış.BackColor = System.Drawing.Color.Teal;
            this.btn_çıkış.Location = new System.Drawing.Point(6, 509);
            this.btn_çıkış.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_çıkış.Name = "btn_çıkış";
            this.btn_çıkış.Size = new System.Drawing.Size(122, 30);
            this.btn_çıkış.TabIndex = 17;
            this.btn_çıkış.Text = "ÇIKIŞ";
            this.btn_çıkış.UseVisualStyleBackColor = false;
            this.btn_çıkış.Click += new System.EventHandler(this.btn_çıkış_Click);
            // 
            // Form_admin_onay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1114, 548);
            this.Controls.Add(this.btn_çıkış);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_admin_onay";
            this.Text = "ADMİN PANEL";
            this.Load += new System.EventHandler(this.Form_admin_onay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView_para_sorgu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlist_transfer_Para;
        private System.Windows.Forms.Button btnParaRed;
        private System.Windows.Forms.TextBox txtlist_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_güncel_para;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlist_mevcut_Para;
        private System.Windows.Forms.Button btnParaOnay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_item_sorgu;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_item_red;
        private System.Windows.Forms.Button btn_item_onay;
        private System.Windows.Forms.TextBox txt_list_item_itemmiktar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_list_item_itemfiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_list_item_itemad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_list_item_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_çıkış;
    }
}