namespace WithOut_Facade_Design_Pattern.Service.IService
{
    public interface INotificationService
    {
        Task SendAsync(string message);
    }
}
