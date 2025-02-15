using With_Facade_Design_Pattern.Service.IService;

namespace With_Facade_Design_Pattern.Service
{
    internal class NotificationService : INotificationService
    {
        public Task SendAsync(string message)
        {
            Console.WriteLine($"Sending notification message: {message}");
            return Task.CompletedTask;
        }
    }
}
