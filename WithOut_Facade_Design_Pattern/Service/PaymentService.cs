using WithOut_Facade_Design_Pattern.Service.IService;

namespace WithOut_Facade_Design_Pattern.Service
{
    internal class PaymentService : IPaymentService
    {
        public Task PayAsync(double amount, string item)
        {
            Console.WriteLine($"Paying amount: {amount} for item: {item}");
            return Task.CompletedTask;
        }
    }
}
