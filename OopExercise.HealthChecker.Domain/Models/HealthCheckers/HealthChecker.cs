using OopExercise.HealthChecker.Domain.Models.Comman;
using OopExercise.HealthChecker.Domain.Models.NotifySenders;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OopExercise.HealthChecker.Domain.Models.HealthCheckers
{
    public abstract class HealthChecker
    {
        protected readonly List<INotificationSender> notifySenders;
        protected HealthChecker(string connectionString, Client client, List<INotificationSender> notifySenders)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            this.notifySenders = notifySenders;
            Client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public string ConnectionString { get; private set; }
        protected string AccessToken { get; private set; }
        public bool Status { get; protected set; }
        public Client Client { get; private set; }
        public abstract Task Check(bool sendNotification);
        public void SetAccessToken(string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new ArgumentNullException(nameof(accessToken));
            AccessToken = accessToken;
            //Set token to request
        }
    }
}
