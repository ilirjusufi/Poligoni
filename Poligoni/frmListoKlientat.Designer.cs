﻿namespace Poligoni
{
    partial class frmListoKlientat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListoKlientat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textkos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnkerko = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridiListo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mbiemri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edito = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Fshij = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridiListo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textkos
            // 
            resources.ApplyResources(this.textkos, "textkos");
            this.textkos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(71)))));
            this.textkos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textkos.ForeColor = System.Drawing.Color.White;
            this.textkos.Name = "textkos";
            this.textkos.TextChanged += new System.EventHandler(this.textkos_TextChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.btnkerko);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textkos);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnkerko
            // 
            resources.ApplyResources(this.btnkerko, "btnkerko");
            this.btnkerko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnkerko.CheckedState.Parent = this.btnkerko;
            this.btnkerko.CustomImages.Parent = this.btnkerko;
            this.btnkerko.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.btnkerko.ForeColor = System.Drawing.Color.White;
            this.btnkerko.HoverState.Parent = this.btnkerko;
            this.btnkerko.Name = "btnkerko";
            this.btnkerko.ShadowDecoration.Parent = this.btnkerko;
            this.btnkerko.Click += new System.EventHandler(this.btnkerko_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.gridiListo);
            this.panel2.Name = "panel2";
            // 
            // gridiListo
            // 
            resources.ApplyResources(this.gridiListo, "gridiListo");
            this.gridiListo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.gridiListo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridiListo.AutoGenerateColumns = false;
            this.gridiListo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridiListo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.gridiListo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridiListo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridiListo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridiListo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridiListo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Userid,
            this.Emri,
            this.Mbiemri,
            this.Username,
            this.Email,
            this.Edito,
            this.Fshij});
            this.gridiListo.DataSource = this.bindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridiListo.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridiListo.EnableHeadersVisualStyles = false;
            this.gridiListo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.gridiListo.Name = "gridiListo";
            this.gridiListo.RowHeadersVisible = false;
            this.gridiListo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridiListo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.gridiListo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.gridiListo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridiListo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridiListo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridiListo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridiListo.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.gridiListo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.gridiListo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.gridiListo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridiListo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridiListo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridiListo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridiListo.ThemeStyle.HeaderStyle.Height = 21;
            this.gridiListo.ThemeStyle.ReadOnly = false;
            this.gridiListo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.gridiListo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridiListo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridiListo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridiListo.ThemeStyle.RowsStyle.Height = 22;
            this.gridiListo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.gridiListo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridiListo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridiListo_CellContentClick);
            // 
            // guna2PictureBox1
            // 
            resources.ApplyResources(this.guna2PictureBox1, "guna2PictureBox1");
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Userid
            // 
            this.Userid.DataPropertyName = "ID";
            resources.ApplyResources(this.Userid, "Userid");
            this.Userid.Name = "Userid";
            // 
            // Emri
            // 
            this.Emri.DataPropertyName = "Emri";
            resources.ApplyResources(this.Emri, "Emri");
            this.Emri.Name = "Emri";
            // 
            // Mbiemri
            // 
            this.Mbiemri.DataPropertyName = "Mbiemri";
            resources.ApplyResources(this.Mbiemri, "Mbiemri");
            this.Mbiemri.Name = "Mbiemri";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            resources.ApplyResources(this.Username, "Username");
            this.Username.Name = "Username";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            // 
            // Edito
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Edito.DefaultCellStyle = dataGridViewCellStyle3;
            this.Edito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.Edito, "Edito");
            this.Edito.Name = "Edito";
            this.Edito.Text = "Edit";
            this.Edito.UseColumnTextForButtonValue = true;
            // 
            // Fshij
            // 
            resources.ApplyResources(this.Fshij, "Fshij");
            this.Fshij.Name = "Fshij";
            this.Fshij.Text = "Delete";
            this.Fshij.UseColumnTextForButtonValue = true;
            // 
            // frmListoKlientat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmListoKlientat";
            this.Load += new System.EventHandler(this.listoklientat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridiListo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textkos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView gridiListo;
        private Guna.UI2.WinForms.Guna2Button btnkerko;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mbiemri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn Edito;
        private System.Windows.Forms.DataGridViewButtonColumn Fshij;
    }
}