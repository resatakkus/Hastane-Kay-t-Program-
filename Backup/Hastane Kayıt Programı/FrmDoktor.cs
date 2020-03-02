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
    public partial class FrmDoktor : Form
    {
        public FrmDoktor()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand emir;
        OleDbDataReader okuma;
        DataTable tablo;

        public static string diploma_no;
        void veri_tabanı()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = HastaneBilgileri.accdb"); baglanti.Open();
        }

        void doktorlar()
        {
            emir = new OleDbCommand("Select * from Doktor", baglanti);
            tablo = new DataTable(); 

            tablo.Columns.Add("Adi_Soyadi");
            tablo.Columns.Add("Diploma_no");

            okuma = emir.ExecuteReader();
            while (okuma.Read())
            {
                DataRow satır = tablo.NewRow(); 

                satır["Adi_Soyadi"] = okuma["Adi"] + " " + okuma["Soyadi"];
                satır["Diploma_no"] = okuma["DiplomaNo"];

                tablo.Rows.Add(satır);
            }

            comboBox1.ValueMember = "Diploma_no";
            comboBox1.DisplayMember = "Adi_Soyadi";
            comboBox1.DataSource = tablo;

            baglanti.Close();
        }

        void sifre()
        {
            emir = new OleDbCommand("Select * from Doktor", baglanti);

            emir.CommandText = "Select * from Doktor where DiplomaNo=@DiplomaNo and sifre=@sifre";
            emir.Parameters.Add("@DiplomaNo", OleDbType.VarChar).Value = comboBox1.SelectedValue.ToString();
            emir.Parameters.Add("@sifre", OleDbType.VarChar).Value = txtSifre.Text;

            okuma = emir.ExecuteReader();
            if (okuma.Read())
            {
                diploma_no = comboBox1.SelectedValue.ToString();

                FrmMuayene goruntule = new FrmMuayene();
                goruntule.Show();
            }
            else MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            baglanti.Close();
        }

        private void FrmDoktor_Load(object sender, EventArgs e)
        {
            veri_tabanı();
            doktorlar();

            txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            veri_tabanı();

            if (txtSifre.Text == "") MessageBox.Show("Lütfen Şifre Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else sifre();
        }

        private void ckdSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdSifre.Checked == true)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
