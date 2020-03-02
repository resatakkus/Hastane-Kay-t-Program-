namespace WindowsFormsApplication1
{
    partial class FrmHasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHasta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtDTarihi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbEvet = new System.Windows.Forms.CheckBox();
            this.ckbHayır = new System.Windows.Forms.CheckBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCKurum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çalıştığı Kurum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtDTarihi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 233);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(144, 174);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(222, 36);
            this.cmbCinsiyet.TabIndex = 12;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(144, 129);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(222, 36);
            this.txtTelefon.TabIndex = 11;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(144, 87);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(222, 36);
            this.txtAdres.TabIndex = 10;
            // 
            // txtDTarihi
            // 
            this.txtDTarihi.Location = new System.Drawing.Point(144, 45);
            this.txtDTarihi.Name = "txtDTarihi";
            this.txtDTarihi.Size = new System.Drawing.Size(222, 36);
            this.txtDTarihi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres:";
            // 
            // ckbEvet
            // 
            this.ckbEvet.AutoSize = true;
            this.ckbEvet.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ckbEvet.Location = new System.Drawing.Point(150, 171);
            this.ckbEvet.Name = "ckbEvet";
            this.ckbEvet.Size = new System.Drawing.Size(67, 32);
            this.ckbEvet.TabIndex = 5;
            this.ckbEvet.Text = "Evet";
            this.ckbEvet.UseVisualStyleBackColor = true;
            // 
            // ckbHayır
            // 
            this.ckbHayır.AutoSize = true;
            this.ckbHayır.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ckbHayır.Location = new System.Drawing.Point(280, 171);
            this.ckbHayır.Name = "ckbHayır";
            this.ckbHayır.Size = new System.Drawing.Size(75, 32);
            this.ckbHayır.TabIndex = 6;
            this.ckbHayır.Text = "Hayır";
            this.ckbHayır.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(93, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(306, 36);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(93, 70);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(306, 36);
            this.txtSoyad.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(57, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "SGK:";
            // 
            // txtCKurum
            // 
            this.txtCKurum.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCKurum.Location = new System.Drawing.Point(171, 112);
            this.txtCKurum.Name = "txtCKurum";
            this.txtCKurum.Size = new System.Drawing.Size(228, 36);
            this.txtCKurum.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(18, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(414, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCKurum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.ckbHayır);
            this.Controls.Add(this.ckbEvet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHasta";
            this.Text = "Hasta Bilgileri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtDTarihi;
        private System.Windows.Forms.CheckBox ckbEvet;
        private System.Windows.Forms.CheckBox ckbHayır;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCKurum;
        private System.Windows.Forms.Button button1;
    }
}