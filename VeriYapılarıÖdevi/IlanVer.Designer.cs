namespace VeriYapılarıÖdevi
{
    partial class IlanVer
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
            this.txt_isTanimi = new System.Windows.Forms.TextBox();
            this.txt_arananOzellik = new System.Windows.Forms.TextBox();
            this.lbl_isTanimi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_isTanimi
            // 
            this.txt_isTanimi.Location = new System.Drawing.Point(111, 44);
            this.txt_isTanimi.Multiline = true;
            this.txt_isTanimi.Name = "txt_isTanimi";
            this.txt_isTanimi.Size = new System.Drawing.Size(100, 56);
            this.txt_isTanimi.TabIndex = 0;
            // 
            // txt_arananOzellik
            // 
            this.txt_arananOzellik.Location = new System.Drawing.Point(111, 115);
            this.txt_arananOzellik.Multiline = true;
            this.txt_arananOzellik.Name = "txt_arananOzellik";
            this.txt_arananOzellik.Size = new System.Drawing.Size(100, 54);
            this.txt_arananOzellik.TabIndex = 1;
            // 
            // lbl_isTanimi
            // 
            this.lbl_isTanimi.AutoSize = true;
            this.lbl_isTanimi.Location = new System.Drawing.Point(12, 45);
            this.lbl_isTanimi.Name = "lbl_isTanimi";
            this.lbl_isTanimi.Size = new System.Drawing.Size(49, 13);
            this.lbl_isTanimi.TabIndex = 2;
            this.lbl_isTanimi.Text = "İş Tanımı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranan Özellikler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "İlanı Yayınla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IlanVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_isTanimi);
            this.Controls.Add(this.txt_arananOzellik);
            this.Controls.Add(this.txt_isTanimi);
            this.Name = "IlanVer";
            this.Text = "İlan Ver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IlanVer_FormClosed);
            this.Load += new System.EventHandler(this.IlanVer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_isTanimi;
        private System.Windows.Forms.TextBox txt_arananOzellik;
        private System.Windows.Forms.Label lbl_isTanimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}