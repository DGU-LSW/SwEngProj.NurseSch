﻿/*
 * 작성: 정창훈
 * Module: FindInfo
 * LOC: 272
 */
namespace NurseDutyManager
{
    partial class Find_Info
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonFind_ID = new System.Windows.Forms.Button();
			this.textBoxLicNum_ID = new System.Windows.Forms.TextBox();
			this.textBoxName_ID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBoxLicNum_PW = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonFind_PW = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBoxName_PW = new System.Windows.Forms.TextBox();
			this.textBoxID_PW = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(286, 249);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.buttonFind_ID);
			this.tabPage1.Controls.Add(this.textBoxLicNum_ID);
			this.tabPage1.Controls.Add(this.textBoxName_ID);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage1.Size = new System.Drawing.Size(278, 223);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "ID찾기";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(93, 63);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "취소";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button4_Click);
			// 
			// buttonFind_ID
			// 
			this.buttonFind_ID.Location = new System.Drawing.Point(12, 63);
			this.buttonFind_ID.Name = "buttonFind_ID";
			this.buttonFind_ID.Size = new System.Drawing.Size(75, 23);
			this.buttonFind_ID.TabIndex = 3;
			this.buttonFind_ID.Text = "확인";
			this.buttonFind_ID.UseVisualStyleBackColor = true;
			this.buttonFind_ID.Click += new System.EventHandler(this.buttonFind_ID_Click);
			// 
			// textBoxLicNum_ID
			// 
			this.textBoxLicNum_ID.Location = new System.Drawing.Point(68, 36);
			this.textBoxLicNum_ID.Name = "textBoxLicNum_ID";
			this.textBoxLicNum_ID.Size = new System.Drawing.Size(100, 21);
			this.textBoxLicNum_ID.TabIndex = 2;
			// 
			// textBoxName_ID
			// 
			this.textBoxName_ID.Location = new System.Drawing.Point(68, 6);
			this.textBoxName_ID.Name = "textBoxName_ID";
			this.textBoxName_ID.Size = new System.Drawing.Size(100, 21);
			this.textBoxName_ID.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "면허번호";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 10;
			this.label1.Text = "이름";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBoxLicNum_PW);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.buttonFind_PW);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.textBoxName_PW);
			this.tabPage2.Controls.Add(this.textBoxID_PW);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage2.Size = new System.Drawing.Size(278, 223);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "PW찾기";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBoxLicNum_PW
			// 
			this.textBoxLicNum_PW.Location = new System.Drawing.Point(68, 63);
			this.textBoxLicNum_PW.Name = "textBoxLicNum_PW";
			this.textBoxLicNum_PW.Size = new System.Drawing.Size(100, 21);
			this.textBoxLicNum_PW.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 14;
			this.label5.Text = "면허번호";
			// 
			// buttonFind_PW
			// 
			this.buttonFind_PW.Location = new System.Drawing.Point(12, 90);
			this.buttonFind_PW.Name = "buttonFind_PW";
			this.buttonFind_PW.Size = new System.Drawing.Size(75, 23);
			this.buttonFind_PW.TabIndex = 8;
			this.buttonFind_PW.Text = "확인";
			this.buttonFind_PW.UseVisualStyleBackColor = true;
			this.buttonFind_PW.Click += new System.EventHandler(this.buttonFind_PW_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(93, 90);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 9;
			this.button4.Text = "취소";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBoxName_PW
			// 
			this.textBoxName_PW.Location = new System.Drawing.Point(68, 9);
			this.textBoxName_PW.Name = "textBoxName_PW";
			this.textBoxName_PW.Size = new System.Drawing.Size(100, 21);
			this.textBoxName_PW.TabIndex = 5;
			// 
			// textBoxID_PW
			// 
			this.textBoxID_PW.Location = new System.Drawing.Point(68, 36);
			this.textBoxID_PW.Name = "textBoxID_PW";
			this.textBoxID_PW.Size = new System.Drawing.Size(100, 21);
			this.textBoxID_PW.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "이름";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 12);
			this.label4.TabIndex = 13;
			this.label4.Text = "ID";
			// 
			// Find_Info
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.tabControl1);
			this.Name = "Find_Info";
			this.Text = "ID,PW 찾기";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonFind_ID;
        private System.Windows.Forms.TextBox textBoxLicNum_ID;
        private System.Windows.Forms.TextBox textBoxName_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLicNum_PW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFind_PW;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxName_PW;
        private System.Windows.Forms.TextBox textBoxID_PW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}