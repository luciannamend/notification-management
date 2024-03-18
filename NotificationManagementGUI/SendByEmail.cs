using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManagementGUI
{
    internal class SendByEmail
    {
        public string Email { get; set; }
        public SendByEmail(string email) { Email = email; }

        // method to match the delegate
        public void SendEmail(string content)
        {
            Console.WriteLine(Email + ": " + content);
        }

        // publisher obj to subscribe email to content
        public void Subscribe(Publish pub)
        {
            pub.PublishContent += SendEmail;
        }

        public void Unsubscribe(Publish pub)
        {
            pub.PublishContent -= SendEmail;
        }

    }
}
