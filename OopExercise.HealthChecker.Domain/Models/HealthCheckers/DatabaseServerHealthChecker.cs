using OopExercise.HealthChecker.Domain.Models.Comman;
using OopExercise.HealthChecker.Domain.Models.NotifySenders;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OopExercise.HealthChecker.Domain.Models.HealthCheckers
{
    public class DatabaseServerHealthChecker : HealthChecker
    {
        public DatabaseServerHealthChecker(string connectionString, Client client, List<INotificationSender> notifySenders)
            : base(connectionString, client, notifySenders)
        {
        }

        public override void Check(bool sendNotification)
        {
            //Status=a select query to connection;
            if (!Status && sendNotification)
                foreach (var sender in notifySenders)
                    sender.Notify(Client);
        }
    }
}
