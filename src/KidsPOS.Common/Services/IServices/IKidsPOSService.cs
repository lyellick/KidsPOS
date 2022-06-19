using KidsPOS.Common.Models;

namespace KidsPOS.Common.Services.IServices
{
    public interface IKidsPOSService
    {
        Task<Product[]> GetProducts();

        Task CreateReceipt(Product[] products);
    }
}
