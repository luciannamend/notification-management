using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NotificationManagementGUI
{
    public partial class PublishNotificationForm : Form
    {
        string content;

        public PublishNotificationForm()
        {
            InitializeComponent();
        }
        
        private void PublishNotificationForm_Load(object sender, EventArgs e) { }

        private void btnExitPublishNotification(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string message = "The content: ('" + content + "') was sent to the following: \n";
            // Add emails to the message
            message += "Emails:\n";
            foreach (string email in ManageSubscriptionForm.listOfEmail)
            {
                message += email + "\n";
            }
            // Add phones to the message
            message += "\nPhones:\n";
            foreach (string phone in ManageSubscriptionForm.listOfPhone)
            {
                message += phone + "\n";
            }
            // Display the message box
            MessageBox.Show(message);
        }

        private void txtInputNotificationContent_TextChanged(object sender, EventArgs e)
        {
            content = txtInputNotificationContent.Text;
        }
    }
}
