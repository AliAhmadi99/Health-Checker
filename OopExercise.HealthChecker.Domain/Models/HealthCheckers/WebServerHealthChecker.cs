using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using OopExercise.HealthChecker.Domain.Models.Common;
using OopExercise.HealthChecker.Domain.Models.NotifySenders;

namespace OopExercise.HealthChecker.Domain.Models.HealthCheckers
{
    public class WebServerHealthChecker : HealthChecker
    {
        public WebServerHealthChecker(string connectionString, Client client, List<INotificationSender> notifySenders)
            : base(connectionString, client, notifySenders)
        {
        }

        public override async Task Check(bool sendNotification)
        {
            using (var httpRequest = new HttpClient())
            {
                var respone = await httpRequest.GetAsync(ConnectionString);
                Status = respone.StatusCode.Equals(HttpStatusCode.OK);
                if (!Status && sendNotification)
                    foreach (var sender in notifySenders)
                    {
                        sender.Notify(Client, await respone.Content.ReadAsStringAsync());
                    }
            }
        }
    }
}
