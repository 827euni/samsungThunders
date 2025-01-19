namespace samsungT.Views
{
    partial class thundersChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart_Thunders = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_Score = new System.Windows.Forms.Button();
            this.Button_3Point = new System.Windows.Forms.Button();
            this.Button_Field = new System.Windows.Forms.Button();
            this.Button_Free = new System.Windows.Forms.Button();
            this.Button_Rebound = new System.Windows.Forms.Button();
            this.Button_Assist = new System.Windows.Forms.Button();
            this.Label_ThundersName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Thunders)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_Thunders
            // 
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.Name = "ChartArea1";
            this.Chart_Thunders.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.Chart_Thunders.Legends.Add(legend6);
            this.Chart_Thunders.Location = new System.Drawing.Point(177, 64);
            this.Chart_Thunders.Name = "Chart_Thunders";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Font = new System.Drawing.Font("Pretendard Variable", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.Chart_Thunders.Series.Add(series6);
            this.Chart_Thunders.Size = new System.Drawing.Size(616, 407);
            this.Chart_Thunders.TabIndex = 0;
            this.Chart_Thunders.Text = "chart1";
            // 
            // Button_Score
            // 
            this.Button_Score.Font = new System.Drawing.Font("Pretendard Variable Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Score.Location = new System.Drawing.Point(12, 64);
            this.Button_Score.Name = "Button_Score";
            this.Button_Score.Size = new System.Drawing.Size(154, 63);
            this.Button_Score.TabIndex = 1;
            this.Button_Score.Text = "득점";
            this.Button_Score.UseVisualStyleBackColor = true;
            this.Button_Score.Click += new System.EventHandler(this.Button_Score_Click);
            // 
            // Button_3Point
            // 
            this.Button_3Point.Font = new System.Drawing.Font("Pretendard Variable Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_3Point.Location = new System.Drawing.Point(12, 133);
            this.Button_3Point.Name = "Button_3Point";
            this.Button_3Point.Size = new System.Drawing.Size(154, 63);
            this.Button_3Point.TabIndex = 1;
            this.Button_3Point.Text = "3점(%)";
            this.Button_3Point.UseVisualStyleBackColor = true;
            this.Button_3Point.Click += new System.EventHandler(this.Button_3Point_Click);
            // 
            // Button_Field
            // 
            this.Button_Field.Font = new System.Drawing.Font("Pretendard Variable Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Field.Location = new System.Drawing.Point(12, 202);
            this.Button_Field.Name = "Button_Field";
            this.Button_Field.Size = new System.Drawing.Size(154, 63);
            this.Button_Field.TabIndex = 1;
            this.Button_Field.Text = "야투(%)";
            this.Button_Field.UseVisualStyleBackColor = true;
            this.Button_Field.Click += new System.EventHandler(this.Button_Field_Click);
            // 
            // Button_Free
            // 
            this.Button_Free.Font = new System.Drawing.Font("Pretendard Variable Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Free.Location = new System.Drawing.Point(12, 271);
            this.Button_Free.Name = "Button_Free";
            this.Button_Free.Size = new System.Drawing.Size(154, 63);
            this.Button_Free.TabIndex = 1;
            this.Button_Free.Text = "자유투(%)";
            this.Button_Free.UseVisualStyleBackColor = true;
            this.Button_Free.Click += new System.EventHandler(this.Button_Free_Click);
            // 
            // Button_Rebound
            // 
            this.Button_Rebound.Font = new System.Drawing.Font("Pretendard Variable Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Rebound.Location = new System.Drawing.Point(12, 340);
            this.Button_Rebound.Name = "Button_Rebound";
            this.Button_Rebound.Size = new System.Drawing.Size(154, 63);
            this.Button_Rebound.TabIndex = 1;
            this.Button_Rebound.Text = "리바운드";
            this.Button_Rebound.UseVisualStyleBackColor = true;
            this.Button_Rebound.Click += new System.EventHandler(this.Button_Rebound_Click);
            // 
            // Button_Assist
            // 
            this.Button_Assist.Font = new System.Drawing.Font("Pretendard Variable Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button_Assist.Location = new System.Drawing.Point(12, 409);
            this.Button_Assist.Name = "Button_Assist";
            this.Button_Assist.Size = new System.Drawing.Size(154, 63);
            this.Button_Assist.TabIndex = 1;
            this.Button_Assist.Text = "어시스트";
            this.Button_Assist.UseVisualStyleBackColor = true;
            this.Button_Assist.Click += new System.EventHandler(this.Button_Assist_Click);
            // 
            // Label_ThundersName
            // 
            this.Label_ThundersName.AutoSize = true;
            this.Label_ThundersName.Font = new System.Drawing.Font("Pretendard Variable", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_ThundersName.Location = new System.Drawing.Point(352, 9);
            this.Label_ThundersName.Name = "Label_ThundersName";
            this.Label_ThundersName.Size = new System.Drawing.Size(101, 38);
            this.Label_ThundersName.TabIndex = 2;
            this.Label_ThundersName.Text = "썬더스";
            // 
            // thundersChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 477);
            this.Controls.Add(this.Label_ThundersName);
            this.Controls.Add(this.Button_Assist);
            this.Controls.Add(this.Button_Rebound);
            this.Controls.Add(this.Button_Free);
            this.Controls.Add(this.Button_Field);
            this.Controls.Add(this.Button_3Point);
            this.Controls.Add(this.Button_Score);
            this.Controls.Add(this.Chart_Thunders);
            this.Name = "thundersChart";
            this.Text = "thundersChart";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Thunders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Thunders;
        private System.Windows.Forms.Button Button_Score;
        private System.Windows.Forms.Button Button_3Point;
        private System.Windows.Forms.Button Button_Field;
        private System.Windows.Forms.Button Button_Free;
        private System.Windows.Forms.Button Button_Rebound;
        private System.Windows.Forms.Button Button_Assist;
        private System.Windows.Forms.Label Label_ThundersName;
    }
}