namespace Poligoni
{
    partial class FrmDashboard
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regjistroStafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndryshoStafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fshijStafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regjistroKlientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndryshoKlientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fshijKlientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listoTeGjitheKlientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrimiToolStripMenuItem,
            this.klientatToolStripMenuItem,
            this.rankimiToolStripMenuItem,
            this.raportetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrimiToolStripMenuItem
            // 
            this.administrimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regjistroStafToolStripMenuItem,
            this.ndryshoStafToolStripMenuItem,
            this.fshijStafToolStripMenuItem});
            this.administrimiToolStripMenuItem.Name = "administrimiToolStripMenuItem";
            this.administrimiToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.administrimiToolStripMenuItem.Text = "Administrimi";
            // 
            // regjistroStafToolStripMenuItem
            // 
            this.regjistroStafToolStripMenuItem.Name = "regjistroStafToolStripMenuItem";
            this.regjistroStafToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.regjistroStafToolStripMenuItem.Text = "Regjistro Staf";
            // 
            // ndryshoStafToolStripMenuItem
            // 
            this.ndryshoStafToolStripMenuItem.Name = "ndryshoStafToolStripMenuItem";
            this.ndryshoStafToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ndryshoStafToolStripMenuItem.Text = "Ndrysho Staf";
            // 
            // fshijStafToolStripMenuItem
            // 
            this.fshijStafToolStripMenuItem.Name = "fshijStafToolStripMenuItem";
            this.fshijStafToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.fshijStafToolStripMenuItem.Text = "Fshij Staf";
            // 
            // klientatToolStripMenuItem
            // 
            this.klientatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regjistroKlientToolStripMenuItem,
            this.ndryshoKlientToolStripMenuItem,
            this.fshijKlientToolStripMenuItem,
            this.listoTeGjitheKlientToolStripMenuItem});
            this.klientatToolStripMenuItem.Name = "klientatToolStripMenuItem";
            this.klientatToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.klientatToolStripMenuItem.Text = "Klientat";
            // 
            // regjistroKlientToolStripMenuItem
            // 
            this.regjistroKlientToolStripMenuItem.Name = "regjistroKlientToolStripMenuItem";
            this.regjistroKlientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.regjistroKlientToolStripMenuItem.Text = "Regjistro Klient";
            // 
            // ndryshoKlientToolStripMenuItem
            // 
            this.ndryshoKlientToolStripMenuItem.Name = "ndryshoKlientToolStripMenuItem";
            this.ndryshoKlientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ndryshoKlientToolStripMenuItem.Text = "Ndrysho Klient";
            // 
            // fshijKlientToolStripMenuItem
            // 
            this.fshijKlientToolStripMenuItem.Name = "fshijKlientToolStripMenuItem";
            this.fshijKlientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.fshijKlientToolStripMenuItem.Text = "Fshij Klient";
            // 
            // listoTeGjitheKlientToolStripMenuItem
            // 
            this.listoTeGjitheKlientToolStripMenuItem.Name = "listoTeGjitheKlientToolStripMenuItem";
            this.listoTeGjitheKlientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.listoTeGjitheKlientToolStripMenuItem.Text = "Listo të gjithë klientët";
            this.listoTeGjitheKlientToolStripMenuItem.Click += new System.EventHandler(this.listoTeGjitheKlientToolStripMenuItem_Click);
            // 
            // rankimiToolStripMenuItem
            // 
            this.rankimiToolStripMenuItem.Name = "rankimiToolStripMenuItem";
            this.rankimiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.rankimiToolStripMenuItem.Text = "Rankimi";
            // 
            // raportetToolStripMenuItem
            // 
            this.raportetToolStripMenuItem.Name = "raportetToolStripMenuItem";
            this.raportetToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.raportetToolStripMenuItem.Text = "Raportet";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDashboard";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmDashboard_Load_1);
            this.Shown += new System.EventHandler(this.FrmDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regjistroStafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndryshoStafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fshijStafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klientatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regjistroKlientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndryshoKlientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fshijKlientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listoTeGjitheKlientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportetToolStripMenuItem;
    }
}