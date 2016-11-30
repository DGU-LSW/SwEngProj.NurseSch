namespace NurseDutyManager
{
    partial class CheckTableForm
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
			this.btnOpen = new System.Windows.Forms.Button();
			this.tboxTable = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(12, 12);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(131, 47);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "열기";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// tboxTable
			// 
			this.tboxTable.Location = new System.Drawing.Point(12, 108);
			this.tboxTable.Multiline = true;
			this.tboxTable.Name = "tboxTable";
			this.tboxTable.ReadOnly = true;
			this.tboxTable.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.tboxTable.Size = new System.Drawing.Size(760, 382);
			this.tboxTable.TabIndex = 1;
			this.tboxTable.WordWrap = false;
			// 
			// CheckTableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 502);
			this.Controls.Add(this.tboxTable);
			this.Controls.Add(this.btnOpen);
			this.Name = "CheckTableForm";
			this.Text = "ChecktableForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.TextBox tboxTable;
	}
}