namespace Poligoni
{
    partial class frmLogin
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnKyqu = new System.Windows.Forms.Button();
            this.btnAnulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(65, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(191, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(65, 115);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(191, 20);
            this.txtPass.TabIndex = 0;
            // 
            // btnKyqu
            // 
            this.btnKyqu.Location = new System.Drawing.Point(65, 159);
            this.btnKyqu.Name = "btnKyqu";
            this.btnKyqu.Size = new System.Drawing.Size(75, 23);
            this.btnKyqu.TabIndex = 1;
            this.btnKyqu.Text = "Kyqu";
            this.btnKyqu.UseVisualStyleBackColor = true;
            // 
            // btnAnulo
            // 
            this.btnAnulo.Location = new System.Drawing.Point(169, 159);
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.Size = new System.Drawing.Size(75, 23);
            this.btnAnulo.TabIndex = 1;
            this.btnAnulo.Text = "Anulo";
            this.btnAnulo.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 331);
            this.Controls.Add(this.btnAnulo);
            this.Controls.Add(this.btnKyqu);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnKyqu;
        private System.Windows.Forms.Button btnAnulo;
    }
}