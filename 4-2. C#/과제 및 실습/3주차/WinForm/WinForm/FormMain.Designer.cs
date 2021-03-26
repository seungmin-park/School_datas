
namespace WinForm
{
    partial class FormMain
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
            this.tbxOperand1 = new System.Windows.Forms.TextBox();
            this.tbxOperator = new System.Windows.Forms.TextBox();
            this.tbxOperand2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxOperand1
            // 
            this.tbxOperand1.Location = new System.Drawing.Point(8, 26);
            this.tbxOperand1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxOperand1.Name = "tbxOperand1";
            this.tbxOperand1.Size = new System.Drawing.Size(89, 32);
            this.tbxOperand1.TabIndex = 0;
            this.tbxOperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxOperator
            // 
            this.tbxOperator.Location = new System.Drawing.Point(107, 26);
            this.tbxOperator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxOperator.Name = "tbxOperator";
            this.tbxOperator.Size = new System.Drawing.Size(56, 32);
            this.tbxOperator.TabIndex = 1;
            this.tbxOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxOperand2
            // 
            this.tbxOperand2.Location = new System.Drawing.Point(173, 26);
            this.tbxOperand2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbxOperand2.Name = "tbxOperand2";
            this.tbxOperand2.Size = new System.Drawing.Size(89, 32);
            this.tbxOperand2.TabIndex = 2;
            this.tbxOperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.LightCoral;
            this.lblResult.Location = new System.Drawing.Point(353, 26);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(186, 32);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 81);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbxOperand2);
            this.Controls.Add(this.tbxOperator);
            this.Controls.Add(this.tbxOperand1);
            this.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormMain";
            this.Text = "산술계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOperand1;
        private System.Windows.Forms.TextBox tbxOperator;
        private System.Windows.Forms.TextBox tbxOperand2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
    }
}

