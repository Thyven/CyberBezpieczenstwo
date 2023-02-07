namespace CyberBezpieczenstwo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.labelRegex = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.userEditBox = new System.Windows.Forms.ListBox();
            this.editLabel = new System.Windows.Forms.Label();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.addNewUserButton = new System.Windows.Forms.Button();
            this.adminRoleButton = new System.Windows.Forms.RadioButton();
            this.userRoleButton = new System.Windows.Forms.RadioButton();
            this.roleLabel = new System.Windows.Forms.Label();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.checkBoxRegex = new System.Windows.Forms.CheckBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.setOneTimePasswordButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.activate = new System.Windows.Forms.Button();
            this.textBox2Activate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(53, 17);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(62, 15);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "username";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(153, 13);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(119, 23);
            this.buttonChangePassword.TabIndex = 2;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Visible = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // labelRegex
            // 
            this.labelRegex.AutoSize = true;
            this.labelRegex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegex.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelRegex.Location = new System.Drawing.Point(297, 13);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(86, 21);
            this.labelRegex.TabIndex = 3;
            this.labelRegex.Text = "Regex ON";
            this.labelRegex.Visible = false;
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 15;
            this.userListBox.Location = new System.Drawing.Point(474, 69);
            this.userListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(299, 124);
            this.userListBox.TabIndex = 4;
            this.userListBox.Visible = false;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(474, 196);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(134, 22);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit selected user";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // userEditBox
            // 
            this.userEditBox.FormattingEnabled = true;
            this.userEditBox.ItemHeight = 15;
            this.userEditBox.Location = new System.Drawing.Point(476, 226);
            this.userEditBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userEditBox.Name = "userEditBox";
            this.userEditBox.Size = new System.Drawing.Size(297, 34);
            this.userEditBox.TabIndex = 8;
            this.userEditBox.Visible = false;
            this.userEditBox.SelectedIndexChanged += new System.EventHandler(this.userEditBox_SelectedIndexChanged);
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(475, 265);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(38, 15);
            this.editLabel.TabIndex = 9;
            this.editLabel.Text = "label2";
            this.editLabel.Visible = false;
            // 
            // editTextBox
            // 
            this.editTextBox.Location = new System.Drawing.Point(474, 282);
            this.editTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(215, 23);
            this.editTextBox.TabIndex = 10;
            this.editTextBox.Visible = false;
            this.editTextBox.TextChanged += new System.EventHandler(this.editTextBox_TextChanged);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(694, 280);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(82, 22);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Visible = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(613, 196);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(82, 22);
            this.addUserButton.TabIndex = 12;
            this.addUserButton.Text = "Add user";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Visible = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(14, 346);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(776, 23);
            this.logTextBox.TabIndex = 13;
            this.logTextBox.TextChanged += new System.EventHandler(this.logTextBox_TextChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(550, 224);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(110, 23);
            this.usernameTextbox.TabIndex = 14;
            this.usernameTextbox.Visible = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(550, 248);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(110, 23);
            this.passwordTextbox.TabIndex = 15;
            this.passwordTextbox.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(481, 226);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(63, 15);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(481, 250);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel.TabIndex = 17;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Visible = false;
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.Location = new System.Drawing.Point(668, 237);
            this.addNewUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.Size = new System.Drawing.Size(82, 22);
            this.addNewUserButton.TabIndex = 18;
            this.addNewUserButton.Text = "Add";
            this.addNewUserButton.UseVisualStyleBackColor = true;
            this.addNewUserButton.Visible = false;
            this.addNewUserButton.Click += new System.EventHandler(this.addNewUserButton_Click);
            // 
            // adminRoleButton
            // 
            this.adminRoleButton.AutoSize = true;
            this.adminRoleButton.Location = new System.Drawing.Point(550, 273);
            this.adminRoleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminRoleButton.Name = "adminRoleButton";
            this.adminRoleButton.Size = new System.Drawing.Size(61, 19);
            this.adminRoleButton.TabIndex = 20;
            this.adminRoleButton.TabStop = true;
            this.adminRoleButton.Text = "Admin";
            this.adminRoleButton.UseVisualStyleBackColor = true;
            this.adminRoleButton.Visible = false;
            // 
            // userRoleButton
            // 
            this.userRoleButton.AutoSize = true;
            this.userRoleButton.Location = new System.Drawing.Point(550, 292);
            this.userRoleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userRoleButton.Name = "userRoleButton";
            this.userRoleButton.Size = new System.Drawing.Size(48, 19);
            this.userRoleButton.TabIndex = 21;
            this.userRoleButton.TabStop = true;
            this.userRoleButton.Text = "User";
            this.userRoleButton.UseVisualStyleBackColor = true;
            this.userRoleButton.Visible = false;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(508, 284);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(33, 15);
            this.roleLabel.TabIndex = 22;
            this.roleLabel.Text = "Role:";
            this.roleLabel.Visible = false;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(701, 196);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(82, 22);
            this.deleteUserButton.TabIndex = 23;
            this.deleteUserButton.Text = "Delete user";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Visible = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // checkBoxRegex
            // 
            this.checkBoxRegex.AutoSize = true;
            this.checkBoxRegex.Location = new System.Drawing.Point(297, 52);
            this.checkBoxRegex.Name = "checkBoxRegex";
            this.checkBoxRegex.Size = new System.Drawing.Size(99, 19);
            this.checkBoxRegex.TabIndex = 24;
            this.checkBoxRegex.Text = "Disable Regex";
            this.checkBoxRegex.UseVisualStyleBackColor = true;
            this.checkBoxRegex.Visible = false;
            this.checkBoxRegex.CheckedChanged += new System.EventHandler(this.checkBoxRegex_CheckedChanged);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(153, 43);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(119, 27);
            this.logOutButton.TabIndex = 25;
            this.logOutButton.Text = "Re-log";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(749, 405);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(27, 15);
            this.labelTest.TabIndex = 26;
            this.labelTest.Text = "Test";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // setOneTimePasswordButton
            // 
            this.setOneTimePasswordButton.Location = new System.Drawing.Point(316, 237);
            this.setOneTimePasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setOneTimePasswordButton.Name = "setOneTimePasswordButton";
            this.setOneTimePasswordButton.Size = new System.Drawing.Size(155, 22);
            this.setOneTimePasswordButton.TabIndex = 27;
            this.setOneTimePasswordButton.Text = "Set One-Time Password";
            this.setOneTimePasswordButton.UseVisualStyleBackColor = true;
            this.setOneTimePasswordButton.Visible = false;
            this.setOneTimePasswordButton.Click += new System.EventHandler(this.setOneTimePasswordButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.Location = new System.Drawing.Point(18, 405);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(75, 23);
            this.LogButton.TabIndex = 29;
            this.LogButton.Text = "View Log";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Visible = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Edit Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 136);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // activate
            // 
            this.activate.Location = new System.Drawing.Point(18, 318);
            this.activate.Name = "activate";
            this.activate.Size = new System.Drawing.Size(75, 23);
            this.activate.TabIndex = 32;
            this.activate.Text = "Activate!";
            this.activate.UseVisualStyleBackColor = true;
            this.activate.Click += new System.EventHandler(this.activate_Click);
            // 
            // textBox2Activate
            // 
            this.textBox2Activate.Location = new System.Drawing.Point(99, 318);
            this.textBox2Activate.Name = "textBox2Activate";
            this.textBox2Activate.Size = new System.Drawing.Size(239, 23);
            this.textBox2Activate.TabIndex = 33;
            this.textBox2Activate.TextChanged += new System.EventHandler(this.textBox2Activate_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2Activate);
            this.Controls.Add(this.activate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.setOneTimePasswordButton);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.checkBoxRegex);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.userRoleButton);
            this.Controls.Add(this.adminRoleButton);
            this.Controls.Add(this.addNewUserButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.userEditBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.labelRegex);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelUsername;
        private Button buttonChangePassword;
        private Label labelRegex;
        private ListBox userListBox;
        private Button editButton;
        private ListBox userEditBox;
        private Label editLabel;
        private TextBox editTextBox;
        private Button changeButton;
        private Button addUserButton;
        private TextBox logTextBox;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button addNewUserButton;
        private RadioButton adminRoleButton;
        private RadioButton userRoleButton;
        private Label roleLabel;
        private Button deleteUserButton;
        private CheckBox checkBoxRegex;
        private Button logOutButton;
        private Label labelTest;
        public System.Windows.Forms.Timer timer;
        private Button setOneTimePasswordButton;
        private Button LogButton;
        private Button button1;
        private TextBox textBox1;
        private Button activate;
        private TextBox textBox2Activate;
    }
}