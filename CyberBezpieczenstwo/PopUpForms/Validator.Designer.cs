namespace CyberBezpieczenstwo.PopUpForms
{
    partial class Validator
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
            this.components = new System.ComponentModel.Container();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelValidaterRegex = new System.Windows.Forms.Label();
            this.labelValidateUsrPass = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.passwordTimeout = new System.Windows.Forms.Timer(this.components);
            this.labelTimerLock = new System.Windows.Forms.Label();
            this.labelOnetimePass = new System.Windows.Forms.Label();
            this.textBoxOneTimePass = new System.Windows.Forms.TextBox();
            this.labelOTPvalX = new System.Windows.Forms.Label();
            this.wvRC = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.buttonIMGCaptcha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvRC)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(77, 50);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 23);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(77, 79);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(77, 147);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Login";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 53);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(60, 15);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 82);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // labelValidaterRegex
            // 
            this.labelValidaterRegex.AutoSize = true;
            this.labelValidaterRegex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValidaterRegex.ForeColor = System.Drawing.Color.Maroon;
            this.labelValidaterRegex.Location = new System.Drawing.Point(14, 173);
            this.labelValidaterRegex.Name = "labelValidaterRegex";
            this.labelValidaterRegex.Size = new System.Drawing.Size(109, 21);
            this.labelValidaterRegex.TabIndex = 5;
            this.labelValidaterRegex.Text = "Wrong regex";
            this.labelValidaterRegex.Visible = false;
            // 
            // labelValidateUsrPass
            // 
            this.labelValidateUsrPass.AutoSize = true;
            this.labelValidateUsrPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValidateUsrPass.ForeColor = System.Drawing.Color.Maroon;
            this.labelValidateUsrPass.Location = new System.Drawing.Point(14, 208);
            this.labelValidateUsrPass.Name = "labelValidateUsrPass";
            this.labelValidateUsrPass.Size = new System.Drawing.Size(230, 21);
            this.labelValidateUsrPass.TabIndex = 6;
            this.labelValidateUsrPass.Text = "Wrong Username / Password";
            this.labelValidateUsrPass.Visible = false;
            // 
            // passwordTimeout
            // 
            this.passwordTimeout.Interval = 1000;
            this.passwordTimeout.Tick += new System.EventHandler(this.passwordTimeout_Tick);
            // 
            // labelTimerLock
            // 
            this.labelTimerLock.AutoSize = true;
            this.labelTimerLock.Location = new System.Drawing.Point(77, 279);
            this.labelTimerLock.Name = "labelTimerLock";
            this.labelTimerLock.Size = new System.Drawing.Size(67, 15);
            this.labelTimerLock.TabIndex = 7;
            this.labelTimerLock.Text = "Lock for 0 s";
            this.labelTimerLock.Visible = false;
            // 
            // labelOnetimePass
            // 
            this.labelOnetimePass.AutoSize = true;
            this.labelOnetimePass.Location = new System.Drawing.Point(242, 58);
            this.labelOnetimePass.Name = "labelOnetimePass";
            this.labelOnetimePass.Size = new System.Drawing.Size(109, 15);
            this.labelOnetimePass.TabIndex = 8;
            this.labelOnetimePass.Text = "One time password";
            // 
            // textBoxOneTimePass
            // 
            this.textBoxOneTimePass.Location = new System.Drawing.Point(251, 79);
            this.textBoxOneTimePass.Name = "textBoxOneTimePass";
            this.textBoxOneTimePass.Size = new System.Drawing.Size(100, 23);
            this.textBoxOneTimePass.TabIndex = 9;
            // 
            // labelOTPvalX
            // 
            this.labelOTPvalX.AutoSize = true;
            this.labelOTPvalX.Location = new System.Drawing.Point(251, 117);
            this.labelOTPvalX.Name = "labelOTPvalX";
            this.labelOTPvalX.Size = new System.Drawing.Size(27, 15);
            this.labelOTPvalX.TabIndex = 11;
            this.labelOTPvalX.Text = "x = ";
            // 
            // wvRC
            // 
            this.wvRC.AllowExternalDrop = true;
            this.wvRC.CreationProperties = null;
            this.wvRC.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvRC.Location = new System.Drawing.Point(0, 0);
            this.wvRC.Name = "wvRC";
            this.wvRC.Size = new System.Drawing.Size(345, 263);
            this.wvRC.TabIndex = 12;
            this.wvRC.ZoomFactor = 1D;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(383, 160);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonIMGCaptcha);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Captcha";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wvRC);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(343, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ReCaptcha";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(482, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 291);
            this.tabControl1.TabIndex = 13;
            // 
            // buttonIMGCaptcha
            // 
            this.buttonIMGCaptcha.Location = new System.Drawing.Point(103, 111);
            this.buttonIMGCaptcha.Name = "buttonIMGCaptcha";
            this.buttonIMGCaptcha.Size = new System.Drawing.Size(132, 37);
            this.buttonIMGCaptcha.TabIndex = 0;
            this.buttonIMGCaptcha.Text = "Tiles Captcha";
            this.buttonIMGCaptcha.UseVisualStyleBackColor = true;
            this.buttonIMGCaptcha.Click += new System.EventHandler(this.buttonIMGCaptcha_Click);
            // 
            // Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 335);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelOTPvalX);
            this.Controls.Add(this.textBoxOneTimePass);
            this.Controls.Add(this.labelOnetimePass);
            this.Controls.Add(this.labelTimerLock);
            this.Controls.Add(this.labelValidateUsrPass);
            this.Controls.Add(this.labelValidaterRegex);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "Validator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Validator";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Validator_FormClosing);
            this.Load += new System.EventHandler(this.Validator_Load);
            this.Shown += new System.EventHandler(this.Validator_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvRC)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonSubmit;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelValidaterRegex;
        private Label labelValidateUsrPass;
        private BindingSource bindingSource1;
        public System.Windows.Forms.Timer passwordTimeout;
        private Label labelTimerLock;
        private Label labelOnetimePass;
        private TextBox textBoxOneTimePass;
        private Label labelOTPvalX;
        public Microsoft.Web.WebView2.WinForms.WebView2 wvRC;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage2;
        private Button buttonIMGCaptcha;
        private TabPage tabPage1;
        private TabControl tabControl1;
    }
}