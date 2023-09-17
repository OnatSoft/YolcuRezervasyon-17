
namespace YolcuRezervasyon_17
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_SeferOlustur = new System.Windows.Forms.Button();
            this.txt_SeferKaptan = new System.Windows.Forms.TextBox();
            this.txt_SeferFiyat = new System.Windows.Forms.TextBox();
            this.msktxt_Saat = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msktxt_Tarih = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SeferVaris = new System.Windows.Forms.TextBox();
            this.txt_SeferKalkis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SeferNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msktxt_KaptanNo = new System.Windows.Forms.MaskedTextBox();
            this.btn_KaptanKaydet = new System.Windows.Forms.Button();
            this.msktxt_KaptanTel = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_KaptanAdSoyad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.RBtn_Seferler = new System.Windows.Forms.RadioButton();
            this.RBtn_Yolcular = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEFERLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(6, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 392);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KAPTANLAR";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_SeferOlustur);
            this.groupBox4.Controls.Add(this.txt_SeferKaptan);
            this.groupBox4.Controls.Add(this.txt_SeferFiyat);
            this.groupBox4.Controls.Add(this.msktxt_Saat);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.msktxt_Tarih);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_SeferVaris);
            this.groupBox4.Controls.Add(this.txt_SeferKalkis);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txt_SeferNo);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(752, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 355);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SEFER OLUŞTUR";
            // 
            // btn_SeferOlustur
            // 
            this.btn_SeferOlustur.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_SeferOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SeferOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SeferOlustur.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SeferOlustur.ForeColor = System.Drawing.Color.White;
            this.btn_SeferOlustur.Location = new System.Drawing.Point(89, 281);
            this.btn_SeferOlustur.Name = "btn_SeferOlustur";
            this.btn_SeferOlustur.Size = new System.Drawing.Size(175, 49);
            this.btn_SeferOlustur.TabIndex = 1;
            this.btn_SeferOlustur.Text = "Sefer Oluştur";
            this.btn_SeferOlustur.UseVisualStyleBackColor = false;
            this.btn_SeferOlustur.Click += new System.EventHandler(this.btn_SeferOlustur_Click);
            // 
            // txt_SeferKaptan
            // 
            this.txt_SeferKaptan.Location = new System.Drawing.Point(89, 239);
            this.txt_SeferKaptan.Name = "txt_SeferKaptan";
            this.txt_SeferKaptan.Size = new System.Drawing.Size(175, 28);
            this.txt_SeferKaptan.TabIndex = 7;
            // 
            // txt_SeferFiyat
            // 
            this.txt_SeferFiyat.Location = new System.Drawing.Point(89, 206);
            this.txt_SeferFiyat.Name = "txt_SeferFiyat";
            this.txt_SeferFiyat.Size = new System.Drawing.Size(175, 28);
            this.txt_SeferFiyat.TabIndex = 6;
            // 
            // msktxt_Saat
            // 
            this.msktxt_Saat.Location = new System.Drawing.Point(89, 173);
            this.msktxt_Saat.Mask = "00:00";
            this.msktxt_Saat.Name = "msktxt_Saat";
            this.msktxt_Saat.Size = new System.Drawing.Size(175, 28);
            this.msktxt_Saat.TabIndex = 5;
            this.msktxt_Saat.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fiyat:";
            // 
            // msktxt_Tarih
            // 
            this.msktxt_Tarih.Location = new System.Drawing.Point(89, 140);
            this.msktxt_Tarih.Mask = "00/00/0000";
            this.msktxt_Tarih.Name = "msktxt_Tarih";
            this.msktxt_Tarih.Size = new System.Drawing.Size(175, 28);
            this.msktxt_Tarih.TabIndex = 4;
            this.msktxt_Tarih.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Saat:";
            // 
            // txt_SeferVaris
            // 
            this.txt_SeferVaris.Location = new System.Drawing.Point(89, 106);
            this.txt_SeferVaris.Name = "txt_SeferVaris";
            this.txt_SeferVaris.Size = new System.Drawing.Size(175, 28);
            this.txt_SeferVaris.TabIndex = 3;
            // 
            // txt_SeferKalkis
            // 
            this.txt_SeferKalkis.Location = new System.Drawing.Point(89, 73);
            this.txt_SeferKalkis.Name = "txt_SeferKalkis";
            this.txt_SeferKalkis.Size = new System.Drawing.Size(175, 28);
            this.txt_SeferKalkis.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Kaptan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Varış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kalkış:";
            // 
            // txt_SeferNo
            // 
            this.txt_SeferNo.Enabled = false;
            this.txt_SeferNo.Location = new System.Drawing.Point(89, 39);
            this.txt_SeferNo.Name = "txt_SeferNo";
            this.txt_SeferNo.Size = new System.Drawing.Size(175, 28);
            this.txt_SeferNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sefer No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msktxt_KaptanNo);
            this.groupBox2.Controls.Add(this.btn_KaptanKaydet);
            this.groupBox2.Controls.Add(this.msktxt_KaptanTel);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_KaptanAdSoyad);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(752, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 294);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YENİ KAPTAN EKLE";
            // 
            // msktxt_KaptanNo
            // 
            this.msktxt_KaptanNo.Location = new System.Drawing.Point(109, 39);
            this.msktxt_KaptanNo.Mask = "0000";
            this.msktxt_KaptanNo.Name = "msktxt_KaptanNo";
            this.msktxt_KaptanNo.Size = new System.Drawing.Size(175, 28);
            this.msktxt_KaptanNo.TabIndex = 1;
            this.msktxt_KaptanNo.ValidatingType = typeof(int);
            // 
            // btn_KaptanKaydet
            // 
            this.btn_KaptanKaydet.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_KaptanKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KaptanKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_KaptanKaydet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KaptanKaydet.ForeColor = System.Drawing.Color.White;
            this.btn_KaptanKaydet.Location = new System.Drawing.Point(109, 154);
            this.btn_KaptanKaydet.Name = "btn_KaptanKaydet";
            this.btn_KaptanKaydet.Size = new System.Drawing.Size(175, 49);
            this.btn_KaptanKaydet.TabIndex = 4;
            this.btn_KaptanKaydet.Text = "Kayıt Et";
            this.btn_KaptanKaydet.UseVisualStyleBackColor = false;
            this.btn_KaptanKaydet.Click += new System.EventHandler(this.btn_KaptanKaydet_Click);
            // 
            // msktxt_KaptanTel
            // 
            this.msktxt_KaptanTel.Location = new System.Drawing.Point(109, 105);
            this.msktxt_KaptanTel.Mask = "(999) 000-0000";
            this.msktxt_KaptanTel.Name = "msktxt_KaptanTel";
            this.msktxt_KaptanTel.Size = new System.Drawing.Size(175, 28);
            this.msktxt_KaptanTel.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 21);
            this.label15.TabIndex = 4;
            this.label15.Text = "Adı Soyadı:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Telefon:";
            // 
            // txt_KaptanAdSoyad
            // 
            this.txt_KaptanAdSoyad.Location = new System.Drawing.Point(109, 72);
            this.txt_KaptanAdSoyad.Name = "txt_KaptanAdSoyad";
            this.txt_KaptanAdSoyad.Size = new System.Drawing.Size(175, 28);
            this.txt_KaptanAdSoyad.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Kaptan No:";
            // 
            // RBtn_Seferler
            // 
            this.RBtn_Seferler.AutoSize = true;
            this.RBtn_Seferler.Location = new System.Drawing.Point(438, 12);
            this.RBtn_Seferler.Name = "RBtn_Seferler";
            this.RBtn_Seferler.Size = new System.Drawing.Size(81, 25);
            this.RBtn_Seferler.TabIndex = 18;
            this.RBtn_Seferler.Text = "Seferler";
            this.RBtn_Seferler.UseVisualStyleBackColor = true;
            this.RBtn_Seferler.CheckedChanged += new System.EventHandler(this.RBtn_Seferler_CheckedChanged);
            // 
            // RBtn_Yolcular
            // 
            this.RBtn_Yolcular.AutoSize = true;
            this.RBtn_Yolcular.Location = new System.Drawing.Point(525, 12);
            this.RBtn_Yolcular.Name = "RBtn_Yolcular";
            this.RBtn_Yolcular.Size = new System.Drawing.Size(82, 25);
            this.RBtn_Yolcular.TabIndex = 19;
            this.RBtn_Yolcular.Text = "Yolcular";
            this.RBtn_Yolcular.UseVisualStyleBackColor = true;
            this.RBtn_Yolcular.CheckedChanged += new System.EventHandler(this.RBtn_Yolcular_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(3, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(716, 365);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KAPTANNO";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ADSOYAD";
            this.columnHeader2.Width = 256;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TELEFON";
            this.columnHeader3.Width = 260;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1088, 834);
            this.Controls.Add(this.RBtn_Yolcular);
            this.Controls.Add(this.RBtn_Seferler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yolcu Otobüs Bileti Rezervasyon / Satın Alımı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_SeferOlustur;
        private System.Windows.Forms.TextBox txt_SeferKaptan;
        private System.Windows.Forms.TextBox txt_SeferFiyat;
        private System.Windows.Forms.MaskedTextBox msktxt_Saat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktxt_Tarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SeferVaris;
        private System.Windows.Forms.TextBox txt_SeferKalkis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SeferNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox msktxt_KaptanNo;
        private System.Windows.Forms.Button btn_KaptanKaydet;
        private System.Windows.Forms.MaskedTextBox msktxt_KaptanTel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_KaptanAdSoyad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton RBtn_Seferler;
        private System.Windows.Forms.RadioButton RBtn_Yolcular;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}