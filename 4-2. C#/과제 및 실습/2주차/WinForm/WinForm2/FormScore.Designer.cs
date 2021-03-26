
namespace WinForm2
{
    partial class FormScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.tbxKor = new System.Windows.Forms.TextBox();
            this.tbxEng = new System.Windows.Forms.TextBox();
            this.tbxMat = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "영어";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "수학";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "평균";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvg
            // 
            this.lblAvg.Location = new System.Drawing.Point(138, 208);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(100, 23);
            this.lblAvg.TabIndex = 0;
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxKor
            // 
            this.tbxKor.Font = new System.Drawing.Font("궁서", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxKor.Location = new System.Drawing.Point(139, 35);
            this.tbxKor.Name = "tbxKor";
            this.tbxKor.Size = new System.Drawing.Size(100, 29);
            this.tbxKor.TabIndex = 0;
            this.tbxKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxEng
            // 
            this.tbxEng.Font = new System.Drawing.Font("궁서", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxEng.Location = new System.Drawing.Point(138, 79);
            this.tbxEng.Name = "tbxEng";
            this.tbxEng.Size = new System.Drawing.Size(100, 29);
            this.tbxEng.TabIndex = 1;
            this.tbxEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxMat
            // 
            this.tbxMat.Font = new System.Drawing.Font("궁서", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxMat.Location = new System.Drawing.Point(138, 128);
            this.tbxMat.Name = "tbxMat";
            this.tbxMat.Size = new System.Drawing.Size(100, 29);
            this.tbxMat.TabIndex = 2;
            this.tbxMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(139, 174);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(99, 23);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "계산";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(32, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "합계";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(138, 240);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(100, 23);
            this.lblSum.TabIndex = 0;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(139, 274);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 351);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.tbxMat);
            this.Controls.Add(this.tbxEng);
            this.Controls.Add(this.tbxKor);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormScore";
            this.Text = "성적처리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.TextBox tbxKor;
        private System.Windows.Forms.TextBox tbxEng;
        private System.Windows.Forms.TextBox tbxMat;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblResult;
    }
}

