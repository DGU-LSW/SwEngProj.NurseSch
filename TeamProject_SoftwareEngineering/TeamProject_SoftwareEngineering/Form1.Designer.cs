namespace TeamProject_SoftwareEngineering
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_id = new System.Windows.Forms.TextBox();
            this.box_pw = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // box_id
            // 
            this.box_id.Location = new System.Drawing.Point(90, 6);
            this.box_id.Name = "box_id";
            this.box_id.Size = new System.Drawing.Size(100, 25);
            this.box_id.TabIndex = 2;
            // 
            // box_pw
            // 
            this.box_pw.Location = new System.Drawing.Point(90, 57);
            this.box_pw.Name = "box_pw";
            this.box_pw.Size = new System.Drawing.Size(100, 25);
            this.box_pw.TabIndex = 3;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(196, 12);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 63);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 104);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.box_pw);
            this.Controls.Add(this.box_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_id;
        private System.Windows.Forms.TextBox box_pw;
        private System.Windows.Forms.Button button_login;
    }
}

