namespace NurseDutyManager
{
    partial class ManageMemberForm
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.textBoxPW = new System.Windows.Forms.TextBox();
			this.textBoxSex = new System.Windows.Forms.TextBox();
			this.textBoxLicNum = new System.Windows.Forms.TextBox();
			this.textBoxPhNum = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(11, 44);
			this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(137, 304);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(158, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "이름";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(225, 75);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new System.Drawing.Size(134, 25);
			this.textBoxName.TabIndex = 3;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(225, 314);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(74, 34);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "저장";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(158, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "아이디";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(158, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "비밀번호";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(158, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 15);
			this.label5.TabIndex = 7;
			this.label5.Text = "성별";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(158, 254);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 8;
			this.label6.Text = "휴대폰";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(158, 220);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 15);
			this.label7.TabIndex = 9;
			this.label7.Text = "면허번호";
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(225, 110);
			this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.ReadOnly = true;
			this.textBoxID.Size = new System.Drawing.Size(134, 25);
			this.textBoxID.TabIndex = 10;
			// 
			// textBoxPW
			// 
			this.textBoxPW.Location = new System.Drawing.Point(225, 144);
			this.textBoxPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPW.Name = "textBoxPW";
			this.textBoxPW.Size = new System.Drawing.Size(134, 25);
			this.textBoxPW.TabIndex = 11;
			// 
			// textBoxSex
			// 
			this.textBoxSex.Location = new System.Drawing.Point(225, 178);
			this.textBoxSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxSex.Name = "textBoxSex";
			this.textBoxSex.ReadOnly = true;
			this.textBoxSex.Size = new System.Drawing.Size(134, 25);
			this.textBoxSex.TabIndex = 12;
			// 
			// textBoxLicNum
			// 
			this.textBoxLicNum.Location = new System.Drawing.Point(225, 215);
			this.textBoxLicNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxLicNum.Name = "textBoxLicNum";
			this.textBoxLicNum.ReadOnly = true;
			this.textBoxLicNum.Size = new System.Drawing.Size(134, 25);
			this.textBoxLicNum.TabIndex = 13;
			// 
			// textBoxPhNum
			// 
			this.textBoxPhNum.Location = new System.Drawing.Point(225, 250);
			this.textBoxPhNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPhNum.Name = "textBoxPhNum";
			this.textBoxPhNum.Size = new System.Drawing.Size(134, 25);
			this.textBoxPhNum.TabIndex = 14;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Group1",
            "Group2",
            "Group3"});
			this.comboBox1.Location = new System.Drawing.Point(225, 44);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(134, 23);
			this.comboBox1.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(158, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 17;
			this.label1.Text = "그룹지정";
			// 
			// ManageMemberForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 406);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBoxPhNum);
			this.Controls.Add(this.textBoxLicNum);
			this.Controls.Add(this.textBoxSex);
			this.Controls.Add(this.textBoxPW);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ManageMemberForm";
			this.Text = "간호사 관리";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.TextBox textBoxLicNum;
        private System.Windows.Forms.TextBox textBoxPhNum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}