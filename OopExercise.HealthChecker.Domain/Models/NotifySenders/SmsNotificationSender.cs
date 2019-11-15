using System;
using System.Collections.Generic;
using System.Text;
using OopExercise.HealthChecker.Domain.Models.Comman;

namespace OopExercise.HealthChecker.Domain.Models.NotifySenders
{
    public class SmsNotificationSender : INotificationSender
    {
        public void Notify(Client client)
        {
            //Send Notification to client.CellphoneNumber
            throw new NotImplementedException();
        }
    }
}
