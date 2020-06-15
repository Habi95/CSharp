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
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.listBoxAlphabet = new System.Windows.Forms.ListBox();
            this.labelEngAusgabe = new System.Windows.Forms.Label();
            this.listBoxTranslation = new System.Windows.Forms.ListBox();
            this.labelGerAusgabe = new System.Windows.Forms.Label();
            this.buttonImportCsv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGerman = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(329, 63);
            this.btnHinzufügen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(100, 28);
            this.btnHinzufügen.TabIndex = 0;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Location = new System.Drawing.Point(580, 63);
            this.labelTranslation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(109, 16);
            this.labelTranslation.TabIndex = 1;
            this.labelTranslation.Text = "English provided";
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(35, 98);
            this.tbGermanWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(195, 22);
            this.tbGermanWord.TabIndex = 2;
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Location = new System.Drawing.Point(515, 98);
            this.tbEnglishWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(243, 22);
            this.tbEnglishWord.TabIndex = 3;
            // 
            // lbGermanWords
            // 
            this.lbGermanWords.FormattingEnabled = true;
            this.lbGermanWords.ItemHeight = 16;
            this.lbGermanWords.Location = new System.Drawing.Point(348, 224);
            this.lbGermanWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbGermanWords.Name = "lbGermanWords";
            this.lbGermanWords.Size = new System.Drawing.Size(159, 244);
            this.lbGermanWords.TabIndex = 4;
            this.lbGermanWords.SelectedIndexChanged += new System.EventHandler(this.lbGermanWords_SelectedIndexChanged);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(332, 98);
            this.btnExportCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(100, 30);
            this.btnExportCSV.TabIndex = 6;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(37, 254);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(193, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(37, 224);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(192, 22);
            this.textBoxSearch.TabIndex = 10;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(97, 190);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(46, 16);
            this.labelSearch.TabIndex = 11;
            this.labelSearch.Text = "Suche";
            // 
            // listBoxAlphabet
            // 
            this.listBoxAlphabet.FormattingEnabled = true;
            this.listBoxAlphabet.ItemHeight = 16;
            this.listBoxAlphabet.Location = new System.Drawing.Point(299, 224);
            this.listBoxAlphabet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxAlphabet.Name = "listBoxAlphabet";
            this.listBoxAlphabet.Size = new System.Drawing.Size(52, 244);
            this.listBoxAlphabet.TabIndex = 12;
            this.listBoxAlphabet.SelectedIndexChanged += new System.EventHandler(this.listBoxAlphabet_SelectedIndexChanged);
            // 
            // labelEngAusgabe
            // 
            this.labelEngAusgabe.AutoSize = true;
            this.labelEngAusgabe.Location = new System.Drawing.Point(612, 190);
            this.labelEngAusgabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEngAusgabe.Name = "labelEngAusgabe";
            this.labelEngAusgabe.Size = new System.Drawing.Size(125, 16);
            this.labelEngAusgabe.TabIndex = 13;
            this.labelEngAusgabe.Text = "Englische Ausgabe";
            // 
            // listBoxTranslation
            // 
            this.listBoxTranslation.FormattingEnabled = true;
            this.listBoxTranslation.ItemHeight = 16;
            this.listBoxTranslation.Location = new System.Drawing.Point(571, 224);
            this.listBoxTranslation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxTranslation.Name = "listBoxTranslation";
            this.listBoxTranslation.Size = new System.Drawing.Size(187, 244);
            this.listBoxTranslation.TabIndex = 14;
            // 
            // labelGerAusgabe
            // 
            this.labelGerAusgabe.AutoSize = true;
            this.labelGerAusgabe.Location = new System.Drawing.Point(328, 190);
            this.labelGerAusgabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGerAusgabe.Name = "labelGerAusgabe";
            this.labelGerAusgabe.Size = new System.Drawing.Size(123, 16);
            this.labelGerAusgabe.TabIndex = 15;
            this.labelGerAusgabe.Text = "Deutsche Ausgabe";
            // 
            // buttonImportCsv
            // 
            this.buttonImportCsv.Location = new System.Drawing.Point(332, 134);
            this.buttonImportCsv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonImportCsv.Name = "buttonImportCsv";
            this.buttonImportCsv.Size = new System.Drawing.Size(97, 32);
            this.buttonImportCsv.TabIndex = 16;
            this.buttonImportCsv.Text = "Import CSV";
            this.buttonImportCsv.UseVisualStyleBackColor = true;
            this.buttonImportCsv.Click += new System.EventHandler(this.buttonImportCsv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Alle Anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGerman
            // 
            this.labelGerman.AutoSize = true;
            this.labelGerman.Location = new System.Drawing.Point(68, 63);
            this.labelGerman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGerman.Name = "labelGerman";
            this.labelGerman.Size = new System.Drawing.Size(117, 16);
            this.labelGerman.TabIndex = 18;
            this.labelGerman.Text = "Deutsch eingeben";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(37, 331);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(192, 27);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.labelGerman);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonImportCsv);
            this.Controls.Add(this.labelGerAusgabe);
            this.Controls.Add(this.listBoxTranslation);
            this.Controls.Add(this.labelEngAusgabe);
            this.Controls.Add(this.listBoxAlphabet);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExportCSV);
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
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ListBox listBoxAlphabet;
        private System.Windows.Forms.Label labelEngAusgabe;
        private System.Windows.Forms.ListBox listBoxTranslation;
        private System.Windows.Forms.Label labelGerAusgabe;
        private System.Windows.Forms.Button buttonImportCsv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelGerman;
        private System.Windows.Forms.Button SaveBtn;
    }
}

