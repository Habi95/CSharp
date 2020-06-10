namespace Einkaufswagen
{
    partial class Form1
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
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.listBoxShoppingList = new System.Windows.Forms.ListBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btnHinzufügen = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelShoppingList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(38, 69);
            this.tbProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(168, 20);
            this.tbProduct.TabIndex = 0;
            // 
            // listBoxShoppingList
            // 
            this.listBoxShoppingList.FormattingEnabled = true;
            this.listBoxShoppingList.Location = new System.Drawing.Point(26, 141);
            this.listBoxShoppingList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxShoppingList.Name = "listBoxShoppingList";
            this.listBoxShoppingList.Size = new System.Drawing.Size(215, 199);
            this.listBoxShoppingList.TabIndex = 1;
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(322, 69);
            this.tbCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(76, 20);
            this.tbCount.TabIndex = 2;
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(329, 141);
            this.btnHinzufügen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(68, 32);
            this.btnHinzufügen.TabIndex = 3;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(329, 178);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 26);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(329, 209);
            this.btnExportCSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(68, 23);
            this.btnExportCSV.TabIndex = 5;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(48, 44);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(44, 13);
            this.labelProduct.TabIndex = 6;
            this.labelProduct.Text = "Product";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(341, 44);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(39, 13);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Anzahl";
            // 
            // labelShoppingList
            // 
            this.labelShoppingList.AutoSize = true;
            this.labelShoppingList.Location = new System.Drawing.Point(57, 117);
            this.labelShoppingList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShoppingList.Name = "labelShoppingList";
            this.labelShoppingList.Size = new System.Drawing.Size(70, 13);
            this.labelShoppingList.TabIndex = 8;
            this.labelShoppingList.Text = "EinkaufsListe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelShoppingList);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.listBoxShoppingList);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.btnHinzufügen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Einkaufsliste Erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.ListBox listBoxShoppingList;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button btnHinzufügen;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelShoppingList;
    }
}

