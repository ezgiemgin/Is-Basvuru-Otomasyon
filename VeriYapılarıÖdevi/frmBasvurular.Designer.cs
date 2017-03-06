namespace VeriYapılarıÖdevi
{
    partial class frmBasvurular
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
            this.dgv_adayListesi = new System.Windows.Forms.DataGridView();
            this.btn_iseAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adayListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_adayListesi
            // 
            this.dgv_adayListesi.AllowUserToAddRows = false;
            this.dgv_adayListesi.AllowUserToDeleteRows = false;
            this.dgv_adayListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_adayListesi.Location = new System.Drawing.Point(12, 65);
            this.dgv_adayListesi.Name = "dgv_adayListesi";
            this.dgv_adayListesi.Size = new System.Drawing.Size(373, 205);
            this.dgv_adayListesi.TabIndex = 6;
            this.dgv_adayListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_adayListesi_CellContentClick);
            // 
            // btn_iseAl
            // 
            this.btn_iseAl.Location = new System.Drawing.Point(316, 12);
            this.btn_iseAl.Name = "btn_iseAl";
            this.btn_iseAl.Size = new System.Drawing.Size(69, 47);
            this.btn_iseAl.TabIndex = 3;
            this.btn_iseAl.Text = "İşe Al";
            this.btn_iseAl.UseVisualStyleBackColor = true;
            this.btn_iseAl.Click += new System.EventHandler(this.btn_iseAl_Click);
            // 
            // frmBasvurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 282);
            this.Controls.Add(this.dgv_adayListesi);
            this.Controls.Add(this.btn_iseAl);
            this.Name = "frmBasvurular";
            this.Text = "frmBasvurular";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBasvurular_FormClosed);
            this.Load += new System.EventHandler(this.frmBasvurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adayListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_adayListesi;
        private System.Windows.Forms.Button btn_iseAl;

    }
}