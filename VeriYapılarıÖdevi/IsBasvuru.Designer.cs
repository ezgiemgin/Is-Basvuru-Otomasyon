namespace VeriYapılarıÖdevi
{
    partial class IsBasvuru
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
            this.dgv_IlanListesi = new System.Windows.Forms.DataGridView();
            this.btn_Listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IlanListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_IlanListesi
            // 
            this.dgv_IlanListesi.AllowUserToAddRows = false;
            this.dgv_IlanListesi.AllowUserToDeleteRows = false;
            this.dgv_IlanListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IlanListesi.Location = new System.Drawing.Point(22, 60);
            this.dgv_IlanListesi.Name = "dgv_IlanListesi";
            this.dgv_IlanListesi.Size = new System.Drawing.Size(240, 150);
            this.dgv_IlanListesi.TabIndex = 0;
            this.dgv_IlanListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_IlanListesi_CellContentClick);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(33, 12);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(75, 23);
            this.btn_Listele.TabIndex = 1;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // IsBasvuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.dgv_IlanListesi);
            this.Name = "IsBasvuru";
            this.Text = "IsBasvuru";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IsBasvuru_FormClosed);
            this.Load += new System.EventHandler(this.IsBasvuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IlanListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_IlanListesi;
        private System.Windows.Forms.Button btn_Listele;
    }
}