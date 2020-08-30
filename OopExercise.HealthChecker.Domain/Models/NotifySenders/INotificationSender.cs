using OopExercise.HealthChecker.Domain.Models.Common;

namespace OopExercise.HealthChecker.Domain.Models.NotifySenders
{
    public interface INotificationSender
    {
        void Notify(Client client,string message);
    }
}
