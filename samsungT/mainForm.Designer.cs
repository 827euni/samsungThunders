namespace samsungT
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.resisterPlayer = new System.Windows.Forms.Button();
            this.resisterTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resisterPlayer
            // 
            this.resisterPlayer.Location = new System.Drawing.Point(0, 0);
            this.resisterPlayer.Name = "resisterPlayer";
            this.resisterPlayer.Size = new System.Drawing.Size(117, 33);
            this.resisterPlayer.TabIndex = 0;
            this.resisterPlayer.Text = "썬더스 선수등록";
            this.resisterPlayer.UseVisualStyleBackColor = true;
            this.resisterPlayer.Click += new System.EventHandler(this.resisterPlayer_Click);
            // 
            // resisterTeam
            // 
            this.resisterTeam.Location = new System.Drawing.Point(0, 67);
            this.resisterTeam.Name = "resisterTeam";
            this.resisterTeam.Size = new System.Drawing.Size(117, 33);
            this.resisterTeam.TabIndex = 1;
            this.resisterTeam.Text = "팀 등록";
            this.resisterTeam.UseVisualStyleBackColor = true;
            this.resisterTeam.Click += new System.EventHandler(this.resisterTeam_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resisterTeam);
            this.Controls.Add(this.resisterPlayer);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resisterPlayer;
        private System.Windows.Forms.Button resisterTeam;
    }
}

