using System;
using System.Diagnostics;
using OopExercise.HealthChecker.Domain.Models.Common;

namespace OopExercise.HealthChecker.Domain.Models.NotifySenders
{
    public class SmsNotificationSender : INotificationSender
    {
        public void Notify(Client client, string message)
        {
            Debug.WriteLine($"SMS Notify to {client.CellphoneNumber} Successfully.\nMessage: {message}\n\n\n");
        }
    }
}
