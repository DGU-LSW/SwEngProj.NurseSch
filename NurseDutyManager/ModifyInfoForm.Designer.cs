namespace NurseDutyManager
{
    partial class ModifyInfoForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPh = new System.Windows.Forms.TextBox();
            this.textBoxLic = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.textBoxPW2 = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "간호사유형";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "남",
            "여"});
            this.comboBoxSex.Location = new System.Drawing.Point(103, 183);
            this.comboBoxSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(114, 23);
            this.comboBoxSex.TabIndex = 44;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "수간호사",
            "일반간호사"});
            this.comboBoxType.Location = new System.Drawing.Point(103, 15);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(114, 23);
            this.comboBoxType.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "성별";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "(- 제외)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 283);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 39;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(70, 283);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 29);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "수정완료";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 48);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(114, 25);
            this.textBoxName.TabIndex = 37;
            // 
            // textBoxPh
            // 
            this.textBoxPh.Location = new System.Drawing.Point(103, 249);
            this.textBoxPh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPh.Name = "textBoxPh";
            this.textBoxPh.Size = new System.Drawing.Size(114, 25);
            this.textBoxPh.TabIndex = 36;
            // 
            // textBoxLic
            // 
            this.textBoxLic.Location = new System.Drawing.Point(103, 215);
            this.textBoxLic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLic.Name = "textBoxLic";
            this.textBoxLic.Size = new System.Drawing.Size(114, 25);
            this.textBoxLic.TabIndex = 35;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(103, 115);
            this.textBoxPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(114, 25);
            this.textBoxPW.TabIndex = 34;
            // 
            // textBoxPW2
            // 
            this.textBoxPW2.Location = new System.Drawing.Point(103, 149);
            this.textBoxPW2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPW2.Name = "textBoxPW2";
            this.textBoxPW2.Size = new System.Drawing.Size(114, 25);
            this.textBoxPW2.TabIndex = 33;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(103, 81);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(114, 25);
            this.textBoxID.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "휴대폰";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "면허번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "비밀번호확인";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "이름";
            // 
            // ModifyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 326);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPh);
            this.Controls.Add(this.textBoxLic);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxPW2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifyInfoForm";
            this.Text = "개인정보수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPh;
        private System.Windows.Forms.TextBox textBoxLic;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.TextBox textBoxPW2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}