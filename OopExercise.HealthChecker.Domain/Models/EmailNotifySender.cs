using System;
using System.Collections.Generic;
using System.Text;

namespace OopExercise.HealthChecker.Domain.Models
{
    public class EmailNotifySender : NotifySender
    {
        public EmailNotifySender(string emailAddress) 
            : base(emailAddress)
        {
        }
    }
}
