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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista));
            this.btConnecta = new System.Windows.Forms.Button();
            this.labeluser = new System.Windows.Forms.Label();
            this.labelinfo = new System.Windows.Forms.Label();
            this.labelpass = new System.Windows.Forms.Label();
            this.textboxUser = new System.Windows.Forms.TextBox();
            this.textboxPass = new System.Windows.Forms.TextBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConnecta
            // 
            this.btConnecta.Location = new System.Drawing.Point(64, 132);
            this.btConnecta.Name = "btConnecta";
            this.btConnecta.Size = new System.Drawing.Size(169, 25);
            this.btConnecta.TabIndex = 0;
            this.btConnecta.Text = "Connecta";
            this.btConnecta.UseVisualStyleBackColor = true;
            this.btConnecta.Click += new System.EventHandler(this.btConnecta_Click);
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Location = new System.Drawing.Point(60, 58);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(27, 13);
            this.labeluser.TabIndex = 1;
            this.labeluser.Text = "user";
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
            // labelpass
            // 
            this.labelpass.AutoSize = true;
            this.labelpass.Location = new System.Drawing.Point(61, 98);
            this.labelpass.Name = "labelpass";
            this.labelpass.Size = new System.Drawing.Size(29, 13);
            this.labelpass.TabIndex = 3;
            this.labelpass.Text = "pass";
            // 
            // textboxUser
            // 
            this.textboxUser.Location = new System.Drawing.Point(119, 55);
            this.textboxUser.Name = "textboxUser";
            this.textboxUser.Size = new System.Drawing.Size(113, 20);
            this.textboxUser.TabIndex = 4;
            // 
            // textboxPass
            // 
            this.textboxPass.Location = new System.Drawing.Point(119, 95);
            this.textboxPass.Name = "textboxPass";
            this.textboxPass.PasswordChar = '*';
            this.textboxPass.Size = new System.Drawing.Size(113, 20);
            this.textboxPass.TabIndex = 5;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(697, 53);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonAdmin.TabIndex = 6;
            this.buttonAdmin.Text = "Admin Mode";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Visible = false;
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.textboxPass);
            this.Controls.Add(this.textboxUser);
            this.Controls.Add(this.labelpass);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.btConnecta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista";
            this.Text = "FlashCats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnecta;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Label labelpass;
        private System.Windows.Forms.TextBox textboxUser;
        private System.Windows.Forms.TextBox textboxPass;
        private System.Windows.Forms.Button buttonAdmin;
    }
}

