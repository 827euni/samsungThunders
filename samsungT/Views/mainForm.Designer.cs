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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button3 = new System.Windows.Forms.Button();
            this.winRateText = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.recentRebound = new System.Windows.Forms.Label();
            this.recentAssist = new System.Windows.Forms.Label();
            this.recentFree = new System.Windows.Forms.Label();
            this.recent3 = new System.Windows.Forms.Label();
            this.recentField = new System.Windows.Forms.Label();
            this.recentText = new System.Windows.Forms.Label();
            this.recentCity = new System.Windows.Forms.Label();
            this.recentAwayScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recentHomeScore = new System.Windows.Forms.Label();
            this.recentGame = new System.Windows.Forms.Label();
            this.clickScoreText = new System.Windows.Forms.Label();
            this.clickRebound = new System.Windows.Forms.Label();
            this.clickAssist = new System.Windows.Forms.Label();
            this.clickChangeTitle = new System.Windows.Forms.Label();
            this.clickChangeText = new System.Windows.Forms.Label();
            this.clickFree = new System.Windows.Forms.Label();
            this.clickScore = new System.Windows.Forms.Label();
            this.click3 = new System.Windows.Forms.Label();
            this.clickCity = new System.Windows.Forms.Label();
            this.clickAwayScore = new System.Windows.Forms.Label();
            this.clickField = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clickHomeScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.winRateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.listPlayers.Location = new System.Drawing.Point(624, 272);
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
            this.button1.Size = new System.Drawing.Size(461, 248);
            this.button1.TabIndex = 6;
            this.button1.Text = "유저컨트롤달력위치";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // winRateChart
            // 
            this.winRateChart.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            this.winRateChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.winRateChart.Legends.Add(legend1);
            this.winRateChart.Location = new System.Drawing.Point(1000, 18);
            this.winRateChart.Name = "winRateChart";
            this.winRateChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "PieStartAngle=270";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.winRateChart.Series.Add(series1);
            this.winRateChart.Size = new System.Drawing.Size(317, 248);
            this.winRateChart.TabIndex = 7;
            this.winRateChart.Text = "chart1";
            // 
            // SKButton
            // 
            this.SKButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SKButton.Location = new System.Drawing.Point(877, 18);
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
            this.KCCButton.Location = new System.Drawing.Point(877, 106);
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
            this.MOBISButton.Location = new System.Drawing.Point(877, 193);
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
            this.SONOButton.Location = new System.Drawing.Point(755, 18);
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
            this.DBButton.Location = new System.Drawing.Point(630, 18);
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
            this.KOGASButton.Location = new System.Drawing.Point(755, 193);
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
            this.KGCButton.Location = new System.Drawing.Point(755, 106);
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
            this.KTButton.Location = new System.Drawing.Point(630, 193);
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
            this.LGButton.Location = new System.Drawing.Point(630, 106);
            this.LGButton.Name = "LGButton";
            this.LGButton.Size = new System.Drawing.Size(114, 73);
            this.LGButton.TabIndex = 15;
            this.LGButton.Text = "창원 LG";
            this.LGButton.UseVisualStyleBackColor = false;
            this.LGButton.Click += new System.EventHandler(this.LGButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(406, 265);
            this.button3.TabIndex = 18;
            this.button3.Text = "스테이터스";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // winRateText
            // 
            this.winRateText.AutoSize = true;
            this.winRateText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winRateText.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winRateText.Location = new System.Drawing.Point(1196, 225);
            this.winRateText.Name = "winRateText";
            this.winRateText.Size = new System.Drawing.Size(78, 31);
            this.winRateText.TabIndex = 19;
            this.winRateText.Text = "100%";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 272);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.recentRebound);
            this.splitContainer1.Panel1.Controls.Add(this.recentAssist);
            this.splitContainer1.Panel1.Controls.Add(this.recentFree);
            this.splitContainer1.Panel1.Controls.Add(this.recent3);
            this.splitContainer1.Panel1.Controls.Add(this.recentField);
            this.splitContainer1.Panel1.Controls.Add(this.recentText);
            this.splitContainer1.Panel1.Controls.Add(this.recentCity);
            this.splitContainer1.Panel1.Controls.Add(this.recentAwayScore);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.recentHomeScore);
            this.splitContainer1.Panel1.Controls.Add(this.recentGame);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.clickScoreText);
            this.splitContainer1.Panel2.Controls.Add(this.clickRebound);
            this.splitContainer1.Panel2.Controls.Add(this.clickAssist);
            this.splitContainer1.Panel2.Controls.Add(this.clickChangeTitle);
            this.splitContainer1.Panel2.Controls.Add(this.clickChangeText);
            this.splitContainer1.Panel2.Controls.Add(this.clickFree);
            this.splitContainer1.Panel2.Controls.Add(this.clickScore);
            this.splitContainer1.Panel2.Controls.Add(this.click3);
            this.splitContainer1.Panel2.Controls.Add(this.clickCity);
            this.splitContainer1.Panel2.Controls.Add(this.clickAwayScore);
            this.splitContainer1.Panel2.Controls.Add(this.clickField);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.clickHomeScore);
            this.splitContainer1.Size = new System.Drawing.Size(612, 265);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 20;
            // 
            // recentRebound
            // 
            this.recentRebound.AutoSize = true;
            this.recentRebound.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentRebound.Location = new System.Drawing.Point(136, 196);
            this.recentRebound.Name = "recentRebound";
            this.recentRebound.Size = new System.Drawing.Size(124, 21);
            this.recentRebound.TabIndex = 2;
            this.recentRebound.Text = "recentRebound";
            this.recentRebound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recentAssist
            // 
            this.recentAssist.AutoSize = true;
            this.recentAssist.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentAssist.Location = new System.Drawing.Point(136, 216);
            this.recentAssist.Name = "recentAssist";
            this.recentAssist.Size = new System.Drawing.Size(101, 21);
            this.recentAssist.TabIndex = 2;
            this.recentAssist.Text = "recentAssist";
            this.recentAssist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // recentFree
            // 
            this.recentFree.AutoSize = true;
            this.recentFree.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentFree.Location = new System.Drawing.Point(136, 176);
            this.recentFree.Name = "recentFree";
            this.recentFree.Size = new System.Drawing.Size(88, 21);
            this.recentFree.TabIndex = 2;
            this.recentFree.Text = "recentFree";
            this.recentFree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // recent3
            // 
            this.recent3.AutoSize = true;
            this.recent3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recent3.Location = new System.Drawing.Point(136, 141);
            this.recent3.Name = "recent3";
            this.recent3.Size = new System.Drawing.Size(64, 21);
            this.recent3.TabIndex = 2;
            this.recent3.Text = "recent3";
            this.recent3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // recentField
            // 
            this.recentField.AutoSize = true;
            this.recentField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentField.Location = new System.Drawing.Point(136, 158);
            this.recentField.Name = "recentField";
            this.recentField.Size = new System.Drawing.Size(92, 21);
            this.recentField.TabIndex = 2;
            this.recentField.Text = "recentField";
            this.recentField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // recentText
            // 
            this.recentText.AutoSize = true;
            this.recentText.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.recentText.Location = new System.Drawing.Point(36, 141);
            this.recentText.Name = "recentText";
            this.recentText.Size = new System.Drawing.Size(85, 95);
            this.recentText.TabIndex = 2;
            this.recentText.Text = "3점\r\n야투\r\n자유투\r\n리바운드\r\n어시스트\r\n";
            this.recentText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // recentCity
            // 
            this.recentCity.AutoSize = true;
            this.recentCity.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentCity.Location = new System.Drawing.Point(78, 106);
            this.recentCity.Name = "recentCity";
            this.recentCity.Size = new System.Drawing.Size(82, 19);
            this.recentCity.TabIndex = 1;
            this.recentCity.Text = "recentCity";
            // 
            // recentAwayScore
            // 
            this.recentAwayScore.AutoSize = true;
            this.recentAwayScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentAwayScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recentAwayScore.Location = new System.Drawing.Point(125, 79);
            this.recentAwayScore.Name = "recentAwayScore";
            this.recentAwayScore.Size = new System.Drawing.Size(24, 27);
            this.recentAwayScore.TabIndex = 1;
            this.recentAwayScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(112, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // recentHomeScore
            // 
            this.recentHomeScore.AutoSize = true;
            this.recentHomeScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentHomeScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recentHomeScore.Location = new System.Drawing.Point(82, 79);
            this.recentHomeScore.Name = "recentHomeScore";
            this.recentHomeScore.Size = new System.Drawing.Size(24, 27);
            this.recentHomeScore.TabIndex = 1;
            this.recentHomeScore.Text = "0";
            // 
            // recentGame
            // 
            this.recentGame.AutoSize = true;
            this.recentGame.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentGame.Location = new System.Drawing.Point(18, 37);
            this.recentGame.Name = "recentGame";
            this.recentGame.Size = new System.Drawing.Size(216, 42);
            this.recentGame.TabIndex = 0;
            this.recentGame.Text = "Recent Game";
            // 
            // clickScoreText
            // 
            this.clickScoreText.AutoSize = true;
            this.clickScoreText.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clickScoreText.Location = new System.Drawing.Point(123, 122);
            this.clickScoreText.Name = "clickScoreText";
            this.clickScoreText.Size = new System.Drawing.Size(72, 19);
            this.clickScoreText.TabIndex = 3;
            this.clickScoreText.Text = "총 득점";
            this.clickScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clickRebound
            // 
            this.clickRebound.AutoSize = true;
            this.clickRebound.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickRebound.Location = new System.Drawing.Point(221, 199);
            this.clickRebound.Name = "clickRebound";
            this.clickRebound.Size = new System.Drawing.Size(114, 21);
            this.clickRebound.TabIndex = 2;
            this.clickRebound.Text = "clickRebound";
            this.clickRebound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clickAssist
            // 
            this.clickAssist.AutoSize = true;
            this.clickAssist.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickAssist.Location = new System.Drawing.Point(221, 220);
            this.clickAssist.Name = "clickAssist";
            this.clickAssist.Size = new System.Drawing.Size(91, 21);
            this.clickAssist.TabIndex = 2;
            this.clickAssist.Text = "clickAssist";
            this.clickAssist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clickChangeTitle
            // 
            this.clickChangeTitle.AutoSize = true;
            this.clickChangeTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickChangeTitle.Location = new System.Drawing.Point(111, 39);
            this.clickChangeTitle.Name = "clickChangeTitle";
            this.clickChangeTitle.Size = new System.Drawing.Size(149, 42);
            this.clickChangeTitle.TabIndex = 0;
            this.clickChangeTitle.Text = "STATUS";
            // 
            // clickChangeText
            // 
            this.clickChangeText.AutoSize = true;
            this.clickChangeText.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clickChangeText.Location = new System.Drawing.Point(58, 141);
            this.clickChangeText.Name = "clickChangeText";
            this.clickChangeText.Size = new System.Drawing.Size(137, 95);
            this.clickChangeText.TabIndex = 2;
            this.clickChangeText.Text = "평균 3점슛(%)\r\n평균 야투율(%)\r\n평균 자유투(%)\r\n총 리바운드\r\n총 어시스트";
            this.clickChangeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clickFree
            // 
            this.clickFree.AutoSize = true;
            this.clickFree.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickFree.Location = new System.Drawing.Point(221, 182);
            this.clickFree.Name = "clickFree";
            this.clickFree.Size = new System.Drawing.Size(78, 21);
            this.clickFree.TabIndex = 2;
            this.clickFree.Text = "clickFree";
            this.clickFree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clickScore
            // 
            this.clickScore.AutoSize = true;
            this.clickScore.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickScore.Location = new System.Drawing.Point(221, 120);
            this.clickScore.Name = "clickScore";
            this.clickScore.Size = new System.Drawing.Size(89, 21);
            this.clickScore.TabIndex = 2;
            this.clickScore.Text = "clickScore";
            this.clickScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // click3
            // 
            this.click3.AutoSize = true;
            this.click3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click3.Location = new System.Drawing.Point(221, 141);
            this.click3.Name = "click3";
            this.click3.Size = new System.Drawing.Size(54, 21);
            this.click3.TabIndex = 2;
            this.click3.Text = "click3";
            this.click3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clickCity
            // 
            this.clickCity.AutoSize = true;
            this.clickCity.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickCity.Location = new System.Drawing.Point(170, 111);
            this.clickCity.Name = "clickCity";
            this.clickCity.Size = new System.Drawing.Size(0, 19);
            this.clickCity.TabIndex = 1;
            // 
            // clickAwayScore
            // 
            this.clickAwayScore.AutoSize = true;
            this.clickAwayScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickAwayScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clickAwayScore.Location = new System.Drawing.Point(192, 81);
            this.clickAwayScore.Name = "clickAwayScore";
            this.clickAwayScore.Size = new System.Drawing.Size(0, 27);
            this.clickAwayScore.TabIndex = 1;
            // 
            // clickField
            // 
            this.clickField.AutoSize = true;
            this.clickField.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickField.Location = new System.Drawing.Point(221, 161);
            this.clickField.Name = "clickField";
            this.clickField.Size = new System.Drawing.Size(82, 21);
            this.clickField.TabIndex = 2;
            this.clickField.Text = "clickField";
            this.clickField.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(179, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 1;
            // 
            // clickHomeScore
            // 
            this.clickHomeScore.AutoSize = true;
            this.clickHomeScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickHomeScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clickHomeScore.Location = new System.Drawing.Point(149, 81);
            this.clickHomeScore.Name = "clickHomeScore";
            this.clickHomeScore.Size = new System.Drawing.Size(0, 27);
            this.clickHomeScore.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 549);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.winRateText);
            this.Controls.Add(this.button3);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label winRateText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label recentGame;
        private System.Windows.Forms.Label recentText;
        private System.Windows.Forms.Label recentFree;
        private System.Windows.Forms.Label recentField;
        private System.Windows.Forms.Label recentAssist;
        private System.Windows.Forms.Label recentRebound;
        private System.Windows.Forms.Label recentCity;
        private System.Windows.Forms.Label recent3;
        private System.Windows.Forms.Label clickChangeTitle;
        private System.Windows.Forms.Label recentAwayScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recentHomeScore;
        private System.Windows.Forms.Label clickRebound;
        private System.Windows.Forms.Label clickAssist;
        private System.Windows.Forms.Label clickChangeText;
        private System.Windows.Forms.Label clickFree;
        private System.Windows.Forms.Label click3;
        private System.Windows.Forms.Label clickField;
        private System.Windows.Forms.Label clickCity;
        private System.Windows.Forms.Label clickAwayScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label clickHomeScore;
        private System.Windows.Forms.Label clickScoreText;
        private System.Windows.Forms.Label clickScore;
    }
}

