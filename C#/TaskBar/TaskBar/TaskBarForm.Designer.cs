namespace TaskBar
{
    partial class TaskBarForm
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
            this.Timelabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxTask = new System.Windows.Forms.RichTextBox();
            this.buttonAdded = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.Location = new System.Drawing.Point(12, 9);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(86, 28);
            this.Timelabel.TabIndex = 0;
            this.Timelabel.Text = "00:00:00";
            this.Timelabel.UseMnemonic = false;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(130, 9);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(108, 28);
            this.Datelabel.TabIndex = 1;
            this.Datelabel.Text = "01.01.2020";
            // 
            // timerNow
            // 
            this.timerNow.Interval = 1000;
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.AutoSize = true;
            this.labelPlaceholder.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholder.Location = new System.Drawing.Point(104, 9);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Size = new System.Drawing.Size(20, 28);
            this.labelPlaceholder.TabIndex = 2;
            this.labelPlaceholder.Text = "/";
            this.labelPlaceholder.UseMnemonic = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // richTextBoxTask
            // 
            this.richTextBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTask.Location = new System.Drawing.Point(17, 101);
            this.richTextBoxTask.Name = "richTextBoxTask";
            this.richTextBoxTask.Size = new System.Drawing.Size(226, 146);
            this.richTextBoxTask.TabIndex = 4;
            this.richTextBoxTask.Text = "";
            // 
            // buttonAdded
            // 
            this.buttonAdded.Location = new System.Drawing.Point(17, 264);
            this.buttonAdded.Name = "buttonAdded";
            this.buttonAdded.Size = new System.Drawing.Size(91, 26);
            this.buttonAdded.TabIndex = 5;
            this.buttonAdded.Text = "Added";
            this.buttonAdded.UseVisualStyleBackColor = true;
            this.buttonAdded.Click += new System.EventHandler(this.buttonAdded_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(17, 296);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(91, 26);
            this.buttonShow.TabIndex = 7;
            this.buttonShow.Text = "Show All";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // TaskBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(265, 367);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAdded);
            this.Controls.Add(this.richTextBoxTask);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelPlaceholder);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Timelabel);
            this.Name = "TaskBarForm";
            this.Text = "TaskBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.Label labelPlaceholder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBoxTask;
        private System.Windows.Forms.Button buttonAdded;
        private System.Windows.Forms.Button buttonShow;
    }
}

