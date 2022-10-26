using CyberBezpieczenstwo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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
            InitializeComponent();
        }

        private void checkForm()
        {
            string oldPassword = textBoxOldPassword.Text;
            string userPassord = textBoxNewPassword.Text;

            string userPassordRe = textBoxNewPasswordRepeat.Text;
            bool oldPassOK = false;
            bool newPassMatch = false;

            for (int i = 0; i < data.items.Count; i++)
            {
                Debug.WriteLine($"userID:{this.mainForm.loggedUser.userID}");

                if (data.items[i].userID == this.mainForm.loggedUser.userID)
                {
                Debug.WriteLine("2");
                    if (data.items[i].password != oldPassword)
                    {
                        Debug.WriteLine("3");

                        // Inna labelke trzeba dodac 
                        labelNotMatching.Visible = true;
                        Task.Delay(2000).ContinueWith(t => ResetLabelError());
                    }
                    else
                    {
                        Debug.WriteLine("old pass match");
                        oldPassOK = true;
                    }
                }
            }


            // if new password dont match
            if (userPassord == userPassordRe && (userPassord != ""))
            {
                Debug.WriteLine("2 match");

                if (userPassord != oldPassword)
                {
                    for (int i = 0; i < data.items[this.mainForm.loggedUser.userID - 1].oldPasswords.Count; i++)
                    {
                        if (data.items[this.mainForm.loggedUser.userID - 1].oldPasswords[i] == userPassord)
                        {
                            newPassMatch = false;
                            Debug.WriteLine("TODO labelka ze takie haslo juz bylo");
                            break;

                        }
                        else
                        {
                            Debug.WriteLine("No match in list");
                            newPassMatch = true;
                        }
                    }
                }
                else
                {
                    labelNotMatching.Text = "new passowrd must be other than old one";
                    labelNotMatching.Visible = true;
                    Task.Delay(2000).ContinueWith(t => ResetLabelError());

                }


            }
            else
            {
                labelNotMatching.Visible = true;
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
            }


            if (newPassMatch && oldPassOK)
            {
                // Actions
                this.mainForm.Refresh();
                Debug.WriteLine("feuer frei");

                // Change password json logic
                data.items[this.mainForm.loggedUser.userID - 1].password = userPassord;
                data.items[this.mainForm.loggedUser.userID - 1].oldPasswords.Add(oldPassword);

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

        private void buttonSubmitPassword_Click(object sender, EventArgs e)
        {
            checkForm();
        }
        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainForm.Enabled = true;
        }
    }
}
