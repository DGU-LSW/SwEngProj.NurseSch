using System.Windows.Forms;
using System;
/*
 * 작성: 정창훈, 이신우, 김수희, 임제희 
 * Module: UI
 * LOC: 422
 */
namespace NurseDutyManager
{
    //http://stackoverflow.com/questions/2340566/creating-wizards-for-windows-forms-in-c-sharp/2342320#2342320
    public class WizardPages : System.Windows.Forms.TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }

        protected override void OnKeyDown(KeyEventArgs ke)
        {
            // Block Ctrl+Tab and Ctrl+Shift+Tab hotkeys
            if (ke.Control && ke.KeyCode == Keys.Tab)
                return;
            base.OnKeyDown(ke);
        }
    }

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
			this.tabControl1 = new NurseDutyManager.WizardPages();
			this.tabPageLogin = new System.Windows.Forms.TabPage();
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
			this.tabPageChief = new System.Windows.Forms.TabPage();
			this.panelChiefMenu = new System.Windows.Forms.Panel();
			this.buttonModifyInfo_chief = new System.Windows.Forms.Button();
			this.buttonApplyOff_chief = new System.Windows.Forms.Button();
			this.buttonChcekSch_chief = new System.Windows.Forms.Button();
			this.buttonOpt = new System.Windows.Forms.Button();
			this.buttonMangNur = new System.Windows.Forms.Button();
			this.buttonCreateSch = new System.Windows.Forms.Button();
			this.tabPageGenaral = new System.Windows.Forms.TabPage();
			this.panelNurseMenu = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPageLogin.SuspendLayout();
			this.panelLogin.SuspendLayout();
			this.tabPageChief.SuspendLayout();
			this.panelChiefMenu.SuspendLayout();
			this.tabPageGenaral.SuspendLayout();
			this.panelNurseMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageLogin);
			this.tabControl1.Controls.Add(this.tabPageChief);
			this.tabControl1.Controls.Add(this.tabPageGenaral);
			this.tabControl1.Location = new System.Drawing.Point(10, 10);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(446, 222);
			this.tabControl1.TabIndex = 100;
			this.tabControl1.TabStop = false;
			// 
			// tabPageLogin
			// 
			this.tabPageLogin.Controls.Add(this.panelLogin);
			this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
			this.tabPageLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageLogin.Name = "tabPageLogin";
			this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageLogin.Size = new System.Drawing.Size(438, 196);
			this.tabPageLogin.TabIndex = 0;
			this.tabPageLogin.Text = "tabPageLogin";
			this.tabPageLogin.UseVisualStyleBackColor = true;
			// 
			// panelLogin
			// 
			this.panelLogin.Controls.Add(this.label4);
			this.panelLogin.Controls.Add(this.label3);
			this.panelLogin.Controls.Add(this.label2);
			this.panelLogin.Controls.Add(this.label1);
			this.panelLogin.Controls.Add(this.textBoxPW);
			this.panelLogin.Controls.Add(this.textBoxID);
			this.panelLogin.Controls.Add(this.buttonLogin);
			this.panelLogin.Controls.Add(this.buttonSearch);
			this.panelLogin.Controls.Add(this.buttonRegist);
			this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLogin.Location = new System.Drawing.Point(3, 2);
			this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(432, 192);
			this.panelLogin.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("굴림", 18F);
			this.label4.ForeColor = System.Drawing.Color.DarkViolet;
			this.label4.Location = new System.Drawing.Point(51, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(213, 24);
			this.label4.TabIndex = 17;
			this.label4.Text = " Scheduling System";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("굴림", 18F);
			this.label3.ForeColor = System.Drawing.Color.DarkViolet;
			this.label3.Location = new System.Drawing.Point(21, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(197, 24);
			this.label3.TabIndex = 16;
			this.label3.Text = "Nursing Manpower";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 12);
			this.label2.TabIndex = 15;
			this.label2.Text = "PW";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 12);
			this.label1.TabIndex = 14;
			this.label1.Text = "ID";
			// 
			// textBoxPW
			// 
			this.textBoxPW.Location = new System.Drawing.Point(47, 113);
			this.textBoxPW.Name = "textBoxPW";
			this.textBoxPW.Size = new System.Drawing.Size(139, 21);
			this.textBoxPW.TabIndex = 2;
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(47, 86);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(139, 21);
			this.textBoxID.TabIndex = 1;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(192, 86);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 48);
			this.buttonLogin.TabIndex = 3;
			this.buttonLogin.Text = "로그인";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(129, 152);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(82, 23);
			this.buttonSearch.TabIndex = 5;
			this.buttonSearch.Text = "ID/PW 찾기";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonRegist
			// 
			this.buttonRegist.Location = new System.Drawing.Point(47, 152);
			this.buttonRegist.Name = "buttonRegist";
			this.buttonRegist.Size = new System.Drawing.Size(75, 23);
			this.buttonRegist.TabIndex = 4;
			this.buttonRegist.Text = "회원가입";
			this.buttonRegist.UseVisualStyleBackColor = true;
			this.buttonRegist.Click += new System.EventHandler(this.buttonRegist_Click);
			// 
			// tabPageChief
			// 
			this.tabPageChief.Controls.Add(this.panelChiefMenu);
			this.tabPageChief.Location = new System.Drawing.Point(4, 22);
			this.tabPageChief.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageChief.Name = "tabPageChief";
			this.tabPageChief.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageChief.Size = new System.Drawing.Size(438, 196);
			this.tabPageChief.TabIndex = 1;
			this.tabPageChief.Text = "tabPageChief";
			this.tabPageChief.UseVisualStyleBackColor = true;
			// 
			// panelChiefMenu
			// 
			this.panelChiefMenu.Controls.Add(this.buttonModifyInfo_chief);
			this.panelChiefMenu.Controls.Add(this.buttonApplyOff_chief);
			this.panelChiefMenu.Controls.Add(this.buttonChcekSch_chief);
			this.panelChiefMenu.Controls.Add(this.buttonOpt);
			this.panelChiefMenu.Controls.Add(this.buttonMangNur);
			this.panelChiefMenu.Controls.Add(this.buttonCreateSch);
			this.panelChiefMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChiefMenu.Location = new System.Drawing.Point(3, 2);
			this.panelChiefMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelChiefMenu.Name = "panelChiefMenu";
			this.panelChiefMenu.Size = new System.Drawing.Size(432, 192);
			this.panelChiefMenu.TabIndex = 1;
			// 
			// buttonModifyInfo_chief
			// 
			this.buttonModifyInfo_chief.Location = new System.Drawing.Point(232, 89);
			this.buttonModifyInfo_chief.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonModifyInfo_chief.Name = "buttonModifyInfo_chief";
			this.buttonModifyInfo_chief.Size = new System.Drawing.Size(98, 48);
			this.buttonModifyInfo_chief.TabIndex = 11;
			this.buttonModifyInfo_chief.Text = "개인정보 수정";
			this.buttonModifyInfo_chief.UseVisualStyleBackColor = true;
			this.buttonModifyInfo_chief.Click += new System.EventHandler(this.buttonModifyInfo_chief_Click);
			// 
			// buttonApplyOff_chief
			// 
			this.buttonApplyOff_chief.Location = new System.Drawing.Point(129, 88);
			this.buttonApplyOff_chief.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonApplyOff_chief.Name = "buttonApplyOff_chief";
			this.buttonApplyOff_chief.Size = new System.Drawing.Size(98, 49);
			this.buttonApplyOff_chief.TabIndex = 10;
			this.buttonApplyOff_chief.Text = "Off 신청";
			this.buttonApplyOff_chief.UseVisualStyleBackColor = true;
			this.buttonApplyOff_chief.Click += new System.EventHandler(this.buttonApplyOff_chief_Click);
			// 
			// buttonChcekSch_chief
			// 
			this.buttonChcekSch_chief.Location = new System.Drawing.Point(25, 88);
			this.buttonChcekSch_chief.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonChcekSch_chief.Name = "buttonChcekSch_chief";
			this.buttonChcekSch_chief.Size = new System.Drawing.Size(98, 49);
			this.buttonChcekSch_chief.TabIndex = 9;
			this.buttonChcekSch_chief.Text = "표확인";
			this.buttonChcekSch_chief.UseVisualStyleBackColor = true;
			this.buttonChcekSch_chief.Click += new System.EventHandler(this.buttonChcekSch_chief_Click);
			// 
			// buttonOpt
			// 
			this.buttonOpt.Location = new System.Drawing.Point(232, 34);
			this.buttonOpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonOpt.Name = "buttonOpt";
			this.buttonOpt.Size = new System.Drawing.Size(98, 49);
			this.buttonOpt.TabIndex = 8;
			this.buttonOpt.Text = "옵션";
			this.buttonOpt.UseVisualStyleBackColor = true;
			this.buttonOpt.Click += new System.EventHandler(this.buttonOpt_Click);
			// 
			// buttonMangNur
			// 
			this.buttonMangNur.Location = new System.Drawing.Point(129, 34);
			this.buttonMangNur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonMangNur.Name = "buttonMangNur";
			this.buttonMangNur.Size = new System.Drawing.Size(98, 49);
			this.buttonMangNur.TabIndex = 7;
			this.buttonMangNur.Text = "간호사 관리";
			this.buttonMangNur.UseVisualStyleBackColor = true;
			this.buttonMangNur.Click += new System.EventHandler(this.buttonMangNur_Click);
			// 
			// buttonCreateSch
			// 
			this.buttonCreateSch.Location = new System.Drawing.Point(25, 34);
			this.buttonCreateSch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonCreateSch.Name = "buttonCreateSch";
			this.buttonCreateSch.Size = new System.Drawing.Size(98, 49);
			this.buttonCreateSch.TabIndex = 6;
			this.buttonCreateSch.Text = "근무표 생성";
			this.buttonCreateSch.UseVisualStyleBackColor = true;
			this.buttonCreateSch.Click += new System.EventHandler(this.buttonCreateSch_Click);
			// 
			// tabPageGenaral
			// 
			this.tabPageGenaral.Controls.Add(this.panelNurseMenu);
			this.tabPageGenaral.Location = new System.Drawing.Point(4, 22);
			this.tabPageGenaral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageGenaral.Name = "tabPageGenaral";
			this.tabPageGenaral.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabPageGenaral.Size = new System.Drawing.Size(438, 196);
			this.tabPageGenaral.TabIndex = 2;
			this.tabPageGenaral.Text = "tabPageGenaral";
			this.tabPageGenaral.UseVisualStyleBackColor = true;
			// 
			// panelNurseMenu
			// 
			this.panelNurseMenu.Controls.Add(this.button1);
			this.panelNurseMenu.Controls.Add(this.button2);
			this.panelNurseMenu.Controls.Add(this.button3);
			this.panelNurseMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelNurseMenu.Location = new System.Drawing.Point(3, 2);
			this.panelNurseMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelNurseMenu.Name = "panelNurseMenu";
			this.panelNurseMenu.Size = new System.Drawing.Size(432, 192);
			this.panelNurseMenu.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(216, 14);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 48);
			this.button1.TabIndex = 14;
			this.button1.Text = "개인정보 수정";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(113, 14);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 49);
			this.button2.TabIndex = 13;
			this.button2.Text = "Off 신청";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(10, 14);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(98, 49);
			this.button3.TabIndex = 12;
			this.button3.Text = "표확인";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// UI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 241);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "UI";
			this.Text = "근무표 자동 생성 프로그램";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_FormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPageLogin.ResumeLayout(false);
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			this.tabPageChief.ResumeLayout(false);
			this.panelChiefMenu.ResumeLayout(false);
			this.tabPageGenaral.ResumeLayout(false);
			this.panelNurseMenu.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelChiefMenu;
		private System.Windows.Forms.Panel panelNurseMenu;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private WizardPages tabControl1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageChief;
        private System.Windows.Forms.TabPage tabPageGenaral;
    }
    
}