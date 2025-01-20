namespace samsungT
{
    partial class addPlayerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.playerId = new System.Windows.Forms.TextBox();
            this.playerPosition = new System.Windows.Forms.TextBox();
            this.playerHeight = new System.Windows.Forms.TextBox();
            this.resister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "등번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "포지션";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "키";
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(184, 38);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 21);
            this.playerName.TabIndex = 0;
            // 
            // playerId
            // 
            this.playerId.Location = new System.Drawing.Point(184, 68);
            this.playerId.Name = "playerId";
            this.playerId.Size = new System.Drawing.Size(100, 21);
            this.playerId.TabIndex = 1;
            // 
            // playerPosition
            // 
            this.playerPosition.Location = new System.Drawing.Point(184, 103);
            this.playerPosition.Name = "playerPosition";
            this.playerPosition.Size = new System.Drawing.Size(100, 21);
            this.playerPosition.TabIndex = 2;
            // 
            // playerHeight
            // 
            this.playerHeight.Location = new System.Drawing.Point(184, 134);
            this.playerHeight.Name = "playerHeight";
            this.playerHeight.Size = new System.Drawing.Size(100, 21);
            this.playerHeight.TabIndex = 3;
            // 
            // resister
            // 
            this.resister.Location = new System.Drawing.Point(184, 176);
            this.resister.Name = "resister";
            this.resister.Size = new System.Drawing.Size(75, 23);
            this.resister.TabIndex = 4;
            this.resister.Text = "선수등록";
            this.resister.UseVisualStyleBackColor = true;
            this.resister.Click += new System.EventHandler(this.resister_Click);
            // 
            // addPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 223);
            this.Controls.Add(this.resister);
            this.Controls.Add(this.playerHeight);
            this.Controls.Add(this.playerPosition);
            this.Controls.Add(this.playerId);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addPlayerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.TextBox playerId;
        private System.Windows.Forms.TextBox playerPosition;
        private System.Windows.Forms.TextBox playerHeight;
        private System.Windows.Forms.Button resister;
    }
}