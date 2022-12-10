using CyberBezpieczenstwo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberBezpieczenstwo.PopUpForms
{
    public partial class ChangePassword : Form
    {

        // Reverse control main form
        private MainForm mainForm;
        DataHandler data = new DataHandler();

        public ChangePassword(MainForm parent)
        {
            mainForm = parent as MainForm;

            this.CenterToParent();
            InitializeComponent();
        }

        private void checkForm()
        {
            string oldPassword = textBoxOldPassword.Text;

            string userPassord = textBoxNewPassword.Text;
            string userPassordRe = textBoxNewPasswordRepeat.Text;

            // Hash it here
            oldPassword = HashString(oldPassword);
            userPassord = HashString(userPassord);
            userPassordRe = HashString(userPassordRe);

            bool oldPassOK = false;
            bool newPassMatch = false;

            // Check for global regex and valdiate it
            bool RegexOK = false;

            for (int i = 0; i < data.items.Count; i++)
            {
                Debug.WriteLine($"userID:{this.mainForm.loggedUser.userID}");

                if (data.items[i].userID == this.mainForm.loggedUser.userID)
                {
                    if (data.items[i].password != oldPassword)
                    {
                        labelNotMatching.Text = "Wrong password";
                        labelNotMatching.Visible = true;
                        Task.Delay(2000).ContinueWith(t => ResetLabelError());
                    }
                    else
                    {
                        oldPassOK = true;
                    }
                }
            }

            // if new password dont match
            if (userPassord == userPassordRe && (userPassord != ""))
            {
                if (userPassord != oldPassword)
                {
                    if (data.items[this.mainForm.loggedUser.userID - 1].oldPasswords != null)
                    {
                        for (int i = 0; i < data.items[this.mainForm.loggedUser.userID - 1].oldPasswords.Count; i++)
                        {
                            if (data.items[this.mainForm.loggedUser.userID - 1].oldPasswords[i] == userPassord)
                            {
                                newPassMatch = false;
                                break;
                            }
                            else
                            {
                                newPassMatch = true;
                            }
                        }
                    }
                    else
                    {
                        // No previous pasword so pass
                        newPassMatch = true;
                    }
                }
                else
                {
                    labelNotMatching.Text = "new password must be other than old one";
                    labelNotMatching.Visible = true;
                    Task.Delay(2000).ContinueWith(t => ResetLabelError());

                }
            }
            else
            {
                labelNotMatching.Text = "New passwords dont match";
                labelNotMatching.Visible = true;
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
            }


            // check regex
            RegexOK = CheckRegex(userPassord);

            if (mainForm.isRegexNeeded == false)
            {
                RegexOK = true;
            }

            if (RegexOK == false)
            {
                labelNotMatching.Text = "Wrong Regex";
                labelNotMatching.Visible = true;
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
            }



            if (newPassMatch && oldPassOK && RegexOK)
            {
                // Actions
                this.mainForm.Refresh();

                // Change password json logic
                var loggedUsername = this.mainForm.loggedUser.username;
                data.ChangePassword(loggedUsername, userPassord, false);
                data.items[this.mainForm.loggedUser.userID - 1].password = userPassord;
                if(data.items[this.mainForm.loggedUser.userID - 1].oldPasswords != null)
                    data.items[this.mainForm.loggedUser.userID - 1].oldPasswords.Add(oldPassword);

                // Date expiration reneval
                var NowPlusMonths = DateTime.Now;
                NowPlusMonths = NowPlusMonths.AddMonths(6);
                NowPlusMonths = NowPlusMonths.Date;
                data.items[this.mainForm.loggedUser.userID - 1].passwordExpireDate = NowPlusMonths;
                data.SaveJson();

                // Closing
                this.mainForm.Enabled = true;
                this.Close();
            }
        }


        private void ResetLabelError()
        {
            try
            {
                labelNotMatching.Invoke((Action)delegate
                {
                    labelNotMatching.Visible = false;
                });
            }
            catch (Exception)
            {
            }
        }

        public bool CheckRegex(string password)
        {
            string regexPattern = @"(?=.*[a-z])(?=.*\W)";
            Regex regexSN = new Regex(regexPattern, RegexOptions.IgnoreCase);
            var RegexOK = regexSN.IsMatch(password);
            return RegexOK;
        }


        // Hashaszowanie

        private string HashString(string input)
        {
            string outputString;

            byte[] buffer = Encoding.UTF8.GetBytes(input);
            byte[] hashedData = SHA256.HashData(buffer);
            outputString = Encoding.UTF8.GetString(hashedData, 0, hashedData.Length);

            return outputString;
        }

        private void buttonSubmitPassword_Click(object sender, EventArgs e)
        {
            checkForm();
        }
        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainForm.Enabled = true;
        }

        private void ChangePassword_Shown(object sender, EventArgs e)
        {
            textBoxOldPassword.Focus();
        }

        private void textBoxOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxNewPassword.Focus();
            }
        }

        private void textBoxNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxNewPasswordRepeat.Focus();
            }
        }

        private void textBoxNewPasswordRepeat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkForm();
            }
        }
    }
}
