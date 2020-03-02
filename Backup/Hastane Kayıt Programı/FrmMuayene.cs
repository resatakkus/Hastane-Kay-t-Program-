using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class FrmMuayene : Form
    {
        public FrmMuayene()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand emir, emir2;
        OleDbDataAdapter adaptör;
        OleDbDataReader okuma, okuma2;
        DataTable tablo;

        double fiyat;
        int sayac, sayac2;
        string ad, soyad;
        string yas;
        string tıklanan_listwiew;
        DateTime dogum_tarihi;

        void veri_tabanı()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = HastaneBilgileri.accdb");
            baglanti.Open();
        }

        void hastalar()
        {
            emir = new OleDbCommand("Select * from Muayene", baglanti);
            emir.CommandText = "Select * from Muayene where Diploma_No=@Diploma_No and Tedavi=@Tedavi and hasta_gelmedi=@hasta_gelmedi and beklenen_tahlil=@beklenen_tahlil and gün_ici=@gün_ici";
            emir.Parameters.Add("@Diploma_No", OleDbType.VarChar).Value = FrmDoktor.diploma_no;
            emir.Parameters.Add("@Tedavi", OleDbType.Boolean).Value = false;
            emir.Parameters.Add("@hasta_gelmedi", OleDbType.Boolean).Value = false;
            emir.Parameters.Add("@beklenen_tahlil", OleDbType.Boolean).Value = false;
            emir.Parameters.Add("@gün_ici", OleDbType.Boolean).Value = false;
            okuma = emir.ExecuteReader();
            while (okuma.Read())
            {
                lviewHastalar.Items.Add(okuma["MNo"].ToString());
                lviewHastalar.Items[sayac].SubItems.Add(okuma["TCKNo"].ToString());
                hasta_ad_soyad();
                lviewHastalar.Items[sayac].SubItems.Add(ad);
                lviewHastalar.Items[sayac].SubItems.Add(soyad);
                yas = (DateTime.Now.Year - dogum_tarihi.Year).ToString();
                lviewHastalar.Items[sayac].SubItems.Add(yas.ToString());
                lviewHastalar.Items[sayac].SubItems.Add(okuma["Tarih"].ToString());
                sayac++;
            }
        }
        void hasta_ad_soyad()
        {
            emir2 = new OleDbCommand("Select * from Hasta", baglanti);
            emir2.CommandText = "Select * from Hasta where TCKno=@TCKno";
            emir2.Parameters.Add("@TCKno", OleDbType.VarChar).Value = okuma["TCKNo"].ToString();
            okuma2 = emir2.ExecuteReader();
            okuma2.Read();
            ad = okuma2["Adi"].ToString();
            soyad = okuma2["Soyadi"].ToString();
            dogum_tarihi = DateTime.Parse(okuma2["DogumTarihi"].ToString());
        }
        void tahliller()
        {
            adaptör = new OleDbDataAdapter("Select * from Tahlil", baglanti);
            tablo = new DataTable();
            adaptör.Fill(tablo);
            emir = new OleDbCommand("Select TNo,Tadi from Tahlil", baglanti);
            cmbTahlil.ValueMember = "TNo";
            cmbTahlil.DisplayMember = "Tadi";
            cmbTahlil.DataSource = tablo;


        }
        void teshisler()
        {
            adaptör = new OleDbDataAdapter("Select * from Teshis", baglanti);
            tablo = new DataTable();
            adaptör.Fill(tablo);
            emir = new OleDbCommand("Select TeshisNo,TeshisAdi from Teshis", baglanti);
            cmbTeshis.ValueMember = "TeshisNo";
            cmbTeshis.DisplayMember = "TeshisAdi";
            cmbTeshis.DataSource = tablo;
        }

        void koyulan_teshisler()
        {
            emir = new OleDbCommand("Select * from Muayene", baglanti);
            emir.CommandText = "Select * from Muayene where TCKNo=@TCKNo and Diploma_No=@Diploma_No and Tedavi=@Tedavi";
            emir.Parameters.Add("@TCKNo", OleDbType.VarChar).Value = lviewHastalar.SelectedItems[0].SubItems[1].Text;
            emir.Parameters.Add("@Diploma_No", OleDbType.VarChar).Value = FrmDoktor.diploma_no;
            emir.Parameters.Add("@Tedavi", OleDbType.Boolean).Value = true;
            lviewTeshisler.Items.Clear();
            okuma = emir.ExecuteReader();
            while (okuma.Read())
            {
                teshisler_koyulan();
            }
            baglanti.Close();
        }

        void teshisler_koyulan()
        {
            emir2 = new OleDbCommand("Select * from Teshis", baglanti);
            emir2.CommandText = "Select * from Teshis where TeshisNo=@TeshisNo";
            emir2.Parameters.Add("@TeshisNo", OleDbType.VarChar).Value = okuma["TeshisNo"].ToString();
            okuma2 = emir2.ExecuteReader();
            if (okuma2.Read()) lviewTeshisler.Items.Add(okuma2["TeshisAdi"].ToString());
        }

        void hasta_bilgileri()
        {
            txtMuayeneNo.Text = lviewHastalar.SelectedItems[0].SubItems[0].Text;
            lblMuayeneNo.Text = lviewHastalar.SelectedItems[0].SubItems[0].Text;
            lblTCNo.Text = lviewHastalar.SelectedItems[0].SubItems[1].Text;
            lblAd.Text = lviewHastalar.SelectedItems[0].SubItems[2].Text;
            lblSoyad.Text = lviewHastalar.SelectedItems[0].SubItems[3].Text;
            lblYaş.Text = lviewHastalar.SelectedItems[0].SubItems[4].Text;
            lblTarih.Text = lviewHastalar.SelectedItems[0].SubItems[5].Text;
        }

        void tahlil_fiyatları()
        {
            emir = new OleDbCommand("Select * from Tahlil", baglanti);
            emir.CommandText = "Select * from Tahlil where TNo=@TNo";
            emir.Parameters.Add("@TNo", OleDbType.VarChar).Value = cmbTahlil.SelectedValue.ToString();
            okuma = emir.ExecuteReader(); okuma.Read();
            fiyat = double.Parse(okuma["Fiyat"].ToString());
            txtFiyat.Text = (fiyat * double.Parse(numericUpDown1.Value.ToString())).ToString();
        }

        void tahlil_ver()
        {
            emir = new OleDbCommand("Select * from Muayene_tahlil", baglanti);
            emir.CommandText = "Insert into Muayene_tahlil (MNo,TahlilNo,Miktar,Tarih) values (@MNo,@TahlilNo,@Miktar,@Tarih)";
            emir.Parameters.Add("@MNo", OleDbType.VarChar).Value = txtMuayeneNo.Text;
            emir.Parameters.Add("@TahlilNo", OleDbType.VarChar).Value = cmbTahlil.SelectedValue.ToString();
            emir.Parameters.Add("@Miktar", OleDbType.VarChar).Value = numericUpDown1.Value.ToString();
            emir.Parameters.Add("@Tarih", OleDbType.VarChar).Value = DateTime.Now.ToShortDateString();
            emir.ExecuteNonQuery();
            emir2 = new OleDbCommand("Select * from Muayene", baglanti);
            emir2.CommandText = "Update Muayene set beklenen_tahlil=@beklenen_tahlil where MNo=@MNo";
            emir2.Parameters.Add("@beklenen_tahlil", OleDbType.Boolean).Value = true;
            emir2.Parameters.Add("@MNo", OleDbType.VarChar).Value = txtMuayeneNo.Text;
            emir2.ExecuteNonQuery();
            baglanti.Close();
        }

        void tahlil_verilen_hastalar()
        {
            emir = new OleDbCommand("Select * from Muayene", baglanti);
            emir.CommandText = "Select * from Muayene where Diploma_No=@Diploma_No and Tedavi=@Tedavi and hasta_gelmedi=@hasta_gelmedi and beklenen_tahlil=@beklenen_tahlil and gün_ici=@gün_ici";
            emir.Parameters.Add("@Diploma_No", OleDbType.VarChar).Value = FrmDoktor.diploma_no;
            emir.Parameters.Add("@Tedavi", OleDbType.Boolean).Value = false;
            emir.Parameters.Add("@hasta_gelmedi", OleDbType.Boolean).Value = false;
            emir.Parameters.Add("@beklenen_tahlil", OleDbType.Boolean).Value = true;
            emir.Parameters.Add("@gün_ici", OleDbType.Boolean).Value = true;
            okuma = emir.ExecuteReader();
            while (okuma.Read())
            {
                tahlil_verilen_hastalar_ad_soyad();
            }

            baglanti.Close();
        }

        void tahlil_verilen_hastalar_ad_soyad()
        {
            emir2 = new OleDbCommand("Select * from Hasta", baglanti);
            emir2.CommandText = "Select * from Hasta where TCKno=@TCKno";
            emir2.Parameters.Add("@TCKno", OleDbType.VarChar).Value = okuma["TCKNo"].ToString();
            okuma2 = emir2.ExecuteReader();
            if (okuma2.Read())
            {
                lviewTahlil.Items.Add(okuma["MNo"].ToString());
                lviewTahlil.Items[sayac2].SubItems.Add(okuma2["Adi"].ToString());
                lviewTahlil.Items[sayac2].SubItems.Add(okuma2["Soyadi"].ToString());
                sayac2++;
            }
        }

        void teshis_koyma()
        {
            emir = new OleDbCommand("Select * from Muayene", baglanti);
            emir.CommandText = "Update Muayene set TeshisNo=@TeshisNo,Tedavi=@Tedavi,beklenen_tahlil=@beklenen_tahlil where MNo=@MNo";
            emir.Parameters.Add("@TeshisNo", OleDbType.VarChar).Value = cmbTeshis.SelectedValue.ToString();
            emir.Parameters.Add("@Tedavi", OleDbType.Boolean).Value = true;
            emir.Parameters.Add("@beklenen_tahlil", OleDbType.Boolean).Value = false;
            emir.Parameters.Add("@MNo", OleDbType.VarChar).Value = txtMuayeneNo.Text;
            emir.ExecuteNonQuery();
            baglanti.Close();
        }
        void hasta_gelmedi()
        {
            emir = new OleDbCommand("Select * from Muayene", baglanti);

            emir.CommandText = "Update Muayene set hasta_gelmedi=@hasta_gelmedi where MNo=@MNo";
            emir.Parameters.Add("@hasta_gelmedi", OleDbType.Boolean).Value = true;
            emir.Parameters.Add("@MNo", OleDbType.VarChar).Value = txtMuayeneNo.Text;
            emir.ExecuteNonQuery();

            baglanti.Close();
        }
        void temizleme()
        {
            lblAd.Text = "---";
            lblMuayeneNo.Text = "---";
            txtMuayeneNo.Text = null;
            lblSoyad.Text = "---";
            lblTarih.Text = "---";
            lblTCNo.Text = "---";
            txtFiyat.Text = "---";
            lblYaş.Text = "---";
        }

        private void FrmMuayene_Load(object sender, EventArgs e)
        {
            veri_tabanı();
            hastalar();
            tahliller();
            teshisler();
            tahlil_verilen_hastalar();
        }

        private void lviewHastalar_Click(object sender, EventArgs e)
        {
            veri_tabanı();
            koyulan_teshisler();
            hasta_bilgileri();
            if (lviewTeshisler.Items.Count == 0) lviewTeshisler.Items.Add("Daha Önce Hiç Teşhis Konulmamış");
            tıklanan_listwiew = "sıra";
        }

        private void cmbTahlil_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri_tabanı();
            tahlil_fiyatları();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            txtFiyat.Text = (fiyat * double.Parse(numericUpDown1.Value.ToString())).ToString();
        }

        private void lviewTahlil_Click(object sender, EventArgs e)
        {
            txtMuayeneNo.Text = lviewTahlil.SelectedItems[0].SubItems[0].Text;
            tıklanan_listwiew = "tahlil_verilen";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri_tabanı();
            tahlil_ver();
            lviewTahlil.Items.Add(txtMuayeneNo.Text);
            lviewTahlil.Items[sayac2].SubItems.Add(lblAd.Text);
            lviewTahlil.Items[sayac2].SubItems.Add(lblSoyad.Text);
            sayac2++;
            lviewHastalar.Items.RemoveAt(lviewHastalar.SelectedItems[0].Index);

            temizleme();

            MessageBox.Show("Tahlil Verilmiştir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veri_tabanı();
            teshis_koyma();
            if (tıklanan_listwiew == "sıra") lviewHastalar.SelectedItems[0].Remove();
            else lviewTahlil.Items.RemoveAt(lviewTahlil.SelectedItems[0].Index);
            temizleme();
            MessageBox.Show("Teşhis Koyulmuştur");
        }

        private void btnTHastaGelmedi_Click(object sender, EventArgs e)
        {
            veri_tabanı();
            hasta_gelmedi();
            lviewTahlil.SelectedItems[0].Remove();
            temizleme();
        }

        private void btnHastaGelmedi_Click(object sender, EventArgs e)
        {
            veri_tabanı();
            hasta_gelmedi();
            lviewHastalar.SelectedItems[0].Remove();
            temizleme();
        }
    }
}
