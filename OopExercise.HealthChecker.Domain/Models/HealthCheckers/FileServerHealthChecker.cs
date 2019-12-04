using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
        public Uri FileUri { get; set; }
        public override async Task Check(bool sendNotification)
        {
            string filePath = string.Empty;
            WebClient client = new WebClient();
            File.Copy(filePath, ConnectionString + " - " + DateTime.UtcNow.Date);
            byte[] arrReturn = await client.UploadFileTaskAsync(FileUri, filePath);
            Console.WriteLine(arrReturn.ToString());
        }
    }
}
