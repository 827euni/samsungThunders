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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Button_Score = new System.Windows.Forms.Button();
            this.Button_3Point = new System.Windows.Forms.Button();
            this.Button_Field = new System.Windows.Forms.Button();
            this.Button_Free = new System.Windows.Forms.Button();
            this.Button_Rebound = new System.Windows.Forms.Button();
            this.Button_Assist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(177, 64);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(616, 407);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard Variable", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(692, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "썬더스";
            // 
            // thundersChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Assist);
            this.Controls.Add(this.Button_Rebound);
            this.Controls.Add(this.Button_Free);
            this.Controls.Add(this.Button_Field);
            this.Controls.Add(this.Button_3Point);
            this.Controls.Add(this.Button_Score);
            this.Controls.Add(this.chart1);
            this.Name = "thundersChart";
            this.Text = "thundersChart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Button_Score;
        private System.Windows.Forms.Button Button_3Point;
        private System.Windows.Forms.Button Button_Field;
        private System.Windows.Forms.Button Button_Free;
        private System.Windows.Forms.Button Button_Rebound;
        private System.Windows.Forms.Button Button_Assist;
        private System.Windows.Forms.Label label1;
    }
}