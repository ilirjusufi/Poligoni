namespace Poligoni
{
    partial class frmMenaxhimiStokut
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
            this.dB_A57CDC_poligoniDataSet = new Poligoni.DB_A57CDC_poligoniDataSet();
            this.useratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useratTableAdapter = new Poligoni.DB_A57CDC_poligoniDataSetTableAdapters.UseratTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dB_A57CDC_poligoniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useratBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_A57CDC_poligoniDataSet
            // 
            this.dB_A57CDC_poligoniDataSet.DataSetName = "DB_A57CDC_poligoniDataSet";
            this.dB_A57CDC_poligoniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // useratBindingSource
            // 
            this.useratBindingSource.DataMember = "Userat";
            this.useratBindingSource.DataSource = this.dB_A57CDC_poligoniDataSet;
            // 
            // useratTableAdapter
            // 
            this.useratTableAdapter.ClearBeforeFill = true;
            // 
            // frmMenaxhimiStokut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmMenaxhimiStokut";
            this.Text = "frmMenaxhimiStokut";
            this.Load += new System.EventHandler(this.frmMenaxhimiStokut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_A57CDC_poligoniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useratBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DB_A57CDC_poligoniDataSet dB_A57CDC_poligoniDataSet;
        private System.Windows.Forms.BindingSource useratBindingSource;
        private DB_A57CDC_poligoniDataSetTableAdapters.UseratTableAdapter useratTableAdapter;
    }
}