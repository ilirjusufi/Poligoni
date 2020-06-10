namespace Poligoni
{
    partial class frmMenagjogjuajtjen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenagjogjuajtjen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnkerko = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textkos = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Gridlistogjuajtien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.klienti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plumbashfryzuar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiketEshenuara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridlistogjuajtien)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(16, 46);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 29);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnkerko
            // 
            this.btnkerko.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.btnkerko.CheckedState.Parent = this.btnkerko;
            this.btnkerko.CustomImages.Parent = this.btnkerko;
            this.btnkerko.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.btnkerko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkerko.ForeColor = System.Drawing.Color.White;
            this.btnkerko.HoverState.Parent = this.btnkerko;
            this.btnkerko.Location = new System.Drawing.Point(780, 46);
            this.btnkerko.Name = "btnkerko";
            this.btnkerko.ShadowDecoration.Parent = this.btnkerko;
            this.btnkerko.Size = new System.Drawing.Size(102, 29);
            this.btnkerko.TabIndex = 9;
            this.btnkerko.Text = "Kerko";
            this.btnkerko.Click += new System.EventHandler(this.btnkerko_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Listo dhe kerko gjuajtjet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textkos
            // 
            this.textkos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(71)))));
            this.textkos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textkos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textkos.ForeColor = System.Drawing.Color.White;
            this.textkos.Location = new System.Drawing.Point(52, 46);
            this.textkos.Margin = new System.Windows.Forms.Padding(30, 5, 5, 0);
            this.textkos.Multiline = true;
            this.textkos.Name = "textkos";
            this.textkos.Size = new System.Drawing.Size(706, 29);
            this.textkos.TabIndex = 7;
            // 
            // Gridlistogjuajtien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Gridlistogjuajtien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Gridlistogjuajtien.AutoGenerateColumns = false;
            this.Gridlistogjuajtien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridlistogjuajtien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Gridlistogjuajtien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridlistogjuajtien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Gridlistogjuajtien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridlistogjuajtien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Gridlistogjuajtien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridlistogjuajtien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klienti,
            this.Arma,
            this.distanca,
            this.plumbashfryzuar,
            this.PiketEshenuara});
            this.Gridlistogjuajtien.DataSource = this.bindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridlistogjuajtien.DefaultCellStyle = dataGridViewCellStyle6;
            this.Gridlistogjuajtien.EnableHeadersVisualStyles = false;
            this.Gridlistogjuajtien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Gridlistogjuajtien.Location = new System.Drawing.Point(20, 108);
            this.Gridlistogjuajtien.Name = "Gridlistogjuajtien";
            this.Gridlistogjuajtien.RowHeadersVisible = false;
            this.Gridlistogjuajtien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridlistogjuajtien.Size = new System.Drawing.Size(862, 305);
            this.Gridlistogjuajtien.TabIndex = 11;
            this.Gridlistogjuajtien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.Gridlistogjuajtien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Gridlistogjuajtien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Gridlistogjuajtien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Gridlistogjuajtien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Gridlistogjuajtien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Gridlistogjuajtien.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Gridlistogjuajtien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Gridlistogjuajtien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Gridlistogjuajtien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Gridlistogjuajtien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Gridlistogjuajtien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Gridlistogjuajtien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridlistogjuajtien.ThemeStyle.HeaderStyle.Height = 21;
            this.Gridlistogjuajtien.ThemeStyle.ReadOnly = false;
            this.Gridlistogjuajtien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Gridlistogjuajtien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Gridlistogjuajtien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Gridlistogjuajtien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Gridlistogjuajtien.ThemeStyle.RowsStyle.Height = 22;
            this.Gridlistogjuajtien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.Gridlistogjuajtien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // klienti
            // 
            this.klienti.DataPropertyName = "klienti";
            this.klienti.HeaderText = "Klienti";
            this.klienti.Name = "klienti";
            // 
            // Arma
            // 
            this.Arma.DataPropertyName = "Arma";
            this.Arma.HeaderText = "Arma";
            this.Arma.Name = "Arma";
            // 
            // distanca
            // 
            this.distanca.DataPropertyName = "distanca";
            this.distanca.HeaderText = "Distanca";
            this.distanca.Name = "distanca";
            // 
            // plumbashfryzuar
            // 
            this.plumbashfryzuar.DataPropertyName = "plumbashfryzuar";
            this.plumbashfryzuar.HeaderText = "Plumbashfryzuar";
            this.plumbashfryzuar.Name = "plumbashfryzuar";
            // 
            // PiketEshenuara
            // 
            this.PiketEshenuara.DataPropertyName = "PiketEshenuara";
            this.PiketEshenuara.HeaderText = "PiketEshenuara";
            this.PiketEshenuara.Name = "PiketEshenuara";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(677, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(789, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fshij";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenagjogjuajtjen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(894, 480);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gridlistogjuajtien);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnkerko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textkos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.Name = "frmMenagjogjuajtjen";
            this.Text = "frmMenagjogjuajtjen";
            this.Load += new System.EventHandler(this.frmMenagjogjuajtjen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridlistogjuajtien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnkerko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textkos;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView Gridlistogjuajtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn klienti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arma;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn plumbashfryzuar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiketEshenuara;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}