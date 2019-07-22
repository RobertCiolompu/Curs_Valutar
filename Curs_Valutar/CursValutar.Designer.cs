namespace Curs_Valutar
{
    partial class CursValutar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursValutar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.DictionarCurs = new System.Windows.Forms.Button();
            this.CautatiMoneda = new System.Windows.Forms.Label();
            this.textboxValoareMonedaCurs = new System.Windows.Forms.TextBox();
            this.GasesteValoare = new System.Windows.Forms.Button();
            this.textboxMonedaCurs = new System.Windows.Forms.TextBox();
            this.ListaCurs = new System.Windows.Forms.TextBox();
            this.InapoiDinCurs = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BackgroundImage = global::Curs_Valutar.Properties.Resources.logo_bnr_panel1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.DictionarCurs);
            this.panel2.Controls.Add(this.CautatiMoneda);
            this.panel2.Controls.Add(this.textboxValoareMonedaCurs);
            this.panel2.Controls.Add(this.GasesteValoare);
            this.panel2.Controls.Add(this.textboxMonedaCurs);
            this.panel2.Controls.Add(this.ListaCurs);
            this.panel2.Controls.Add(this.InapoiDinCurs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 441);
            this.panel2.TabIndex = 2;
            // 
            // DictionarCurs
            // 
            this.DictionarCurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DictionarCurs.Location = new System.Drawing.Point(253, 156);
            this.DictionarCurs.Name = "DictionarCurs";
            this.DictionarCurs.Size = new System.Drawing.Size(128, 39);
            this.DictionarCurs.TabIndex = 6;
            this.DictionarCurs.Text = "Dictionar monede";
            this.DictionarCurs.UseVisualStyleBackColor = true;
            this.DictionarCurs.Click += new System.EventHandler(this.buttonDenumiri_Click);
            // 
            // CautatiMoneda
            // 
            this.CautatiMoneda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CautatiMoneda.AutoSize = true;
            this.CautatiMoneda.Location = new System.Drawing.Point(251, 227);
            this.CautatiMoneda.Name = "CautatiMoneda";
            this.CautatiMoneda.Size = new System.Drawing.Size(130, 13);
            this.CautatiMoneda.TabIndex = 5;
            this.CautatiMoneda.Text = "Cautati o anumita moneda";
            // 
            // textboxValoareMonedaCurs
            // 
            this.textboxValoareMonedaCurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxValoareMonedaCurs.Location = new System.Drawing.Point(253, 315);
            this.textboxValoareMonedaCurs.Name = "textboxValoareMonedaCurs";
            this.textboxValoareMonedaCurs.ReadOnly = true;
            this.textboxValoareMonedaCurs.Size = new System.Drawing.Size(126, 20);
            this.textboxValoareMonedaCurs.TabIndex = 4;
            // 
            // GasesteValoare
            // 
            this.GasesteValoare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GasesteValoare.Location = new System.Drawing.Point(253, 280);
            this.GasesteValoare.Name = "GasesteValoare";
            this.GasesteValoare.Size = new System.Drawing.Size(103, 23);
            this.GasesteValoare.TabIndex = 3;
            this.GasesteValoare.Text = "Cauta";
            this.GasesteValoare.UseVisualStyleBackColor = true;
            this.GasesteValoare.Click += new System.EventHandler(this.GasesteValoare_Click);
            // 
            // textboxMonedaCurs
            // 
            this.textboxMonedaCurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textboxMonedaCurs.Location = new System.Drawing.Point(253, 243);
            this.textboxMonedaCurs.Name = "textboxMonedaCurs";
            this.textboxMonedaCurs.Size = new System.Drawing.Size(128, 20);
            this.textboxMonedaCurs.TabIndex = 2;
            // 
            // ListaCurs
            // 
            this.ListaCurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListaCurs.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCurs.Location = new System.Drawing.Point(37, 128);
            this.ListaCurs.Multiline = true;
            this.ListaCurs.Name = "ListaCurs";
            this.ListaCurs.ReadOnly = true;
            this.ListaCurs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ListaCurs.Size = new System.Drawing.Size(185, 279);
            this.ListaCurs.TabIndex = 1;
            this.ListaCurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InapoiDinCurs
            // 
            this.InapoiDinCurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InapoiDinCurs.Location = new System.Drawing.Point(253, 353);
            this.InapoiDinCurs.Name = "InapoiDinCurs";
            this.InapoiDinCurs.Size = new System.Drawing.Size(134, 36);
            this.InapoiDinCurs.TabIndex = 0;
            this.InapoiDinCurs.Text = "Inapoi la pagina principala";
            this.InapoiDinCurs.UseVisualStyleBackColor = true;
            this.InapoiDinCurs.Click += new System.EventHandler(this.InapoiLaPagPrincipala_Click);
            // 
            // CursValutar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(429, 441);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CursValutar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "CursValutar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DictionarCurs;
        private System.Windows.Forms.Label CautatiMoneda;
        private System.Windows.Forms.TextBox textboxValoareMonedaCurs;
        private System.Windows.Forms.Button GasesteValoare;
        private System.Windows.Forms.TextBox textboxMonedaCurs;
        public System.Windows.Forms.TextBox ListaCurs;
        private System.Windows.Forms.Button InapoiDinCurs;
    }
}