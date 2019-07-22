namespace Curs_Valutar
{
    partial class PaginaPrincipala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipala));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActualizareCurs = new System.Windows.Forms.Button();
            this.Conversie = new System.Windows.Forms.Button();
            this.CursCurent = new System.Windows.Forms.Button();
            this.textBoxPagPrincipala = new System.Windows.Forms.TextBox();
            this.BaraMeniu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursCurentMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.conversieMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteBNRMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.dictionarMonedeMeniu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.BaraMeniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = global::Curs_Valutar.Properties.Resources.logo_bnr_panel1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ActualizareCurs);
            this.panel1.Controls.Add(this.Conversie);
            this.panel1.Controls.Add(this.CursCurent);
            this.panel1.Controls.Add(this.textBoxPagPrincipala);
            this.panel1.Controls.Add(this.BaraMeniu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 410);
            this.panel1.TabIndex = 0;
            // 
            // ActualizareCurs
            // 
            this.ActualizareCurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActualizareCurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ActualizareCurs.Location = new System.Drawing.Point(157, 325);
            this.ActualizareCurs.Name = "ActualizareCurs";
            this.ActualizareCurs.Size = new System.Drawing.Size(116, 38);
            this.ActualizareCurs.TabIndex = 0;
            this.ActualizareCurs.Text = "Actualizare curs";
            this.ActualizareCurs.UseVisualStyleBackColor = true;
            this.ActualizareCurs.Click += new System.EventHandler(this.ActualizareCurs_Click);
            // 
            // Conversie
            // 
            this.Conversie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Conversie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Conversie.Location = new System.Drawing.Point(303, 325);
            this.Conversie.Name = "Conversie";
            this.Conversie.Size = new System.Drawing.Size(87, 38);
            this.Conversie.TabIndex = 2;
            this.Conversie.Text = "Conversie";
            this.Conversie.UseVisualStyleBackColor = true;
            this.Conversie.Click += new System.EventHandler(this.DeschideFereastraNoua_Click);
            // 
            // CursCurent
            // 
            this.CursCurent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CursCurent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CursCurent.Location = new System.Drawing.Point(29, 325);
            this.CursCurent.Name = "CursCurent";
            this.CursCurent.Size = new System.Drawing.Size(92, 38);
            this.CursCurent.TabIndex = 1;
            this.CursCurent.Text = "Curs curent";
            this.CursCurent.UseVisualStyleBackColor = true;
            this.CursCurent.Click += new System.EventHandler(this.DeschideFereastraNoua_Click);
            // 
            // textBoxPagPrincipala
            // 
            this.textBoxPagPrincipala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPagPrincipala.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBoxPagPrincipala.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPagPrincipala.Location = new System.Drawing.Point(72, 129);
            this.textBoxPagPrincipala.Multiline = true;
            this.textBoxPagPrincipala.Name = "textBoxPagPrincipala";
            this.textBoxPagPrincipala.Size = new System.Drawing.Size(286, 169);
            this.textBoxPagPrincipala.TabIndex = 3;
            this.textBoxPagPrincipala.Text = resources.GetString("textBoxPagPrincipala.Text");
            // 
            // BaraMeniu
            // 
            this.BaraMeniu.BackColor = System.Drawing.SystemColors.GrayText;
            this.BaraMeniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.goToToolStripMenuItem});
            this.BaraMeniu.Location = new System.Drawing.Point(0, 0);
            this.BaraMeniu.Name = "BaraMeniu";
            this.BaraMeniu.Size = new System.Drawing.Size(416, 24);
            this.BaraMeniu.TabIndex = 4;
            this.BaraMeniu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursCurentMeniu,
            this.conversieMeniu,
            this.iesireMeniu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cursCurentMeniu
            // 
            this.cursCurentMeniu.Name = "cursCurentMeniu";
            this.cursCurentMeniu.Size = new System.Drawing.Size(152, 22);
            this.cursCurentMeniu.Text = "Curs curent";
            this.cursCurentMeniu.Click += new System.EventHandler(this.cursCurentMeniu_Click);
            // 
            // conversieMeniu
            // 
            this.conversieMeniu.Name = "conversieMeniu";
            this.conversieMeniu.Size = new System.Drawing.Size(152, 22);
            this.conversieMeniu.Text = "Conversie";
            this.conversieMeniu.Click += new System.EventHandler(this.conversieMeniu_Click);
            // 
            // iesireMeniu
            // 
            this.iesireMeniu.Name = "iesireMeniu";
            this.iesireMeniu.Size = new System.Drawing.Size(152, 22);
            this.iesireMeniu.Text = "Iesire";
            this.iesireMeniu.Click += new System.EventHandler(this.iesireMeniu_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteBNRMeniu,
            this.dictionarMonedeMeniu});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.goToToolStripMenuItem.Text = "Go to";
            // 
            // siteBNRMeniu
            // 
            this.siteBNRMeniu.Name = "siteBNRMeniu";
            this.siteBNRMeniu.Size = new System.Drawing.Size(169, 22);
            this.siteBNRMeniu.Text = "Site BNR";
            this.siteBNRMeniu.Click += new System.EventHandler(this.siteBNRMeniu_Click);
            // 
            // dictionarMonedeMeniu
            // 
            this.dictionarMonedeMeniu.Name = "dictionarMonedeMeniu";
            this.dictionarMonedeMeniu.Size = new System.Drawing.Size(169, 22);
            this.dictionarMonedeMeniu.Text = "Dictionar monede";
            this.dictionarMonedeMeniu.Click += new System.EventHandler(this.dictionarMonedeMeniu_Click);
            // 
            // PaginaPrincipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(416, 410);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaginaPrincipala";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertor&Curs Valutar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BaraMeniu.ResumeLayout(false);
            this.BaraMeniu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Conversie;
        private System.Windows.Forms.Button CursCurent;
        private System.Windows.Forms.TextBox textBoxPagPrincipala;
        private System.Windows.Forms.Button ActualizareCurs;
        private System.Windows.Forms.MenuStrip BaraMeniu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursCurentMeniu;
        private System.Windows.Forms.ToolStripMenuItem conversieMeniu;
        private System.Windows.Forms.ToolStripMenuItem iesireMeniu;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteBNRMeniu;
        private System.Windows.Forms.ToolStripMenuItem dictionarMonedeMeniu;
    }
}

