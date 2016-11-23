namespace NurseDutyManager
{
    partial class GeneralMenuForm
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
            this.ChcekSchButton = new System.Windows.Forms.Button();
            this.ApplyOffButton = new System.Windows.Forms.Button();
            this.ModifyInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChcekSchButton
            // 
            this.ChcekSchButton.Location = new System.Drawing.Point(15, 34);
            this.ChcekSchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChcekSchButton.Name = "ChcekSchButton";
            this.ChcekSchButton.Size = new System.Drawing.Size(98, 49);
            this.ChcekSchButton.TabIndex = 4;
            this.ChcekSchButton.Text = "표확인";
            this.ChcekSchButton.UseVisualStyleBackColor = true;
            // 
            // ApplyOffButton
            // 
            this.ApplyOffButton.Location = new System.Drawing.Point(119, 34);
            this.ApplyOffButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplyOffButton.Name = "ApplyOffButton";
            this.ApplyOffButton.Size = new System.Drawing.Size(98, 49);
            this.ApplyOffButton.TabIndex = 5;
            this.ApplyOffButton.Text = "Off 신청";
            this.ApplyOffButton.UseVisualStyleBackColor = true;
            // 
            // ModifyInfoButton
            // 
            this.ModifyInfoButton.Location = new System.Drawing.Point(223, 34);
            this.ModifyInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyInfoButton.Name = "ModifyInfoButton";
            this.ModifyInfoButton.Size = new System.Drawing.Size(98, 48);
            this.ModifyInfoButton.TabIndex = 6;
            this.ModifyInfoButton.Text = "개인정보 수정";
            this.ModifyInfoButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 121);
            this.Controls.Add(this.ModifyInfoButton);
            this.Controls.Add(this.ApplyOffButton);
            this.Controls.Add(this.ChcekSchButton);
            this.Name = "Form1";
            this.Text = "GeneralMenuForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChcekSchButton;
        private System.Windows.Forms.Button ApplyOffButton;
        private System.Windows.Forms.Button ModifyInfoButton;
    }
}