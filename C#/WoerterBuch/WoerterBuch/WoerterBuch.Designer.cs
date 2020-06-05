namespace WoerterBuch
{
    partial class BackGround
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.tbEnglishWord = new System.Windows.Forms.TextBox();
            this.lbGermanWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(329, 63);
            this.btnHinzufügen.Margin = new System.Windows.Forms.Padding(4);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(100, 28);
            this.btnHinzufügen.TabIndex = 0;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Location = new System.Drawing.Point(344, 18);
            this.labelTranslation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(85, 17);
            this.labelTranslation.TabIndex = 1;
            this.labelTranslation.Text = "DE < > ENG";
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(73, 15);
            this.tbGermanWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(195, 22);
            this.tbGermanWord.TabIndex = 2;
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Location = new System.Drawing.Point(528, 15);
            this.tbEnglishWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(243, 22);
            this.tbEnglishWord.TabIndex = 3;
            // 
            // lbGermanWords
            // 
            this.lbGermanWords.FormattingEnabled = true;
            this.lbGermanWords.ItemHeight = 16;
            this.lbGermanWords.Location = new System.Drawing.Point(73, 190);
            this.lbGermanWords.Margin = new System.Windows.Forms.Padding(4);
            this.lbGermanWords.Name = "lbGermanWords";
            this.lbGermanWords.Size = new System.Drawing.Size(159, 244);
            this.lbGermanWords.TabIndex = 4;
            this.lbGermanWords.SelectedIndexChanged += new System.EventHandler(this.lbGermanWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(319, 190);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(192, 22);
            this.tbTranslation.TabIndex = 5;
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(332, 98);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(100, 30);
            this.btnExportCSV.TabIndex = 6;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(332, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lbGermanWords);
            this.Controls.Add(this.tbEnglishWord);
            this.Controls.Add(this.tbGermanWord);
            this.Controls.Add(this.labelTranslation);
            this.Controls.Add(this.btnHinzufügen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BackGround";
            this.Text = "WörterBuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Label labelTranslation;
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbEnglishWord;
        private System.Windows.Forms.ListBox lbGermanWords;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnSearch;
    }
}

