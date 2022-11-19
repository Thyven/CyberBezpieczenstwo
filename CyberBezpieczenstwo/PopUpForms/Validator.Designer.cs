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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.buttonSubmit.Location = new System.Drawing.Point(77, 117);
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
            this.labelValidaterRegex.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValidaterRegex.ForeColor = System.Drawing.Color.Maroon;
            this.labelValidaterRegex.Location = new System.Drawing.Point(12, 155);
            this.labelValidaterRegex.Name = "labelValidaterRegex";
            this.labelValidaterRegex.Size = new System.Drawing.Size(131, 25);
            this.labelValidaterRegex.TabIndex = 5;
            this.labelValidaterRegex.Text = "Wrong regex";
            this.labelValidaterRegex.Visible = false;
            // 
            // labelValidateUsrPass
            // 
            this.labelValidateUsrPass.AutoSize = true;
            this.labelValidateUsrPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValidateUsrPass.ForeColor = System.Drawing.Color.Maroon;
            this.labelValidateUsrPass.Location = new System.Drawing.Point(12, 198);
            this.labelValidateUsrPass.Name = "labelValidateUsrPass";
            this.labelValidateUsrPass.Size = new System.Drawing.Size(272, 25);
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
            this.labelTimerLock.Location = new System.Drawing.Point(14, 258);
            this.labelTimerLock.Name = "labelTimerLock";
            this.labelTimerLock.Size = new System.Drawing.Size(67, 15);
            this.labelTimerLock.TabIndex = 7;
            this.labelTimerLock.Text = "Lock for 0 s";
            this.labelTimerLock.Visible = false;
            // 
            // Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 335);
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
            this.Shown += new System.EventHandler(this.Validator_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
    }
}