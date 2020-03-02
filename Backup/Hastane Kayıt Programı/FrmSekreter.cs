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
    public partial class FrmSekreter : Form
    {
        public FrmSekreter()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand emir;
        OleDbDataAdapter adaptör;
        OleDbDataReader okuma;
        DataTable tablo;

        string siraNo;
        public static string PNo, DiplomaNo, tcNo;

        void veri_tabanı(string tablo_ismi)
        {
            baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = HastaneBilgileri.accdb");
            adaptör = new OleDbDataAdapter("Select * from " + tablo_ismi, baglanti);
            tablo = new DataTable();
            baglanti.Open();
            adaptör.Fill(tablo);
        }

        void poliklinik()
        {
            emir = new OleDbCommand("Select PNO,Padi  from Poliklinik", baglanti);
            cmbPoliklinik.ValueMember = "PNO";
            cmbPoliklinik.DisplayMember = "Padi";
            cmbPoliklinik.DataSource = tablo;
            baglanti.Close();
        }

        void doktor()
        {
            emir = new OleDbCommand("Select * from Doktor", baglanti);
            emir.CommandText = "Select * from Doktor where PNO=@PNO";
            emir.Parameters.Add("@PNO", OleDbType.VarChar).Value = cmbPoliklinik.SelectedValue.ToString();
            tablo = new DataTable(); 
            tablo.Columns.Add("Adi_Soyadi");
            tablo.Columns.Add("DiplomaNo");
            okuma = emir.ExecuteReader();
            while (okuma.Read())
            {
                DataRow satır = tablo.NewRow();
                satır["Adi_Soyadi"] = okuma["Adi"] + " " + okuma["Soyadi"];
                satır["DiplomaNo"] = okuma["DiplomaNo"];
                tablo.Rows.Add(satır);
            }
            cmbDoktor.ValueMember = "DiplomaNo";
            cmbDoktor.DisplayMember = "Adi_Soyadi";
            cmbDoktor.DataSource = tablo;
            baglanti.Close();
        }

        void hasta_bulma()
        {
            emir = new OleDbCommand("Select * from Hasta", baglanti);
            emir.CommandText = "Select * from Hasta where TCKno=@TCKno";
            emir.Parameters.Add("@TCKno", OleDbType.VarChar).Value = txtTCNO.Text;

            okuma = emir.ExecuteReader();
            if (!okuma.Read())
            {
                tcNo = txtTCNO.Text;
                PNo = cmbPoliklinik.SelectedValue.ToString();
                DiplomaNo = cmbPoliklinik.SelectedValue.ToString();
                FrmHasta goruntule = new FrmHasta();
                goruntule.ShowDialog();
            }
            else 
            {
                emir = new OleDbCommand("Select * from Muayene", baglanti);

                emir.CommandText = "Insert into Muayene (PNo,Diploma_No,Tarih,TCKNo) values (@PNo,@Diploma_No,@Tarih,@TCKNo)";
                emir.Parameters.Add("@PNo", OleDbType.VarChar).Value = cmbPoliklinik.SelectedValue.ToString();
                emir.Parameters.Add("Diploma_No", OleDbType.VarChar).Value = cmbDoktor.SelectedValue.ToString();
                emir.Parameters.Add("Tarih", OleDbType.VarChar).Value = DateTime.Now.ToShortDateString();
                emir.Parameters.Add("TCKNo", OleDbType.VarChar).Value = txtTCNO.Text;
                emir.ExecuteNonQuery();
            }
        }

        void sıra_no_bulma()
        {
            emir = new OleDbCommand("Select * from Muayene", baglanti);
            emir.CommandText = "Select * from Muayene where TCKNo=@TCKNo and Tedavi=@Tedavi and gün_ici=@gün_ici";
            emir.Parameters.Add("@TCKNo", OleDbType.VarChar).Value = txtTCNO.Text;
            emir.Parameters.Add("@Tedavi", OleDbType.Boolean).Value = false;
            emir.Parameters.Add("@gün_ici", OleDbType.Boolean).Value = false;
            okuma = emir.ExecuteReader();
            okuma.Read();
            siraNo = okuma["MNo"].ToString();
            baglanti.Close();
        }

        private void FrmSekreter_Load(object sender, EventArgs e)
        {
            veri_tabanı("Poliklinik");
            poliklinik();
        }

        private void btnSira_Click(object sender, EventArgs e)
        {
            veri_tabanı("Hasta");
            hasta_bulma();
            sıra_no_bulma();

            MessageBox.Show("Sıra No: " + siraNo);
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri_tabanı("Doktor");
            doktor();
        }
    }
}
