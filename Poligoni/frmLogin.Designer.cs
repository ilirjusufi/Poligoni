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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.jGradientPanel1 = new JGradient_Panel.JGradientPanel();
            this.txtuser1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtpass2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.DropGjuha = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnanuloo = new System.Windows.Forms.Button();
            this.btnkyquu = new System.Windows.Forms.Button();
            this.jGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // jGradientPanel1
            // 
            this.jGradientPanel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.jGradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(71)))));
            this.jGradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.jGradientPanel1.Controls.Add(this.txtuser1);
            this.jGradientPanel1.Controls.Add(this.txtpass2);
            this.jGradientPanel1.Controls.Add(this.DropGjuha);
            this.jGradientPanel1.Controls.Add(this.gunaControlBox1);
            this.jGradientPanel1.Controls.Add(this.pictureBox7);
            this.jGradientPanel1.Controls.Add(this.pictureBox4);
            this.jGradientPanel1.Controls.Add(this.pictureBox5);
            this.jGradientPanel1.Controls.Add(this.pictureBox6);
            this.jGradientPanel1.Controls.Add(this.btnanuloo);
            this.jGradientPanel1.Controls.Add(this.btnkyquu);
            resources.ApplyResources(this.jGradientPanel1, "jGradientPanel1");
            this.jGradientPanel1.Name = "jGradientPanel1";
            this.jGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.jGradientPanel1_Paint);
            // 
            // txtuser1
            // 
            this.txtuser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.txtuser1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser1.FocusedLineColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.txtuser1, "txtuser1");
            this.txtuser1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtuser1.LineColor = System.Drawing.Color.Gainsboro;
            this.txtuser1.Name = "txtuser1";
            this.txtuser1.PasswordChar = '\0';
            this.txtuser1.SelectedText = "";
            // 
            // txtpass2
            // 
            this.txtpass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.txtpass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass2.FocusedLineColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.txtpass2, "txtpass2");
            this.txtpass2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtpass2.LineColor = System.Drawing.Color.Gainsboro;
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.PasswordChar = '*';
            this.txtpass2.SelectedText = "";
            // 
            // DropGjuha
            // 
            this.DropGjuha.Animated = true;
            this.DropGjuha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.DropGjuha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.DropGjuha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropGjuha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropGjuha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DropGjuha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DropGjuha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DropGjuha.FocusedState.Parent = this.DropGjuha;
            resources.ApplyResources(this.DropGjuha, "DropGjuha");
            this.DropGjuha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DropGjuha.HoverState.Parent = this.DropGjuha;
            this.DropGjuha.Items.AddRange(new object[] {
            resources.GetString("DropGjuha.Items"),
            resources.GetString("DropGjuha.Items1")});
            this.DropGjuha.ItemsAppearance.Parent = this.DropGjuha;
            this.DropGjuha.Name = "DropGjuha";
            this.DropGjuha.ShadowDecoration.Parent = this.DropGjuha;
            this.DropGjuha.StartIndex = 0;
            this.DropGjuha.SelectedIndexChanged += new System.EventHandler(this.DropGjuha_SelectedIndexChanged);
            // 
            // gunaControlBox1
            // 
            resources.ApplyResources(this.gunaControlBox1, "gunaControlBox1");
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Poligoni.Properties.Resources.Language_Targeting;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // btnanuloo
            // 
            this.btnanuloo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.btnanuloo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnanuloo.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btnanuloo, "btnanuloo");
            this.btnanuloo.ForeColor = System.Drawing.Color.White;
            this.btnanuloo.Name = "btnanuloo";
            this.btnanuloo.UseVisualStyleBackColor = false;
            // 
            // btnkyquu
            // 
            this.btnkyquu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.btnkyquu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnkyquu.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btnkyquu, "btnkyquu");
            this.btnkyquu.ForeColor = System.Drawing.Color.White;
            this.btnkyquu.Name = "btnkyquu";
            this.btnkyquu.UseVisualStyleBackColor = false;
            this.btnkyquu.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jGradientPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.jGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		private JGradient_Panel.JGradientPanel jGradientPanel1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Button btnanuloo;
		private System.Windows.Forms.Button btnkyquu;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtpass2;
        private Guna.UI.WinForms.GunaLineTextBox txtuser1;
        private Guna.UI2.WinForms.Guna2ComboBox DropGjuha;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}