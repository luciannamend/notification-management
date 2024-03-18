using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

namespace NotificationManagementGUI
{    
    public partial class ManageSubscriptionForm : Form
    {
        public static List<String> listOfEmail = new List<String>();
        public static List<String> listOfPhone = new List<String>();
        string subscribedMessage = "Thanks for subscribing";
        string unsubscribedMessage = "Sorry to see you go! You are unsubscribed from notifications.";
        string alreadySubscribedMessage = "Thank you. You are already subscribed :)";
        string alreadyUnsubscribedMessage = "Oops! You are not subscribed to notifications.";
        string tryAgainMessage = "Sorry, something went wrong. Please, try again:" +
                    "\nemail: example@email.com \nphone: must be numbers";
        public ManageSubscriptionForm() { InitializeComponent(); }

        private void ManageSubscription_Load(object sender, EventArgs e) { }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) { }

        private void BtnCancelSubscription_Click(object sender, EventArgs e)
        { 
            NotificationManagerForm notificationManagerForm = new NotificationManagerForm();
            notificationManagerForm.Show();
            this.Hide();            
        }

        private void TxtInputEmail_Click(object sender, EventArgs e) { }

        private void BtnSubscribe_Click(object sender, EventArgs e)
        {
            if (ckSendByEmail.Checked && !ckSendByPhoneNumber.Checked)
            {
                SubscribeByEmail();
            }
            else if (ckSendByPhoneNumber.Checked && !ckSendByEmail.Checked)
            {
                SubscribeByPhoneNumber();
            }
            else if (ckSendByEmail.Checked && ckSendByPhoneNumber.Checked)
            {
                SubscribeByEmail();
                SubscribeByPhoneNumber();
            }
            else
            {
                MessageBox.Show(tryAgainMessage);
            }
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            if (ckSendByEmail.Checked && !ckSendByPhoneNumber.Checked)
            {
                UnsubscribeByEmail();
            }
            else if (ckSendByPhoneNumber.Checked && !ckSendByEmail.Checked)
            {
                UnsubscribeByPhoneNumber();
            }
            else if (ckSendByEmail.Checked && ckSendByPhoneNumber.Checked) 
            {
                UnsubscribeByEmail();
                UnsubscribeByPhoneNumber();
            }
            else
            {
                MessageBox.Show(tryAgainMessage);
            }
        }

        private void SubscribeByEmail()
        {
            try
            {
                var userEmail = new MailAddress(txtInputEmail.Text);
                string strUserEmail = userEmail.Address;

                if (!listOfEmail.Contains(strUserEmail))
                {
                    Publish publish = new Publish();
                    SendByEmail sendEmailToUser = new SendByEmail(strUserEmail);
                    sendEmailToUser.Subscribe(publish);

                    listOfEmail.Add(strUserEmail);
                    MessageBox.Show(subscribedMessage);
                }
                else
                {
                    MessageBox.Show(alreadySubscribedMessage);
                }
            }
            catch
            {
                MessageBox.Show(tryAgainMessage);
            }
        }

        private void SubscribeByPhoneNumber()
        {
            try
            {
                int userPhoneNumber = Convert.ToInt32(txtInputPhoneNumber.Text);
                string strUserPhoneNumber = Convert.ToString(userPhoneNumber);

                if (!listOfPhone.Contains(strUserPhoneNumber))
                {
                    Publish publish = new Publish();
                    SendByPhoneNumber sendSMSToUser = new SendByPhoneNumber(strUserPhoneNumber);
                    sendSMSToUser.Subscribe(publish);

                    listOfPhone.Add(strUserPhoneNumber);
                    MessageBox.Show(subscribedMessage);
                }
                else
                {
                    MessageBox.Show(alreadySubscribedMessage);
                }
            }
            catch
            {
                MessageBox.Show(tryAgainMessage);
            }
        }

        private void UnsubscribeByEmail()
        {
            try
            {
                var userEmail = new MailAddress(txtInputEmail.Text);
                string strUserEmail = userEmail.Address;

                if (listOfEmail.Contains(strUserEmail))
                {
                    Publish publish = new Publish();
                    SendByEmail sendEmailToUser = new SendByEmail(strUserEmail);
                    sendEmailToUser.Unsubscribe(publish);

                    listOfEmail.Remove(strUserEmail);
                    MessageBox.Show(unsubscribedMessage);
                }
                else
                {
                    MessageBox.Show(alreadyUnsubscribedMessage);
                }
            }
            catch
            {
                MessageBox.Show(tryAgainMessage);
            }
        }

        private void UnsubscribeByPhoneNumber()
        {
            try
            {
                string strUserPhoneNumber = txtInputPhoneNumber.Text;

                if (listOfPhone.Contains(strUserPhoneNumber))
                {
                    Publish publish = new Publish();
                    SendByPhoneNumber sendSMSToUser = new SendByPhoneNumber(strUserPhoneNumber);
                    sendSMSToUser.Unsubscribe(publish);

                    listOfPhone.Remove(strUserPhoneNumber);
                    MessageBox.Show(unsubscribedMessage);
                }
                else
                {
                    MessageBox.Show(alreadyUnsubscribedMessage);
                }
            }
            catch
            {
                MessageBox.Show(tryAgainMessage);
            }
        }
    }
}
