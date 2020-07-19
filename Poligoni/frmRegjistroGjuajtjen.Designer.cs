namespace Poligoni
{
	partial class frmRegjistroGjuajtjen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegjistroGjuajtjen));
            this.jGradientPanel1 = new JGradient_Panel.JGradientPanel();
            this.btneditogjujtjen = new FlatButton.JFlatButton();
            this.dropklientat = new System.Windows.Forms.ComboBox();
            this.useratBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A62C25_poligoniDataSet2 = new Poligoni.DB_A62C25_poligoniDataSet2();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.droparmet = new System.Windows.Forms.ComboBox();
            this.armaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_A62C25_poligoniDataSet = new Poligoni.DB_A62C25_poligoniDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Txtdistanca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtMaxPlumba = new System.Windows.Forms.TextBox();
            this.txtKalibri = new System.Windows.Forms.TextBox();
            this.btnRegjistroGjuajtjen = new FlatButton.JFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArma = new System.Windows.Forms.Label();
            this.armaTableAdapter = new Poligoni.DB_A62C25_poligoniDataSetTableAdapters.ArmaTableAdapter();
            this.useratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useratTableAdapter1 = new Poligoni.DB_A62C25_poligoniDataSet2TableAdapters.UseratTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.jGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useratBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A62C25_poligoniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A62C25_poligoniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useratBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jGradientPanel1
            // 
            this.jGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.jGradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.jGradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.jGradientPanel1.Controls.Add(this.guna2CircleButton1);
            this.jGradientPanel1.Controls.Add(this.btneditogjujtjen);
            this.jGradientPanel1.Controls.Add(this.dropklientat);
            this.jGradientPanel1.Controls.Add(this.pictureBox6);
            this.jGradientPanel1.Controls.Add(this.droparmet);
            this.jGradientPanel1.Controls.Add(this.label2);
            this.jGradientPanel1.Controls.Add(this.pictureBox5);
            this.jGradientPanel1.Controls.Add(this.pictureBox3);
            this.jGradientPanel1.Controls.Add(this.Txtdistanca);
            this.jGradientPanel1.Controls.Add(this.label1);
            this.jGradientPanel1.Controls.Add(this.pictureBox2);
            this.jGradientPanel1.Controls.Add(this.pictureBox1);
            this.jGradientPanel1.Controls.Add(this.pictureBox4);
            this.jGradientPanel1.Controls.Add(this.txtMaxPlumba);
            this.jGradientPanel1.Controls.Add(this.txtKalibri);
            this.jGradientPanel1.Controls.Add(this.btnRegjistroGjuajtjen);
            this.jGradientPanel1.Controls.Add(this.label4);
            this.jGradientPanel1.Controls.Add(this.label5);
            this.jGradientPanel1.Controls.Add(this.label3);
            this.jGradientPanel1.Controls.Add(this.lblArma);
            resources.ApplyResources(this.jGradientPanel1, "jGradientPanel1");
            this.jGradientPanel1.Name = "jGradientPanel1";
            this.helpProvider1.SetShowHelp(this.jGradientPanel1, ((bool)(resources.GetObject("jGradientPanel1.ShowHelp"))));
            this.jGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.jGradientPanel1_Paint);
            // 
            // btneditogjujtjen
            // 
            this.btneditogjujtjen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.btneditogjujtjen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.btneditogjujtjen.ButtonText = "Edito Gjuajtjen";
            this.btneditogjujtjen.CausesValidation = false;
            this.btneditogjujtjen.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btneditogjujtjen.ErrorImageLeft")));
            this.btneditogjujtjen.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btneditogjujtjen.ErrorImageRight")));
            this.btneditogjujtjen.FocusBackground = System.Drawing.Color.Empty;
            this.btneditogjujtjen.FocusFontColor = System.Drawing.Color.Empty;
            this.btneditogjujtjen.ForeColors = System.Drawing.Color.White;
            this.btneditogjujtjen.HoverBackground = System.Drawing.Color.DarkSlateGray;
            this.btneditogjujtjen.HoverFontColor = System.Drawing.Color.Transparent;
            this.btneditogjujtjen.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btneditogjujtjen.ImageLeft")));
            this.btneditogjujtjen.ImageRight = null;
            this.btneditogjujtjen.LeftPictureColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btneditogjujtjen, "btneditogjujtjen");
            this.btneditogjujtjen.Name = "btneditogjujtjen";
            this.btneditogjujtjen.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btneditogjujtjen.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btneditogjujtjen.RightPictureColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetShowHelp(this.btneditogjujtjen, ((bool)(resources.GetObject("btneditogjujtjen.ShowHelp"))));
            this.btneditogjujtjen.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btneditogjujtjen.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btneditogjujtjen.Click += new System.EventHandler(this.jFlatButton1_Click);
            // 
            // dropklientat
            // 
            this.dropklientat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.dropklientat.DataSource = this.useratBindingSource1;
            this.dropklientat.DisplayMember = "Username";
            this.dropklientat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.dropklientat, "dropklientat");
            this.dropklientat.ForeColor = System.Drawing.SystemColors.Info;
            this.dropklientat.FormattingEnabled = true;
            this.dropklientat.Name = "dropklientat";
            this.helpProvider1.SetShowHelp(this.dropklientat, ((bool)(resources.GetObject("dropklientat.ShowHelp"))));
            this.dropklientat.ValueMember = "Username";
            // 
            // useratBindingSource1
            // 
            this.useratBindingSource1.DataMember = "Userat";
            this.useratBindingSource1.DataSource = this.dB_A62C25_poligoniDataSet2;
            // 
            // dB_A62C25_poligoniDataSet2
            // 
            this.dB_A62C25_poligoniDataSet2.DataSetName = "DB_A62C25_poligoniDataSet2";
            this.dB_A62C25_poligoniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Poligoni.Properties.Resources._3;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.helpProvider1.SetShowHelp(this.pictureBox6, ((bool)(resources.GetObject("pictureBox6.ShowHelp"))));
            this.pictureBox6.TabStop = false;
            // 
            // droparmet
            // 
            this.droparmet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.droparmet.DataSource = this.armaBindingSource;
            this.droparmet.DisplayMember = "EmriArmes";
            resources.ApplyResources(this.droparmet, "droparmet");
            this.droparmet.ForeColor = System.Drawing.SystemColors.Info;
            this.droparmet.FormattingEnabled = true;
            this.droparmet.Name = "droparmet";
            this.helpProvider1.SetShowHelp(this.droparmet, ((bool)(resources.GetObject("droparmet.ShowHelp"))));
            this.droparmet.ValueMember = "EmriArmes";
            // 
            // armaBindingSource
            // 
            this.armaBindingSource.DataMember = "Arma";
            this.armaBindingSource.DataSource = this.dB_A62C25_poligoniDataSet;
            // 
            // dB_A62C25_poligoniDataSet
            // 
            this.dB_A62C25_poligoniDataSet.DataSetName = "DB_A62C25_poligoniDataSet";
            this.dB_A62C25_poligoniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            this.helpProvider1.SetShowHelp(this.label2, ((bool)(resources.GetObject("label2.ShowHelp"))));
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.helpProvider1.SetShowHelp(this.pictureBox5, ((bool)(resources.GetObject("pictureBox5.ShowHelp"))));
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.helpProvider1.SetShowHelp(this.pictureBox3, ((bool)(resources.GetObject("pictureBox3.ShowHelp"))));
            this.pictureBox3.TabStop = false;
            // 
            // Txtdistanca
            // 
            this.Txtdistanca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.Txtdistanca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.Txtdistanca, "Txtdistanca");
            this.Txtdistanca.ForeColor = System.Drawing.Color.White;
            this.Txtdistanca.Name = "Txtdistanca";
            this.helpProvider1.SetShowHelp(this.Txtdistanca, ((bool)(resources.GetObject("Txtdistanca.ShowHelp"))));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.helpProvider1.SetShowHelp(this.label1, ((bool)(resources.GetObject("label1.ShowHelp"))));
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.helpProvider1.SetShowHelp(this.pictureBox2, ((bool)(resources.GetObject("pictureBox2.ShowHelp"))));
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.helpProvider1.SetShowHelp(this.pictureBox1, ((bool)(resources.GetObject("pictureBox1.ShowHelp"))));
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.helpProvider1.SetShowHelp(this.pictureBox4, ((bool)(resources.GetObject("pictureBox4.ShowHelp"))));
            this.pictureBox4.TabStop = false;
            // 
            // txtMaxPlumba
            // 
            this.txtMaxPlumba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.txtMaxPlumba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtMaxPlumba, "txtMaxPlumba");
            this.txtMaxPlumba.ForeColor = System.Drawing.Color.White;
            this.txtMaxPlumba.Name = "txtMaxPlumba";
            this.helpProvider1.SetShowHelp(this.txtMaxPlumba, ((bool)(resources.GetObject("txtMaxPlumba.ShowHelp"))));
            // 
            // txtKalibri
            // 
            this.txtKalibri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.txtKalibri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtKalibri, "txtKalibri");
            this.txtKalibri.ForeColor = System.Drawing.Color.White;
            this.txtKalibri.Name = "txtKalibri";
            this.helpProvider1.SetShowHelp(this.txtKalibri, ((bool)(resources.GetObject("txtKalibri.ShowHelp"))));
            // 
            // btnRegjistroGjuajtjen
            // 
            this.btnRegjistroGjuajtjen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.btnRegjistroGjuajtjen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.btnRegjistroGjuajtjen.ButtonText = "Register shoot";
            this.btnRegjistroGjuajtjen.CausesValidation = false;
            this.btnRegjistroGjuajtjen.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnRegjistroGjuajtjen.ErrorImageLeft")));
            this.btnRegjistroGjuajtjen.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnRegjistroGjuajtjen.ErrorImageRight")));
            this.btnRegjistroGjuajtjen.FocusBackground = System.Drawing.Color.Empty;
            this.btnRegjistroGjuajtjen.FocusFontColor = System.Drawing.Color.Empty;
            this.btnRegjistroGjuajtjen.ForeColors = System.Drawing.Color.White;
            this.btnRegjistroGjuajtjen.HoverBackground = System.Drawing.Color.DarkSlateGray;
            this.btnRegjistroGjuajtjen.HoverFontColor = System.Drawing.Color.Transparent;
            this.btnRegjistroGjuajtjen.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btnRegjistroGjuajtjen.ImageLeft")));
            this.btnRegjistroGjuajtjen.ImageRight = null;
            this.btnRegjistroGjuajtjen.LeftPictureColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnRegjistroGjuajtjen, "btnRegjistroGjuajtjen");
            this.btnRegjistroGjuajtjen.Name = "btnRegjistroGjuajtjen";
            this.btnRegjistroGjuajtjen.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnRegjistroGjuajtjen.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnRegjistroGjuajtjen.RightPictureColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetShowHelp(this.btnRegjistroGjuajtjen, ((bool)(resources.GetObject("btnRegjistroGjuajtjen.ShowHelp"))));
            this.btnRegjistroGjuajtjen.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRegjistroGjuajtjen.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnRegjistroGjuajtjen.Click += new System.EventHandler(this.btnRegjistroGjuajtjen_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            this.helpProvider1.SetShowHelp(this.label4, ((bool)(resources.GetObject("label4.ShowHelp"))));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            this.helpProvider1.SetShowHelp(this.label5, ((bool)(resources.GetObject("label5.ShowHelp"))));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            this.helpProvider1.SetShowHelp(this.label3, ((bool)(resources.GetObject("label3.ShowHelp"))));
            // 
            // lblArma
            // 
            resources.ApplyResources(this.lblArma, "lblArma");
            this.lblArma.BackColor = System.Drawing.Color.Transparent;
            this.lblArma.ForeColor = System.Drawing.Color.White;
            this.lblArma.Name = "lblArma";
            this.helpProvider1.SetShowHelp(this.lblArma, ((bool)(resources.GetObject("lblArma.ShowHelp"))));
            // 
            // armaTableAdapter
            // 
            this.armaTableAdapter.ClearBeforeFill = true;
            // 
            // useratTableAdapter1
            // 
            this.useratTableAdapter1.ClearBeforeFill = true;
            // 
            // helpProvider1
            // 
            resources.ApplyResources(this.helpProvider1, "helpProvider1");
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2CircleButton1, "guna2CircleButton1");
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.IndicateFocus = true;
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.helpProvider1.SetShowHelp(this.guna2CircleButton1, ((bool)(resources.GetObject("guna2CircleButton1.ShowHelp"))));
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click_1);
            // 
            // frmRegjistroGjuajtjen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jGradientPanel1);
            this.Name = "frmRegjistroGjuajtjen";
            this.helpProvider1.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Load += new System.EventHandler(this.frmRegjistroGjuajtjen_Load);
            this.jGradientPanel1.ResumeLayout(false);
            this.jGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useratBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A62C25_poligoniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A62C25_poligoniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useratBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private JGradient_Panel.JGradientPanel jGradientPanel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.TextBox txtMaxPlumba;
		private System.Windows.Forms.TextBox txtKalibri;
		private FlatButton.JFlatButton btnRegjistroGjuajtjen;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblArma;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TextBox Txtdistanca;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox droparmet;
        private DB_A62C25_poligoniDataSet dB_A62C25_poligoniDataSet;
        private System.Windows.Forms.BindingSource armaBindingSource;
        private DB_A62C25_poligoniDataSetTableAdapters.ArmaTableAdapter armaTableAdapter;
        private System.Windows.Forms.ComboBox dropklientat;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.BindingSource useratBindingSource;

        private DB_A62C25_poligoniDataSet2 dB_A62C25_poligoniDataSet2;
        private System.Windows.Forms.BindingSource useratBindingSource1;
        private DB_A62C25_poligoniDataSet2TableAdapters.UseratTableAdapter useratTableAdapter1;
        private FlatButton.JFlatButton btneditogjujtjen;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}