namespace KolekcijeVozilo
{
    partial class formVozilo
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodProizvodnje = new System.Windows.Forms.TextBox();
            this.txtBrojKotaca = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblGodProizvodnje = new System.Windows.Forms.Label();
            this.lblBrojKotaca = new System.Windows.Forms.Label();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(13, 31);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(142, 20);
            this.txtModel.TabIndex = 0;
            // 
            // txtGodProizvodnje
            // 
            this.txtGodProizvodnje.Location = new System.Drawing.Point(13, 73);
            this.txtGodProizvodnje.Name = "txtGodProizvodnje";
            this.txtGodProizvodnje.Size = new System.Drawing.Size(142, 20);
            this.txtGodProizvodnje.TabIndex = 1;
            // 
            // txtBrojKotaca
            // 
            this.txtBrojKotaca.Location = new System.Drawing.Point(13, 114);
            this.txtBrojKotaca.Name = "txtBrojKotaca";
            this.txtBrojKotaca.Size = new System.Drawing.Size(142, 20);
            this.txtBrojKotaca.TabIndex = 2;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(183, 51);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 62);
            this.btnUnesi.TabIndex = 3;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(305, 51);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(75, 62);
            this.btnObradi.TabIndex = 4;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(423, 51);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 62);
            this.btnIspisi.TabIndex = 5;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(13, 15);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            // 
            // lblGodProizvodnje
            // 
            this.lblGodProizvodnje.AutoSize = true;
            this.lblGodProizvodnje.Location = new System.Drawing.Point(13, 58);
            this.lblGodProizvodnje.Name = "lblGodProizvodnje";
            this.lblGodProizvodnje.Size = new System.Drawing.Size(101, 13);
            this.lblGodProizvodnje.TabIndex = 8;
            this.lblGodProizvodnje.Text = "Godina proizvodnje:";
            // 
            // lblBrojKotaca
            // 
            this.lblBrojKotaca.AutoSize = true;
            this.lblBrojKotaca.Location = new System.Drawing.Point(13, 100);
            this.lblBrojKotaca.Name = "lblBrojKotaca";
            this.lblBrojKotaca.Size = new System.Drawing.Size(64, 13);
            this.lblBrojKotaca.TabIndex = 9;
            this.lblBrojKotaca.Text = "Broj kotača:";
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(13, 161);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(485, 277);
            this.txtIspis.TabIndex = 10;
            // 
            // formVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.lblBrojKotaca);
            this.Controls.Add(this.lblGodProizvodnje);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtBrojKotaca);
            this.Controls.Add(this.txtGodProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Name = "formVozilo";
            this.Text = "Vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodProizvodnje;
        private System.Windows.Forms.TextBox txtBrojKotaca;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblGodProizvodnje;
        private System.Windows.Forms.Label lblBrojKotaca;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

