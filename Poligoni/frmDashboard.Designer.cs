﻿namespace Poligoni
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regjistroStafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndyshoStafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fshijStafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klientatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regjistroKlientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndryshoKlientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fshijKlientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listoKlientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rankimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(820, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 27);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(-9, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 25);
            this.panel3.TabIndex = 7;
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
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrimiToolStripMenuItem
            // 
            this.administrimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regjistroStafToolStripMenuItem,
            this.ndyshoStafToolStripMenuItem,
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
            // ndyshoStafToolStripMenuItem
            // 
            this.ndyshoStafToolStripMenuItem.Name = "ndyshoStafToolStripMenuItem";
            this.ndyshoStafToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ndyshoStafToolStripMenuItem.Text = "Ndysho Staf";
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
            this.listoKlientToolStripMenuItem1});
            this.klientatToolStripMenuItem.Name = "klientatToolStripMenuItem";
            this.klientatToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.klientatToolStripMenuItem.Text = "Klientat";
            // 
            // regjistroKlientToolStripMenuItem
            // 
            this.regjistroKlientToolStripMenuItem.Name = "regjistroKlientToolStripMenuItem";
            this.regjistroKlientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.regjistroKlientToolStripMenuItem.Text = "Regjistro Klient";
            this.regjistroKlientToolStripMenuItem.Click += new System.EventHandler(this.regjistroKlientToolStripMenuItem_Click_1);
            // 
            // ndryshoKlientToolStripMenuItem
            // 
            this.ndryshoKlientToolStripMenuItem.Name = "ndryshoKlientToolStripMenuItem";
            this.ndryshoKlientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ndryshoKlientToolStripMenuItem.Text = "Ndrysho Klient";
            // 
            // fshijKlientToolStripMenuItem
            // 
            this.fshijKlientToolStripMenuItem.Name = "fshijKlientToolStripMenuItem";
            this.fshijKlientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fshijKlientToolStripMenuItem.Text = "Fshij Klient";
            // 
            // listoKlientToolStripMenuItem1
            // 
            this.listoKlientToolStripMenuItem1.Name = "listoKlientToolStripMenuItem1";
            this.listoKlientToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.listoKlientToolStripMenuItem1.Text = "Listo Klient";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Useri korrekt";
            this.label2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(880, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmDashboard_Load_1);
            this.Shown += new System.EventHandler(this.FrmDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regjistroStafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndyshoStafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fshijStafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klientatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regjistroKlientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndryshoKlientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fshijKlientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listoKlientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rankimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportetToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}