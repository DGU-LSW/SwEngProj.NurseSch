namespace NurseDutyManager
{
    partial class UI
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRegist = new System.Windows.Forms.Button();
            this.panelChiefMenu = new System.Windows.Forms.Panel();
            this.buttonModifyInfo_chief = new System.Windows.Forms.Button();
            this.buttonApplyOff_chief = new System.Windows.Forms.Button();
            this.buttonChcekSch_chief = new System.Windows.Forms.Button();
            this.buttonOpt = new System.Windows.Forms.Button();
            this.buttonMangNur = new System.Windows.Forms.Button();
            this.buttonCreateSch = new System.Windows.Forms.Button();
            this.panelNurseMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelChiefMenu.SuspendLayout();
            this.panelNurseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.panelChiefMenu);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.textBoxPW);
            this.panelLogin.Controls.Add(this.textBoxID);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.buttonSearch);
            this.panelLogin.Controls.Add(this.buttonRegist);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(522, 325);
            this.panelLogin.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 18F);
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(58, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = " Scheduling System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Gulim", 18F);
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nursing Manpower";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "PW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(54, 141);
            this.textBoxPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(158, 25);
            this.textBoxPW.TabIndex = 13;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(54, 107);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(158, 25);
            this.textBoxID.TabIndex = 12;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(220, 107);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(86, 60);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(147, 190);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "ID/PW 찾기";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRegist
            // 
            this.buttonRegist.Location = new System.Drawing.Point(54, 190);
            this.buttonRegist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRegist.Name = "buttonRegist";
            this.buttonRegist.Size = new System.Drawing.Size(86, 29);
            this.buttonRegist.TabIndex = 9;
            this.buttonRegist.Text = "회원가입";
            this.buttonRegist.UseVisualStyleBackColor = true;
            this.buttonRegist.Click += new System.EventHandler(this.buttonRegist_Click);
            // 
            // panelChiefMenu
            // 
            this.panelChiefMenu.Controls.Add(this.panelNurseMenu);
            this.panelChiefMenu.Controls.Add(this.buttonModifyInfo_chief);
            this.panelChiefMenu.Controls.Add(this.buttonApplyOff_chief);
            this.panelChiefMenu.Controls.Add(this.buttonChcekSch_chief);
            this.panelChiefMenu.Controls.Add(this.buttonOpt);
            this.panelChiefMenu.Controls.Add(this.buttonMangNur);
            this.panelChiefMenu.Controls.Add(this.buttonCreateSch);
            this.panelChiefMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChiefMenu.Location = new System.Drawing.Point(0, 0);
            this.panelChiefMenu.Name = "panelChiefMenu";
            this.panelChiefMenu.Size = new System.Drawing.Size(522, 325);
            this.panelChiefMenu.TabIndex = 1;
            this.panelChiefMenu.Visible = false;
            // 
            // buttonModifyInfo_chief
            // 
            this.buttonModifyInfo_chief.Location = new System.Drawing.Point(265, 111);
            this.buttonModifyInfo_chief.Name = "buttonModifyInfo_chief";
            this.buttonModifyInfo_chief.Size = new System.Drawing.Size(112, 60);
            this.buttonModifyInfo_chief.TabIndex = 11;
            this.buttonModifyInfo_chief.Text = "개인정보 수정";
            this.buttonModifyInfo_chief.UseVisualStyleBackColor = true;
            this.buttonModifyInfo_chief.Click += new System.EventHandler(this.buttonModifyInfo_chief_Click);
            // 
            // buttonApplyOff_chief
            // 
            this.buttonApplyOff_chief.Location = new System.Drawing.Point(147, 110);
            this.buttonApplyOff_chief.Name = "buttonApplyOff_chief";
            this.buttonApplyOff_chief.Size = new System.Drawing.Size(112, 61);
            this.buttonApplyOff_chief.TabIndex = 10;
            this.buttonApplyOff_chief.Text = "Off 신청";
            this.buttonApplyOff_chief.UseVisualStyleBackColor = true;
            this.buttonApplyOff_chief.Click += new System.EventHandler(this.buttonApplyOff_chief_Click);
            // 
            // buttonChcekSch_chief
            // 
            this.buttonChcekSch_chief.Location = new System.Drawing.Point(29, 110);
            this.buttonChcekSch_chief.Name = "buttonChcekSch_chief";
            this.buttonChcekSch_chief.Size = new System.Drawing.Size(112, 61);
            this.buttonChcekSch_chief.TabIndex = 9;
            this.buttonChcekSch_chief.Text = "표확인";
            this.buttonChcekSch_chief.UseVisualStyleBackColor = true;
            this.buttonChcekSch_chief.Click += new System.EventHandler(this.buttonChcekSch_chief_Click);
            // 
            // buttonOpt
            // 
            this.buttonOpt.Location = new System.Drawing.Point(265, 43);
            this.buttonOpt.Name = "buttonOpt";
            this.buttonOpt.Size = new System.Drawing.Size(112, 61);
            this.buttonOpt.TabIndex = 8;
            this.buttonOpt.Text = "옵션";
            this.buttonOpt.UseVisualStyleBackColor = true;
            this.buttonOpt.Click += new System.EventHandler(this.buttonOpt_Click);
            // 
            // buttonMangNur
            // 
            this.buttonMangNur.Location = new System.Drawing.Point(147, 43);
            this.buttonMangNur.Name = "buttonMangNur";
            this.buttonMangNur.Size = new System.Drawing.Size(112, 61);
            this.buttonMangNur.TabIndex = 7;
            this.buttonMangNur.Text = "간호사 관리";
            this.buttonMangNur.UseVisualStyleBackColor = true;
            this.buttonMangNur.Click += new System.EventHandler(this.buttonMangNur_Click);
            // 
            // buttonCreateSch
            // 
            this.buttonCreateSch.Location = new System.Drawing.Point(29, 43);
            this.buttonCreateSch.Name = "buttonCreateSch";
            this.buttonCreateSch.Size = new System.Drawing.Size(112, 61);
            this.buttonCreateSch.TabIndex = 6;
            this.buttonCreateSch.Text = "근무표 생성";
            this.buttonCreateSch.UseVisualStyleBackColor = true;
            this.buttonCreateSch.Click += new System.EventHandler(this.buttonCreateSch_Click);
            // 
            // panelNurseMenu
            // 
            this.panelNurseMenu.Controls.Add(this.button1);
            this.panelNurseMenu.Controls.Add(this.button2);
            this.panelNurseMenu.Controls.Add(this.button3);
            this.panelNurseMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNurseMenu.Location = new System.Drawing.Point(0, 0);
            this.panelNurseMenu.Name = "panelNurseMenu";
            this.panelNurseMenu.Size = new System.Drawing.Size(522, 325);
            this.panelNurseMenu.TabIndex = 2;
            this.panelNurseMenu.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 60);
            this.button1.TabIndex = 14;
            this.button1.Text = "개인정보 수정";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 61);
            this.button2.TabIndex = 13;
            this.button2.Text = "Off 신청";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 61);
            this.button3.TabIndex = 12;
            this.button3.Text = "표확인";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 325);
            this.Controls.Add(this.panelLogin);
            this.Name = "UI";
            this.Text = "UI";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelChiefMenu.ResumeLayout(false);
            this.panelNurseMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelChiefMenu;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRegist;
        private System.Windows.Forms.Button buttonModifyInfo_chief;
        private System.Windows.Forms.Button buttonApplyOff_chief;
        private System.Windows.Forms.Button buttonChcekSch_chief;
        private System.Windows.Forms.Button buttonOpt;
        private System.Windows.Forms.Button buttonMangNur;
        private System.Windows.Forms.Button buttonCreateSch;
        private System.Windows.Forms.Panel panelNurseMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}