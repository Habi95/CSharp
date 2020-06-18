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
            this.components = new System.ComponentModel.Container();
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
            this.buttonDB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGerman = new System.Windows.Forms.Label();
            this.comboBoxLang1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLang2 = new System.Windows.Forms.ComboBox();
            this.textBoxOutput1 = new System.Windows.Forms.TextBox();
            this.textBoxOutput2 = new System.Windows.Forms.TextBox();
            this.buttonImportDB = new System.Windows.Forms.Button();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdate = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(332, 65);
            this.btnHinzufügen.Margin = new System.Windows.Forms.Padding(4);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(100, 28);
            this.btnHinzufügen.TabIndex = 0;
            this.btnHinzufügen.Text = "ADDEN";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Location = new System.Drawing.Point(643, 71);
            this.labelTranslation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(62, 16);
            this.labelTranslation.TabIndex = 1;
            this.labelTranslation.Text = "provided";
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(35, 98);
            this.tbGermanWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(195, 22);
            this.tbGermanWord.TabIndex = 2;
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Location = new System.Drawing.Point(515, 98);
            this.tbEnglishWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(243, 22);
            this.tbEnglishWord.TabIndex = 3;
            // 
            // lbGermanWords
            // 
            this.lbGermanWords.FormattingEnabled = true;
            this.lbGermanWords.ItemHeight = 16;
            this.lbGermanWords.Location = new System.Drawing.Point(348, 224);
            this.lbGermanWords.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSearch.Location = new System.Drawing.Point(37, 218);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(193, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(38, 190);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(192, 22);
            this.textBoxSearch.TabIndex = 10;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(110, 150);
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
            this.listBoxAlphabet.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlphabet.Name = "listBoxAlphabet";
            this.listBoxAlphabet.Size = new System.Drawing.Size(52, 244);
            this.listBoxAlphabet.TabIndex = 12;
            this.listBoxAlphabet.SelectedIndexChanged += new System.EventHandler(this.listBoxAlphabet_SelectedIndexChanged);
            // 
            // labelEngAusgabe
            // 
            this.labelEngAusgabe.AutoSize = true;
            this.labelEngAusgabe.Location = new System.Drawing.Point(672, 201);
            this.labelEngAusgabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEngAusgabe.Name = "labelEngAusgabe";
            this.labelEngAusgabe.Size = new System.Drawing.Size(46, 16);
            this.labelEngAusgabe.TabIndex = 13;
            this.labelEngAusgabe.Text = "Output";
            // 
            // listBoxTranslation
            // 
            this.listBoxTranslation.FormattingEnabled = true;
            this.listBoxTranslation.ItemHeight = 16;
            this.listBoxTranslation.Location = new System.Drawing.Point(571, 224);
            this.listBoxTranslation.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTranslation.Name = "listBoxTranslation";
            this.listBoxTranslation.Size = new System.Drawing.Size(187, 244);
            this.listBoxTranslation.TabIndex = 14;
            this.listBoxTranslation.SelectedIndexChanged += new System.EventHandler(this.listBoxTranslation_SelectedIndexChanged);
            // 
            // labelGerAusgabe
            // 
            this.labelGerAusgabe.AutoSize = true;
            this.labelGerAusgabe.Location = new System.Drawing.Point(449, 196);
            this.labelGerAusgabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGerAusgabe.Name = "labelGerAusgabe";
            this.labelGerAusgabe.Size = new System.Drawing.Size(46, 16);
            this.labelGerAusgabe.TabIndex = 15;
            this.labelGerAusgabe.Text = "Output";
            // 
            // buttonDB
            // 
            this.buttonDB.Location = new System.Drawing.Point(332, 134);
            this.buttonDB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(100, 32);
            this.buttonDB.TabIndex = 16;
            this.buttonDB.Text = "Import CSV";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.buttonImportCsv_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGerman
            // 
            this.labelGerman.AutoSize = true;
            this.labelGerman.Location = new System.Drawing.Point(163, 71);
            this.labelGerman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGerman.Name = "labelGerman";
            this.labelGerman.Size = new System.Drawing.Size(62, 16);
            this.labelGerman.TabIndex = 18;
            this.labelGerman.Text = "provided";
            // 
            // comboBoxLang1
            // 
            this.comboBoxLang1.FormattingEnabled = true;
            this.comboBoxLang1.Location = new System.Drawing.Point(35, 63);
            this.comboBoxLang1.Name = "comboBoxLang1";
            this.comboBoxLang1.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLang1.TabIndex = 20;
            this.comboBoxLang1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxLang2
            // 
            this.comboBoxLang2.FormattingEnabled = true;
            this.comboBoxLang2.Location = new System.Drawing.Point(515, 63);
            this.comboBoxLang2.Name = "comboBoxLang2";
            this.comboBoxLang2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLang2.TabIndex = 21;
            this.comboBoxLang2.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang2_SelectedIndexChanged);
            // 
            // textBoxOutput1
            // 
            this.textBoxOutput1.Location = new System.Drawing.Point(348, 190);
            this.textBoxOutput1.Name = "textBoxOutput1";
            this.textBoxOutput1.Size = new System.Drawing.Size(94, 22);
            this.textBoxOutput1.TabIndex = 22;
            // 
            // textBoxOutput2
            // 
            this.textBoxOutput2.Location = new System.Drawing.Point(571, 195);
            this.textBoxOutput2.Name = "textBoxOutput2";
            this.textBoxOutput2.Size = new System.Drawing.Size(94, 22);
            this.textBoxOutput2.TabIndex = 23;
            // 
            // buttonImportDB
            // 
            this.buttonImportDB.Location = new System.Drawing.Point(38, 295);
            this.buttonImportDB.Name = "buttonImportDB";
            this.buttonImportDB.Size = new System.Drawing.Size(192, 27);
            this.buttonImportDB.TabIndex = 24;
            this.buttonImportDB.Text = "Import DB";
            this.buttonImportDB.UseVisualStyleBackColor = true;
            this.buttonImportDB.Click += new System.EventHandler(this.buttonImportDB_Click);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(40, 339);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(189, 22);
            this.textBoxDelete.TabIndex = 25;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(81, 367);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 31);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(81, 443);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(108, 31);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUpdate
            // 
            this.textBoxUpdate.Location = new System.Drawing.Point(37, 415);
            this.textBoxUpdate.Name = "textBoxUpdate";
            this.textBoxUpdate.Size = new System.Drawing.Size(189, 22);
            this.textBoxUpdate.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.buttonImportDB);
            this.Controls.Add(this.textBoxOutput2);
            this.Controls.Add(this.textBoxOutput1);
            this.Controls.Add(this.comboBoxLang2);
            this.Controls.Add(this.comboBoxLang1);
            this.Controls.Add(this.labelGerman);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDB);
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
            this.Load += new System.EventHandler(this.BackGround_Load);
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
        private System.Windows.Forms.Button buttonDB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelGerman;
        private System.Windows.Forms.ComboBox comboBoxLang1;
        private System.Windows.Forms.ComboBox comboBoxLang2;
        private System.Windows.Forms.TextBox textBoxOutput1;
        private System.Windows.Forms.TextBox textBoxOutput2;
        private System.Windows.Forms.Button buttonImportDB;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

