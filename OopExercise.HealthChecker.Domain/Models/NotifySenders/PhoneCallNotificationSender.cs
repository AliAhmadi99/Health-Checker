using OopExercise.HealthChecker.Domain.Models.Comman;
using System;
using System.Collections.Generic;
using System.Text;

namespace OopExercise.HealthChecker.Domain.Models.NotifySenders
{
    public class PhoneCallNotificationSender : INotificationSender
    {
        public void Notify(Client client)
        {
            //Send Notification to client.PhoneNumber
            throw new NotImplementedException();
        }
    }
}
