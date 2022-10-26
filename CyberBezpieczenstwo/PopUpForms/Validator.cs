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
        DataHandler data;

        public Validator(MainForm parent)
        {
            mainForm = parent as MainForm;
            data = new DataHandler();
            InitializeComponent();
            
        }
        private void checkForm()
        {
            var userName = textBoxUsername.Text;
            var userPassord = textBoxPassword.Text;
            
            // username and password must add up
            bool canPass;

            var validate = new Validate();
            if (validate.ifUserExist(userName, userPassord)) canPass = true;
            else canPass = false;

            // check regex
            var RegexOK = validate.checkRegex(userPassord);
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
                this.mainForm.loggedUser = data.GetUsers().Where(x => x.username == userName).First();
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

        private void Validator_Load(object sender, EventArgs e)
        {

        }
    }
}





    
