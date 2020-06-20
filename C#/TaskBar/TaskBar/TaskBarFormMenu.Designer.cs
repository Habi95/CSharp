namespace TaskBar
{
    partial class TaskBarFormMenu
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
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.timerNow2 = new System.Windows.Forms.Timer(this.components);
            this.listBoxToDos = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonDutyOnDate = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.AutoSize = true;
            this.labelPlaceholder.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholder.Location = new System.Drawing.Point(99, 9);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Size = new System.Drawing.Size(20, 28);
            this.labelPlaceholder.TabIndex = 5;
            this.labelPlaceholder.Text = "/";
            this.labelPlaceholder.UseMnemonic = false;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(125, 9);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(108, 28);
            this.Datelabel.TabIndex = 4;
            this.Datelabel.Text = "01.01.2020";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.Location = new System.Drawing.Point(7, 9);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(86, 28);
            this.Timelabel.TabIndex = 3;
            this.Timelabel.Text = "00:00:00";
            this.Timelabel.UseMnemonic = false;
            // 
            // timerNow2
            // 
            this.timerNow2.Interval = 1000;
            this.timerNow2.Tick += new System.EventHandler(this.timerNow2_Tick);
            // 
            // listBoxToDos
            // 
            this.listBoxToDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listBoxToDos.FormattingEnabled = true;
            this.listBoxToDos.ItemHeight = 24;
            this.listBoxToDos.Location = new System.Drawing.Point(12, 78);
            this.listBoxToDos.Name = "listBoxToDos";
            this.listBoxToDos.Size = new System.Drawing.Size(465, 244);
            this.listBoxToDos.TabIndex = 6;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 328);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(106, 23);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 46);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker.TabIndex = 8;
            // 
            // buttonDutyOnDate
            // 
            this.buttonDutyOnDate.Location = new System.Drawing.Point(139, 46);
            this.buttonDutyOnDate.Name = "buttonDutyOnDate";
            this.buttonDutyOnDate.Size = new System.Drawing.Size(137, 26);
            this.buttonDutyOnDate.TabIndex = 9;
            this.buttonDutyOnDate.Text = "Show Duty By Date =>";
            this.buttonDutyOnDate.UseVisualStyleBackColor = true;
            this.buttonDutyOnDate.Click += new System.EventHandler(this.buttonDutyOnDate_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.Location = new System.Drawing.Point(282, 46);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(126, 26);
            this.buttonToday.TabIndex = 10;
            this.buttonToday.Text = "Show Duty Today =>";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(124, 328);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(83, 23);
            this.buttonShowAll.TabIndex = 11;
            this.buttonShowAll.Text = "Reload";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(213, 328);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // TaskBarFormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(591, 477);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonToday);
            this.Controls.Add(this.buttonDutyOnDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxToDos);
            this.Controls.Add(this.labelPlaceholder);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.Timelabel);
            this.Name = "TaskBarFormMenu";
            this.Text = "TaskBarFormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlaceholder;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Timer timerNow2;
        private System.Windows.Forms.ListBox listBoxToDos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonDutyOnDate;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonRemove;
    }
}