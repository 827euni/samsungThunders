namespace calenderBasketball
{
    partial class ThundersCalender
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.calender = new System.Windows.Forms.TableLayoutPanel();
            this.month = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calender
            // 
            this.calender.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.calender.ColumnCount = 7;
            this.calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.calender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28939F));
            this.calender.Font = new System.Drawing.Font("Pretendard", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.calender.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.calender.Location = new System.Drawing.Point(62, 73);
            this.calender.Name = "calender";
            this.calender.RowCount = 6;
            this.calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.calender.Size = new System.Drawing.Size(757, 458);
            this.calender.TabIndex = 0;
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Font = new System.Drawing.Font("Pretendard Variable ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.month.Location = new System.Drawing.Point(408, 22);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(59, 38);
            this.month.TabIndex = 1;
            this.month.Text = "1월";
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.prevButton.Location = new System.Drawing.Point(369, 22);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(33, 35);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "◀";
            this.prevButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextButton.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nextButton.Location = new System.Drawing.Point(473, 22);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(33, 35);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "▶";
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // ThundersCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.month);
            this.Controls.Add(this.calender);
            this.Name = "ThundersCalender";
            this.Size = new System.Drawing.Size(888, 548);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel calender;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
    }
}
