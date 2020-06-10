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
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.comboBoxApps = new System.Windows.Forms.ComboBox();
            this.Startbtn = new System.Windows.Forms.Button();
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
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(187, 319);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 3;
            this.buttonShowAll.Text = "Alle Anzeigen";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxApps
            // 
            this.comboBoxApps.FormattingEnabled = true;
            this.comboBoxApps.Location = new System.Drawing.Point(68, 75);
            this.comboBoxApps.Name = "comboBoxApps";
            this.comboBoxApps.Size = new System.Drawing.Size(121, 21);
            this.comboBoxApps.TabIndex = 4;
            this.comboBoxApps.SelectedIndexChanged += new System.EventHandler(this.comboBoxApps_SelectedIndexChanged);
            // 
            // Startbtn
            // 
            this.Startbtn.Location = new System.Drawing.Point(68, 318);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(75, 23);
            this.Startbtn.TabIndex = 5;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // SmartAppListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(353, 744);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.comboBoxApps);
            this.Controls.Add(this.buttonShowAll);
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
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.ComboBox comboBoxApps;
        private System.Windows.Forms.Button Startbtn;
    }
}