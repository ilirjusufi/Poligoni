namespace Poligoni
{
    partial class frmmenagjoArmet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsatagridArmet = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ArmaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmriArmes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kalibri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPlumba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdito = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFshij = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsatagridArmet)).BeginInit();
            this.SuspendLayout();
            // 
            // dsatagridArmet
            // 
            this.dsatagridArmet.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dsatagridArmet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dsatagridArmet.AutoGenerateColumns = false;
            this.dsatagridArmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsatagridArmet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.dsatagridArmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dsatagridArmet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dsatagridArmet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsatagridArmet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dsatagridArmet.ColumnHeadersHeight = 21;
            this.dsatagridArmet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArmaID,
            this.EmriArmes,
            this.Kalibri,
            this.MaxPlumba});
            this.dsatagridArmet.DataSource = this.bindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dsatagridArmet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dsatagridArmet.EnableHeadersVisualStyles = false;
            this.dsatagridArmet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dsatagridArmet.Location = new System.Drawing.Point(12, 88);
            this.dsatagridArmet.Name = "dsatagridArmet";
            this.dsatagridArmet.RowHeadersVisible = false;
            this.dsatagridArmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsatagridArmet.Size = new System.Drawing.Size(776, 270);
            this.dsatagridArmet.TabIndex = 0;
            this.dsatagridArmet.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dsatagridArmet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dsatagridArmet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dsatagridArmet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dsatagridArmet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dsatagridArmet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dsatagridArmet.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.dsatagridArmet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dsatagridArmet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dsatagridArmet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dsatagridArmet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dsatagridArmet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dsatagridArmet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dsatagridArmet.ThemeStyle.HeaderStyle.Height = 21;
            this.dsatagridArmet.ThemeStyle.ReadOnly = false;
            this.dsatagridArmet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dsatagridArmet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dsatagridArmet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dsatagridArmet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dsatagridArmet.ThemeStyle.RowsStyle.Height = 22;
            this.dsatagridArmet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dsatagridArmet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dsatagridArmet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsatagridArmet_CellContentClick);
            // 
            // ArmaID
            // 
            this.ArmaID.DataPropertyName = "ArmaID";
            this.ArmaID.HeaderText = "ArmaID";
            this.ArmaID.Name = "ArmaID";
            // 
            // EmriArmes
            // 
            this.EmriArmes.DataPropertyName = "EmriArmes";
            this.EmriArmes.HeaderText = "EmriArmes";
            this.EmriArmes.Name = "EmriArmes";
            // 
            // Kalibri
            // 
            this.Kalibri.DataPropertyName = "Kalibiri";
            this.Kalibri.HeaderText = "Kalibri";
            this.Kalibri.Name = "Kalibri";
            // 
            // MaxPlumba
            // 
            this.MaxPlumba.DataPropertyName = "MaxPlumba";
            this.MaxPlumba.HeaderText = "MaxPlumba";
            this.MaxPlumba.Name = "MaxPlumba";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(12, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(606, 29);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(649, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(139, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Kerko";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdito
            // 
            this.btnEdito.CheckedState.Parent = this.btnEdito;
            this.btnEdito.CustomImages.Parent = this.btnEdito;
            this.btnEdito.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdito.ForeColor = System.Drawing.Color.White;
            this.btnEdito.HoverState.Parent = this.btnEdito;
            this.btnEdito.Location = new System.Drawing.Point(405, 393);
            this.btnEdito.Name = "btnEdito";
            this.btnEdito.ShadowDecoration.Parent = this.btnEdito;
            this.btnEdito.Size = new System.Drawing.Size(180, 45);
            this.btnEdito.TabIndex = 3;
            this.btnEdito.Text = "guna2Button1";
            this.btnEdito.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BtnFshij
            // 
            this.BtnFshij.CheckedState.Parent = this.BtnFshij;
            this.BtnFshij.CustomImages.Parent = this.BtnFshij;
            this.BtnFshij.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnFshij.ForeColor = System.Drawing.Color.White;
            this.BtnFshij.HoverState.Parent = this.BtnFshij;
            this.BtnFshij.Location = new System.Drawing.Point(608, 393);
            this.BtnFshij.Name = "BtnFshij";
            this.BtnFshij.ShadowDecoration.Parent = this.BtnFshij;
            this.BtnFshij.Size = new System.Drawing.Size(180, 45);
            this.BtnFshij.TabIndex = 4;
            this.BtnFshij.Text = "guna2Button2";
            this.BtnFshij.Click += new System.EventHandler(this.BtnFshij_Click);
            // 
            // frmmenagjoArmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFshij);
            this.Controls.Add(this.btnEdito);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dsatagridArmet);
            this.Name = "frmmenagjoArmet";
            this.Text = "frmmenagjoArmet";
            this.Load += new System.EventHandler(this.frmmenagjoArmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsatagridArmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView dsatagridArmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArmaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmriArmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kalibri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPlumba;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnEdito;
        private Guna.UI2.WinForms.Guna2Button BtnFshij;
    }
}