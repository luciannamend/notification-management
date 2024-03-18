using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManagementGUI
{
    internal class SendByPhoneNumber
    {
        public string PhoneNumber { get; set; }
        public SendByPhoneNumber() { }
        public SendByPhoneNumber(string phoneNumber) { PhoneNumber = phoneNumber; }

        // method to match the delegate
        public void SendSMS(string content)
        {
            Console.WriteLine(PhoneNumber + ": " + content);
        }

        // publisher obj to subscribe phone to content
        public void Subscribe(Publish pub)
        {
            pub.PublishContent += SendSMS;
        }

        public void Unsubscribe(Publish pub)
        {
            pub.PublishContent -= SendSMS;
        }
    }
}
