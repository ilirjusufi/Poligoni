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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textkos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridiListo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Emri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mbiemri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textkos);
            this.panel1.Controls.Add(this.button1);
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
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.gridiListo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridiListo.AutoGenerateColumns = false;
            this.gridiListo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridiListo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.gridiListo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridiListo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridiListo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridiListo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridiListo.ColumnHeadersHeight = 21;
            this.gridiListo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emri,
            this.Mbiemri,
            this.Username,
            this.Email});
            this.gridiListo.DataSource = this.bindingSource1;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridiListo.DefaultCellStyle = dataGridViewCellStyle9;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mbiemri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private Guna.UI2.WinForms.Guna2DataGridView gridiListo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}