namespace With_Facade_Design_Pattern.Service.IService
{
    public interface IPaymentService
    {
        Task PayAsync(double amount, string item);
    }
}
