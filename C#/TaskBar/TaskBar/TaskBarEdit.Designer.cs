namespace TaskBar
{
    partial class TaskBarEdit
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
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonAdded = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.AutoSize = true;
            this.labelPlaceholder.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholder.Location = new System.Drawing.Point(104, 9);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Size = new System.Drawing.Size(20, 28);
            this.labelPlaceholder.TabIndex = 8;
            this.labelPlaceholder.Text = "/";
            this.labelPlaceholder.UseMnemonic = false;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(130, 9);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(108, 28);
            this.Datelabel.TabIndex = 7;
            this.Datelabel.Text = "01.01.2020";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.Location = new System.Drawing.Point(12, 9);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(86, 28);
            this.Timelabel.TabIndex = 6;
            this.Timelabel.Text = "00:00:00";
            this.Timelabel.UseMnemonic = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(47, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(146, 26);
            this.dateTimePicker.TabIndex = 9;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(71, 282);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(91, 26);
            this.buttonShow.TabIndex = 12;
            this.buttonShow.Text = "Show All";
            this.buttonShow.UseVisualStyleBackColor = true;
            // 
            // buttonAdded
            // 
            this.buttonAdded.Location = new System.Drawing.Point(71, 250);
            this.buttonAdded.Name = "buttonAdded";
            this.buttonAdded.Size = new System.Drawing.Size(91, 26);
            this.buttonAdded.TabIndex = 11;
            this.buttonAdded.Text = "Added";
            this.buttonAdded.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(45, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(147, 145);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // TaskBarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(265, 367);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAdded);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelPlaceholder);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Timelabel);
            this.Name = "TaskBarEdit";
            this.Text = "TaskBarEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlaceholder;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonAdded;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}