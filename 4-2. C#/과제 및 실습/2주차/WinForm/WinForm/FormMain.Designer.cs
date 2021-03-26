
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
            this.tbxOPerand1 = new System.Windows.Forms.TextBox();
            this.tbxOPerand2 = new System.Windows.Forms.TextBox();
            this.chxFloat = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxOPerand1
            // 
            this.tbxOPerand1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxOPerand1.Location = new System.Drawing.Point(12, 27);
            this.tbxOPerand1.Name = "tbxOPerand1";
            this.tbxOPerand1.Size = new System.Drawing.Size(124, 33);
            this.tbxOPerand1.TabIndex = 0;
            // 
            // tbxOPerand2
            // 
            this.tbxOPerand2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxOPerand2.Location = new System.Drawing.Point(160, 27);
            this.tbxOPerand2.Name = "tbxOPerand2";
            this.tbxOPerand2.Size = new System.Drawing.Size(126, 33);
            this.tbxOPerand2.TabIndex = 0;
            // 
            // chxFloat
            // 
            this.chxFloat.AutoSize = true;
            this.chxFloat.Checked = true;
            this.chxFloat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxFloat.Location = new System.Drawing.Point(325, 35);
            this.chxFloat.Name = "chxFloat";
            this.chxFloat.Size = new System.Drawing.Size(48, 16);
            this.chxFloat.TabIndex = 1;
            this.chxFloat.Text = "실수";
            this.chxFloat.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "더하기";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.ForeColor = System.Drawing.Color.Crimson;
            this.lblResult.Location = new System.Drawing.Point(13, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(273, 47);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 229);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chxFloat);
            this.Controls.Add(this.tbxOPerand2);
            this.Controls.Add(this.tbxOPerand1);
            this.Name = "FormMain";
            this.Text = "2주차";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOPerand1;
        private System.Windows.Forms.TextBox tbxOPerand2;
        private System.Windows.Forms.CheckBox chxFloat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
    }
}

