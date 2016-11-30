/*
 * 작성: 임제희
 * Module: ApplyOff
 * LOC: 150
 */
namespace NurseDutyManager
{
	partial class ApplyOff
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
			this.rbtnOff = new System.Windows.Forms.RadioButton();
			this.rbtnHoliday = new System.Windows.Forms.RadioButton();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.lboxHoliday = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rbtnOff
			// 
			this.rbtnOff.AutoSize = true;
			this.rbtnOff.ForeColor = System.Drawing.Color.Red;
			this.rbtnOff.Location = new System.Drawing.Point(18, 258);
			this.rbtnOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtnOff.Name = "rbtnOff";
			this.rbtnOff.Size = new System.Drawing.Size(58, 19);
			this.rbtnOff.TabIndex = 8;
			this.rbtnOff.TabStop = true;
			this.rbtnOff.Text = "휴일";
			this.rbtnOff.UseVisualStyleBackColor = true;
			this.rbtnOff.CheckedChanged += new System.EventHandler(this.rbtnOff_CheckedChanged);
			// 
			// rbtnHoliday
			// 
			this.rbtnHoliday.AutoSize = true;
			this.rbtnHoliday.ForeColor = System.Drawing.Color.Blue;
			this.rbtnHoliday.Location = new System.Drawing.Point(82, 258);
			this.rbtnHoliday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtnHoliday.Name = "rbtnHoliday";
			this.rbtnHoliday.Size = new System.Drawing.Size(58, 19);
			this.rbtnHoliday.TabIndex = 9;
			this.rbtnHoliday.TabStop = true;
			this.rbtnHoliday.Text = "휴가";
			this.rbtnHoliday.UseVisualStyleBackColor = true;
			this.rbtnHoliday.CheckedChanged += new System.EventHandler(this.rbtnHoliday_CheckedChanged);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(127, 313);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(97, 40);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "저장";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(230, 313);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(103, 40);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "취소";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 13;
			// 
			// lboxHoliday
			// 
			this.lboxHoliday.FormattingEnabled = true;
			this.lboxHoliday.ItemHeight = 15;
			this.lboxHoliday.Location = new System.Drawing.Point(281, 18);
			this.lboxHoliday.Name = "lboxHoliday";
			this.lboxHoliday.Size = new System.Drawing.Size(173, 259);
			this.lboxHoliday.TabIndex = 14;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(18, 313);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(103, 40);
			this.btnAdd.TabIndex = 15;
			this.btnAdd.Text = "추가";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// ApplyOff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 382);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lboxHoliday);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.rbtnHoliday);
			this.Controls.Add(this.rbtnOff);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ApplyOff";
			this.Text = "근무표확인";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RadioButton rbtnOff;
		private System.Windows.Forms.RadioButton rbtnHoliday;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.ListBox lboxHoliday;
		private System.Windows.Forms.Button btnAdd;
	}
}