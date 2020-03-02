namespace WindowsFormsApplication1
{
    partial class FrmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAna));
            this.btnSekreter = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSekreter
            // 
            this.btnSekreter.BackColor = System.Drawing.Color.Teal;
            this.btnSekreter.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreter.ForeColor = System.Drawing.Color.White;
            this.btnSekreter.Location = new System.Drawing.Point(12, 13);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.Size = new System.Drawing.Size(218, 66);
            this.btnSekreter.TabIndex = 0;
            this.btnSekreter.Text = "Sekreter Girişi";
            this.btnSekreter.UseVisualStyleBackColor = false;
            this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.BackColor = System.Drawing.Color.Teal;
            this.btnDoktor.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktor.ForeColor = System.Drawing.Color.White;
            this.btnDoktor.Location = new System.Drawing.Point(236, 12);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(218, 66);
            this.btnDoktor.TabIndex = 1;
            this.btnDoktor.Text = "Doktor Girişi";
            this.btnDoktor.UseVisualStyleBackColor = false;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.adsadas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 345);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnSekreter);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAna";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSekreter;
        private System.Windows.Forms.Button btnDoktor;
    }
}

