namespace SmartPhone
{
    partial class SmartPhoneForm
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
            this.GoToListBtn = new System.Windows.Forms.Button();
            this.labelTimeHome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GoToListBtn
            // 
            this.GoToListBtn.Location = new System.Drawing.Point(68, 471);
            this.GoToListBtn.Name = "GoToListBtn";
            this.GoToListBtn.Size = new System.Drawing.Size(209, 102);
            this.GoToListBtn.TabIndex = 0;
            this.GoToListBtn.Text = "GoToList";
            this.GoToListBtn.UseVisualStyleBackColor = true;
            this.GoToListBtn.Click += new System.EventHandler(this.GoToListBtn_Click);
            // 
            // labelTimeHome
            // 
            this.labelTimeHome.AutoSize = true;
            this.labelTimeHome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTimeHome.Location = new System.Drawing.Point(292, 9);
            this.labelTimeHome.Name = "labelTimeHome";
            this.labelTimeHome.Size = new System.Drawing.Size(49, 13);
            this.labelTimeHome.TabIndex = 1;
            this.labelTimeHome.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SmartPhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(353, 744);
            this.Controls.Add(this.labelTimeHome);
            this.Controls.Add(this.GoToListBtn);
            this.Name = "SmartPhoneForm";
            this.Text = "HomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToListBtn;
        private System.Windows.Forms.Label labelTimeHome;
        private System.Windows.Forms.Timer timer1;
    }
}

