namespace Curs_Valutar
{
    partial class SchimbValutar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchimbValutar));
            this.InapoiDinConvertor = new System.Windows.Forms.Button();
            this.ConvertitiDin = new System.Windows.Forms.Label();
            this.ListaConversie1 = new System.Windows.Forms.ListBox();
            this.textboxSumaDeConvertit = new System.Windows.Forms.TextBox();
            this.IntroducetiSuma = new System.Windows.Forms.Label();
            this.ButonConversie = new System.Windows.Forms.Button();
            this.textboxSumaConvertita = new System.Windows.Forms.TextBox();
            this.SumaConvertita = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Label();
            this.ListaConversie2 = new System.Windows.Forms.ListBox();
            this.ConvertitiIn = new System.Windows.Forms.Label();
            this.MonedaDeConvertitDin = new System.Windows.Forms.Label();
            this.MonedaDeConvertitIn = new System.Windows.Forms.Label();
            this.DictionarSchimb = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InapoiDinConvertor
            // 
            this.InapoiDinConvertor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InapoiDinConvertor.Location = new System.Drawing.Point(36, 341);
            this.InapoiDinConvertor.Name = "InapoiDinConvertor";
            this.InapoiDinConvertor.Size = new System.Drawing.Size(131, 34);
            this.InapoiDinConvertor.TabIndex = 0;
            this.InapoiDinConvertor.Text = "Inapoi la pagina principala";
            this.InapoiDinConvertor.UseVisualStyleBackColor = true;
            this.InapoiDinConvertor.Click += new System.EventHandler(this.InapoiLaPagPrincipala_Click);
            // 
            // ConvertitiDin
            // 
            this.ConvertitiDin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertitiDin.AutoSize = true;
            this.ConvertitiDin.BackColor = System.Drawing.SystemColors.GrayText;
            this.ConvertitiDin.Location = new System.Drawing.Point(35, 100);
            this.ConvertitiDin.Name = "ConvertitiDin";
            this.ConvertitiDin.Size = new System.Drawing.Size(68, 13);
            this.ConvertitiDin.TabIndex = 3;
            this.ConvertitiDin.Text = "Convertiti din";
            // 
            // ListaConversie1
            // 
            this.ListaConversie1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaConversie1.FormattingEnabled = true;
            this.ListaConversie1.Location = new System.Drawing.Point(38, 120);
            this.ListaConversie1.Name = "ListaConversie1";
            this.ListaConversie1.ScrollAlwaysVisible = true;
            this.ListaConversie1.Size = new System.Drawing.Size(128, 108);
            this.ListaConversie1.TabIndex = 5;
            this.ListaConversie1.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // textboxSumaDeConvertit
            // 
            this.textboxSumaDeConvertit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxSumaDeConvertit.Location = new System.Drawing.Point(36, 289);
            this.textboxSumaDeConvertit.Multiline = true;
            this.textboxSumaDeConvertit.Name = "textboxSumaDeConvertit";
            this.textboxSumaDeConvertit.Size = new System.Drawing.Size(128, 32);
            this.textboxSumaDeConvertit.TabIndex = 7;
            // 
            // IntroducetiSuma
            // 
            this.IntroducetiSuma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IntroducetiSuma.AutoSize = true;
            this.IntroducetiSuma.BackColor = System.Drawing.SystemColors.GrayText;
            this.IntroducetiSuma.Location = new System.Drawing.Point(35, 273);
            this.IntroducetiSuma.Name = "IntroducetiSuma";
            this.IntroducetiSuma.Size = new System.Drawing.Size(85, 13);
            this.IntroducetiSuma.TabIndex = 8;
            this.IntroducetiSuma.Text = "Introduceti suma";
            // 
            // ButonConversie
            // 
            this.ButonConversie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButonConversie.Location = new System.Drawing.Point(190, 289);
            this.ButonConversie.Name = "ButonConversie";
            this.ButonConversie.Size = new System.Drawing.Size(45, 32);
            this.ButonConversie.TabIndex = 9;
            this.ButonConversie.Text = "=";
            this.ButonConversie.UseVisualStyleBackColor = true;
            this.ButonConversie.Click += new System.EventHandler(this.Conversie_Click);
            // 
            // textboxSumaConvertita
            // 
            this.textboxSumaConvertita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxSumaConvertita.Location = new System.Drawing.Point(262, 289);
            this.textboxSumaConvertita.Multiline = true;
            this.textboxSumaConvertita.Name = "textboxSumaConvertita";
            this.textboxSumaConvertita.Size = new System.Drawing.Size(128, 32);
            this.textboxSumaConvertita.TabIndex = 10;
            // 
            // SumaConvertita
            // 
            this.SumaConvertita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SumaConvertita.AutoSize = true;
            this.SumaConvertita.BackColor = System.Drawing.SystemColors.GrayText;
            this.SumaConvertita.Location = new System.Drawing.Point(259, 273);
            this.SumaConvertita.Name = "SumaConvertita";
            this.SumaConvertita.Size = new System.Drawing.Size(84, 13);
            this.SumaConvertita.TabIndex = 11;
            this.SumaConvertita.Text = "Suma convertita";
            // 
            // Convert
            // 
            this.Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Convert.AutoSize = true;
            this.Convert.BackColor = System.Drawing.SystemColors.GrayText;
            this.Convert.Location = new System.Drawing.Point(191, 273);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(44, 13);
            this.Convert.TabIndex = 12;
            this.Convert.Text = "Convert";
            // 
            // ListaConversie2
            // 
            this.ListaConversie2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaConversie2.FormattingEnabled = true;
            this.ListaConversie2.Location = new System.Drawing.Point(262, 120);
            this.ListaConversie2.Name = "ListaConversie2";
            this.ListaConversie2.ScrollAlwaysVisible = true;
            this.ListaConversie2.Size = new System.Drawing.Size(128, 108);
            this.ListaConversie2.TabIndex = 13;
            this.ListaConversie2.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // ConvertitiIn
            // 
            this.ConvertitiIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertitiIn.AutoSize = true;
            this.ConvertitiIn.BackColor = System.Drawing.SystemColors.GrayText;
            this.ConvertitiIn.Location = new System.Drawing.Point(259, 104);
            this.ConvertitiIn.Name = "ConvertitiIn";
            this.ConvertitiIn.Size = new System.Drawing.Size(62, 13);
            this.ConvertitiIn.TabIndex = 14;
            this.ConvertitiIn.Text = "Convertiti in";
            // 
            // MonedaDeConvertitDin
            // 
            this.MonedaDeConvertitDin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MonedaDeConvertitDin.AutoSize = true;
            this.MonedaDeConvertitDin.BackColor = System.Drawing.SystemColors.GrayText;
            this.MonedaDeConvertitDin.Location = new System.Drawing.Point(39, 241);
            this.MonedaDeConvertitDin.Name = "MonedaDeConvertitDin";
            this.MonedaDeConvertitDin.Size = new System.Drawing.Size(0, 13);
            this.MonedaDeConvertitDin.TabIndex = 15;
            // 
            // MonedaDeConvertitIn
            // 
            this.MonedaDeConvertitIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MonedaDeConvertitIn.AutoSize = true;
            this.MonedaDeConvertitIn.BackColor = System.Drawing.SystemColors.GrayText;
            this.MonedaDeConvertitIn.Location = new System.Drawing.Point(259, 241);
            this.MonedaDeConvertitIn.Name = "MonedaDeConvertitIn";
            this.MonedaDeConvertitIn.Size = new System.Drawing.Size(0, 13);
            this.MonedaDeConvertitIn.TabIndex = 16;
            // 
            // DictionarSchimb
            // 
            this.DictionarSchimb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DictionarSchimb.Location = new System.Drawing.Point(38, 38);
            this.DictionarSchimb.Name = "DictionarSchimb";
            this.DictionarSchimb.Size = new System.Drawing.Size(131, 34);
            this.DictionarSchimb.TabIndex = 17;
            this.DictionarSchimb.Text = "Dictionar monede";
            this.DictionarSchimb.UseVisualStyleBackColor = true;
            this.DictionarSchimb.Click += new System.EventHandler(this.buttonDenumiri_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.BackgroundImage = global::Curs_Valutar.Properties.Resources.logo_bnr_panel2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.DictionarSchimb);
            this.panel3.Controls.Add(this.MonedaDeConvertitIn);
            this.panel3.Controls.Add(this.MonedaDeConvertitDin);
            this.panel3.Controls.Add(this.ConvertitiIn);
            this.panel3.Controls.Add(this.ListaConversie2);
            this.panel3.Controls.Add(this.Convert);
            this.panel3.Controls.Add(this.SumaConvertita);
            this.panel3.Controls.Add(this.textboxSumaConvertita);
            this.panel3.Controls.Add(this.ButonConversie);
            this.panel3.Controls.Add(this.IntroducetiSuma);
            this.panel3.Controls.Add(this.textboxSumaDeConvertit);
            this.panel3.Controls.Add(this.ListaConversie1);
            this.panel3.Controls.Add(this.ConvertitiDin);
            this.panel3.Controls.Add(this.InapoiDinConvertor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 437);
            this.panel3.TabIndex = 3;
            // 
            // SchimbValutar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(426, 437);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchimbValutar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ConvertorValutar";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InapoiDinConvertor;
        private System.Windows.Forms.Label ConvertitiDin;
        private System.Windows.Forms.ListBox ListaConversie1;
        private System.Windows.Forms.TextBox textboxSumaDeConvertit;
        private System.Windows.Forms.Label IntroducetiSuma;
        private System.Windows.Forms.Button ButonConversie;
        private System.Windows.Forms.TextBox textboxSumaConvertita;
        private System.Windows.Forms.Label SumaConvertita;
        private System.Windows.Forms.Label Convert;
        private System.Windows.Forms.ListBox ListaConversie2;
        private System.Windows.Forms.Label ConvertitiIn;
        private System.Windows.Forms.Label MonedaDeConvertitDin;
        private System.Windows.Forms.Label MonedaDeConvertitIn;
        private System.Windows.Forms.Button DictionarSchimb;
        private System.Windows.Forms.Panel panel3;
    }
}