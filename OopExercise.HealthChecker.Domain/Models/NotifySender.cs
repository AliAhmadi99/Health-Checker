using System;
using System.Collections.Generic;
using System.Text;

namespace OopExercise.HealthChecker.Domain.Models
{
    public abstract class NotifySender
    {
        public NotifySender(string contactAddress)
        {
            ContactAddress = contactAddress;
        }
        public string ContactAddress { get; private set; }
        public abstract void Send();
    }
}
