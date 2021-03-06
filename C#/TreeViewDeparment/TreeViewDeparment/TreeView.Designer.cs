﻿namespace TreeViewDeparment
{
    partial class TreeView
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
            this.treeViewDepartment = new System.Windows.Forms.TreeView();
            this.comboBoxParent = new System.Windows.Forms.ComboBox();
            this.textBoxSubDepartment = new System.Windows.Forms.TextBox();
            this.labelSuperior = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxNewSuperior = new System.Windows.Forms.TextBox();
            this.labelNewSuperior = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.SuspendLayout();
            // 
            // treeViewDepartment
            // 
            this.treeViewDepartment.Location = new System.Drawing.Point(39, 12);
            this.treeViewDepartment.Name = "treeViewDepartment";
            this.treeViewDepartment.Size = new System.Drawing.Size(455, 293);
            this.treeViewDepartment.TabIndex = 0;
            this.treeViewDepartment.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewDepartment_ItemDrag);
            this.treeViewDepartment.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewDepartment_DragDrop);
            this.treeViewDepartment.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewDepartment_DragEnter);
            this.treeViewDepartment.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewDepartment_DragOver);
            // 
            // comboBoxParent
            // 
            this.comboBoxParent.FormattingEnabled = true;
            this.comboBoxParent.Location = new System.Drawing.Point(649, 27);
            this.comboBoxParent.Name = "comboBoxParent";
            this.comboBoxParent.Size = new System.Drawing.Size(139, 21);
            this.comboBoxParent.TabIndex = 1;
            // 
            // textBoxSubDepartment
            // 
            this.textBoxSubDepartment.Location = new System.Drawing.Point(649, 77);
            this.textBoxSubDepartment.Name = "textBoxSubDepartment";
            this.textBoxSubDepartment.Size = new System.Drawing.Size(139, 20);
            this.textBoxSubDepartment.TabIndex = 2;
            // 
            // labelSuperior
            // 
            this.labelSuperior.AutoSize = true;
            this.labelSuperior.Location = new System.Drawing.Point(548, 35);
            this.labelSuperior.Name = "labelSuperior";
            this.labelSuperior.Size = new System.Drawing.Size(46, 13);
            this.labelSuperior.TabIndex = 3;
            this.labelSuperior.Text = "Superior";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(548, 84);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(62, 13);
            this.labelDepartment.TabIndex = 4;
            this.labelDepartment.Text = "Department";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(649, 103);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 25);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add Department";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(649, 134);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(139, 37);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove Department\r\nFrom Superior\r\n";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxNewSuperior
            // 
            this.textBoxNewSuperior.Location = new System.Drawing.Point(649, 54);
            this.textBoxNewSuperior.Name = "textBoxNewSuperior";
            this.textBoxNewSuperior.Size = new System.Drawing.Size(139, 20);
            this.textBoxNewSuperior.TabIndex = 8;
            // 
            // labelNewSuperior
            // 
            this.labelNewSuperior.AutoSize = true;
            this.labelNewSuperior.Location = new System.Drawing.Point(548, 61);
            this.labelNewSuperior.Name = "labelNewSuperior";
            this.labelNewSuperior.Size = new System.Drawing.Size(71, 13);
            this.labelNewSuperior.TabIndex = 9;
            this.labelNewSuperior.Text = "New Superior";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNewSuperior);
            this.Controls.Add(this.textBoxNewSuperior);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelSuperior);
            this.Controls.Add(this.textBoxSubDepartment);
            this.Controls.Add(this.comboBoxParent);
            this.Controls.Add(this.treeViewDepartment);
            this.Name = "TreeView";
            this.Text = "Department Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewDepartment;
        private System.Windows.Forms.ComboBox comboBoxParent;
        private System.Windows.Forms.TextBox textBoxSubDepartment;
        private System.Windows.Forms.Label labelSuperior;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxNewSuperior;
        private System.Windows.Forms.Label labelNewSuperior;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}

