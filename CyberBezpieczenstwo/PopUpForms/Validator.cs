using CyberBezpieczenstwo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
        DataHandler data = new DataHandler();

        public Validator(MainForm parent)
        {
            mainForm = parent as MainForm;
            InitializeComponent();
            
        }
        private void checkForm()
        {
            var userName = textBoxUsername.Text;
            var userPassord = textBoxPassword.Text;
            int userID = 0;
            
            // username and password must add up
            int numberOfMatches = 0;
            bool canPass = false;


            // Check username and password
            data.LoadJson("data.json");

            for (int i = 0; i < data.items.Count; i++)
            {
                if (userName == data.items[i].username) numberOfMatches++;
                if (userPassord == data.items[i].password) numberOfMatches++;
               
                if (numberOfMatches == 2)
                {
                    userID = data.items[i].userID;

                    if (data.items[i].role == "Admin")
                    {
                        this.mainForm.isAdmin = true;
                    }
                    canPass = true;
                    break;
                }

                numberOfMatches = 0;
            }

            // check regex
            string regexPattern = @"(?=.*[a-z])(?=.*\W)";
            Regex regexSN = new Regex(regexPattern, RegexOptions.IgnoreCase);
            var RegexOK = regexSN.IsMatch(userPassord);

            if (!RegexOK)
            {
                labelValidaterRegex.Visible = true;
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
            }

            if (!canPass)
            {
                labelValidateUsrPass.Visible = true;
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
            }

            if (RegexOK && canPass)
            {
                // Actions
                this.mainForm.userName = userName;
                this.mainForm.userID = userID;
                this.mainForm.Refresh();

                // Closing
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            checkForm();
        }

        private void Validator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainForm.Enabled = true;

        }
    }
}





    
