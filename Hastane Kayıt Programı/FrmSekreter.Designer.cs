namespace WindowsFormsApplication1
{
    partial class FrmSekreter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreter));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTCNO = new System.Windows.Forms.TextBox();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.btnSira = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poliklinik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doktor:";
            // 
            // txtTCNO
            // 
            this.txtTCNO.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNO.Location = new System.Drawing.Point(145, 20);
            this.txtTCNO.Name = "txtTCNO";
            this.txtTCNO.Size = new System.Drawing.Size(250, 36);
            this.txtTCNO.TabIndex = 3;
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(145, 62);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(250, 36);
            this.cmbPoliklinik.TabIndex = 4;
            this.cmbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cmbPoliklinik_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(145, 106);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(250, 36);
            this.cmbDoktor.TabIndex = 5;
            // 
            // btnSira
            // 
            this.btnSira.BackColor = System.Drawing.Color.Green;
            this.btnSira.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSira.Location = new System.Drawing.Point(157, 159);
            this.btnSira.Name = "btnSira";
            this.btnSira.Size = new System.Drawing.Size(226, 51);
            this.btnSira.TabIndex = 6;
            this.btnSira.Text = "Sıra Al";
            this.btnSira.UseVisualStyleBackColor = false;
            this.btnSira.Click += new System.EventHandler(this.btnSira_Click);
            // 
            // FrmSekreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(410, 233);
            this.Controls.Add(this.btnSira);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.cmbPoliklinik);
            this.Controls.Add(this.txtTCNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSekreter";
            this.Text = "Sekreter Sıra Alım";
            this.Load += new System.EventHandler(this.FrmSekreter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTCNO;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Button btnSira;
    }
}