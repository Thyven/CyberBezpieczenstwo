using CyberBezpieczenstwo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            bool canPass = false;

            // if new password dont match
            if (userPassord == userPassordRe)
            {
                canPass = true;
            }
            else
            {
                labelNotMatching.Visible = true;
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
            }


            if (canPass)
            {
                // Actions
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
