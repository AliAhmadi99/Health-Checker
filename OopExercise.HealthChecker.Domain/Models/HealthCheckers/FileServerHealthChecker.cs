using System;
using System.Collections.Generic;
using System.Text;
using OopExercise.HealthChecker.Domain.Models.Comman;
using OopExercise.HealthChecker.Domain.Models.NotifySenders;

namespace OopExercise.HealthChecker.Domain.Models.HealthCheckers
{
    class FileServerHealthChecker : HealthChecker
    {

        public FileServerHealthChecker(string connectionString, Client client, List<INotificationSender> notifySenders)
            : base(connectionString, client, notifySenders)
        {
        }

        public override void Check(bool sendNotification)
        {
            //Status=upload a file to check heath;
            if (!Status && sendNotification)
                foreach (var sender in notifySenders)
                {
                    sender.Notify(Client);
                }
        }
    }
}
