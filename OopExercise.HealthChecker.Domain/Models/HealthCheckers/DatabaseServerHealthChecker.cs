using OopExercise.HealthChecker.Domain.Models.Common;
using OopExercise.HealthChecker.Domain.Models.NotifySenders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExercise.HealthChecker.Domain.Models.HealthCheckers
{
    public class DatabaseServerHealthChecker : HealthChecker
    {
        public DatabaseServerHealthChecker(string connectionString, Client client, List<INotificationSender> notifySenders)
            : base(connectionString, client, notifySenders)
        {
        }
        public override async Task Check(bool sendNotification)
        {
            string query = "SELECT 1";

            SqlConnection conn = new SqlConnection(ConnectionString);
            DataTable dataTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                await conn.OpenAsync();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                await conn.CloseAsync();
                da.Dispose();
            }

            Status = !dataTable.HasErrors;
            if (!Status && sendNotification)
                foreach (var sender in notifySenders)
                    sender.Notify(Client, string.Join(',', dataTable.GetErrors().ToList()));
        }
    }
}
