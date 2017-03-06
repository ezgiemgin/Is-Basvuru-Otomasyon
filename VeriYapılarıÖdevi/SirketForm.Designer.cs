namespace VeriYapılarıÖdevi
{
    partial class SirketForm
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
            this.txt_sirketAdi = new System.Windows.Forms.TextBox();
            this.txt_sirketTel = new System.Windows.Forms.TextBox();
            this.txt_sirketFaks = new System.Windows.Forms.TextBox();
            this.txt_sirketMail = new System.Windows.Forms.TextBox();
            this.txt_sirketAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sirketKaydet = new System.Windows.Forms.Button();
            this.btn_sirketIlan = new System.Windows.Forms.Button();
            this.btn_sirketGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sirketAdi
            // 
            this.txt_sirketAdi.Location = new System.Drawing.Point(116, 26);
            this.txt_sirketAdi.Name = "txt_sirketAdi";
            this.txt_sirketAdi.Size = new System.Drawing.Size(191, 20);
            this.txt_sirketAdi.TabIndex = 0;
            // 
            // txt_sirketTel
            // 
            this.txt_sirketTel.Location = new System.Drawing.Point(116, 52);
            this.txt_sirketTel.Name = "txt_sirketTel";
            this.txt_sirketTel.Size = new System.Drawing.Size(191, 20);
            this.txt_sirketTel.TabIndex = 1;
            // 
            // txt_sirketFaks
            // 
            this.txt_sirketFaks.Location = new System.Drawing.Point(116, 78);
            this.txt_sirketFaks.Name = "txt_sirketFaks";
            this.txt_sirketFaks.Size = new System.Drawing.Size(191, 20);
            this.txt_sirketFaks.TabIndex = 2;
            // 
            // txt_sirketMail
            // 
            this.txt_sirketMail.Location = new System.Drawing.Point(116, 104);
            this.txt_sirketMail.Name = "txt_sirketMail";
            this.txt_sirketMail.Size = new System.Drawing.Size(191, 20);
            this.txt_sirketMail.TabIndex = 3;
            // 
            // txt_sirketAdres
            // 
            this.txt_sirketAdres.Location = new System.Drawing.Point(116, 130);
            this.txt_sirketAdres.Multiline = true;
            this.txt_sirketAdres.Name = "txt_sirketAdres";
            this.txt_sirketAdres.Size = new System.Drawing.Size(191, 58);
            this.txt_sirketAdres.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şirket Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Faks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "E-Posta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adres";
            // 
            // btn_sirketKaydet
            // 
            this.btn_sirketKaydet.Location = new System.Drawing.Point(33, 201);
            this.btn_sirketKaydet.Name = "btn_sirketKaydet";
            this.btn_sirketKaydet.Size = new System.Drawing.Size(95, 23);
            this.btn_sirketKaydet.TabIndex = 5;
            this.btn_sirketKaydet.Text = "Şirketi Kaydet";
            this.btn_sirketKaydet.UseVisualStyleBackColor = true;
            this.btn_sirketKaydet.Click += new System.EventHandler(this.btn_sirketKaydet_Click);
            // 
            // btn_sirketIlan
            // 
            this.btn_sirketIlan.Location = new System.Drawing.Point(235, 201);
            this.btn_sirketIlan.Name = "btn_sirketIlan";
            this.btn_sirketIlan.Size = new System.Drawing.Size(75, 23);
            this.btn_sirketIlan.TabIndex = 7;
            this.btn_sirketIlan.Text = "İlanlar";
            this.btn_sirketIlan.UseVisualStyleBackColor = true;
            this.btn_sirketIlan.Click += new System.EventHandler(this.btn_sirketIlan_Click);
            // 
            // btn_sirketGuncelle
            // 
            this.btn_sirketGuncelle.Enabled = false;
            this.btn_sirketGuncelle.Location = new System.Drawing.Point(134, 201);
            this.btn_sirketGuncelle.Name = "btn_sirketGuncelle";
            this.btn_sirketGuncelle.Size = new System.Drawing.Size(95, 23);
            this.btn_sirketGuncelle.TabIndex = 6;
            this.btn_sirketGuncelle.Text = "Bilgileri Güncelle";
            this.btn_sirketGuncelle.UseVisualStyleBackColor = true;
            this.btn_sirketGuncelle.Click += new System.EventHandler(this.btn_sirketGuncelle_Click);
            // 
            // SirketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 236);
            this.Controls.Add(this.btn_sirketIlan);
            this.Controls.Add(this.btn_sirketGuncelle);
            this.Controls.Add(this.btn_sirketKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sirketAdres);
            this.Controls.Add(this.txt_sirketMail);
            this.Controls.Add(this.txt_sirketFaks);
            this.Controls.Add(this.txt_sirketTel);
            this.Controls.Add(this.txt_sirketAdi);
            this.Name = "SirketForm";
            this.Text = "Şirket Bilgileri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SirketForm_FormClosed);
            this.Load += new System.EventHandler(this.SirketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sirketAdi;
        private System.Windows.Forms.TextBox txt_sirketTel;
        private System.Windows.Forms.TextBox txt_sirketFaks;
        private System.Windows.Forms.TextBox txt_sirketMail;
        private System.Windows.Forms.TextBox txt_sirketAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sirketKaydet;
        private System.Windows.Forms.Button btn_sirketIlan;
        private System.Windows.Forms.Button btn_sirketGuncelle;
    }
}