namespace samsungT
{
    partial class addTeamForm
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
            this.teamCity = new System.Windows.Forms.TextBox();
            this.teamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resister
            // 
            this.resister.Location = new System.Drawing.Point(149, 217);
            this.resister.Name = "resister";
            this.resister.Size = new System.Drawing.Size(75, 23);
            this.resister.TabIndex = 17;
            this.resister.Text = "선수등록";
            this.resister.UseVisualStyleBackColor = true;
            this.resister.Click += new System.EventHandler(this.resister_Click);
            // 
            // teamCity
            // 
            this.teamCity.Location = new System.Drawing.Point(176, 172);
            this.teamCity.Name = "teamCity";
            this.teamCity.Size = new System.Drawing.Size(100, 21);
            this.teamCity.TabIndex = 14;
            // 
            // teamName
            // 
            this.teamName.Location = new System.Drawing.Point(176, 142);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(100, 21);
            this.teamName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "소속 도시";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "팀 이름";
            // 
            // addTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.resister);
            this.Controls.Add(this.teamCity);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addTeam";
            this.Text = "addTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resister;
        private System.Windows.Forms.TextBox teamCity;
        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}