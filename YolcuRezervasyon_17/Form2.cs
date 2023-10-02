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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"");

        private void btn_KaptanKaydet_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connect.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_kaptan (KAPTANNO, ADSOYAD, TELEFON) values (@P1,@P2,@P3)", connect);
            cmd.Parameters.AddWithValue("@P1", msktxt_KaptanNo.Text);
            cmd.Parameters.AddWithValue("@P2", txt_KaptanAdSoyad.Text);
            cmd.Parameters.AddWithValue("@P3", msktxt_KaptanTel.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kaptan başarıyla veritabanına kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Kaptanlar();

            msktxt_KaptanNo.Clear();
            txt_KaptanAdSoyad.Clear();
            msktxt_KaptanTel.Clear();
        }

        private void SeferBilgi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_SEFERLER", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void YolcuBilgi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_YOLCULAR", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Kaptanlar()
        {
            //SqlDataAdapter da = new SqlDataAdapter("select * from tbl_kaptan", connect);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView2.DataSource = dt;

            SqlDataAdapter dap = new SqlDataAdapter("select * from TBL_KAPTAN", connect);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["KAPTANNO"].ToString());
                item.SubItems.Add(row["ADSOYAD"].ToString());
                item.SubItems.Add(row["TELEFON"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void RBtn_Seferler_CheckedChanged(object sender, EventArgs e)
        {
            SeferBilgi();
            groupBox1.Text = "SEFERLER";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SeferBilgi();
            Kaptanlar();
        }

        private void RBtn_Yolcular_CheckedChanged(object sender, EventArgs e)
        {
            YolcuBilgi();
            groupBox1.Text = "YOLCULAR";
        }

        private void btn_SeferOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SeferKalkis.Text != "" || txt_SeferVaris.Text != "" || msktxt_Tarih.Text != "" || msktxt_Saat.Text != "" || txt_SeferFiyat.Text != "" || txt_SeferKaptan.Text != "")
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("insert into TBL_SEFERLER (KALKIS, VARIS, TARIH, SAAT, FIYAT, KAPTAN) values (@PR1,@PR2,@PR3,@PR4,@PR5,@PR6)", connect);
                    cmd.Parameters.AddWithValue("@PR1", txt_SeferKalkis.Text);
                    cmd.Parameters.AddWithValue("@PR2", txt_SeferVaris.Text);
                    cmd.Parameters.AddWithValue("@PR3", msktxt_Tarih.Text);
                    cmd.Parameters.AddWithValue("@PR4", msktxt_Saat.Text);
                    cmd.Parameters.AddWithValue("@PR5", txt_SeferFiyat.Text);
                    cmd.Parameters.AddWithValue("@PR6", txt_SeferKaptan.Text);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show(txt_SeferNo.Text + "Numaralı sefer başarıyla sisteme eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SeferBilgi();

                    txt_SeferKalkis.Clear();
                    txt_SeferVaris.Clear();
                    msktxt_Tarih.Clear();
                    msktxt_Saat.Clear();
                    txt_SeferFiyat.Clear();
                    txt_SeferKaptan.Clear();
                }
                else
                {
                    MessageBox.Show("Sefer oluşturmak için lütfen tüm alanları eksiksiz ve doğru şekilde giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Sistemde beklenmeyen bir hata oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Form1 frm1 = new Form1();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            if (RBtn_Seferler.Checked == true)
            {
                frm1.seferno = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                frm1.Show();
                this.Hide();
            }
            if (RBtn_Yolcular.Checked == true)
            {
                frm1.txt_RezAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                frm1.msktxt_RezTCNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                
            }
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
