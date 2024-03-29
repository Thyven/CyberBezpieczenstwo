using CyberBezpieczenstwo.Data;
using CyberBezpieczenstwo.PopUpForms;
using System.Diagnostics;

namespace CyberBezpieczenstwo
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        DataHandler data = new DataHandler();

        public UserData loggedUser;
        private List<UserData> listOfUsers;
        public bool isAdmin = false;

        public bool isRegexNeeded = true;
        public int oneTimePasswordValueX = 20;
        public string aktywator = "Wakacje2022";
        public int liczbaUzyc = 5;
        public void Refresh()
        {
            labelUsername.Text = loggedUser.username;

            if (loggedUser.role == "admin")
            {
                checkBoxRegex.Visible = true;
                userListBox.Visible = true;
                editButton.Visible = true;
                deleteUserButton.Visible = true;
                addUserButton.Visible = true;
                LogButton.Visible = true;
                userListBox.Items.Clear();
                listOfUsers = data.GetUsers();
                foreach (var user in listOfUsers)
                {
                    userListBox.Items.Add(user);
                }
            }
            else if (loggedUser.role == "mod")
            {
                checkBoxRegex.Visible = false;
                userListBox.Visible = true;
                editButton.Visible = true;
                deleteUserButton.Visible = false;
                addUserButton.Visible = false;
                LogButton.Visible = true;
                userListBox.Items.Clear();
                listOfUsers = data.GetUsers();
                foreach (var user in listOfUsers)
                {
                    userListBox.Items.Add(user);
                }
            }
            else //user
            {
                addNewUserButton.Visible = false;
                editButton.Visible = false;
                deleteUserButton.Visible = false;
                addUserButton.Visible = false;
                userListBox.Visible = false;
                usernameLabel.Visible = false;
                passwordLabel.Visible = false;
                usernameTextbox.Visible = false;
                passwordTextbox.Visible = false;
                roleLabel.Visible = false;
                adminRoleButton.Visible = false;
                userRoleButton.Visible = false;
                checkBoxRegex.Visible = false;
                LogButton.Visible = false;
                buttonChangePassword.Visible = false;
                editTextBox.Visible = false;
                setOneTimePasswordButton.Visible = false;
                userEditBox.Visible = false;
                passwordTextbox.Visible = false;
                editLabel.Visible = false;
                changeButton.Visible = false;
            }

            // Regex labels
            if (isRegexNeeded)
            {
                labelRegex.Text = "Regex ON";
                labelRegex.ForeColor = Color.DarkGreen;
            }
            else
            {
                labelRegex.Text = "Regex OFF";
                labelRegex.ForeColor = Color.Crimson;
            }

        }
        internal void CheckDateExpiration()
        {
            Task.Delay(2000);
            // Check if password time is valid
            for (int i = 0; i < data.items.Count; i++)
            {
                if (data.items[i].userID == loggedUser.userID)
                {
                    if (data.items[i].passwordExpireDate < DateTime.Today)
                    {
                        DialogResult changePassword = MessageBox.Show("Password Expired, need a new one", "Password Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (changePassword == DialogResult.OK)
                        {
                            ChangePassword valdiator = new ChangePassword(this);
                            valdiator.Show();
                            this.Enabled = false;
                            Logger.Write($"Password change as {loggedUser.username}"); //log
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Validator valdiator = new Validator(this);
            valdiator.Show();
            this.Enabled = false;
            addNewUserButton.Visible = false;
            editButton.Visible = false;
            deleteUserButton.Visible = false;
            addUserButton.Visible = false;
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword valdiator = new ChangePassword(this);
            valdiator.Show();
            this.Enabled = false;
            Logger.Write($"{loggedUser.username} has changed own password");
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!userEditBox.Visible)
            {
                editUserVisible();
                userEditBox.Items.Add("Click to change username");
                userEditBox.Items.Add("Click to change password");
            }
        }

        private void userEditBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = userEditBox.SelectedIndex;
            if (selectedIndex == 0)
            {
                editLabel.Text = "Enter new username: ";
                setOneTimePasswordButton.Visible = false;

            }
            else
            {
                editLabel.Text = "Enter new password: ";
                setOneTimePasswordButton.Visible = true;
            }
            editLabel.Visible = true;
            editTextBox.Visible = true;
            setOneTimePasswordButton.Visible = true;
            changeButton.Visible = true;
            setOneTimePasswordButton.Visible = true;
        }

        private void editTextBox_TextChanged(object sender, EventArgs e)
        {
            changeButton.Enabled = true;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var validate = new Validate();
            var data = new DataHandler();
            var selectedIndex = userEditBox.SelectedIndex;
            logTextBox.Clear();

            UserData selectedUser = (UserData)userListBox.SelectedItem;
            if (selectedUser == null)
            {
                logTextBox.Text = "No user selected";
                return;
            }
            if (selectedIndex == 0) //zmiana username
            {
                var selectedUsername = selectedUser.username;
                if (!data.ChangeUsername(selectedUsername, editTextBox.Text))
                {
                    logTextBox.Text = "Unable to change username";
                }
                else
                {
                    RefreshUserList();
                    logTextBox.Text = $"Username for user {selectedUsername} changed for {editTextBox.Text}";
                    Logger.Write($"{loggedUser.username} has changed username of {selectedUsername} to {editTextBox.Text}");
                    return;
                }
            }
            if (selectedIndex == 1) //zmiana hasla
            {
                var newPassword = validate.HashString(editTextBox.Text);
                if (!data.ChangePassword(selectedUser.username, newPassword, isRegexNeeded))
                {
                    logTextBox.Text = "Unable to change password";
                }
                else
                {
                    logTextBox.Text = $"Password for user {selectedUser} has been changed";
                    Logger.Write($"{loggedUser.username} has changed password of {selectedUser}");
                }
            }
        }

        private void RefreshUserList()
        {
            userListBox.Items.Clear();
            var users = data.GetUsers();
            foreach (var user in users)
            {
                userListBox.Items.Add(user);
            }
        }
        private void addUserVisible()
        {
            userEditBox.Visible = editLabel.Visible = editTextBox.Visible = changeButton.Visible = setOneTimePasswordButton.Visible = false;
            adminRoleButton.Visible =
                addNewUserButton.Visible =
                userRoleButton.Visible =
                roleLabel.Visible =
                usernameLabel.Visible =
                passwordLabel.Visible =
                usernameTextbox.Visible =
                passwordTextbox.Visible = true;
        }
        private void editUserVisible()
        {
            roleLabel.Visible =
                    addNewUserButton.Visible =
                    adminRoleButton.Visible =
                    userRoleButton.Visible =
                    usernameLabel.Visible =
                    passwordLabel.Visible =
                    usernameTextbox.Visible =
                    passwordTextbox.Visible = false;
            userEditBox.Visible = true;
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            addUserVisible();
        }

        private void logTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            var validate = new Validate();
            var newUsername = usernameTextbox.Text;
            if (validate.ifUserExist(newUsername))
            {
                logTextBox.Clear();
                logTextBox.Text = "Username with that name already exist";
                return;
            }
            var newPassword = passwordTextbox.Text;
            if (!validate.checkRegex(newPassword, isRegexNeeded))
            {
                logTextBox.Clear();
                logTextBox.Text = "Incorrect password";
                return;
            }
            string newRole = "user";
            if (adminRoleButton.Checked) newRole = "admin";

            newPassword = validate.HashString(newPassword);
            var newUser = data.CreateUser(newUsername, newPassword, newRole);
            logTextBox.Clear();
            logTextBox.Text = $"New user {newUser.username} has been added";
            Logger.Write($"{loggedUser.username} has added new user {newUser.username}");
            RefreshUserList();

        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            // Confirm messagebox
            DialogResult deleteResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deleteResult == DialogResult.Yes)
            {
                var data = new DataHandler();
                logTextBox.Clear();
                UserData selectedUser = (UserData)userListBox.SelectedItem;
                Logger.Write($"{loggedUser.username} Removed user {selectedUser}");
                if (selectedUser.username == loggedUser.username)
                {
                    logTextBox.Text = "Unable to delete user";
                    return;
                }
                if (data.DeleteUser(selectedUser.username))
                {
                    logTextBox.Text = "User has been deleted";
                    RefreshUserList();
                    return;
                }
                logTextBox.Text = "Unable to delete user";
            }
        }

        private void checkBoxRegex_CheckedChanged(object sender, EventArgs e)
        {
            isRegexNeeded = !isRegexNeeded;
            Refresh();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            timer.Stop();
            loggedUser = new UserData();
            Logger.Write($" {loggedUser.userID}Logged Out");
            Validator valdiator = new Validator(this);
            valdiator.Show();
            this.Enabled = false;
            addNewUserButton.Visible = false;
            editButton.Visible = false;
            deleteUserButton.Visible = false;
            addUserButton.Visible = false;
            loggedUser.role = "NiePowinienesTegoWidziec!";
            Refresh();
        }


        // timeout po 15 min (900s)
        int timeooutTime = 200;
        int tTime = 200;

        private void OnUserActivity()
        {
            tTime = timeooutTime;
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            OnUserActivity();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            OnUserActivity();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (tTime >= 1)
            {
                tTime--;
                labelTest.Text = tTime.ToString();
            }
            else
            {
                tTime = 10;
                Logout();
            }
        }

        private void setOneTimePasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            int usernameLenght = 0;
            var usersNumber = userListBox.Items.Count;
            if (usernameTextbox.Text.Length > 1)
            {
                usernameLenght = usernameTextbox.Text.Length;
            }
            else
            {
                logTextBox.Clear();
                logTextBox.Text = "First enter username";
                return;

            }
            var generatePassword = new GeneratePassword();
        }

        private void setOneTimePasswordButton_Click(object sender, EventArgs e)
        {


            UserData selectedUser = (UserData)userListBox.SelectedItem;
            if (selectedUser == null) return;
            int usernameLenght = selectedUser.username.Length;
            Logger.Write($"OneTimePassword created for {selectedUser}");

            var generatePassword = new GeneratePassword();
            double newPassword = generatePassword.OneTimePassword(usernameLenght, oneTimePasswordValueX);
            if (userEditBox.SelectedIndex == 1)
            {
                var dataHander = new DataHandler();
                string username = selectedUser.username;
                dataHander.UpdateUserOneTimePass(username, "Y", newPassword);
            }

            MessageBox.Show("OTP has been created!", "OTP information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static string Decrypt(string message, int shift)
        {
            char[] messageArray = message.ToCharArray();
            for (int i = 0; i < messageArray.Length; i++)
            {
                int charValue = (int)messageArray[i];
                if (charValue >= 65 && charValue <= 90)
                {
                    charValue = 65 + ((charValue - 65 + (26 - shift)) % 26);
                }
                else if (charValue >= 97 && charValue <= 122)
                {
                    charValue = 97 + ((charValue - 97 + (26 - shift)) % 26);
                }
                messageArray[i] = (char)charValue;
            }
            return new string(messageArray);
        }

        private void LogButton_Click(object sender, EventArgs e)
        {

            Process.Start("notepad.exe", Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Log.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (liczbaUzyc > 0)
            {
                Process.Start("notepad.exe", Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Log.txt");
                liczbaUzyc -= 1;
            }
            else
            {
                MessageBox.Show("Wersja Trail sie skonczyla");
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2Activate_TextChanged(object sender, EventArgs e)
        {
        }
        private void activate_Click(object sender, EventArgs e)
        {
            var cezarstring = Decrypt(textBox2Activate.Text, 2);
            if (cezarstring == aktywator)
            {
                liczbaUzyc = 9999;
                textBox2Activate.Text = "Kod poprawny";
            }
            else
            {
                textBox2Activate.Text = "Kod niepoprawny!!";
            }
        }
    }
}