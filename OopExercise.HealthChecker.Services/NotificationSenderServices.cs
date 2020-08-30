using OopExercise.HealthChecker.Domain.Models.Common;
using OopExercise.HealthChecker.Domain.Models.NotifySenders;
using System;

namespace OopExercise.HealthChecker.Services
{
    public class NotificationSenderServices
    {
        public static void SendMail(Client client, String message)
        {
            var emailSender = new EmailNotificationSender();
            emailSender.Notify(client, message);
        }
        public static void SendSMS(Client client, String message)
        {
            var emailSender = new SmsNotificationSender();
            emailSender.Notify(client, message);
        }
    }
}
