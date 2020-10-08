namespace FlashCards
{
    partial class Vista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConnecta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConnecta
            // 
            this.btConnecta.Location = new System.Drawing.Point(300, 293);
            this.btConnecta.Name = "btConnecta";
            this.btConnecta.Size = new System.Drawing.Size(230, 63);
            this.btConnecta.TabIndex = 0;
            this.btConnecta.Text = "Connecta";
            this.btConnecta.UseVisualStyleBackColor = true;
            this.btConnecta.Click += new System.EventHandler(this.btConnecta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Location = new System.Drawing.Point(60, 411);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(24, 13);
            this.labelinfo.TabIndex = 2;
            this.labelinfo.Text = "info";
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConnecta);
            this.Name = "Vista";
            this.Text = "FlashCats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnecta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelinfo;
    }
}

