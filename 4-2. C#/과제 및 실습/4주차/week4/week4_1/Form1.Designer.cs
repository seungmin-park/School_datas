
namespace week4_1
{
    partial class Form1
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
            this.tbxScore = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxScore
            // 
            this.tbxScore.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxScore.Location = new System.Drawing.Point(12, 31);
            this.tbxScore.Name = "tbxScore";
            this.tbxScore.Size = new System.Drawing.Size(226, 29);
            this.tbxScore.TabIndex = 0;
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInput.Location = new System.Drawing.Point(244, 31);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(83, 29);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnView.Location = new System.Drawing.Point(333, 31);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(98, 29);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "결과조회";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblResult.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(0, 90);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(443, 168);
            this.lblResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 258);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tbxScore);
            this.Name = "Form1";
            this.Text = "4주차 (1)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxScore;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblResult;
    }
}

