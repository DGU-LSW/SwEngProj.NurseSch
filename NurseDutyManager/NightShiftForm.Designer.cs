/*
 * 작성: 김수희 
 * Module: NightShiftForm
 * LOC: 151
 */
namespace NurseDutyManager
{
    partial class NightShiftForm
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// Required designer variable.

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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Group1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Group2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Group3";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(74, 226);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(86, 29);
			this.button1.TabIndex = 3;
			this.button1.Text = "확인";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(167, 226);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 29);
			this.button2.TabIndex = 4;
			this.button2.Text = "취소";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(116, 57);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(137, 25);
			this.numericUpDown1.TabIndex = 5;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(114, 115);
			this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(137, 25);
			this.numericUpDown2.TabIndex = 6;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(114, 178);
			this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(137, 25);
			this.numericUpDown3.TabIndex = 7;
			// 
			// NightShiftForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 325);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "NightShiftForm";
			this.Text = "월별 Night 근무 설정";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}