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
            this.tbProduct.Location = new System.Drawing.Point(51, 85);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(222, 22);
            this.tbProduct.TabIndex = 0;
            // 
            // listBoxShoppingList
            // 
            this.listBoxShoppingList.FormattingEnabled = true;
            this.listBoxShoppingList.ItemHeight = 16;
            this.listBoxShoppingList.Location = new System.Drawing.Point(35, 174);
            this.listBoxShoppingList.Name = "listBoxShoppingList";
            this.listBoxShoppingList.Size = new System.Drawing.Size(285, 244);
            this.listBoxShoppingList.TabIndex = 1;
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(430, 85);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 22);
            this.tbCount.TabIndex = 2;
            // 
            // btnHinzufügen
            // 
            this.btnHinzufügen.Location = new System.Drawing.Point(439, 174);
            this.btnHinzufügen.Name = "btnHinzufügen";
            this.btnHinzufügen.Size = new System.Drawing.Size(91, 39);
            this.btnHinzufügen.TabIndex = 3;
            this.btnHinzufügen.Text = "Hinzufügen";
            this.btnHinzufügen.UseVisualStyleBackColor = true;
            this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(439, 219);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 32);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(439, 257);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(91, 28);
            this.btnExportCSV.TabIndex = 5;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(64, 54);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(57, 17);
            this.labelProduct.TabIndex = 6;
            this.labelProduct.Text = "Product";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(455, 54);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(64, 21);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Anzahl";
            // 
            // labelShoppingList
            // 
            this.labelShoppingList.AutoSize = true;
            this.labelShoppingList.Location = new System.Drawing.Point(76, 144);
            this.labelShoppingList.Name = "labelShoppingList";
            this.labelShoppingList.Size = new System.Drawing.Size(115, 21);
            this.labelShoppingList.TabIndex = 8;
            this.labelShoppingList.Text = "EinkaufsListe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelShoppingList);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnHinzufügen);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.listBoxShoppingList);
            this.Controls.Add(this.tbProduct);
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

