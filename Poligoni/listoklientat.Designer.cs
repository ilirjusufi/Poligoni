namespace Poligoni
{
    partial class listoklientat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textkos = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridiListo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mbiemri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edito = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Fshij = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnkerko = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridiListo)).BeginInit();
            this.SuspendLayout();
            // 
            // textkos
            // 
            this.textkos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.textkos.Location = new System.Drawing.Point(12, 47);
            this.textkos.Name = "textkos";
            this.textkos.Size = new System.Drawing.Size(668, 20);
            this.textkos.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btnkerko);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textkos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 83);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listo dhe kerko klienta";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridiListo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 367);
            this.panel2.TabIndex = 5;
            // 
            // gridiListo
            // 
            this.gridiListo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.gridiListo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridiListo.AutoGenerateColumns = false;
            this.gridiListo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridiListo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.gridiListo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridiListo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridiListo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridiListo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridiListo.ColumnHeadersHeight = 21;
            this.gridiListo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Userid,
            this.Emri,
            this.Mbiemri,
            this.Username,
            this.Email,
            this.Edito,
            this.Fshij});
            this.gridiListo.DataSource = this.bindingSource1;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridiListo.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridiListo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridiListo.EnableHeadersVisualStyles = false;
            this.gridiListo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.gridiListo.Location = new System.Drawing.Point(0, 0);
            this.gridiListo.Name = "gridiListo";
            this.gridiListo.RowHeadersVisible = false;
            this.gridiListo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridiListo.Size = new System.Drawing.Size(800, 367);
            this.gridiListo.TabIndex = 4;
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
            // Userid
            // 
            this.Userid.DataPropertyName = "ID";
            this.Userid.HeaderText = "userid";
            this.Userid.Name = "Userid";
            // 
            // Emri
            // 
            this.Emri.DataPropertyName = "Emri";
            this.Emri.HeaderText = "Emri";
            this.Emri.Name = "Emri";
            // 
            // Mbiemri
            // 
            this.Mbiemri.DataPropertyName = "Mbiemri";
            this.Mbiemri.HeaderText = "Mbiemri";
            this.Mbiemri.Name = "Mbiemri";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Edito
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Edito.DefaultCellStyle = dataGridViewCellStyle11;
            this.Edito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edito.HeaderText = "Edito";
            this.Edito.Name = "Edito";
            this.Edito.Text = "Edito";
            this.Edito.ToolTipText = "Edito";
            this.Edito.UseColumnTextForButtonValue = true;
            // 
            // Fshij
            // 
            this.Fshij.HeaderText = "Fshij";
            this.Fshij.Name = "Fshij";
            this.Fshij.Text = "Fshij";
            this.Fshij.ToolTipText = "Fshij";
            this.Fshij.UseColumnTextForButtonValue = true;
            // 
            // btnkerko
            // 
            this.btnkerko.CheckedState.Parent = this.btnkerko;
            this.btnkerko.CustomImages.Parent = this.btnkerko;
            this.btnkerko.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnkerko.ForeColor = System.Drawing.Color.White;
            this.btnkerko.HoverState.Parent = this.btnkerko;
            this.btnkerko.Location = new System.Drawing.Point(686, 46);
            this.btnkerko.Name = "btnkerko";
            this.btnkerko.ShadowDecoration.Parent = this.btnkerko;
            this.btnkerko.Size = new System.Drawing.Size(105, 21);
            this.btnkerko.TabIndex = 5;
            this.btnkerko.Text = "Kerko";
            this.btnkerko.Click += new System.EventHandler(this.btnkerko_Click);
            // 
            // listoklientat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "listoklientat";
            this.Text = "listoklientat";
            this.Load += new System.EventHandler(this.listoklientat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridiListo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textkos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView gridiListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mbiemri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn Edito;
        private System.Windows.Forms.DataGridViewButtonColumn Fshij;
        private Guna.UI2.WinForms.Guna2Button btnkerko;
    }
}