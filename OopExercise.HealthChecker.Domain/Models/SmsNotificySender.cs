using System;
using System.Collections.Generic;
using System.Text;

namespace OopExercise.HealthChecker.Domain.Models
{
    public class SmsNotificySender : NotifySender
    {
        public SmsNotificySender(string cellPhoneNumber)
            : base(cellPhoneNumber)
        {

        }

        public override void Send()
        {
            //Send Notify to {ContactAddress}
        }
    }
}
