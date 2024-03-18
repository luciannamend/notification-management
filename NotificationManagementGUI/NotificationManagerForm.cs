using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationManagementGUI
{
    public partial class NotificationManagerForm : Form
    {

        public NotificationManagerForm()
        {
            InitializeComponent();
        }

        private void NotificationManager_Load(object sender, EventArgs e)
        {
            if (ManageSubscriptionForm.listOfEmail.Count > 0)
            { btnPublishNotification.Enabled = true; }
            else { btnPublishNotification.Enabled = false; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPublishNotification_Click(object sender, EventArgs e)
        {
            PublishNotificationForm publishNotificationForm = new PublishNotificationForm();
            publishNotificationForm.Show();  
            this.Hide();
        }

        private void btnManageSubscription_Click(object sender, EventArgs e)
        {
            ManageSubscriptionForm manageSubscriptionForm = new ManageSubscriptionForm();
            manageSubscriptionForm.Show();
            this.Hide();
        }
    }
}
