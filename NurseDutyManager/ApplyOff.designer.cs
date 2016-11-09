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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(17, 54);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(62, 23);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(113, 54);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(56, 23);
			this.comboBox2.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("굴림", 15F);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Off 신청";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(175, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "월";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(85, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "년";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(203, 53);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "조회";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.ForeColor = System.Drawing.Color.Red;
			this.radioButton1.Location = new System.Drawing.Point(315, 55);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(58, 19);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "휴일";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.ForeColor = System.Drawing.Color.Blue;
			this.radioButton2.Location = new System.Drawing.Point(379, 55);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(58, 19);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "휴가";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 7;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label8, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.label9, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.label10, 6, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 113);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 338);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "label4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(117, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(231, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 15);
			this.label6.TabIndex = 2;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(345, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 15);
			this.label7.TabIndex = 3;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(459, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 15);
			this.label8.TabIndex = 4;
			this.label8.Text = "label8";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(573, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 15);
			this.label9.TabIndex = 5;
			this.label9.Text = "label9";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(687, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 15);
			this.label10.TabIndex = 6;
			this.label10.Text = "label10";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(267, 473);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "신청";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(462, 473);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "취소";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ApplyOff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(825, 518);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "ApplyOff";
			this.Text = "Nurse Duty Manager";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
	}
}

