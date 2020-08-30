using OopExercise.HealthChecker.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OopExercise.HealthChecker.Domain.Models.NotifySenders
{
    public class PhoneCallNotificationSender : INotificationSender
    {
        public void Notify(Client client, string message)
        {
            Debug.WriteLine($"We called to {client.PhoneNumber} and notify {client.Name}.\nMessage: {message}\n\n\n");
        }
    }
}
