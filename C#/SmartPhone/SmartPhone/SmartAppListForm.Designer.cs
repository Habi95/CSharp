namespace SmartPhone
{
    partial class SmartAppListForm
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
            this.components = new System.ComponentModel.Container();
            this.listBoxApp = new System.Windows.Forms.ListBox();
            this.labelTimeMenu = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBoxApp
            // 
            this.listBoxApp.FormattingEnabled = true;
            this.listBoxApp.Location = new System.Drawing.Point(68, 114);
            this.listBoxApp.Name = "listBoxApp";
            this.listBoxApp.Size = new System.Drawing.Size(194, 199);
            this.listBoxApp.TabIndex = 0;
            this.listBoxApp.SelectedIndexChanged += new System.EventHandler(this.listBoxApp_SelectedIndexChanged);
            // 
            // labelTimeMenu
            // 
            this.labelTimeMenu.AutoSize = true;
            this.labelTimeMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTimeMenu.Location = new System.Drawing.Point(292, 9);
            this.labelTimeMenu.Name = "labelTimeMenu";
            this.labelTimeMenu.Size = new System.Drawing.Size(49, 13);
            this.labelTimeMenu.TabIndex = 2;
            this.labelTimeMenu.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SmartAppListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(353, 744);
            this.Controls.Add(this.labelTimeMenu);
            this.Controls.Add(this.listBoxApp);
            this.Name = "SmartAppListForm";
            this.Text = "Menü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxApp;
        private System.Windows.Forms.Label labelTimeMenu;
        private System.Windows.Forms.Timer timer;
    }
}