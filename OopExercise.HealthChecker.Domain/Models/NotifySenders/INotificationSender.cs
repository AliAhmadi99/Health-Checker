using OopExercise.HealthChecker.Domain.Models.Comman;

namespace OopExercise.HealthChecker.Domain.Models.NotifySenders
{
    public interface INotificationSender
    {
        void Notify(Client client,string message);
    }
}
