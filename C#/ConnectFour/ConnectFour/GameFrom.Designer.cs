namespace ConnectFour
{
    partial class GameFrom
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
            this.buttonRow1 = new System.Windows.Forms.Button();
            this.buttonRow2 = new System.Windows.Forms.Button();
            this.buttonRow7 = new System.Windows.Forms.Button();
            this.buttonRow6 = new System.Windows.Forms.Button();
            this.buttonRow5 = new System.Windows.Forms.Button();
            this.buttonRow4 = new System.Windows.Forms.Button();
            this.buttonRow3 = new System.Windows.Forms.Button();
            this.labelStopWatch = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelHowIsMove = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonRow1
            // 
            this.buttonRow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRow1.Location = new System.Drawing.Point(200, 110);
            this.buttonRow1.Name = "buttonRow1";
            this.buttonRow1.Size = new System.Drawing.Size(40, 40);
            this.buttonRow1.TabIndex = 1;
            this.buttonRow1.Text = "1";
            this.buttonRow1.UseVisualStyleBackColor = true;
            this.buttonRow1.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRow2
            // 
            this.buttonRow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRow2.Location = new System.Drawing.Point(268, 110);
            this.buttonRow2.Name = "buttonRow2";
            this.buttonRow2.Size = new System.Drawing.Size(40, 40);
            this.buttonRow2.TabIndex = 2;
            this.buttonRow2.Text = "2";
            this.buttonRow2.UseVisualStyleBackColor = true;
            this.buttonRow2.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRow7
            // 
            this.buttonRow7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRow7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRow7.Location = new System.Drawing.Point(608, 110);
            this.buttonRow7.Name = "buttonRow7";
            this.buttonRow7.Size = new System.Drawing.Size(40, 40);
            this.buttonRow7.TabIndex = 7;
            this.buttonRow7.Text = "7";
            this.buttonRow7.UseVisualStyleBackColor = true;
            this.buttonRow7.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRow6
            // 
            this.buttonRow6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRow6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRow6.Location = new System.Drawing.Point(540, 110);
            this.buttonRow6.Name = "buttonRow6";
            this.buttonRow6.Size = new System.Drawing.Size(40, 40);
            this.buttonRow6.TabIndex = 6;
            this.buttonRow6.Text = "6";
            this.buttonRow6.UseVisualStyleBackColor = true;
            this.buttonRow6.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRow5
            // 
            this.buttonRow5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRow5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRow5.Location = new System.Drawing.Point(472, 110);
            this.buttonRow5.Name = "buttonRow5";
            this.buttonRow5.Size = new System.Drawing.Size(40, 40);
            this.buttonRow5.TabIndex = 5;
            this.buttonRow5.Text = "5";
            this.buttonRow5.UseVisualStyleBackColor = true;
            this.buttonRow5.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRow4
            // 
            this.buttonRow4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRow4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRow4.Location = new System.Drawing.Point(404, 110);
            this.buttonRow4.Name = "buttonRow4";
            this.buttonRow4.Size = new System.Drawing.Size(40, 40);
            this.buttonRow4.TabIndex = 4;
            this.buttonRow4.Text = "4";
            this.buttonRow4.UseVisualStyleBackColor = true;
            this.buttonRow4.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonRow3
            // 
            this.buttonRow3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonRow3.Location = new System.Drawing.Point(336, 110);
            this.buttonRow3.Name = "buttonRow3";
            this.buttonRow3.Size = new System.Drawing.Size(40, 40);
            this.buttonRow3.TabIndex = 3;
            this.buttonRow3.Text = "3";
            this.buttonRow3.UseVisualStyleBackColor = true;
            this.buttonRow3.Click += new System.EventHandler(this.button_Click);
            // 
            // labelStopWatch
            // 
            this.labelStopWatch.AutoSize = true;
            this.labelStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelStopWatch.Location = new System.Drawing.Point(338, 9);
            this.labelStopWatch.Name = "labelStopWatch";
            this.labelStopWatch.Size = new System.Drawing.Size(174, 46);
            this.labelStopWatch.TabIndex = 8;
            this.labelStopWatch.Text = "00:00:00";
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonStart.Location = new System.Drawing.Point(200, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 43);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonQuit.Location = new System.Drawing.Point(564, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(84, 43);
            this.buttonQuit.TabIndex = 10;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelHowIsMove
            // 
            this.labelHowIsMove.AutoSize = true;
            this.labelHowIsMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelHowIsMove.Location = new System.Drawing.Point(355, 66);
            this.labelHowIsMove.Name = "labelHowIsMove";
            this.labelHowIsMove.Size = new System.Drawing.Size(144, 25);
            this.labelHowIsMove.TabIndex = 11;
            this.labelHowIsMove.Text = "How is in Move";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelPlayer2.Location = new System.Drawing.Point(678, 66);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(140, 25);
            this.labelPlayer2.TabIndex = 12;
            this.labelPlayer2.Text = "Player 2 Name";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelPlayer1.Location = new System.Drawing.Point(23, 66);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(140, 25);
            this.labelPlayer1.TabIndex = 13;
            this.labelPlayer1.Text = "Player 1 Name";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxPlayer1.Location = new System.Drawing.Point(23, 121);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(140, 30);
            this.textBoxPlayer1.TabIndex = 14;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxPlayer2.Location = new System.Drawing.Point(683, 121);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(140, 30);
            this.textBoxPlayer2.TabIndex = 15;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GameFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(875, 698);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelHowIsMove);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelStopWatch);
            this.Controls.Add(this.buttonRow3);
            this.Controls.Add(this.buttonRow4);
            this.Controls.Add(this.buttonRow5);
            this.Controls.Add(this.buttonRow6);
            this.Controls.Add(this.buttonRow7);
            this.Controls.Add(this.buttonRow2);
            this.Controls.Add(this.buttonRow1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GameFrom";
            this.Text = "4_Wins!";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameFrom_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRow1;
        private System.Windows.Forms.Button buttonRow2;
        private System.Windows.Forms.Button buttonRow7;
        private System.Windows.Forms.Button buttonRow6;
        private System.Windows.Forms.Button buttonRow5;
        private System.Windows.Forms.Button buttonRow4;
        private System.Windows.Forms.Button buttonRow3;
        private System.Windows.Forms.Label labelStopWatch;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelHowIsMove;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Timer timer;
    }
}

