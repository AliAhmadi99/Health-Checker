using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OopExercise.HealthChecker.Domain.Models
{
    public class DatabaseServerHealthChecker : HealthChecker
    {
        private readonly NotifySender notifySender;
        public DatabaseServerHealthChecker(NotifySender notifySender,
            string serverConection,
            string userName = null, string password = null)
            : base(serverConection, notifySender)
        {
        }

        public bool Status { get; protected set; }

        public override bool GetStatus()
        {
            //Status=a select query to connection;
            if (!Status)
                notifySender.Send();
            return Status;
        }
    }
}
