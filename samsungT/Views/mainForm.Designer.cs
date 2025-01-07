﻿namespace samsungT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.resisterPlayer = new System.Windows.Forms.Button();
            this.resisterTeam = new System.Windows.Forms.Button();
            this.listPlayers = new System.Windows.Forms.ListView();
            this.playerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThreePoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FreeThrow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldGoal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rebound = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Assist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resisterGame = new System.Windows.Forms.Button();
            this.resisterGamePlayer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.winRateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SKButton = new System.Windows.Forms.Button();
            this.KCCButton = new System.Windows.Forms.Button();
            this.MOBISButton = new System.Windows.Forms.Button();
            this.SONOButton = new System.Windows.Forms.Button();
            this.DBButton = new System.Windows.Forms.Button();
            this.KOGASButton = new System.Windows.Forms.Button();
            this.KGCButton = new System.Windows.Forms.Button();
            this.KTButton = new System.Windows.Forms.Button();
            this.LGButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.winRateText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.winRateChart)).BeginInit();
            this.SuspendLayout();
            // 
            // resisterPlayer
            // 
            this.resisterPlayer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resisterPlayer.Location = new System.Drawing.Point(12, 146);
            this.resisterPlayer.Name = "resisterPlayer";
            this.resisterPlayer.Size = new System.Drawing.Size(145, 54);
            this.resisterPlayer.TabIndex = 0;
            this.resisterPlayer.Text = "썬더스 선수등록";
            this.resisterPlayer.UseVisualStyleBackColor = false;
            this.resisterPlayer.Click += new System.EventHandler(this.resisterPlayer_Click);
            // 
            // resisterTeam
            // 
            this.resisterTeam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resisterTeam.Location = new System.Drawing.Point(12, 86);
            this.resisterTeam.Name = "resisterTeam";
            this.resisterTeam.Size = new System.Drawing.Size(145, 54);
            this.resisterTeam.TabIndex = 1;
            this.resisterTeam.Text = "팀 등록";
            this.resisterTeam.UseVisualStyleBackColor = false;
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
            this.Rebound,
            this.Assist});
            this.listPlayers.HideSelection = false;
            this.listPlayers.Location = new System.Drawing.Point(527, 272);
            this.listPlayers.Name = "listPlayers";
            this.listPlayers.Size = new System.Drawing.Size(693, 265);
            this.listPlayers.TabIndex = 2;
            this.listPlayers.UseCompatibleStateImageBehavior = false;
            this.listPlayers.View = System.Windows.Forms.View.Details;
            // 
            // playerID
            // 
            this.playerID.Text = "playerID";
            this.playerID.Width = 50;
            // 
            // playerName
            // 
            this.playerName.Text = "playerName";
            this.playerName.Width = 112;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            // 
            // Score
            // 
            this.Score.DisplayIndex = 8;
            this.Score.Text = "Score";
            // 
            // ThreePoint
            // 
            this.ThreePoint.DisplayIndex = 3;
            this.ThreePoint.Text = "ThreePoint";
            this.ThreePoint.Width = 81;
            // 
            // FreeThrow
            // 
            this.FreeThrow.DisplayIndex = 4;
            this.FreeThrow.Text = "FreeThrow";
            this.FreeThrow.Width = 81;
            // 
            // FieldGoal
            // 
            this.FieldGoal.DisplayIndex = 5;
            this.FieldGoal.Text = "FieldGoal";
            this.FieldGoal.Width = 81;
            // 
            // Rebound
            // 
            this.Rebound.DisplayIndex = 6;
            this.Rebound.Text = "Rebound";
            this.Rebound.Width = 87;
            // 
            // Assist
            // 
            this.Assist.DisplayIndex = 7;
            this.Assist.Text = "Assist";
            // 
            // resisterGame
            // 
            this.resisterGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resisterGame.Location = new System.Drawing.Point(12, 29);
            this.resisterGame.Name = "resisterGame";
            this.resisterGame.Size = new System.Drawing.Size(145, 51);
            this.resisterGame.TabIndex = 3;
            this.resisterGame.Text = "경기 등록";
            this.resisterGame.UseVisualStyleBackColor = false;
            this.resisterGame.Click += new System.EventHandler(this.resisterGame_Click);
            // 
            // resisterGamePlayer
            // 
            this.resisterGamePlayer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resisterGamePlayer.Location = new System.Drawing.Point(12, 206);
            this.resisterGamePlayer.Name = "resisterGamePlayer";
            this.resisterGamePlayer.Size = new System.Drawing.Size(145, 50);
            this.resisterGamePlayer.TabIndex = 5;
            this.resisterGamePlayer.Text = "경기기록 등록";
            this.resisterGamePlayer.UseVisualStyleBackColor = false;
            this.resisterGamePlayer.Click += new System.EventHandler(this.resisterGamePlayer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 248);
            this.button1.TabIndex = 6;
            this.button1.Text = "유저컨트롤달력위치";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // winRateChart
            // 
            this.winRateChart.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea2.Name = "ChartArea1";
            this.winRateChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.winRateChart.Legends.Add(legend2);
            this.winRateChart.Location = new System.Drawing.Point(903, 12);
            this.winRateChart.Name = "winRateChart";
            this.winRateChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.CustomProperties = "PieStartAngle=270";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.winRateChart.Series.Add(series2);
            this.winRateChart.Size = new System.Drawing.Size(317, 254);
            this.winRateChart.TabIndex = 7;
            this.winRateChart.Text = "chart1";
            // 
            // SKButton
            // 
            this.SKButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SKButton.Location = new System.Drawing.Point(783, 18);
            this.SKButton.Name = "SKButton";
            this.SKButton.Size = new System.Drawing.Size(114, 73);
            this.SKButton.TabIndex = 8;
            this.SKButton.Text = "서울 SK";
            this.SKButton.UseVisualStyleBackColor = false;
            this.SKButton.Click += new System.EventHandler(this.SKButton_Click);
            // 
            // KCCButton
            // 
            this.KCCButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KCCButton.Location = new System.Drawing.Point(783, 106);
            this.KCCButton.Name = "KCCButton";
            this.KCCButton.Size = new System.Drawing.Size(114, 73);
            this.KCCButton.TabIndex = 9;
            this.KCCButton.Text = "부산 KCC";
            this.KCCButton.UseVisualStyleBackColor = false;
            this.KCCButton.Click += new System.EventHandler(this.KCCButton_Click);
            // 
            // MOBISButton
            // 
            this.MOBISButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MOBISButton.Location = new System.Drawing.Point(783, 193);
            this.MOBISButton.Name = "MOBISButton";
            this.MOBISButton.Size = new System.Drawing.Size(114, 73);
            this.MOBISButton.TabIndex = 10;
            this.MOBISButton.Text = "울산 현대모비스";
            this.MOBISButton.UseVisualStyleBackColor = false;
            this.MOBISButton.Click += new System.EventHandler(this.MOBISButton_Click);
            // 
            // SONOButton
            // 
            this.SONOButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SONOButton.Location = new System.Drawing.Point(661, 18);
            this.SONOButton.Name = "SONOButton";
            this.SONOButton.Size = new System.Drawing.Size(114, 73);
            this.SONOButton.TabIndex = 11;
            this.SONOButton.Text = "고양 소노";
            this.SONOButton.UseVisualStyleBackColor = false;
            this.SONOButton.Click += new System.EventHandler(this.SONOButton_Click);
            // 
            // DBButton
            // 
            this.DBButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DBButton.Location = new System.Drawing.Point(536, 18);
            this.DBButton.Name = "DBButton";
            this.DBButton.Size = new System.Drawing.Size(114, 73);
            this.DBButton.TabIndex = 12;
            this.DBButton.Text = "원주 DB";
            this.DBButton.UseVisualStyleBackColor = false;
            this.DBButton.Click += new System.EventHandler(this.DBButton_Click);
            // 
            // KOGASButton
            // 
            this.KOGASButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KOGASButton.Location = new System.Drawing.Point(661, 193);
            this.KOGASButton.Name = "KOGASButton";
            this.KOGASButton.Size = new System.Drawing.Size(114, 73);
            this.KOGASButton.TabIndex = 14;
            this.KOGASButton.Text = "대구 한국가스공사";
            this.KOGASButton.UseVisualStyleBackColor = false;
            this.KOGASButton.Click += new System.EventHandler(this.KOGASButton_Click);
            // 
            // KGCButton
            // 
            this.KGCButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KGCButton.Location = new System.Drawing.Point(661, 106);
            this.KGCButton.Name = "KGCButton";
            this.KGCButton.Size = new System.Drawing.Size(114, 73);
            this.KGCButton.TabIndex = 13;
            this.KGCButton.Text = "안양 정관장";
            this.KGCButton.UseVisualStyleBackColor = false;
            this.KGCButton.Click += new System.EventHandler(this.KGCButton_Click);
            // 
            // KTButton
            // 
            this.KTButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KTButton.Location = new System.Drawing.Point(536, 193);
            this.KTButton.Name = "KTButton";
            this.KTButton.Size = new System.Drawing.Size(114, 73);
            this.KTButton.TabIndex = 16;
            this.KTButton.Text = "수원 KT";
            this.KTButton.UseVisualStyleBackColor = false;
            this.KTButton.Click += new System.EventHandler(this.KTButton_Click);
            // 
            // LGButton
            // 
            this.LGButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LGButton.Location = new System.Drawing.Point(536, 106);
            this.LGButton.Name = "LGButton";
            this.LGButton.Size = new System.Drawing.Size(114, 73);
            this.LGButton.TabIndex = 15;
            this.LGButton.Text = "창원 LG";
            this.LGButton.UseVisualStyleBackColor = false;
            this.LGButton.Click += new System.EventHandler(this.LGButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 265);
            this.button2.TabIndex = 17;
            this.button2.Text = "다음 경기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 265);
            this.button3.TabIndex = 18;
            this.button3.Text = "스테이터스";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // winRateText
            // 
            this.winRateText.AutoSize = true;
            this.winRateText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winRateText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winRateText.Location = new System.Drawing.Point(1095, 220);
            this.winRateText.Name = "winRateText";
            this.winRateText.Size = new System.Drawing.Size(90, 36);
            this.winRateText.TabIndex = 19;
            this.winRateText.Text = "100%";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 549);
            this.Controls.Add(this.winRateText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KTButton);
            this.Controls.Add(this.LGButton);
            this.Controls.Add(this.KOGASButton);
            this.Controls.Add(this.KGCButton);
            this.Controls.Add(this.DBButton);
            this.Controls.Add(this.SONOButton);
            this.Controls.Add(this.MOBISButton);
            this.Controls.Add(this.KCCButton);
            this.Controls.Add(this.SKButton);
            this.Controls.Add(this.winRateChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resisterGamePlayer);
            this.Controls.Add(this.resisterGame);
            this.Controls.Add(this.listPlayers);
            this.Controls.Add(this.resisterTeam);
            this.Controls.Add(this.resisterPlayer);
            this.Name = "mainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.winRateChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ColumnHeader Rebound;
        private System.Windows.Forms.Button resisterGame;
        private System.Windows.Forms.ColumnHeader Score;
        private System.Windows.Forms.ColumnHeader Assist;
        private System.Windows.Forms.Button resisterGamePlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart winRateChart;
        private System.Windows.Forms.Button SKButton;
        private System.Windows.Forms.Button KCCButton;
        private System.Windows.Forms.Button MOBISButton;
        private System.Windows.Forms.Button SONOButton;
        private System.Windows.Forms.Button DBButton;
        private System.Windows.Forms.Button KOGASButton;
        private System.Windows.Forms.Button KGCButton;
        private System.Windows.Forms.Button KTButton;
        private System.Windows.Forms.Button LGButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label winRateText;
    }
}

