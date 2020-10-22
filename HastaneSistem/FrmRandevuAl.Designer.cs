namespace HastaneSistem
{
    partial class FrmRandevuAl
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.cmbilce = new System.Windows.Forms.ComboBox();
            this.cmbhastane = new System.Windows.Forms.ComboBox();
            this.cmbklinik = new System.Windows.Forms.ComboBox();
            this.cmbhekim = new System.Windows.Forms.ComboBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnRandevuAra = new System.Windows.Forms.Button();
            this.dTPtarih = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastane Randevu Arama";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(36, 66);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(34, 13);
            this.lbltarih.TabIndex = 1;
            this.lbltarih.Text = "Tarih:";
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(28, 106);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(259, 21);
            this.cmbil.TabIndex = 4;
            this.cmbil.Text = "İl Seçiniz*";
            // 
            // cmbilce
            // 
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(28, 146);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(259, 21);
            this.cmbilce.TabIndex = 6;
            this.cmbilce.Text = "İlçe Seçiniz*";
            // 
            // cmbhastane
            // 
            this.cmbhastane.FormattingEnabled = true;
            this.cmbhastane.Location = new System.Drawing.Point(28, 194);
            this.cmbhastane.Name = "cmbhastane";
            this.cmbhastane.Size = new System.Drawing.Size(259, 21);
            this.cmbhastane.TabIndex = 8;
            this.cmbhastane.Text = "Hastane*";
            // 
            // cmbklinik
            // 
            this.cmbklinik.FormattingEnabled = true;
            this.cmbklinik.Location = new System.Drawing.Point(28, 241);
            this.cmbklinik.Name = "cmbklinik";
            this.cmbklinik.Size = new System.Drawing.Size(259, 21);
            this.cmbklinik.TabIndex = 9;
            this.cmbklinik.Text = "Klinik*";
            // 
            // cmbhekim
            // 
            this.cmbhekim.FormattingEnabled = true;
            this.cmbhekim.Location = new System.Drawing.Point(28, 290);
            this.cmbhekim.Name = "cmbhekim";
            this.cmbhekim.Size = new System.Drawing.Size(259, 21);
            this.cmbhekim.TabIndex = 10;
            this.cmbhekim.Text = "Hekim*";
            this.cmbhekim.SelectedIndexChanged += new System.EventHandler(this.cmbhekim_SelectedIndexChanged);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btntemizle.Location = new System.Drawing.Point(28, 337);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(103, 23);
            this.btntemizle.TabIndex = 11;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnRandevuAra
            // 
            this.btnRandevuAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRandevuAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAra.Location = new System.Drawing.Point(173, 337);
            this.btnRandevuAra.Name = "btnRandevuAra";
            this.btnRandevuAra.Size = new System.Drawing.Size(114, 23);
            this.btnRandevuAra.TabIndex = 12;
            this.btnRandevuAra.Text = "Randevu Ara";
            this.btnRandevuAra.UseVisualStyleBackColor = false;
            this.btnRandevuAra.Click += new System.EventHandler(this.btnRandevuAra_Click);
            // 
            // dTPtarih
            // 
            this.dTPtarih.Location = new System.Drawing.Point(76, 66);
            this.dTPtarih.Name = "dTPtarih";
            this.dTPtarih.Size = new System.Drawing.Size(200, 20);
            this.dTPtarih.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btn10);
            this.groupBox1.Controls.Add(this.btn11);
            this.groupBox1.Controls.Add(this.btn13);
            this.groupBox1.Controls.Add(this.btn15);
            this.groupBox1.Controls.Add(this.btn16);
            this.groupBox1.Controls.Add(this.btn14);
            this.groupBox1.Controls.Add(this.btn12);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(352, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 294);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn10.Location = new System.Drawing.Point(170, 64);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(96, 37);
            this.btn10.TabIndex = 16;
            this.btn10.Text = "10:00";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn11.Location = new System.Drawing.Point(28, 118);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(96, 37);
            this.btn11.TabIndex = 15;
            this.btn11.Text = "11:00";
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn13.Location = new System.Drawing.Point(28, 175);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(96, 37);
            this.btn13.TabIndex = 14;
            this.btn13.Text = "13:00";
            this.btn13.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn15.Location = new System.Drawing.Point(28, 233);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(96, 37);
            this.btn15.TabIndex = 13;
            this.btn15.Text = "15:00";
            this.btn15.UseVisualStyleBackColor = true;
            // 
            // btn16
            // 
            this.btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn16.Location = new System.Drawing.Point(170, 233);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(96, 37);
            this.btn16.TabIndex = 12;
            this.btn16.Text = "16:00";
            this.btn16.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            this.btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn14.Location = new System.Drawing.Point(170, 175);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(96, 37);
            this.btn14.TabIndex = 11;
            this.btn14.Text = "14:00";
            this.btn14.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn12.Location = new System.Drawing.Point(170, 118);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(96, 37);
            this.btn12.TabIndex = 10;
            this.btn12.Text = "12:00";
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(28, 64);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(96, 37);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "09:00";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saat Dilimini Seçiniz:";
            // 
            // FrmRandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(892, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dTPtarih);
            this.Controls.Add(this.btnRandevuAra);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.cmbhekim);
            this.Controls.Add(this.cmbklinik);
            this.Controls.Add(this.cmbhastane);
            this.Controls.Add(this.cmbilce);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.label1);
            this.Name = "FrmRandevuAl";
            this.Text = "FrmRandevuAl";
            this.Load += new System.EventHandler(this.FrmRandevuAl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.ComboBox cmbil;
        private System.Windows.Forms.ComboBox cmbilce;
        private System.Windows.Forms.ComboBox cmbhastane;
        private System.Windows.Forms.ComboBox cmbklinik;
        private System.Windows.Forms.ComboBox cmbhekim;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnRandevuAra;
        private System.Windows.Forms.DateTimePicker dTPtarih;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn12;
    }
}