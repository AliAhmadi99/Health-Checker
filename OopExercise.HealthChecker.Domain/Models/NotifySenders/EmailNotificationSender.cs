using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using OopExercise.HealthChecker.Domain.Models.Comman;

namespace OopExercise.HealthChecker.Domain.Models.NotifySenders
{
    public class EmailNotificationSender : INotificationSender
    {
        public void Notify(Client client, string message)
        {
            Debug.WriteLine($"We sent mail to {client.EmailAddress}.\nMessage: {message}\n\n\n");
        }
    }
}
