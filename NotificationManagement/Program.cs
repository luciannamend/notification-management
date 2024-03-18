using System;
using System.Collections.Generic;

namespace NotificationManagement
{
    internal class Program
    {
        // ===================== Publisher Class =====================
        public class Publisher 
        {
            public delegate void PublishContentDel(string content);

            public PublishContentDel PublishContent = null;

            public void SendContent(string content) 
            { 
                PublishContent.Invoke(content); 
            }
        }

        // ===================== Email Subs Class ===================== 
        public class SendByEmail 
        {
            public string Email { get; set; }
            public SendByEmail() { }
            public SendByEmail(string email) { Email = email; }

            // method to match the delegate
            public void SendEmail(string content) 
            {
                Console.WriteLine(Email + ": " + content); 
            }

            // publisher obj to subscribe email to content
            public void Subscribe(Publisher pub) 
            {
                pub.PublishContent += SendEmail;
            }

            public void Unsubscribe(Publisher pub) 
            { 
                pub.PublishContent -= SendEmail;  
            }
        }

        // ===================== PhoneNumber Subs Class ===================== 
        public class SendByPhoneNumber
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
            public void Subscribe(Publisher pub)
            {
                pub.PublishContent += SendSMS;
            }

            public void Unsubscribe(Publisher pub)
            { 
                pub.PublishContent -= SendSMS; 
            }
        }
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();

            SendByEmail sendEmailToUser1 = new SendByEmail("user1_@gmail.com");
            SendByEmail sendEmailToUser2 = new SendByEmail("user2_@gmail.com");

            SendByPhoneNumber sendSMSToUser1 = new SendByPhoneNumber("647 956 321");
            SendByPhoneNumber sendSMSToUser2 = new SendByPhoneNumber("647 956 123");

            Console.WriteLine();
            Console.WriteLine("============================== SUBS ==============================");

            sendEmailToUser1.Subscribe(pub);
            sendEmailToUser2.Subscribe(pub);

            sendSMSToUser1.Subscribe(pub);
            sendSMSToUser2.Subscribe(pub);

            pub.SendContent("You received a discount");

            Console.WriteLine();
            Console.WriteLine("============================== UNSUBS ==============================");

            sendEmailToUser1.Unsubscribe(pub);

            sendSMSToUser1.Unsubscribe(pub);

            pub.SendContent("As a valued user you earn $20 discount!");
            Console.WriteLine();



        }
    }
}
