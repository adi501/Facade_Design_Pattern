namespace With_Facade_Design_Pattern.Service.IService
{
    public interface IInventoryService
    {
        Task<string[]> GetAsync();
    }
}
