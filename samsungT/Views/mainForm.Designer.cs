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
            this.listPlayers = new System.Windows.Forms.ListView();
            this.playerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThreePoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeThrow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldGoal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rebounds = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resisterGame = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Assist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // resisterPlayer
            // 
            this.resisterPlayer.Location = new System.Drawing.Point(12, 12);
            this.resisterPlayer.Name = "resisterPlayer";
            this.resisterPlayer.Size = new System.Drawing.Size(117, 33);
            this.resisterPlayer.TabIndex = 0;
            this.resisterPlayer.Text = "썬더스 선수등록";
            this.resisterPlayer.UseVisualStyleBackColor = true;
            this.resisterPlayer.Click += new System.EventHandler(this.resisterPlayer_Click);
            // 
            // resisterTeam
            // 
            this.resisterTeam.Location = new System.Drawing.Point(12, 51);
            this.resisterTeam.Name = "resisterTeam";
            this.resisterTeam.Size = new System.Drawing.Size(117, 33);
            this.resisterTeam.TabIndex = 1;
            this.resisterTeam.Text = "팀 등록";
            this.resisterTeam.UseVisualStyleBackColor = true;
            this.resisterTeam.Click += new System.EventHandler(this.resisterTeam_Click);
            // 
            // listPlayers
            // 
            this.listPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerID,
            this.playerName,
            this.Position,
            this.Score,
            this.ThreePoint,
            this.FreeThrow,
            this.FieldGoal,
            this.Rebounds,
            this.Assist});
            this.listPlayers.HideSelection = false;
            this.listPlayers.Location = new System.Drawing.Point(152, 12);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.Size = new System.Drawing.Size(553, 219);
            this.listPlayers.TabIndex = 2;
            this.listPlayers.UseCompatibleStateImageBehavior = false;
            this.listPlayers.View = System.Windows.Forms.View.Details;
            // 
            // playerID
            // 
            this.playerID.Text = "playerID";
            // 
            // playerName
            // 
            this.playerName.Text = "playerName";
            // 
            // Position
            // 
            this.Position.Text = "Position";
            // 
            // ThreePoint
            // 
            this.ThreePoint.DisplayIndex = 3;
            this.ThreePoint.Text = "ThreePoint";
            // 
            // FreeThrow
            // 
            this.FreeThrow.DisplayIndex = 4;
            this.FreeThrow.Text = "FreeThrow";
            // 
            // FieldGoal
            // 
            this.FieldGoal.DisplayIndex = 5;
            this.FieldGoal.Text = "FieldGoal";
            // 
            // Rebounds
            // 
            this.Rebounds.DisplayIndex = 6;
            this.Rebounds.Text = "Rebound";
            // 
            // resisterGame
            // 
            this.resisterGame.Location = new System.Drawing.Point(12, 90);
            this.resisterGame.Name = "resisterGame";
            this.resisterGame.Size = new System.Drawing.Size(117, 33);
            this.resisterGame.TabIndex = 3;
            this.resisterGame.Text = "경기 등록";
            this.resisterGame.UseVisualStyleBackColor = true;
            this.resisterGame.Click += new System.EventHandler(this.resisterGame_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(129, 256);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // Assist
            // 
            this.Assist.DisplayIndex = 7;
            this.Assist.Text = "Assist";
            // 
            // Score
            // 
            this.Score.DisplayIndex = 8;
            this.Score.Text = "Score";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.resisterGame);
            this.Controls.Add(this.listPlayers);
            this.Controls.Add(this.resisterTeam);
            this.Controls.Add(this.resisterPlayer);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resisterPlayer;
        private System.Windows.Forms.Button resisterTeam;
        private System.Windows.Forms.ListView listPlayers;
        private System.Windows.Forms.ColumnHeader playerID;
        private System.Windows.Forms.ColumnHeader playerName;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader ThreePoint;
        private System.Windows.Forms.ColumnHeader FreeThrow;
        private System.Windows.Forms.ColumnHeader FieldGoal;
        private System.Windows.Forms.ColumnHeader Rebounds;
        private System.Windows.Forms.Button resisterGame;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ColumnHeader Score;
        private System.Windows.Forms.ColumnHeader Assist;
    }
}

