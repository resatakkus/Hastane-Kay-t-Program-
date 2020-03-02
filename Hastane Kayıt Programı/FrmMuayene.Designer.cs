namespace WindowsFormsApplication1
{
    partial class FrmMuayene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMuayene));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblYaş = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblMuayeneNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lviewTeshisler = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTahlil = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTeshis = new System.Windows.Forms.ComboBox();
            this.txtMuayeneNo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lviewTahlil = new System.Windows.Forms.ListView();
            this.chdMNo = new System.Windows.Forms.ColumnHeader();
            this.chdAd = new System.Windows.Forms.ColumnHeader();
            this.chdSoyad = new System.Windows.Forms.ColumnHeader();
            this.lviewHastalar = new System.Windows.Forms.ListView();
            this.chdMuayeneNo = new System.Windows.Forms.ColumnHeader();
            this.chdTCNo = new System.Windows.Forms.ColumnHeader();
            this.chdAd2 = new System.Windows.Forms.ColumnHeader();
            this.chdSoyad2 = new System.Windows.Forms.ColumnHeader();
            this.chdYaş = new System.Windows.Forms.ColumnHeader();
            this.chdTarih = new System.Windows.Forms.ColumnHeader();
            this.btnHastaGelmedi = new System.Windows.Forms.Button();
            this.btnTHastaGelmedi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Green;
            this.groupBox1.Controls.Add(this.lblTarih);
            this.groupBox1.Controls.Add(this.lblYaş);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.lblTCNo);
            this.groupBox1.Controls.Add(this.lblMuayeneNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta bilgileri";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(145, 231);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(28, 24);
            this.lblTarih.TabIndex = 11;
            this.lblTarih.Text = "---";
            // 
            // lblYaş
            // 
            this.lblYaş.AutoSize = true;
            this.lblYaş.Location = new System.Drawing.Point(145, 196);
            this.lblYaş.Name = "lblYaş";
            this.lblYaş.Size = new System.Drawing.Size(28, 24);
            this.lblYaş.TabIndex = 10;
            this.lblYaş.Text = "---";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(145, 157);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(28, 24);
            this.lblSoyad.TabIndex = 9;
            this.lblSoyad.Text = "---";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(145, 118);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(28, 24);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "---";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(145, 77);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(28, 24);
            this.lblTCNo.TabIndex = 7;
            this.lblTCNo.Text = "---";
            // 
            // lblMuayeneNo
            // 
            this.lblMuayeneNo.AutoSize = true;
            this.lblMuayeneNo.Location = new System.Drawing.Point(145, 40);
            this.lblMuayeneNo.Name = "lblMuayeneNo";
            this.lblMuayeneNo.Size = new System.Drawing.Size(28, 24);
            this.lblMuayeneNo.TabIndex = 6;
            this.lblMuayeneNo.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muayene No:";
            // 
            // lviewTeshisler
            // 
            this.lviewTeshisler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lviewTeshisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lviewTeshisler.Location = new System.Drawing.Point(590, 312);
            this.lviewTeshisler.Name = "lviewTeshisler";
            this.lviewTeshisler.Size = new System.Drawing.Size(416, 269);
            this.lviewTeshisler.TabIndex = 0;
            this.lviewTeshisler.UseCompatibleStateImageBehavior = false;
            this.lviewTeshisler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Koyulan Teşhisler";
            this.columnHeader1.Width = 412;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Green;
            this.groupBox2.Controls.Add(this.cmbTahlil);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(594, 587);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tahliller";
            // 
            // cmbTahlil
            // 
            this.cmbTahlil.FormattingEnabled = true;
            this.cmbTahlil.Location = new System.Drawing.Point(83, 34);
            this.cmbTahlil.Name = "cmbTahlil";
            this.cmbTahlil.Size = new System.Drawing.Size(226, 32);
            this.cmbTahlil.TabIndex = 8;
            this.cmbTahlil.SelectedIndexChanged += new System.EventHandler(this.cmbTahlil_SelectedIndexChanged);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Enabled = false;
            this.txtFiyat.Location = new System.Drawing.Point(83, 110);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(226, 29);
            this.txtFiyat.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(226, 29);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(315, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 111);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tahlil Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 24);
            this.label15.TabIndex = 3;
            this.label15.Text = "Adet:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "Fiyat:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 24);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tahlil:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Green;
            this.groupBox3.Controls.Add(this.cmbTeshis);
            this.groupBox3.Controls.Add(this.txtMuayeneNo);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(594, 750);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tahliller";
            // 
            // cmbTeshis
            // 
            this.cmbTeshis.FormattingEnabled = true;
            this.cmbTeshis.Location = new System.Drawing.Point(136, 65);
            this.cmbTeshis.Name = "cmbTeshis";
            this.cmbTeshis.Size = new System.Drawing.Size(180, 32);
            this.cmbTeshis.TabIndex = 7;
            // 
            // txtMuayeneNo
            // 
            this.txtMuayeneNo.Location = new System.Drawing.Point(136, 30);
            this.txtMuayeneNo.Name = "txtMuayeneNo";
            this.txtMuayeneNo.Size = new System.Drawing.Size(180, 29);
            this.txtMuayeneNo.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Location = new System.Drawing.Point(322, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 88);
            this.button2.TabIndex = 5;
            this.button2.Text = "Teşhis Koy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Muayene No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Teşhis:";
            // 
            // lviewTahlil
            // 
            this.lviewTahlil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdMNo,
            this.chdAd,
            this.chdSoyad});
            this.lviewTahlil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lviewTahlil.Location = new System.Drawing.Point(12, 587);
            this.lviewTahlil.Name = "lviewTahlil";
            this.lviewTahlil.Size = new System.Drawing.Size(467, 276);
            this.lviewTahlil.TabIndex = 3;
            this.lviewTahlil.UseCompatibleStateImageBehavior = false;
            this.lviewTahlil.View = System.Windows.Forms.View.Details;
            this.lviewTahlil.Click += new System.EventHandler(this.lviewTahlil_Click);
            // 
            // chdMNo
            // 
            this.chdMNo.Text = "Muayene No";
            this.chdMNo.Width = 136;
            // 
            // chdAd
            // 
            this.chdAd.Text = "Ad";
            this.chdAd.Width = 146;
            // 
            // chdSoyad
            // 
            this.chdSoyad.Text = "Soyad";
            this.chdSoyad.Width = 181;
            // 
            // lviewHastalar
            // 
            this.lviewHastalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdMuayeneNo,
            this.chdTCNo,
            this.chdAd2,
            this.chdSoyad2,
            this.chdYaş,
            this.chdTarih});
            this.lviewHastalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lviewHastalar.Location = new System.Drawing.Point(12, 12);
            this.lviewHastalar.Name = "lviewHastalar";
            this.lviewHastalar.Size = new System.Drawing.Size(994, 287);
            this.lviewHastalar.TabIndex = 4;
            this.lviewHastalar.UseCompatibleStateImageBehavior = false;
            this.lviewHastalar.View = System.Windows.Forms.View.Details;
            this.lviewHastalar.Click += new System.EventHandler(this.lviewHastalar_Click);
            // 
            // chdMuayeneNo
            // 
            this.chdMuayeneNo.Text = "Muayene No";
            this.chdMuayeneNo.Width = 143;
            // 
            // chdTCNo
            // 
            this.chdTCNo.Text = "TC No";
            this.chdTCNo.Width = 170;
            // 
            // chdAd2
            // 
            this.chdAd2.Text = "Ad";
            this.chdAd2.Width = 158;
            // 
            // chdSoyad2
            // 
            this.chdSoyad2.Text = "Soyad";
            this.chdSoyad2.Width = 153;
            // 
            // chdYaş
            // 
            this.chdYaş.Text = "Yaş";
            this.chdYaş.Width = 109;
            // 
            // chdTarih
            // 
            this.chdTarih.Text = "Tarih";
            this.chdTarih.Width = 256;
            // 
            // btnHastaGelmedi
            // 
            this.btnHastaGelmedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHastaGelmedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaGelmedi.Location = new System.Drawing.Point(483, 312);
            this.btnHastaGelmedi.Name = "btnHastaGelmedi";
            this.btnHastaGelmedi.Size = new System.Drawing.Size(101, 269);
            this.btnHastaGelmedi.TabIndex = 5;
            this.btnHastaGelmedi.Text = "Hasta Gelmedi";
            this.btnHastaGelmedi.UseVisualStyleBackColor = false;
            this.btnHastaGelmedi.Click += new System.EventHandler(this.btnHastaGelmedi_Click);
            // 
            // btnTHastaGelmedi
            // 
            this.btnTHastaGelmedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTHastaGelmedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTHastaGelmedi.Location = new System.Drawing.Point(485, 587);
            this.btnTHastaGelmedi.Name = "btnTHastaGelmedi";
            this.btnTHastaGelmedi.Size = new System.Drawing.Size(101, 276);
            this.btnTHastaGelmedi.TabIndex = 6;
            this.btnTHastaGelmedi.Text = "Hasta Gelmedi";
            this.btnTHastaGelmedi.UseVisualStyleBackColor = false;
            this.btnTHastaGelmedi.Click += new System.EventHandler(this.btnTHastaGelmedi_Click);
            // 
            // FrmMuayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1018, 878);
            this.Controls.Add(this.btnTHastaGelmedi);
            this.Controls.Add(this.btnHastaGelmedi);
            this.Controls.Add(this.lviewHastalar);
            this.Controls.Add(this.lviewTahlil);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lviewTeshisler);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMuayene";
            this.Text = "Hasta Muayene";
            this.Load += new System.EventHandler(this.FrmMuayene_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblYaş;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblMuayeneNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lviewTeshisler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cmbTeshis;
        private System.Windows.Forms.TextBox txtMuayeneNo;
        private System.Windows.Forms.ListView lviewTahlil;
        private System.Windows.Forms.ColumnHeader chdMNo;
        private System.Windows.Forms.ColumnHeader chdAd;
        private System.Windows.Forms.ColumnHeader chdSoyad;
        private System.Windows.Forms.ListView lviewHastalar;
        private System.Windows.Forms.ColumnHeader chdMuayeneNo;
        private System.Windows.Forms.ColumnHeader chdTCNo;
        private System.Windows.Forms.ColumnHeader chdAd2;
        private System.Windows.Forms.ColumnHeader chdSoyad2;
        private System.Windows.Forms.ColumnHeader chdYaş;
        private System.Windows.Forms.ColumnHeader chdTarih;
        private System.Windows.Forms.ComboBox cmbTahlil;
        private System.Windows.Forms.Button btnHastaGelmedi;
        private System.Windows.Forms.Button btnTHastaGelmedi;
    }
}