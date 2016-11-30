/*
 * 작성: 임제희
 * Module: Dutylist
 * LOC: 185
 */
namespace NurseDutyManager
{
	partial class DutyList
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
			this.cboxYear = new System.Windows.Forms.ComboBox();
			this.cboxMonth = new System.Windows.Forms.ComboBox();
			this.lblYear = new System.Windows.Forms.Label();
			this.lblMonth = new System.Windows.Forms.Label();
			this.btnMakeDutyList = new System.Windows.Forms.Button();
			this.btnSaveList = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pBarMakeDutyList = new System.Windows.Forms.ProgressBar();
			this.lblOnProgress = new System.Windows.Forms.Label();
			this.tboxDutyList = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cboxYear
			// 
			this.cboxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxYear.FormattingEnabled = true;
			this.cboxYear.Location = new System.Drawing.Point(11, 12);
			this.cboxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboxYear.Name = "cboxYear";
			this.cboxYear.Size = new System.Drawing.Size(73, 23);
			this.cboxYear.TabIndex = 0;
			this.cboxYear.SelectedIndexChanged += new System.EventHandler(this.cboxYear_SelectedIndexChanged);
			// 
			// cboxMonth
			// 
			this.cboxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxMonth.FormattingEnabled = true;
			this.cboxMonth.Location = new System.Drawing.Point(118, 12);
			this.cboxMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboxMonth.Name = "cboxMonth";
			this.cboxMonth.Size = new System.Drawing.Size(53, 23);
			this.cboxMonth.TabIndex = 1;
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Location = new System.Drawing.Point(90, 15);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(22, 15);
			this.lblYear.TabIndex = 2;
			this.lblYear.Text = "년";
			// 
			// lblMonth
			// 
			this.lblMonth.AutoSize = true;
			this.lblMonth.Location = new System.Drawing.Point(177, 15);
			this.lblMonth.Name = "lblMonth";
			this.lblMonth.Size = new System.Drawing.Size(22, 15);
			this.lblMonth.TabIndex = 3;
			this.lblMonth.Text = "월";
			// 
			// btnMakeDutyList
			// 
			this.btnMakeDutyList.Location = new System.Drawing.Point(11, 45);
			this.btnMakeDutyList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMakeDutyList.Name = "btnMakeDutyList";
			this.btnMakeDutyList.Size = new System.Drawing.Size(173, 62);
			this.btnMakeDutyList.TabIndex = 4;
			this.btnMakeDutyList.Text = "근무표 생성";
			this.btnMakeDutyList.UseVisualStyleBackColor = true;
			this.btnMakeDutyList.Click += new System.EventHandler(this.btnMakeDutyList_Click);
			// 
			// btnSaveList
			// 
			this.btnSaveList.Location = new System.Drawing.Point(191, 45);
			this.btnSaveList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSaveList.Name = "btnSaveList";
			this.btnSaveList.Size = new System.Drawing.Size(83, 29);
			this.btnSaveList.TabIndex = 5;
			this.btnSaveList.Text = "저 장";
			this.btnSaveList.UseVisualStyleBackColor = true;
			this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(191, 79);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(83, 29);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "취 소";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.button3_Click);
			// 
			// pBarMakeDutyList
			// 
			this.pBarMakeDutyList.Location = new System.Drawing.Point(395, 79);
			this.pBarMakeDutyList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pBarMakeDutyList.Name = "pBarMakeDutyList";
			this.pBarMakeDutyList.Size = new System.Drawing.Size(239, 22);
			this.pBarMakeDutyList.TabIndex = 7;
			this.pBarMakeDutyList.Visible = false;
			// 
			// lblOnProgress
			// 
			this.lblOnProgress.AutoSize = true;
			this.lblOnProgress.Location = new System.Drawing.Point(469, 45);
			this.lblOnProgress.Name = "lblOnProgress";
			this.lblOnProgress.Size = new System.Drawing.Size(97, 15);
			this.lblOnProgress.TabIndex = 8;
			this.lblOnProgress.Text = "생성중입니다";
			this.lblOnProgress.Visible = false;
			// 
			// tboxDutyList
			// 
			this.tboxDutyList.Location = new System.Drawing.Point(11, 134);
			this.tboxDutyList.Multiline = true;
			this.tboxDutyList.Name = "tboxDutyList";
			this.tboxDutyList.ReadOnly = true;
			this.tboxDutyList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tboxDutyList.Size = new System.Drawing.Size(744, 362);
			this.tboxDutyList.TabIndex = 9;
			// 
			// DutyList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 508);
			this.Controls.Add(this.tboxDutyList);
			this.Controls.Add(this.lblOnProgress);
			this.Controls.Add(this.pBarMakeDutyList);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveList);
			this.Controls.Add(this.btnMakeDutyList);
			this.Controls.Add(this.lblMonth);
			this.Controls.Add(this.lblYear);
			this.Controls.Add(this.cboxMonth);
			this.Controls.Add(this.cboxYear);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "DutyList";
			this.Text = "근무표 생성";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboxYear;
		private System.Windows.Forms.ComboBox cboxMonth;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.Label lblMonth;
		private System.Windows.Forms.Button btnMakeDutyList;
		private System.Windows.Forms.Button btnSaveList;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ProgressBar pBarMakeDutyList;
		private System.Windows.Forms.Label lblOnProgress;
		private System.Windows.Forms.TextBox tboxDutyList;
	}
}