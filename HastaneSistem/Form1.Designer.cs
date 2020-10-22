namespace HastaneSistem
{
    partial class Form1
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
            this.txttcgiriniz = new System.Windows.Forms.TextBox();
            this.lblkllncad = new System.Windows.Forms.Label();
            this.BTNGİRİS = new System.Windows.Forms.Button();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtsifregiriniz = new System.Windows.Forms.TextBox();
            this.btnhkayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttcgiriniz
            // 
            this.txttcgiriniz.Location = new System.Drawing.Point(106, 68);
            this.txttcgiriniz.Name = "txttcgiriniz";
            this.txttcgiriniz.Size = new System.Drawing.Size(147, 20);
            this.txttcgiriniz.TabIndex = 0;
            this.txttcgiriniz.Text = "Tc Kimlik Numaranızı Giriniz";
            // 
            // lblkllncad
            // 
            this.lblkllncad.AutoSize = true;
            this.lblkllncad.Location = new System.Drawing.Point(35, 71);
            this.lblkllncad.Name = "lblkllncad";
            this.lblkllncad.Size = new System.Drawing.Size(65, 13);
            this.lblkllncad.TabIndex = 1;
            this.lblkllncad.Text = "Kullanıcı Ad:";
            // 
            // BTNGİRİS
            // 
            this.BTNGİRİS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNGİRİS.Location = new System.Drawing.Point(117, 162);
            this.BTNGİRİS.Name = "BTNGİRİS";
            this.BTNGİRİS.Size = new System.Drawing.Size(119, 32);
            this.BTNGİRİS.TabIndex = 2;
            this.BTNGİRİS.Text = "GİRİŞ";
            this.BTNGİRİS.UseVisualStyleBackColor = false;
            this.BTNGİRİS.Click += new System.EventHandler(this.BTNGİRİS_Click);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(69, 117);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(31, 13);
            this.lblsifre.TabIndex = 3;
            this.lblsifre.Text = "Şifre:";
            this.lblsifre.Click += new System.EventHandler(this.lblsifre_Click);
            // 
            // txtsifregiriniz
            // 
            this.txtsifregiriniz.Location = new System.Drawing.Point(117, 114);
            this.txtsifregiriniz.Name = "txtsifregiriniz";
            this.txtsifregiriniz.Size = new System.Drawing.Size(119, 20);
            this.txtsifregiriniz.TabIndex = 1;
            this.txtsifregiriniz.UseSystemPasswordChar = true;
            // 
            // btnhkayıtol
            // 
            this.btnhkayıtol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnhkayıtol.Location = new System.Drawing.Point(117, 200);
            this.btnhkayıtol.Name = "btnhkayıtol";
            this.btnhkayıtol.Size = new System.Drawing.Size(119, 32);
            this.btnhkayıtol.TabIndex = 3;
            this.btnhkayıtol.Text = "Kayıt Ol";
            this.btnhkayıtol.UseVisualStyleBackColor = false;
            this.btnhkayıtol.Click += new System.EventHandler(this.btnhkayıtol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(310, 261);
            this.Controls.Add(this.btnhkayıtol);
            this.Controls.Add(this.txtsifregiriniz);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.BTNGİRİS);
            this.Controls.Add(this.lblkllncad);
            this.Controls.Add(this.txttcgiriniz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttcgiriniz;
        private System.Windows.Forms.Label lblkllncad;
        private System.Windows.Forms.Button BTNGİRİS;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtsifregiriniz;
        private System.Windows.Forms.Button btnhkayıtol;
    }
}

