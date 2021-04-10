
namespace week6_4
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.tbxView = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(24, 26);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(97, 30);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "차량번호";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(143, 21);
            this.tbxNumber.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(169, 35);
            this.tbxNumber.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(29, 102);
            this.btnIn.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(129, 58);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "입차";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(177, 102);
            this.btnOut.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(129, 58);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "출차";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(458, 102);
            this.btnView.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(129, 58);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "전체 현황";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // tbxView
            // 
            this.tbxView.BackColor = System.Drawing.Color.White;
            this.tbxView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbxView.Location = new System.Drawing.Point(0, 253);
            this.tbxView.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tbxView.Multiline = true;
            this.tbxView.Name = "tbxView";
            this.tbxView.ReadOnly = true;
            this.tbxView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxView.Size = new System.Drawing.Size(725, 233);
            this.tbxView.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(725, 486);
            this.Controls.Add(this.tbxView);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.lblNumber);
            this.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox tbxView;
    }
}

