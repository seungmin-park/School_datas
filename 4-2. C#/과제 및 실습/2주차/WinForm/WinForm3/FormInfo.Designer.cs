
namespace WinForm3
{
    partial class FormInfo
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
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(20, 27);
            this.tbxNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(155, 33);
            this.tbxNumber.TabIndex = 0;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(185, 27);
            this.tbxName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(155, 33);
            this.tbxName.TabIndex = 1;
            // 
            // tbxScore
            // 
            this.tbxScore.Location = new System.Drawing.Point(350, 27);
            this.tbxScore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(155, 33);
            this.tbxScore.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(513, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(131, 33);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "신규입력";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(20, 125);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(624, 138);
            this.tbxOutput.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(513, 76);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(131, 33);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "전체조회";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 275);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbxScore);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxNumber);
            this.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormInfo";
            this.Text = "학생관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnView;
    }
}

