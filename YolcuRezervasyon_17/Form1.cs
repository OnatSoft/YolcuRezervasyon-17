using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YolcuRezervasyon_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"");

        private void detaylarıGösterMenu_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        public string cinsiyet;
        public string seferno;

        private void Cinsiyet(Button id)
        {
            DialogResult result = MessageBox.Show("Cinsiyetiniz Erkek ise 'EVET', Kadın ise 'HAYIR' seçiniz.", "Koltuk Cinsiyet Seçimi", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                id.BackColor = Color.DeepSkyBlue;
                cinsiyet = "ERKEK";
            }
            else if (result == DialogResult.No)
            {
                id.BackColor = Color.HotPink;
                cinsiyet = "KADIN";
            }
        }

        private void btn_RezOlustur_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            DialogResult rezervasyonOnay = MessageBox.Show("Bu rezervasyonu oluşturmayı onaylıyor musunuz?", "REZERVASYON ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            try
            {
                connect.Open();
                if (txt_RezSeferNo.Text != "" || txt_RezAd.Text != "" || txt_RezSoyad.Text != "" || msktxt_RezTCNo.Text != String.Empty || msktxt_Telefon.Text != String.Empty || txt_Email.Text != "" || txt_KoltukNo.Text != "")
                {
                    if (rezervasyonOnay == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("insert into TBL_YOLCULAR (SEFERNO, YOLCUTC, ADSOYAD, TELEFON, MAIL, KOLTUK, CINSIYET) values (@PR0, @PR1, @PR2, @PR3, @PR4, @PR5, @PR6)", connect);
                        cmd.Parameters.AddWithValue("@PR0", txt_RezSeferNo.Text);
                        cmd.Parameters.AddWithValue("@PR1", msktxt_RezTCNo.Text);
                        cmd.Parameters.AddWithValue("@PR2", txt_RezAd.Text + " " + txt_RezSoyad.Text);
                        cmd.Parameters.AddWithValue("@PR3", msktxt_Telefon.Text);
                        cmd.Parameters.AddWithValue("@PR4", txt_Email.Text);
                        cmd.Parameters.AddWithValue("@PR5", txt_KoltukNo.Text);
                        cmd.Parameters.AddWithValue("@PR6", cinsiyet);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(txt_RezSeferNo.Text + "\nNumaralı sefer de " + txt_RezAd.Text + " " + txt_RezSoyad.Text + " isimli yolcunun rezervasyonu başarıyla yapılmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_RezAd.Clear();
                        txt_RezSoyad.Clear();
                        msktxt_RezTCNo.Clear();
                        msktxt_Telefon.Clear();
                        txt_Email.Clear();
                    }

                }
                else
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    if (txt_RezSeferNo.Text == "") { pictureBox1.Location = new Point(237, 41); }
                    else { pictureBox1.Visible = false; }

                    if (msktxt_RezTCNo.MaskCompleted == false) { pictureBox2.Location = new Point(237, 75); }
                    else { pictureBox2.Visible = false; }

                    if (txt_RezAd.Text == "") { pictureBox3.Location = new Point(237, 107); }
                    else { pictureBox3.Visible = false; }

                    if (txt_KoltukNo.Text == "") { pictureBox4.Location = new Point(237, 140); }
                    else { pictureBox4.Visible = false; }
                    MessageBox.Show("Lütfen yolcu rezervasyon bilgilerini doğru ve eksiksiz şekilde doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Yolcu rezervasyonu oluştururken beklenmeyen hata oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoluBos(Button id, string Koltuk)
        {
            connect.Open();
            SqlCommand komut = new SqlCommand("select Y.CINSIYET, y.KOLTUK from TBL_YOLCULAR as Y " +
                "inner join TBL_SEFERLER as S on " +
                "Y.SEFERNO = S.SEFERNO " +
                "WHERE S.SEFERNO = @PR1 and y.KOLTUK = @PR2", connect);
            komut.Parameters.AddWithValue("@PR1", txt_RezSeferNo.Text);
            komut.Parameters.AddWithValue("@PR2", txt_KoltukNo.Text);
            komut.ExecuteNonQuery();

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == "ERKEK")
                {
                    id.BackColor = Color.DeepSkyBlue;
                    id.Enabled = false;
                }
                else if (dr[0].ToString() == "KADIN")
                {
                    id.BackColor = Color.HotPink;
                    id.Enabled = false;
                }

            }
            dr.Close();
            connect.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_RezSeferNo.Text = seferno;

            DoluBos(koltuk1, "1");
            DoluBos(koltuk2, "2");
            DoluBos(koltuk3, "3");
            DoluBos(koltuk4, "4");
            DoluBos(koltuk5, "5");
            DoluBos(koltuk6, "6");
            DoluBos(koltuk7, "7");
            DoluBos(koltuk8, "8");
            DoluBos(koltuk9, "9");
            DoluBos(koltuk10, "10");
            DoluBos(koltuk11, "11");
            DoluBos(koltuk12, "12");
            DoluBos(koltuk13, "13");
            DoluBos(koltuk14, "14");
            DoluBos(koltuk15, "15");
            DoluBos(koltuk16, "16");
            DoluBos(koltuk17, "17");
            DoluBos(koltuk18, "18");
            DoluBos(koltuk19, "19");
            DoluBos(koltuk20, "20");
            DoluBos(koltuk21, "21");
            DoluBos(koltuk22, "22");
            DoluBos(koltuk23, "23");
            DoluBos(koltuk24, "24");
        }

        private void koltuk1_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk1.Text;
            Cinsiyet(koltuk1);
        }

        private void koltuk2_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk2.Text;
            Cinsiyet(koltuk2);
        }

        private void koltuk3_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk3.Text;
            Cinsiyet(koltuk3);
        }

        private void koltuk4_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk4.Text;
            Cinsiyet(koltuk4);
        }

        private void koltuk5_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk5.Text;
            Cinsiyet(koltuk5);
        }

        private void koltuk6_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk6.Text;
            Cinsiyet(koltuk6);
        }

        private void koltuk7_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk7.Text;
            Cinsiyet(koltuk7);
        }

        private void koltuk8_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk8.Text;
            Cinsiyet(koltuk8);
        }

        private void koltuk9_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk9.Text;
            Cinsiyet(koltuk9);
        }

        private void koltuk10_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk10.Text;
            Cinsiyet(koltuk10);
        }

        private void koltuk11_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk11.Text;
            Cinsiyet(koltuk11);
        }

        private void koltuk12_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk12.Text;
            Cinsiyet(koltuk12);
        }

        private void koltuk13_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk13.Text;
            Cinsiyet(koltuk13);
        }

        private void koltuk14_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk14.Text;
            Cinsiyet(koltuk14);
        }

        private void koltuk15_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk15.Text;
            Cinsiyet(koltuk15);
        }

        private void koltuk16_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk16.Text;
            Cinsiyet(koltuk16);
        }

        private void koltuk17_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk17.Text;
            Cinsiyet(koltuk17);
        }

        private void koltuk18_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk18.Text;
            Cinsiyet(koltuk18);
        }

        private void koltuk19_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk19.Text;
            Cinsiyet(koltuk19);
        }

        private void koltuk20_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk20.Text;
            Cinsiyet(koltuk20);
        }

        private void koltuk21_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk21.Text;
            Cinsiyet(koltuk21);
        }

        private void koltuk22_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk22.Text;
            Cinsiyet(koltuk22);
        }

        private void koltuk23_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk23.Text;
            Cinsiyet(koltuk23);
        }

        private void koltuk24_Click(object sender, EventArgs e)
        {
            txt_KoltukNo.Text = koltuk24.Text;
            Cinsiyet(koltuk24);
        }
    }
}
