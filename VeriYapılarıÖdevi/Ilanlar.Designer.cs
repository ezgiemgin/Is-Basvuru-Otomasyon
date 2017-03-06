namespace VeriYapılarıÖdevi
{
    partial class Ilanlar
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
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_ilanver = new System.Windows.Forms.Button();
            this.btn_iseAl = new System.Windows.Forms.Button();
            this.dgv_adayListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adayListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(38, 29);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(95, 48);
            this.btn_Listele.TabIndex = 0;
            this.btn_Listele.Text = "İlanları Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_ilanver
            // 
            this.btn_ilanver.Location = new System.Drawing.Point(291, 29);
            this.btn_ilanver.Name = "btn_ilanver";
            this.btn_ilanver.Size = new System.Drawing.Size(75, 47);
            this.btn_ilanver.TabIndex = 1;
            this.btn_ilanver.Text = "İlan Ver";
            this.btn_ilanver.UseVisualStyleBackColor = true;
            this.btn_ilanver.Click += new System.EventHandler(this.btn_ilanver_Click);
            // 
            // btn_iseAl
            // 
            this.btn_iseAl.Location = new System.Drawing.Point(216, 29);
            this.btn_iseAl.Name = "btn_iseAl";
            this.btn_iseAl.Size = new System.Drawing.Size(69, 47);
            this.btn_iseAl.TabIndex = 0;
            this.btn_iseAl.Text = "Uygun Kişiyi İşe Al ";
            this.btn_iseAl.UseVisualStyleBackColor = true;
            this.btn_iseAl.Click += new System.EventHandler(this.btn_iseAl_Click);
            // 
            // dgv_adayListesi
            // 
            this.dgv_adayListesi.AllowUserToAddRows = false;
            this.dgv_adayListesi.AllowUserToDeleteRows = false;
            this.dgv_adayListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_adayListesi.Location = new System.Drawing.Point(38, 83);
            this.dgv_adayListesi.Name = "dgv_adayListesi";
            this.dgv_adayListesi.Size = new System.Drawing.Size(328, 150);
            this.dgv_adayListesi.TabIndex = 2;
            this.dgv_adayListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_adayListesi_CellContentClick);
            // 
            // Ilanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 255);
            this.Controls.Add(this.dgv_adayListesi);
            this.Controls.Add(this.btn_ilanver);
            this.Controls.Add(this.btn_iseAl);
            this.Controls.Add(this.btn_Listele);
            this.Name = "Ilanlar";
            this.Text = "Ilanlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ilanlar_FormClosed_1);
            this.Load += new System.EventHandler(this.Ilanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adayListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_ilanver;
        private System.Windows.Forms.Button btn_iseAl;
        private System.Windows.Forms.DataGridView dgv_adayListesi;
    }
}