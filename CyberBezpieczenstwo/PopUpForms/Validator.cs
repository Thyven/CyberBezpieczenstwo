﻿using CyberBezpieczenstwo.Data;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
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


        // timeout
        int wrongTries = 0;
        int howManyTries = 3;


        // Captcha
        public bool captcha;
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

            // check OTP;
            double optValue = 0;
            try
            {
                optValue = Convert.ToDouble(textBoxOneTimePass.Text);

            }
            catch (Exception)
            {
            }

            bool OTPisOK = validate.checkOTP(userName, optValue);

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

            //// OTP
            //if (!OTPisOK)
            //{
            //    labelValidateUsrPass.Visible = true;
            //    labelValidateUsrPass.Text = "Wrong One Time Password";
            //    Logger.Write($"Someone tried to log in with incorrect OneTimePassword!");
            //    Task.Delay(2000).ContinueWith(t => ResetLabelError());
            //}

            if (!captcha)
            {
                labelValidateUsrPass.Visible = true;
                labelValidateUsrPass.Text = "Wrong Captcha";
                Logger.Write($"Wrong Captcha!");
                Task.Delay(2000).ContinueWith(t => ResetLabelError());
            }

            if (RegexOK && canPass && captcha)
            {
                // Actions
                this.mainForm.loggedUser = data.GetUsers().Where(x => x.username == userName).First();
                this.mainForm.Refresh();
                this.mainForm.CheckDateExpiration();
                this.mainForm.timer.Start();
                Logger.Write($"{mainForm.loggedUser.username} logged in");

                // Closing
                preventParentClosing = true;
                this.mainForm.Enabled = true;
                this.Close();

            }
            else
            {
                wrongTries++;
                Logger.Write($"Someone tried to log in with incorrect login or password");
                if (wrongTries >= howManyTries)
                {
                    this.Enabled = false;
                    labelTimerLock.Visible = true;
                    passwordTimeout.Start();
                }
            }
        }


        //  wrong login/password timeout for 15 min (900s)
        static int timeoutTime = 10;
        int tTime = timeoutTime;
        private void passwordTimeout_Tick(object sender, EventArgs e)
        {
            tTime--;
            labelTimerLock.Text = $"Lock for {tTime} s";

            if (tTime <= 0)
            {
                wrongTries = 0;
                this.Enabled = true;
                labelTimerLock.Visible = false;
                tTime = timeoutTime;
                passwordTimeout.Stop();
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


        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!captcha)
            {
                string script = "document.getElementsByClassName('g-recaptcha-response')[0].value";

                string response = await wvRC.ExecuteScriptAsync(script);
                string encodedResponse = response.Replace("\"", "");
                string secretKey = "6LfSN8YjAAAAAMt5kyHcwU8nX5d6xsAAV3bLYq3e";

                string url = $"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={encodedResponse}";

                using (WebClient client = new WebClient())
                {
                    string result = client.DownloadString(url);
                    JObject json = JObject.Parse(result);
                    bool success = (bool)json["success"];
                    Debug.WriteLine(success);

                    if (success)
                    {
                        captcha = true;
                        Debug.WriteLine($"Captcha bool: {captcha}");
                    }
                    else
                    {
                        captcha = false;
                        Debug.WriteLine($"Captcha bool: {captcha}");
                    }
                }
            }

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
            labelOTPvalX.Text = $"X = {mainForm.oneTimePasswordValueX.ToString()}";
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

        // ReCaptcha
        private void Validator_Load(object sender, EventArgs e)
        {
            wvRC.Source = new Uri("https://recaptcha.tiiny.site/");
        }

        private void buttonIMGCaptcha_Click(object sender, EventArgs e)
        {
            CaptchaForm captcha = new CaptchaForm(this);
            captcha.Show();
            this.Enabled = false;
        }
    }

}




    
