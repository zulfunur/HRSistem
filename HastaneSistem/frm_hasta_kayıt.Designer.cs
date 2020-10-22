namespace HastaneSistem
{
    partial class frm_hasta_kayıt
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
            this.lblhad = new System.Windows.Forms.Label();
            this.txthad = new System.Windows.Forms.TextBox();
            this.mskdhtel = new System.Windows.Forms.MaskedTextBox();
            this.lblhTC = new System.Windows.Forms.Label();
            this.lblhtel = new System.Windows.Forms.Label();
            this.lblhsoyad = new System.Windows.Forms.Label();
            this.txthsoyad = new System.Windows.Forms.TextBox();
            this.mskdhtc = new System.Windows.Forms.MaskedTextBox();
            this.lblhcinsiyet = new System.Windows.Forms.Label();
            this.lblhdogtarihi = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.mskdhdogtarihi = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblhad
            // 
            this.lblhad.AutoSize = true;
            this.lblhad.Location = new System.Drawing.Point(106, 109);
            this.lblhad.Name = "lblhad";
            this.lblhad.Size = new System.Drawing.Size(24, 15);
            this.lblhad.TabIndex = 0;
            this.lblhad.Text = "Ad:";
            // 
            // txthad
            // 
            this.txthad.Location = new System.Drawing.Point(154, 109);
            this.txthad.Name = "txthad";
            this.txthad.Size = new System.Drawing.Size(100, 21);
            this.txthad.TabIndex = 0;
            // 
            // mskdhtel
            // 
            this.mskdhtel.Location = new System.Drawing.Point(154, 187);
            this.mskdhtel.Mask = "(999) 000-0000";
            this.mskdhtel.Name = "mskdhtel";
            this.mskdhtel.Size = new System.Drawing.Size(100, 21);
            this.mskdhtel.TabIndex = 2;
            // 
            // lblhTC
            // 
            this.lblhTC.AutoSize = true;
            this.lblhTC.Location = new System.Drawing.Point(105, 235);
            this.lblhTC.Name = "lblhTC";
            this.lblhTC.Size = new System.Drawing.Size(25, 15);
            this.lblhTC.TabIndex = 3;
            this.lblhTC.Text = "TC:";
            // 
            // lblhtel
            // 
            this.lblhtel.AutoSize = true;
            this.lblhtel.Location = new System.Drawing.Point(103, 190);
            this.lblhtel.Name = "lblhtel";
            this.lblhtel.Size = new System.Drawing.Size(27, 15);
            this.lblhtel.TabIndex = 4;
            this.lblhtel.Text = "Tel:";
            // 
            // lblhsoyad
            // 
            this.lblhsoyad.AutoSize = true;
            this.lblhsoyad.Location = new System.Drawing.Point(86, 148);
            this.lblhsoyad.Name = "lblhsoyad";
            this.lblhsoyad.Size = new System.Drawing.Size(44, 15);
            this.lblhsoyad.TabIndex = 5;
            this.lblhsoyad.Text = "Soyad:";
            // 
            // txthsoyad
            // 
            this.txthsoyad.Location = new System.Drawing.Point(154, 148);
            this.txthsoyad.Name = "txthsoyad";
            this.txthsoyad.Size = new System.Drawing.Size(100, 21);
            this.txthsoyad.TabIndex = 1;
            // 
            // mskdhtc
            // 
            this.mskdhtc.Location = new System.Drawing.Point(154, 229);
            this.mskdhtc.Mask = "00000000000";
            this.mskdhtc.Name = "mskdhtc";
            this.mskdhtc.Size = new System.Drawing.Size(100, 21);
            this.mskdhtc.TabIndex = 3;
            this.mskdhtc.ValidatingType = typeof(int);
            // 
            // lblhcinsiyet
            // 
            this.lblhcinsiyet.AutoSize = true;
            this.lblhcinsiyet.Location = new System.Drawing.Point(78, 275);
            this.lblhcinsiyet.Name = "lblhcinsiyet";
            this.lblhcinsiyet.Size = new System.Drawing.Size(52, 15);
            this.lblhcinsiyet.TabIndex = 12;
            this.lblhcinsiyet.Text = "Cinsiyet:";
            // 
            // lblhdogtarihi
            // 
            this.lblhdogtarihi.AutoSize = true;
            this.lblhdogtarihi.Location = new System.Drawing.Point(46, 310);
            this.lblhdogtarihi.Name = "lblhdogtarihi";
            this.lblhdogtarihi.Size = new System.Drawing.Size(85, 15);
            this.lblhdogtarihi.TabIndex = 13;
            this.lblhdogtarihi.Text = "Doğum Tarihi:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(148, 275);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kadın";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(211, 275);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 19);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Erkek";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // mskdhdogtarihi
            // 
            this.mskdhdogtarihi.Location = new System.Drawing.Point(154, 304);
            this.mskdhdogtarihi.Mask = "00/00/0000";
            this.mskdhdogtarihi.Name = "mskdhdogtarihi";
            this.mskdhdogtarihi.Size = new System.Drawing.Size(100, 21);
            this.mskdhdogtarihi.TabIndex = 6;
            this.mskdhdogtarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Yeni Hasta Kaydı";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(148, 382);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(100, 23);
            this.btnkaydet.TabIndex = 8;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(27, 346);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(104, 15);
            this.lblsifre.TabIndex = 20;
            this.lblsifre.Text = "Şİfre Oluşturunuz:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(154, 340);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 21);
            this.txtsifre.TabIndex = 7;
            // 
            // frm_hasta_kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(379, 417);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskdhdogtarihi);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblhdogtarihi);
            this.Controls.Add(this.lblhcinsiyet);
            this.Controls.Add(this.mskdhtc);
            this.Controls.Add(this.txthsoyad);
            this.Controls.Add(this.lblhsoyad);
            this.Controls.Add(this.lblhtel);
            this.Controls.Add(this.lblhTC);
            this.Controls.Add(this.mskdhtel);
            this.Controls.Add(this.txthad);
            this.Controls.Add(this.lblhad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frm_hasta_kayıt";
            this.Text = "frm_hasta_kayıt";
            this.Load += new System.EventHandler(this.frm_hasta_kayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhad;
        private System.Windows.Forms.TextBox txthad;
        private System.Windows.Forms.MaskedTextBox mskdhtel;
        private System.Windows.Forms.Label lblhTC;
        private System.Windows.Forms.Label lblhtel;
        private System.Windows.Forms.Label lblhsoyad;
        private System.Windows.Forms.TextBox txthsoyad;
        private System.Windows.Forms.MaskedTextBox mskdhtc;
        private System.Windows.Forms.Label lblhcinsiyet;
        private System.Windows.Forms.Label lblhdogtarihi;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.MaskedTextBox mskdhdogtarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtsifre;
    }
}