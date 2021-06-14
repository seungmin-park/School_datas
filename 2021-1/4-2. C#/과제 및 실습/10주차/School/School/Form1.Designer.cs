
namespace School
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgEntrance = new System.Windows.Forms.TabPage();
            this.tpgRegCource = new System.Windows.Forms.TabPage();
            this.tpgSearchStudent = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEntranceName = new System.Windows.Forms.TextBox();
            this.chkIndustrialEdu = new System.Windows.Forms.CheckBox();
            this.pnlEntranceCompany = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEntranceCompany = new System.Windows.Forms.TextBox();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.lblEntranceResult = new System.Windows.Forms.Label();
            this.cbxEntranceGrade = new System.Windows.Forms.ComboBox();
            this.tbxReCourseSearchId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRegCourseId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRegCourseName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegCourseSearch = new System.Windows.Forms.Button();
            this.lbxRegCourse = new System.Windows.Forms.ListBox();
            this.tbxRegCourseName = new System.Windows.Forms.TextBox();
            this.btnRegCourseHiding = new System.Windows.Forms.Button();
            this.btnRegCourseOverriding = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tpgEntrance.SuspendLayout();
            this.tpgRegCource.SuspendLayout();
            this.pnlEntranceCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgEntrance);
            this.tabMain.Controls.Add(this.tpgRegCource);
            this.tabMain.Controls.Add(this.tpgSearchStudent);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(100, 35);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(800, 450);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 0;
            // 
            // tpgEntrance
            // 
            this.tpgEntrance.Controls.Add(this.cbxEntranceGrade);
            this.tpgEntrance.Controls.Add(this.btnEntrance);
            this.tpgEntrance.Controls.Add(this.pnlEntranceCompany);
            this.tpgEntrance.Controls.Add(this.chkIndustrialEdu);
            this.tpgEntrance.Controls.Add(this.tbxEntranceName);
            this.tpgEntrance.Controls.Add(this.label2);
            this.tpgEntrance.Controls.Add(this.lblEntranceResult);
            this.tpgEntrance.Controls.Add(this.label1);
            this.tpgEntrance.Location = new System.Drawing.Point(4, 39);
            this.tpgEntrance.Name = "tpgEntrance";
            this.tpgEntrance.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEntrance.Size = new System.Drawing.Size(792, 407);
            this.tpgEntrance.TabIndex = 0;
            this.tpgEntrance.Text = "입학관리";
            this.tpgEntrance.UseVisualStyleBackColor = true;
            // 
            // tpgRegCource
            // 
            this.tpgRegCource.Controls.Add(this.lbxRegCourse);
            this.tpgRegCource.Controls.Add(this.btnRegCourseOverriding);
            this.tpgRegCource.Controls.Add(this.btnRegCourseHiding);
            this.tpgRegCource.Controls.Add(this.btnRegCourseSearch);
            this.tpgRegCource.Controls.Add(this.tbxRegCourseName);
            this.tpgRegCource.Controls.Add(this.tbxReCourseSearchId);
            this.tpgRegCource.Controls.Add(this.lblRegCourseName);
            this.tpgRegCource.Controls.Add(this.lblRegCourseId);
            this.tpgRegCource.Controls.Add(this.label7);
            this.tpgRegCource.Controls.Add(this.label5);
            this.tpgRegCource.Controls.Add(this.label9);
            this.tpgRegCource.Controls.Add(this.label4);
            this.tpgRegCource.Location = new System.Drawing.Point(4, 39);
            this.tpgRegCource.Name = "tpgRegCource";
            this.tpgRegCource.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRegCource.Size = new System.Drawing.Size(792, 407);
            this.tpgRegCource.TabIndex = 1;
            this.tpgRegCource.Text = "수강관리";
            this.tpgRegCource.UseVisualStyleBackColor = true;
            // 
            // tpgSearchStudent
            // 
            this.tpgSearchStudent.Location = new System.Drawing.Point(4, 39);
            this.tpgSearchStudent.Name = "tpgSearchStudent";
            this.tpgSearchStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSearchStudent.Size = new System.Drawing.Size(792, 407);
            this.tpgSearchStudent.TabIndex = 2;
            this.tpgSearchStudent.Text = "학생조회";
            this.tpgSearchStudent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "학년";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxEntranceName
            // 
            this.tbxEntranceName.Location = new System.Drawing.Point(196, 13);
            this.tbxEntranceName.Name = "tbxEntranceName";
            this.tbxEntranceName.Size = new System.Drawing.Size(182, 26);
            this.tbxEntranceName.TabIndex = 1;
            // 
            // chkIndustrialEdu
            // 
            this.chkIndustrialEdu.AutoSize = true;
            this.chkIndustrialEdu.Location = new System.Drawing.Point(384, 72);
            this.chkIndustrialEdu.Name = "chkIndustrialEdu";
            this.chkIndustrialEdu.Size = new System.Drawing.Size(59, 20);
            this.chkIndustrialEdu.TabIndex = 2;
            this.chkIndustrialEdu.Text = "산학";
            this.chkIndustrialEdu.UseVisualStyleBackColor = true;
            this.chkIndustrialEdu.CheckedChanged += new System.EventHandler(this.chkIndustrialEdu_CheckedChanged);
            // 
            // pnlEntranceCompany
            // 
            this.pnlEntranceCompany.Controls.Add(this.label3);
            this.pnlEntranceCompany.Controls.Add(this.tbxEntranceCompany);
            this.pnlEntranceCompany.Location = new System.Drawing.Point(0, 103);
            this.pnlEntranceCompany.Name = "pnlEntranceCompany";
            this.pnlEntranceCompany.Size = new System.Drawing.Size(443, 61);
            this.pnlEntranceCompany.TabIndex = 3;
            this.pnlEntranceCompany.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "회사";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxEntranceCompany
            // 
            this.tbxEntranceCompany.Location = new System.Drawing.Point(196, 19);
            this.tbxEntranceCompany.Name = "tbxEntranceCompany";
            this.tbxEntranceCompany.Size = new System.Drawing.Size(182, 26);
            this.tbxEntranceCompany.TabIndex = 1;
            // 
            // btnEntrance
            // 
            this.btnEntrance.Location = new System.Drawing.Point(0, 170);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(443, 23);
            this.btnEntrance.TabIndex = 4;
            this.btnEntrance.Text = "등록";
            this.btnEntrance.UseVisualStyleBackColor = true;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // lblEntranceResult
            // 
            this.lblEntranceResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEntranceResult.Location = new System.Drawing.Point(3, 232);
            this.lblEntranceResult.Name = "lblEntranceResult";
            this.lblEntranceResult.Padding = new System.Windows.Forms.Padding(10);
            this.lblEntranceResult.Size = new System.Drawing.Size(786, 172);
            this.lblEntranceResult.TabIndex = 0;
            // 
            // cbxEntranceGrade
            // 
            this.cbxEntranceGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEntranceGrade.FormattingEnabled = true;
            this.cbxEntranceGrade.Location = new System.Drawing.Point(196, 66);
            this.cbxEntranceGrade.Name = "cbxEntranceGrade";
            this.cbxEntranceGrade.Size = new System.Drawing.Size(182, 24);
            this.cbxEntranceGrade.TabIndex = 5;
            // 
            // tbxReCourseSearchId
            // 
            this.tbxReCourseSearchId.Location = new System.Drawing.Point(156, 22);
            this.tbxReCourseSearchId.Name = "tbxReCourseSearchId";
            this.tbxReCourseSearchId.Size = new System.Drawing.Size(182, 26);
            this.tbxReCourseSearchId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "학번";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "학번";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegCourseId
            // 
            this.lblRegCourseId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegCourseId.Location = new System.Drawing.Point(156, 64);
            this.lblRegCourseId.Name = "lblRegCourseId";
            this.lblRegCourseId.Size = new System.Drawing.Size(144, 26);
            this.lblRegCourseId.TabIndex = 2;
            this.lblRegCourseId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "이름";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegCourseName
            // 
            this.lblRegCourseName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegCourseName.Location = new System.Drawing.Point(156, 104);
            this.lblRegCourseName.Name = "lblRegCourseName";
            this.lblRegCourseName.Size = new System.Drawing.Size(144, 26);
            this.lblRegCourseName.TabIndex = 2;
            this.lblRegCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "수강과목";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegCourseSearch
            // 
            this.btnRegCourseSearch.Location = new System.Drawing.Point(344, 24);
            this.btnRegCourseSearch.Name = "btnRegCourseSearch";
            this.btnRegCourseSearch.Size = new System.Drawing.Size(101, 23);
            this.btnRegCourseSearch.TabIndex = 5;
            this.btnRegCourseSearch.Text = "검색";
            this.btnRegCourseSearch.UseVisualStyleBackColor = true;
            this.btnRegCourseSearch.Click += new System.EventHandler(this.btnRegCourseSearch_Click);
            // 
            // lbxRegCourse
            // 
            this.lbxRegCourse.FormattingEnabled = true;
            this.lbxRegCourse.ItemHeight = 16;
            this.lbxRegCourse.Location = new System.Drawing.Point(159, 139);
            this.lbxRegCourse.Name = "lbxRegCourse";
            this.lbxRegCourse.Size = new System.Drawing.Size(179, 148);
            this.lbxRegCourse.TabIndex = 6;
            // 
            // tbxRegCourseName
            // 
            this.tbxRegCourseName.Location = new System.Drawing.Point(159, 299);
            this.tbxRegCourseName.Name = "tbxRegCourseName";
            this.tbxRegCourseName.Size = new System.Drawing.Size(182, 26);
            this.tbxRegCourseName.TabIndex = 3;
            // 
            // btnRegCourseHiding
            // 
            this.btnRegCourseHiding.Location = new System.Drawing.Point(347, 295);
            this.btnRegCourseHiding.Name = "btnRegCourseHiding";
            this.btnRegCourseHiding.Size = new System.Drawing.Size(114, 31);
            this.btnRegCourseHiding.TabIndex = 5;
            this.btnRegCourseHiding.Text = "등록(Hiding)";
            this.btnRegCourseHiding.UseVisualStyleBackColor = true;
            this.btnRegCourseHiding.Click += new System.EventHandler(this.btnRegCourseHiding_Click);
            // 
            // btnRegCourseOverriding
            // 
            this.btnRegCourseOverriding.Location = new System.Drawing.Point(467, 296);
            this.btnRegCourseOverriding.Name = "btnRegCourseOverriding";
            this.btnRegCourseOverriding.Size = new System.Drawing.Size(138, 30);
            this.btnRegCourseOverriding.TabIndex = 5;
            this.btnRegCourseOverriding.Text = "등록(Overriding)";
            this.btnRegCourseOverriding.UseVisualStyleBackColor = true;
            this.btnRegCourseOverriding.Click += new System.EventHandler(this.btnRegCourseOverriding_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "학생관리";
            this.tabMain.ResumeLayout(false);
            this.tpgEntrance.ResumeLayout(false);
            this.tpgEntrance.PerformLayout();
            this.tpgRegCource.ResumeLayout(false);
            this.tpgRegCource.PerformLayout();
            this.pnlEntranceCompany.ResumeLayout(false);
            this.pnlEntranceCompany.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgEntrance;
        private System.Windows.Forms.TabPage tpgRegCource;
        private System.Windows.Forms.TabPage tpgSearchStudent;
        private System.Windows.Forms.ComboBox cbxEntranceGrade;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.Panel pnlEntranceCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEntranceCompany;
        private System.Windows.Forms.CheckBox chkIndustrialEdu;
        private System.Windows.Forms.TextBox tbxEntranceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEntranceResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegCourseSearch;
        private System.Windows.Forms.TextBox tbxReCourseSearchId;
        private System.Windows.Forms.Label lblRegCourseName;
        private System.Windows.Forms.Label lblRegCourseId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxRegCourse;
        private System.Windows.Forms.Button btnRegCourseOverriding;
        private System.Windows.Forms.Button btnRegCourseHiding;
        private System.Windows.Forms.TextBox tbxRegCourseName;
    }
}

