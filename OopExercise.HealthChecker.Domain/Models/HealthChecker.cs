using System;
using System.Collections.Generic;
using System.Text;

namespace OopExercise.HealthChecker.Domain.Models
{
    public abstract class HealthChecker
    {
        private readonly NotifySender notifySender;
        protected HealthChecker(string connectionString, NotifySender notifySender)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            this.notifySender = notifySender;
        }

        public string ConnectionString { get; private set; }
        public abstract bool GetStatus();
    }
}
