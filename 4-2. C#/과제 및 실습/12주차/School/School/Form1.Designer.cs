
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
            this.cbxEntranceGrade = new System.Windows.Forms.ComboBox();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.pnlEntranceCompany = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEntranceCompany = new System.Windows.Forms.TextBox();
            this.chkIndustrialEdu = new System.Windows.Forms.CheckBox();
            this.tbxEntranceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEntranceResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpgRegCource = new System.Windows.Forms.TabPage();
            this.lbxRegCourse = new System.Windows.Forms.ListBox();
            this.btnRegCourseOverriding = new System.Windows.Forms.Button();
            this.btnRegCourseHiding = new System.Windows.Forms.Button();
            this.btnRegCourseSearch = new System.Windows.Forms.Button();
            this.tbxRegCourseName = new System.Windows.Forms.TextBox();
            this.tbxReCourseSearchId = new System.Windows.Forms.TextBox();
            this.lblRegCourseName = new System.Windows.Forms.Label();
            this.lblRegCourseId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpgSearchStudent = new System.Windows.Forms.TabPage();
            this.lblViewAvg = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblViewMin = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewSearch = new System.Windows.Forms.Button();
            this.tbxViewSearchId = new System.Windows.Forms.TextBox();
            this.lblViewName = new System.Windows.Forms.Label();
            this.lblViewMax = new System.Windows.Forms.Label();
            this.lblViewId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tpgAttend = new System.Windows.Forms.TabPage();
            this.btnAttend2 = new System.Windows.Forms.Button();
            this.btnAttend3 = new System.Windows.Forms.Button();
            this.btnAttend4 = new System.Windows.Forms.Button();
            this.btnAttend1 = new System.Windows.Forms.Button();
            this.dgvAttend = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAttendSearch = new System.Windows.Forms.Button();
            this.tbxAttendSearchId = new System.Windows.Forms.TextBox();
            this.lblAttendName = new System.Windows.Forms.Label();
            this.lblAttendId = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tpgScore = new System.Windows.Forms.TabPage();
            this.btnScoreSave = new System.Windows.Forms.Button();
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnScoreSearch = new System.Windows.Forms.Button();
            this.tbxScoreSearchId = new System.Windows.Forms.TextBox();
            this.lblScoreName = new System.Windows.Forms.Label();
            this.lblScoreId = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tpgEntrance.SuspendLayout();
            this.pnlEntranceCompany.SuspendLayout();
            this.tpgRegCource.SuspendLayout();
            this.tpgSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.tpgAttend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttend)).BeginInit();
            this.tpgScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgEntrance);
            this.tabMain.Controls.Add(this.tpgRegCource);
            this.tabMain.Controls.Add(this.tpgSearchStudent);
            this.tabMain.Controls.Add(this.tpgAttend);
            this.tabMain.Controls.Add(this.tpgScore);
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
            // cbxEntranceGrade
            // 
            this.cbxEntranceGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEntranceGrade.FormattingEnabled = true;
            this.cbxEntranceGrade.Location = new System.Drawing.Point(196, 66);
            this.cbxEntranceGrade.Name = "cbxEntranceGrade";
            this.cbxEntranceGrade.Size = new System.Drawing.Size(182, 24);
            this.cbxEntranceGrade.TabIndex = 5;
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
            // tbxEntranceName
            // 
            this.tbxEntranceName.Location = new System.Drawing.Point(196, 13);
            this.tbxEntranceName.Name = "tbxEntranceName";
            this.tbxEntranceName.Size = new System.Drawing.Size(182, 26);
            this.tbxEntranceName.TabIndex = 1;
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
            // lblEntranceResult
            // 
            this.lblEntranceResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEntranceResult.Location = new System.Drawing.Point(3, 232);
            this.lblEntranceResult.Name = "lblEntranceResult";
            this.lblEntranceResult.Padding = new System.Windows.Forms.Padding(10);
            this.lblEntranceResult.Size = new System.Drawing.Size(786, 172);
            this.lblEntranceResult.TabIndex = 0;
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
            // lbxRegCourse
            // 
            this.lbxRegCourse.FormattingEnabled = true;
            this.lbxRegCourse.ItemHeight = 16;
            this.lbxRegCourse.Location = new System.Drawing.Point(159, 139);
            this.lbxRegCourse.Name = "lbxRegCourse";
            this.lbxRegCourse.Size = new System.Drawing.Size(179, 148);
            this.lbxRegCourse.TabIndex = 6;
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
            // tbxRegCourseName
            // 
            this.tbxRegCourseName.Location = new System.Drawing.Point(159, 299);
            this.tbxRegCourseName.Name = "tbxRegCourseName";
            this.tbxRegCourseName.Size = new System.Drawing.Size(182, 26);
            this.tbxRegCourseName.TabIndex = 3;
            // 
            // tbxReCourseSearchId
            // 
            this.tbxReCourseSearchId.Location = new System.Drawing.Point(156, 22);
            this.tbxReCourseSearchId.Name = "tbxReCourseSearchId";
            this.tbxReCourseSearchId.Size = new System.Drawing.Size(182, 26);
            this.tbxReCourseSearchId.TabIndex = 3;
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
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "학번";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "학번";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpgSearchStudent
            // 
            this.tpgSearchStudent.Controls.Add(this.lblViewAvg);
            this.tpgSearchStudent.Controls.Add(this.label28);
            this.tpgSearchStudent.Controls.Add(this.lblViewMin);
            this.tpgSearchStudent.Controls.Add(this.label26);
            this.tpgSearchStudent.Controls.Add(this.dgvView);
            this.tpgSearchStudent.Controls.Add(this.btnViewSearch);
            this.tpgSearchStudent.Controls.Add(this.tbxViewSearchId);
            this.tpgSearchStudent.Controls.Add(this.lblViewName);
            this.tpgSearchStudent.Controls.Add(this.lblViewMax);
            this.tpgSearchStudent.Controls.Add(this.lblViewId);
            this.tpgSearchStudent.Controls.Add(this.label10);
            this.tpgSearchStudent.Controls.Add(this.label23);
            this.tpgSearchStudent.Controls.Add(this.label11);
            this.tpgSearchStudent.Controls.Add(this.label12);
            this.tpgSearchStudent.Location = new System.Drawing.Point(4, 39);
            this.tpgSearchStudent.Name = "tpgSearchStudent";
            this.tpgSearchStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSearchStudent.Size = new System.Drawing.Size(792, 407);
            this.tpgSearchStudent.TabIndex = 2;
            this.tpgSearchStudent.Text = "학생조회";
            this.tpgSearchStudent.UseVisualStyleBackColor = true;
            // 
            // lblViewAvg
            // 
            this.lblViewAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblViewAvg.Location = new System.Drawing.Point(548, 305);
            this.lblViewAvg.Name = "lblViewAvg";
            this.lblViewAvg.Size = new System.Drawing.Size(144, 26);
            this.lblViewAvg.TabIndex = 16;
            this.lblViewAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(475, 305);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(67, 26);
            this.label28.TabIndex = 17;
            this.label28.Text = "평균";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblViewMin
            // 
            this.lblViewMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblViewMin.Location = new System.Drawing.Point(317, 305);
            this.lblViewMin.Name = "lblViewMin";
            this.lblViewMin.Size = new System.Drawing.Size(144, 26);
            this.lblViewMin.TabIndex = 14;
            this.lblViewMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(236, 305);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 26);
            this.label26.TabIndex = 15;
            this.label26.Text = "최소점수";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvView.Location = new System.Drawing.Point(11, 133);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowTemplate.Height = 23;
            this.dgvView.Size = new System.Drawing.Size(773, 150);
            this.dgvView.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "과목명";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "점수";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "출석";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "지각";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "결석";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnViewSearch
            // 
            this.btnViewSearch.Location = new System.Drawing.Point(346, 15);
            this.btnViewSearch.Name = "btnViewSearch";
            this.btnViewSearch.Size = new System.Drawing.Size(101, 23);
            this.btnViewSearch.TabIndex = 12;
            this.btnViewSearch.Text = "검색";
            this.btnViewSearch.UseVisualStyleBackColor = true;
            this.btnViewSearch.Click += new System.EventHandler(this.btnViewSearch_Click);
            // 
            // tbxViewSearchId
            // 
            this.tbxViewSearchId.Location = new System.Drawing.Point(158, 13);
            this.tbxViewSearchId.Name = "tbxViewSearchId";
            this.tbxViewSearchId.Size = new System.Drawing.Size(182, 26);
            this.tbxViewSearchId.TabIndex = 11;
            // 
            // lblViewName
            // 
            this.lblViewName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblViewName.Location = new System.Drawing.Point(158, 95);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(144, 26);
            this.lblViewName.TabIndex = 6;
            this.lblViewName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblViewMax
            // 
            this.lblViewMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblViewMax.Location = new System.Drawing.Point(86, 305);
            this.lblViewMax.Name = "lblViewMax";
            this.lblViewMax.Size = new System.Drawing.Size(144, 26);
            this.lblViewMax.TabIndex = 7;
            this.lblViewMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblViewId
            // 
            this.lblViewId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblViewId.Location = new System.Drawing.Point(158, 55);
            this.lblViewId.Name = "lblViewId";
            this.lblViewId.Size = new System.Drawing.Size(144, 26);
            this.lblViewId.TabIndex = 7;
            this.lblViewId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 26);
            this.label10.TabIndex = 8;
            this.label10.Text = "이름";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(8, 305);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 26);
            this.label23.TabIndex = 9;
            this.label23.Text = "최대점수";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(8, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 26);
            this.label11.TabIndex = 9;
            this.label11.Text = "학번";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(8, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 26);
            this.label12.TabIndex = 10;
            this.label12.Text = "학번";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpgAttend
            // 
            this.tpgAttend.Controls.Add(this.btnAttend2);
            this.tpgAttend.Controls.Add(this.btnAttend3);
            this.tpgAttend.Controls.Add(this.btnAttend4);
            this.tpgAttend.Controls.Add(this.btnAttend1);
            this.tpgAttend.Controls.Add(this.dgvAttend);
            this.tpgAttend.Controls.Add(this.btnAttendSearch);
            this.tpgAttend.Controls.Add(this.tbxAttendSearchId);
            this.tpgAttend.Controls.Add(this.lblAttendName);
            this.tpgAttend.Controls.Add(this.lblAttendId);
            this.tpgAttend.Controls.Add(this.label15);
            this.tpgAttend.Controls.Add(this.label16);
            this.tpgAttend.Controls.Add(this.label17);
            this.tpgAttend.Location = new System.Drawing.Point(4, 39);
            this.tpgAttend.Name = "tpgAttend";
            this.tpgAttend.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAttend.Size = new System.Drawing.Size(792, 407);
            this.tpgAttend.TabIndex = 3;
            this.tpgAttend.Text = "출석관리";
            this.tpgAttend.UseVisualStyleBackColor = true;
            // 
            // btnAttend2
            // 
            this.btnAttend2.Location = new System.Drawing.Point(469, 326);
            this.btnAttend2.Name = "btnAttend2";
            this.btnAttend2.Size = new System.Drawing.Size(101, 23);
            this.btnAttend2.TabIndex = 17;
            this.btnAttend2.Text = "출석";
            this.btnAttend2.UseVisualStyleBackColor = true;
            this.btnAttend2.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // btnAttend3
            // 
            this.btnAttend3.Location = new System.Drawing.Point(576, 326);
            this.btnAttend3.Name = "btnAttend3";
            this.btnAttend3.Size = new System.Drawing.Size(101, 23);
            this.btnAttend3.TabIndex = 16;
            this.btnAttend3.Text = "지각";
            this.btnAttend3.UseVisualStyleBackColor = true;
            this.btnAttend3.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // btnAttend4
            // 
            this.btnAttend4.Location = new System.Drawing.Point(683, 326);
            this.btnAttend4.Name = "btnAttend4";
            this.btnAttend4.Size = new System.Drawing.Size(101, 23);
            this.btnAttend4.TabIndex = 15;
            this.btnAttend4.Text = "결석";
            this.btnAttend4.UseVisualStyleBackColor = true;
            this.btnAttend4.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // btnAttend1
            // 
            this.btnAttend1.Location = new System.Drawing.Point(14, 326);
            this.btnAttend1.Name = "btnAttend1";
            this.btnAttend1.Size = new System.Drawing.Size(101, 23);
            this.btnAttend1.TabIndex = 14;
            this.btnAttend1.Text = "초기화";
            this.btnAttend1.UseVisualStyleBackColor = true;
            this.btnAttend1.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // dgvAttend
            // 
            this.dgvAttend.AllowUserToAddRows = false;
            this.dgvAttend.AllowUserToDeleteRows = false;
            this.dgvAttend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvAttend.Location = new System.Drawing.Point(14, 136);
            this.dgvAttend.Name = "dgvAttend";
            this.dgvAttend.RowTemplate.Height = 23;
            this.dgvAttend.Size = new System.Drawing.Size(770, 150);
            this.dgvAttend.TabIndex = 13;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "과목명";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "1";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "2";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "3";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "4";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 50;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "5";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 50;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "6";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 50;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "7";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 50;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "8";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 50;
            // 
            // btnAttendSearch
            // 
            this.btnAttendSearch.Location = new System.Drawing.Point(349, 17);
            this.btnAttendSearch.Name = "btnAttendSearch";
            this.btnAttendSearch.Size = new System.Drawing.Size(101, 23);
            this.btnAttendSearch.TabIndex = 12;
            this.btnAttendSearch.Text = "검색";
            this.btnAttendSearch.UseVisualStyleBackColor = true;
            this.btnAttendSearch.Click += new System.EventHandler(this.btnAttendSearch_Click);
            // 
            // tbxAttendSearchId
            // 
            this.tbxAttendSearchId.Location = new System.Drawing.Point(161, 15);
            this.tbxAttendSearchId.Name = "tbxAttendSearchId";
            this.tbxAttendSearchId.Size = new System.Drawing.Size(182, 26);
            this.tbxAttendSearchId.TabIndex = 11;
            // 
            // lblAttendName
            // 
            this.lblAttendName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttendName.Location = new System.Drawing.Point(161, 97);
            this.lblAttendName.Name = "lblAttendName";
            this.lblAttendName.Size = new System.Drawing.Size(144, 26);
            this.lblAttendName.TabIndex = 6;
            this.lblAttendName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAttendId
            // 
            this.lblAttendId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttendId.Location = new System.Drawing.Point(161, 57);
            this.lblAttendId.Name = "lblAttendId";
            this.lblAttendId.Size = new System.Drawing.Size(144, 26);
            this.lblAttendId.TabIndex = 7;
            this.lblAttendId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(11, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 26);
            this.label15.TabIndex = 8;
            this.label15.Text = "이름";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(11, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 26);
            this.label16.TabIndex = 9;
            this.label16.Text = "학번";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(11, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 26);
            this.label17.TabIndex = 10;
            this.label17.Text = "학번";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpgScore
            // 
            this.tpgScore.Controls.Add(this.btnScoreSave);
            this.tpgScore.Controls.Add(this.dgvScore);
            this.tpgScore.Controls.Add(this.btnScoreSearch);
            this.tpgScore.Controls.Add(this.tbxScoreSearchId);
            this.tpgScore.Controls.Add(this.lblScoreName);
            this.tpgScore.Controls.Add(this.lblScoreId);
            this.tpgScore.Controls.Add(this.label20);
            this.tpgScore.Controls.Add(this.label21);
            this.tpgScore.Controls.Add(this.label22);
            this.tpgScore.Location = new System.Drawing.Point(4, 39);
            this.tpgScore.Name = "tpgScore";
            this.tpgScore.Padding = new System.Windows.Forms.Padding(3);
            this.tpgScore.Size = new System.Drawing.Size(792, 407);
            this.tpgScore.TabIndex = 4;
            this.tpgScore.Text = "성적관리";
            this.tpgScore.UseVisualStyleBackColor = true;
            // 
            // btnScoreSave
            // 
            this.btnScoreSave.Location = new System.Drawing.Point(491, 299);
            this.btnScoreSave.Name = "btnScoreSave";
            this.btnScoreSave.Size = new System.Drawing.Size(101, 23);
            this.btnScoreSave.TabIndex = 14;
            this.btnScoreSave.Text = "저장";
            this.btnScoreSave.UseVisualStyleBackColor = true;
            this.btnScoreSave.Click += new System.EventHandler(this.btnScoreSave_Click);
            // 
            // dgvScore
            // 
            this.dgvScore.AllowUserToAddRows = false;
            this.dgvScore.AllowUserToDeleteRows = false;
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column16});
            this.dgvScore.Location = new System.Drawing.Point(156, 131);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.RowTemplate.Height = 23;
            this.dgvScore.Size = new System.Drawing.Size(436, 150);
            this.dgvScore.TabIndex = 13;
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column15.HeaderText = "과목명";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "성적";
            this.Column16.Name = "Column16";
            this.Column16.Width = 200;
            // 
            // btnScoreSearch
            // 
            this.btnScoreSearch.Location = new System.Drawing.Point(344, 8);
            this.btnScoreSearch.Name = "btnScoreSearch";
            this.btnScoreSearch.Size = new System.Drawing.Size(101, 23);
            this.btnScoreSearch.TabIndex = 12;
            this.btnScoreSearch.Text = "검색";
            this.btnScoreSearch.UseVisualStyleBackColor = true;
            this.btnScoreSearch.Click += new System.EventHandler(this.btnScoreSearch_Click);
            // 
            // tbxScoreSearchId
            // 
            this.tbxScoreSearchId.Location = new System.Drawing.Point(156, 6);
            this.tbxScoreSearchId.Name = "tbxScoreSearchId";
            this.tbxScoreSearchId.Size = new System.Drawing.Size(182, 26);
            this.tbxScoreSearchId.TabIndex = 11;
            // 
            // lblScoreName
            // 
            this.lblScoreName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreName.Location = new System.Drawing.Point(156, 88);
            this.lblScoreName.Name = "lblScoreName";
            this.lblScoreName.Size = new System.Drawing.Size(144, 26);
            this.lblScoreName.TabIndex = 6;
            this.lblScoreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScoreId
            // 
            this.lblScoreId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreId.Location = new System.Drawing.Point(156, 48);
            this.lblScoreId.Name = "lblScoreId";
            this.lblScoreId.Size = new System.Drawing.Size(144, 26);
            this.lblScoreId.TabIndex = 7;
            this.lblScoreId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(6, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 26);
            this.label20.TabIndex = 8;
            this.label20.Text = "이름";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(6, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(144, 26);
            this.label21.TabIndex = 9;
            this.label21.Text = "학번";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(6, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 26);
            this.label22.TabIndex = 10;
            this.label22.Text = "학번";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnlEntranceCompany.ResumeLayout(false);
            this.pnlEntranceCompany.PerformLayout();
            this.tpgRegCource.ResumeLayout(false);
            this.tpgRegCource.PerformLayout();
            this.tpgSearchStudent.ResumeLayout(false);
            this.tpgSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.tpgAttend.ResumeLayout(false);
            this.tpgAttend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttend)).EndInit();
            this.tpgScore.ResumeLayout(false);
            this.tpgScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
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
        private System.Windows.Forms.Label lblViewAvg;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lblViewMin;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnViewSearch;
        private System.Windows.Forms.TextBox tbxViewSearchId;
        private System.Windows.Forms.Label lblViewName;
        private System.Windows.Forms.Label lblViewMax;
        private System.Windows.Forms.Label lblViewId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tpgAttend;
        private System.Windows.Forms.Button btnAttend2;
        private System.Windows.Forms.Button btnAttend3;
        private System.Windows.Forms.Button btnAttend4;
        private System.Windows.Forms.Button btnAttend1;
        private System.Windows.Forms.DataGridView dgvAttend;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Button btnAttendSearch;
        private System.Windows.Forms.TextBox tbxAttendSearchId;
        private System.Windows.Forms.Label lblAttendName;
        private System.Windows.Forms.Label lblAttendId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tpgScore;
        private System.Windows.Forms.Button btnScoreSave;
        private System.Windows.Forms.DataGridView dgvScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.Button btnScoreSearch;
        private System.Windows.Forms.TextBox tbxScoreSearchId;
        private System.Windows.Forms.Label lblScoreName;
        private System.Windows.Forms.Label lblScoreId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

