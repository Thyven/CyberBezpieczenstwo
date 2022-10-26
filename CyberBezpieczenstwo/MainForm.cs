using CyberBezpieczenstwo.Data;
using CyberBezpieczenstwo.PopUpForms;

namespace CyberBezpieczenstwo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DataHandler data = new DataHandler();

        public UserData loggedUser;
        private List<UserData> listOfUsers;
        public bool isAdmin = false;

        public void Refresh()
        {
            labelUsername.Text = loggedUser.username;

            if (loggedUser.role == "admin")
            {
                labeAdmin.Visible = true;
                userListBox.Visible = true;
                listOfUsers = data.GetUsers();
                foreach (var user in listOfUsers)
                {
                    userListBox.Items.Add(user);
                }
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Validator valdiator = new Validator(this);
            valdiator.Show();
            this.Enabled = false;

          //  data.LoadJson("data.json");
          //  data.DebugData();

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword valdiator = new ChangePassword(this);
            valdiator.Show();
            this.Enabled = false;

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
            }
            else
            {
                editLabel.Text = "Enter new password: ";
            }
            editLabel.Visible = true;
            editTextBox.Visible = true;
            changeButton.Visible = true;
        }

        private void editTextBox_TextChanged(object sender, EventArgs e)
        {
            changeButton.Enabled = true;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
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
                    return;
                }
            }
            if(selectedIndex == 1) //zmiana hasla
            {
                if (!data.ChangePassword(selectedUser.username, editTextBox.Text))
                {
                    logTextBox.Text = "Unable to change password";
                }
                else
                {
                    logTextBox.Text = $"Password for user {selectedUser.username} has been changed";
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
            userEditBox.Visible = editLabel.Visible = editTextBox.Visible = changeButton.Visible = false;
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
            if(validate.ifUserExist(newUsername))
            {
                logTextBox.Clear();
                logTextBox.Text = "Username with that name already exist";
                return;
            }
            var newPassword = passwordTextbox.Text;
            if(!validate.checkRegex(newPassword))
            {
                logTextBox.Clear();
                logTextBox.Text = "Incorrect password";
                return;
            }
            string newRole = "user";
            if (adminRoleButton.Checked) newRole = "admin";

            var newUser = data.CreateUser(newUsername, newPassword, newRole);
            logTextBox.Clear();
            logTextBox.Text = $"New user {newUser.username} has been added";
            RefreshUserList();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            var data = new DataHandler();
            logTextBox.Clear();
            UserData selectedUser = (UserData)userListBox.SelectedItem;
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
}