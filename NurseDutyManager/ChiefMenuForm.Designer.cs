/*
 * 작성: 이신우
 * Module: ChiefMenuForm
 * LOC: 132
 */
namespace NurseDutyManager
{
    partial class ChiefMenuForm
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
            this.CreateSchButton = new System.Windows.Forms.Button();
            this.MangNurButton = new System.Windows.Forms.Button();
            this.OptButton = new System.Windows.Forms.Button();
            this.ChcekSchButton = new System.Windows.Forms.Button();
            this.ApplyOffButton = new System.Windows.Forms.Button();
            this.ModifyInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateSchButton
            // 
            this.CreateSchButton.Location = new System.Drawing.Point(10, 10);
            this.CreateSchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateSchButton.Name = "CreateSchButton";
            this.CreateSchButton.Size = new System.Drawing.Size(98, 49);
            this.CreateSchButton.TabIndex = 0;
            this.CreateSchButton.Text = "근무표 생성";
            this.CreateSchButton.UseVisualStyleBackColor = true;
            // 
            // MangNurButton
            // 
            this.MangNurButton.Location = new System.Drawing.Point(114, 10);
            this.MangNurButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MangNurButton.Name = "MangNurButton";
            this.MangNurButton.Size = new System.Drawing.Size(98, 49);
            this.MangNurButton.TabIndex = 1;
            this.MangNurButton.Text = "간호사 관리";
            this.MangNurButton.UseVisualStyleBackColor = true;
            // 
            // OptButton
            // 
            this.OptButton.Location = new System.Drawing.Point(217, 10);
            this.OptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptButton.Name = "OptButton";
            this.OptButton.Size = new System.Drawing.Size(98, 49);
            this.OptButton.TabIndex = 2;
            this.OptButton.Text = "옵션";
            this.OptButton.UseVisualStyleBackColor = true;
            // 
            // ChcekSchButton
            // 
            this.ChcekSchButton.Location = new System.Drawing.Point(10, 63);
            this.ChcekSchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChcekSchButton.Name = "ChcekSchButton";
            this.ChcekSchButton.Size = new System.Drawing.Size(98, 49);
            this.ChcekSchButton.TabIndex = 3;
            this.ChcekSchButton.Text = "표확인";
            this.ChcekSchButton.UseVisualStyleBackColor = true;
            this.ChcekSchButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ApplyOffButton
            // 
            this.ApplyOffButton.Location = new System.Drawing.Point(114, 63);
            this.ApplyOffButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplyOffButton.Name = "ApplyOffButton";
            this.ApplyOffButton.Size = new System.Drawing.Size(98, 49);
            this.ApplyOffButton.TabIndex = 4;
            this.ApplyOffButton.Text = "Off 신청";
            this.ApplyOffButton.UseVisualStyleBackColor = true;
            // 
            // ModifyInfoButton
            // 
            this.ModifyInfoButton.Location = new System.Drawing.Point(217, 64);
            this.ModifyInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyInfoButton.Name = "ModifyInfoButton";
            this.ModifyInfoButton.Size = new System.Drawing.Size(98, 48);
            this.ModifyInfoButton.TabIndex = 5;
            this.ModifyInfoButton.Text = "개인정보 수정";
            this.ModifyInfoButton.UseVisualStyleBackColor = true;
            // 
            // ChiefMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 121);
            this.Controls.Add(this.ModifyInfoButton);
            this.Controls.Add(this.ApplyOffButton);
            this.Controls.Add(this.ChcekSchButton);
            this.Controls.Add(this.OptButton);
            this.Controls.Add(this.MangNurButton);
            this.Controls.Add(this.CreateSchButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChiefMenuForm";
            this.Text = "수간호사 Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateSchButton;
        private System.Windows.Forms.Button MangNurButton;
        private System.Windows.Forms.Button OptButton;
        private System.Windows.Forms.Button ChcekSchButton;
        private System.Windows.Forms.Button ApplyOffButton;
        private System.Windows.Forms.Button ModifyInfoButton;
    }
}