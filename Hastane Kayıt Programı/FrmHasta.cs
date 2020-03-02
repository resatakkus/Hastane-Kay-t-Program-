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
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand emir;

        void veri_tabanı()
        {
            baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = HastaneBilgileri.accdb");
            baglanti.Open();
        }

        void hasta_ekleme()
        {
            emir = new OleDbCommand("Select * from Hasta", baglanti);

            emir.CommandText = "Insert into Hasta (TCKno,Adi,Soyadi,CalistigiKurum,SGK,DogumTarihi,Adres,Telefon,Cinsiyet) values (@TCKno,@Adi,@Soyadi,@CalistigiKurum,@SGK,@DogumTarihi,@Adres,@Telefon,@Cinsiyet)";
            emir.Parameters.Add("@TCno", OleDbType.VarChar).Value = FrmSekreter.tcNo;
            emir.Parameters.Add("@Adi", OleDbType.VarChar).Value = txtAd.Text;
            emir.Parameters.Add("@Soyadi", OleDbType.VarChar).Value = txtSoyad.Text;
            emir.Parameters.Add("@CalistigiKurum", OleDbType.VarChar).Value = txtCKurum.Text;
            if (ckbEvet.Checked == true) emir.Parameters.Add("@SGK", OleDbType.Boolean).Value = true;
            else emir.Parameters.Add("@SGK", OleDbType.Boolean).Value = false;
            emir.Parameters.Add("@DogumTarihi", OleDbType.VarChar).Value = txtDTarihi.Text;
            emir.Parameters.Add("@Adres", OleDbType.VarChar).Value = txtAdres.Text;
            emir.Parameters.Add("@Telefon", OleDbType.VarChar).Value = txtTelefon.Text;
            emir.Parameters.Add("@Cinsiyet", OleDbType.VarChar).Value = cmbCinsiyet.Text;
            emir.ExecuteNonQuery();

        }

        void sıra_verme()
        {
            emir = new OleDbCommand("Select * from Muayene", baglanti);

            emir.CommandText = "Insert into Muayene (PNo,Diploma_No,Tarih,TCKNo) values (@PNo,@Diploma_No,@Tarih,@TCKNo)";
            emir.Parameters.Add("@PNo", OleDbType.VarChar).Value = FrmSekreter.PNo;
            emir.Parameters.Add("@Diploma_No", OleDbType.VarChar).Value = FrmSekreter.DiplomaNo;
            emir.Parameters.Add("@Tarih", OleDbType.VarChar).Value = DateTime.Now.ToShortDateString();
            emir.Parameters.Add("@TCKNo", OleDbType.VarChar).Value = FrmSekreter.tcNo;
            emir.ExecuteNonQuery();

            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            veri_tabanı();
            hasta_ekleme();
            sıra_verme();
            MessageBox.Show("Hasta Kayıdı Yapılmıştır");
            this.Close();
        }
    }
}
