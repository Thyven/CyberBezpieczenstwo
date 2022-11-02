namespace CyberBezpieczenstwo.PopUpForms
{
    partial class ChangePassword
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
            this.buttonSubmitPassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPasswordRepeat = new System.Windows.Forms.TextBox();
            this.labelNotMatching = new System.Windows.Forms.Label();
            this.labelPassUsed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSubmitPassword
            // 
            this.buttonSubmitPassword.Location = new System.Drawing.Point(68, 251);
            this.buttonSubmitPassword.Name = "buttonSubmitPassword";
            this.buttonSubmitPassword.Size = new System.Drawing.Size(117, 23);
            this.buttonSubmitPassword.TabIndex = 0;
            this.buttonSubmitPassword.Text = "Change Password";
            this.buttonSubmitPassword.UseVisualStyleBackColor = true;
            this.buttonSubmitPassword.Click += new System.EventHandler(this.buttonSubmitPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(41, 36);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(167, 23);
            this.textBoxOldPassword.TabIndex = 3;
            this.textBoxOldPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOldPassword_KeyDown);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(41, 106);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(167, 23);
            this.textBoxNewPassword.TabIndex = 4;
            this.textBoxNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNewPassword_KeyDown);
            // 
            // textBoxNewPasswordRepeat
            // 
            this.textBoxNewPasswordRepeat.Location = new System.Drawing.Point(41, 135);
            this.textBoxNewPasswordRepeat.Name = "textBoxNewPasswordRepeat";
            this.textBoxNewPasswordRepeat.Size = new System.Drawing.Size(167, 23);
            this.textBoxNewPasswordRepeat.TabIndex = 5;
            this.textBoxNewPasswordRepeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNewPasswordRepeat_KeyDown);
            // 
            // labelNotMatching
            // 
            this.labelNotMatching.AutoSize = true;
            this.labelNotMatching.Location = new System.Drawing.Point(63, 180);
            this.labelNotMatching.Name = "labelNotMatching";
            this.labelNotMatching.Size = new System.Drawing.Size(122, 15);
            this.labelNotMatching.TabIndex = 6;
            this.labelNotMatching.Text = "Password dont match";
            this.labelNotMatching.Visible = false;
            // 
            // labelPassUsed
            // 
            this.labelPassUsed.AutoSize = true;
            this.labelPassUsed.Location = new System.Drawing.Point(39, 211);
            this.labelPassUsed.Name = "labelPassUsed";
            this.labelPassUsed.Size = new System.Drawing.Size(169, 15);
            this.labelPassUsed.TabIndex = 7;
            this.labelPassUsed.Text = "This password was used before";
            this.labelPassUsed.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 287);
            this.Controls.Add(this.labelPassUsed);
            this.Controls.Add(this.labelNotMatching);
            this.Controls.Add(this.textBoxNewPasswordRepeat);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmitPassword);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChangePassword";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.Shown += new System.EventHandler(this.ChangePassword_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSubmitPassword;
        private Label label1;
        private Label label2;
        private TextBox textBoxOldPassword;
        private TextBox textBoxNewPassword;
        private TextBox textBoxNewPasswordRepeat;
        private Label labelNotMatching;
        private Label labelPassUsed;
    }
}