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
    public partial class Validator : Form
    {
        // Reverse control main form
        private MainForm mainForm;
        DataHandler data;

        bool preventParentClosing;

        public Validator(MainForm parent)
        {
            mainForm = parent as MainForm;
            data = new DataHandler();

            this.CenterToParent();
            InitializeComponent();


        }
        private void checkForm()
        {
            var userName = textBoxUsername.Text;
            var userPassord = textBoxPassword.Text;

            userPassord = HashString(userPassord);
            Debug.WriteLine(userPassord);

            // username and password must add up
            bool canPass;

            var validate = new Validate();
            if (validate.ifUserExist(userName, userPassord)) canPass = true;
            else canPass = false;

            // check regex
            var RegexOK = validate.checkRegex(userPassord, mainForm.isRegexNeeded);

            
            if (!RegexOK)
            {
                labelValidaterRegex.Visible = true;
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
                Logger.Write($"Incorrect user and/or password!"); // bład logowania
            }

            if (!canPass)
            {
                labelValidateUsrPass.Visible = true;
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
                Logger.Write($"Incorrect user and/or password!"); // bład logowania
            }

            if (RegexOK && canPass)
            {
                // Actions
                this.mainForm.loggedUser = data.GetUsers().Where(x => x.username == userName).First();
                this.mainForm.Refresh();
                this.mainForm.CheckDateExpiration();

                //Log
                var currentUser = this.mainForm.loggedUser.username;
                Logger.Write($"Signed In as {currentUser}");

                // Closing
                preventParentClosing = true;
                this.mainForm.Enabled = true;
                this.Close();
            }
            
        }

        private void ResetLabelError()
        {
            try
            {
                labelValidaterRegex.Invoke((Action)delegate
                {
                    labelValidaterRegex.Visible = false;
                });

                labelValidateUsrPass.Invoke((Action)delegate
                {
                    labelValidateUsrPass.Visible = false;
                });
            }
            catch (Exception)
            {
            }
        }

        private string HashString(string input)
        {
            string outputString;

            byte[] buffer = Encoding.UTF8.GetBytes(input);
            byte[] hashedData = SHA256.HashData(buffer);
            outputString = Encoding.UTF8.GetString(hashedData, 0, hashedData.Length);

            return outputString;
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            checkForm();
           
        }

        private void Validator_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (preventParentClosing == false)
            {
                this.mainForm.Close();
            }

        }


        // Go to next texbox
        private void Validator_Shown(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }
        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        // press button
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkForm();
            }
        }

    }
}