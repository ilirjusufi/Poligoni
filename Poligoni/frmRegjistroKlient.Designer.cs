namespace Poligoni
{
    partial class frmRegjistroKlient
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
            this.button1 = new JThinButton.JThinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jGradientPanel1 = new JGradient_Panel.JGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordKlientit = new JTextBox2.JTextBox();
            this.txtUsernameKlientit = new JTextBox2.JTextBox();
            this.txtEmailKlientit = new JTextBox2.JTextBox();
            this.txtMbiemriKlientit = new JTextBox2.JTextBox();
            this.txtEmriKlientit = new JTextBox2.JTextBox();
            this.jGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.White;
            this.button1.BorderRadius = 5;
            this.button1.ButtonText = "Submit";
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColors = System.Drawing.Color.White;
            this.button1.HoverBackground = System.Drawing.Color.White;
            this.button1.HoverBorder = System.Drawing.Color.Empty;
            this.button1.HoverFontColor = System.Drawing.Color.Black;
            this.button1.LineThickness = 2;
            this.button1.Location = new System.Drawing.Point(388, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 48);
            this.button1.TabIndex = 20;
            this.button1.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Emri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mbiemri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(214, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(221, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(253, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email";
            // 
            // jGradientPanel1
            // 
            this.jGradientPanel1.ColorBottom = System.Drawing.Color.SeaGreen;
            this.jGradientPanel1.ColorTop = System.Drawing.Color.DarkOliveGreen;
            this.jGradientPanel1.Controls.Add(this.panel1);
            this.jGradientPanel1.Controls.Add(this.txtPasswordKlientit);
            this.jGradientPanel1.Controls.Add(this.txtUsernameKlientit);
            this.jGradientPanel1.Controls.Add(this.txtEmailKlientit);
            this.jGradientPanel1.Controls.Add(this.txtMbiemriKlientit);
            this.jGradientPanel1.Controls.Add(this.txtEmriKlientit);
            this.jGradientPanel1.Controls.Add(this.label5);
            this.jGradientPanel1.Controls.Add(this.label4);
            this.jGradientPanel1.Controls.Add(this.button1);
            this.jGradientPanel1.Controls.Add(this.label3);
            this.jGradientPanel1.Controls.Add(this.label2);
            this.jGradientPanel1.Controls.Add(this.label1);
            this.jGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.jGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.jGradientPanel1.Name = "jGradientPanel1";
            this.jGradientPanel1.Size = new System.Drawing.Size(903, 561);
            this.jGradientPanel1.TabIndex = 13;
            this.jGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.jGradientPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(303, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 91);
            this.panel1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "Regjistrimi i Klientit";
            // 
            // txtPasswordKlientit
            // 
            this.txtPasswordKlientit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordKlientit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtPasswordKlientit.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtPasswordKlientit.HintText = null;
            this.txtPasswordKlientit.IsPassword = true;
            this.txtPasswordKlientit.Location = new System.Drawing.Point(315, 338);
            this.txtPasswordKlientit.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordKlientit.MaxLength = 32767;
            this.txtPasswordKlientit.Name = "txtPasswordKlientit";
            this.txtPasswordKlientit.OnFocusedColor = System.Drawing.Color.White;
            this.txtPasswordKlientit.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtPasswordKlientit.ReadOnly = false;
            this.txtPasswordKlientit.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtPasswordKlientit.Size = new System.Drawing.Size(279, 38);
            this.txtPasswordKlientit.TabIndex = 34;
            this.txtPasswordKlientit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswordKlientit.TextName = "";
            // 
            // txtUsernameKlientit
            // 
            this.txtUsernameKlientit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameKlientit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtUsernameKlientit.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtUsernameKlientit.HintText = null;
            this.txtUsernameKlientit.IsPassword = false;
            this.txtUsernameKlientit.Location = new System.Drawing.Point(315, 281);
            this.txtUsernameKlientit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsernameKlientit.MaxLength = 32767;
            this.txtUsernameKlientit.Name = "txtUsernameKlientit";
            this.txtUsernameKlientit.OnFocusedColor = System.Drawing.Color.White;
            this.txtUsernameKlientit.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtUsernameKlientit.ReadOnly = false;
            this.txtUsernameKlientit.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtUsernameKlientit.Size = new System.Drawing.Size(279, 38);
            this.txtUsernameKlientit.TabIndex = 33;
            this.txtUsernameKlientit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsernameKlientit.TextName = "";
            // 
            // txtEmailKlientit
            // 
            this.txtEmailKlientit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailKlientit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtEmailKlientit.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtEmailKlientit.HintText = null;
            this.txtEmailKlientit.IsPassword = false;
            this.txtEmailKlientit.Location = new System.Drawing.Point(315, 222);
            this.txtEmailKlientit.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailKlientit.MaxLength = 32767;
            this.txtEmailKlientit.Name = "txtEmailKlientit";
            this.txtEmailKlientit.OnFocusedColor = System.Drawing.Color.White;
            this.txtEmailKlientit.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtEmailKlientit.ReadOnly = false;
            this.txtEmailKlientit.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtEmailKlientit.Size = new System.Drawing.Size(279, 38);
            this.txtEmailKlientit.TabIndex = 32;
            this.txtEmailKlientit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmailKlientit.TextName = "";
            // 
            // txtMbiemriKlientit
            // 
            this.txtMbiemriKlientit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMbiemriKlientit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtMbiemriKlientit.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtMbiemriKlientit.HintText = null;
            this.txtMbiemriKlientit.IsPassword = false;
            this.txtMbiemriKlientit.Location = new System.Drawing.Point(315, 168);
            this.txtMbiemriKlientit.Margin = new System.Windows.Forms.Padding(4);
            this.txtMbiemriKlientit.MaxLength = 32767;
            this.txtMbiemriKlientit.Name = "txtMbiemriKlientit";
            this.txtMbiemriKlientit.OnFocusedColor = System.Drawing.Color.White;
            this.txtMbiemriKlientit.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtMbiemriKlientit.ReadOnly = false;
            this.txtMbiemriKlientit.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtMbiemriKlientit.Size = new System.Drawing.Size(279, 38);
            this.txtMbiemriKlientit.TabIndex = 31;
            this.txtMbiemriKlientit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMbiemriKlientit.TextName = "";
            // 
            // txtEmriKlientit
            // 
            this.txtEmriKlientit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmriKlientit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtEmriKlientit.Font_Size = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtEmriKlientit.HintText = null;
            this.txtEmriKlientit.IsPassword = false;
            this.txtEmriKlientit.Location = new System.Drawing.Point(315, 110);
            this.txtEmriKlientit.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmriKlientit.MaxLength = 32767;
            this.txtEmriKlientit.Name = "txtEmriKlientit";
            this.txtEmriKlientit.OnFocusedColor = System.Drawing.Color.White;
            this.txtEmriKlientit.OnFocusedTextColor = System.Drawing.Color.Gray;
            this.txtEmriKlientit.ReadOnly = false;
            this.txtEmriKlientit.Right_To_Left = System.Windows.Forms.RightToLeft.No;
            this.txtEmriKlientit.Size = new System.Drawing.Size(279, 38);
            this.txtEmriKlientit.TabIndex = 1;
            this.txtEmriKlientit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmriKlientit.TextName = "";
            // 
            // frmRegjistroKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 561);
            this.Controls.Add(this.jGradientPanel1);
            this.Name = "frmRegjistroKlient";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.jGradientPanel1.ResumeLayout(false);
            this.jGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private JThinButton.JThinButton button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private JGradient_Panel.JGradientPanel jGradientPanel1;
        private JTextBox2.JTextBox txtEmriKlientit;
        private JTextBox2.JTextBox txtPasswordKlientit;
        private JTextBox2.JTextBox txtUsernameKlientit;
        private JTextBox2.JTextBox txtEmailKlientit;
        private JTextBox2.JTextBox txtMbiemriKlientit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}

