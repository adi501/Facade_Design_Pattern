using WithOut_Facade_Design_Pattern.Service.IService;

namespace WithOut_Facade_Design_Pattern.Service
{
    internal class InventoryService : IInventoryService
    {
        public Task<string[]> GetAsync()
        {
            return Task.FromResult(new string[] { "Book", "Pen" });
        }
    }
}
