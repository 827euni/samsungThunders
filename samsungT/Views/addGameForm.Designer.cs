namespace samsungT
{
    partial class addGameForm
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
            this.resister = new System.Windows.Forms.Button();
            this.homeScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateGame = new System.Windows.Forms.DateTimePicker();
            this.awayScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HomePick = new System.Windows.Forms.ComboBox();
            this.AwayPick = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // resister
            // 
            this.resister.Location = new System.Drawing.Point(149, 296);
            this.resister.Name = "resister";
            this.resister.Size = new System.Drawing.Size(75, 23);
            this.resister.TabIndex = 17;
            this.resister.Text = "경기등록";
            this.resister.UseVisualStyleBackColor = true;
            this.resister.Click += new System.EventHandler(this.resister_Click);
            // 
            // homeScore
            // 
            this.homeScore.Location = new System.Drawing.Point(167, 229);
            this.homeScore.Name = "homeScore";
            this.homeScore.Size = new System.Drawing.Size(100, 21);
            this.homeScore.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "홈 점수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "어웨이 팀";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "홈 팀";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "경기 날짜";
            // 
            // dateGame
            // 
            this.dateGame.Location = new System.Drawing.Point(167, 130);
            this.dateGame.Name = "dateGame";
            this.dateGame.Size = new System.Drawing.Size(200, 21);
            this.dateGame.TabIndex = 18;
            // 
            // awayScore
            // 
            this.awayScore.Location = new System.Drawing.Point(167, 256);
            this.awayScore.Name = "awayScore";
            this.awayScore.Size = new System.Drawing.Size(100, 21);
            this.awayScore.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "어웨이 점수";
            // 
            // HomePick
            // 
            this.HomePick.FormattingEnabled = true;
            this.HomePick.Location = new System.Drawing.Point(167, 163);
            this.HomePick.Name = "HomePick";
            this.HomePick.Size = new System.Drawing.Size(115, 20);
            this.HomePick.TabIndex = 21;
            // 
            // AwayPick
            // 
            this.AwayPick.FormattingEnabled = true;
            this.AwayPick.Location = new System.Drawing.Point(167, 195);
            this.AwayPick.Name = "AwayPick";
            this.AwayPick.Size = new System.Drawing.Size(115, 20);
            this.AwayPick.TabIndex = 22;
            // 
            // addGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.AwayPick);
            this.Controls.Add(this.HomePick);
            this.Controls.Add(this.awayScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateGame);
            this.Controls.Add(this.resister);
            this.Controls.Add(this.homeScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addGame";
            this.Text = "addGame";
            this.Load += new System.EventHandler(this.addGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resister;
        private System.Windows.Forms.TextBox homeScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateGame;
        private System.Windows.Forms.TextBox awayScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox HomePick;
        private System.Windows.Forms.ComboBox AwayPick;
    }
}