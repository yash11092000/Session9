using Session_8_partone.Model;

namespace Session_8_partone.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllItems();
        object GetProductById(int id);
    }
}
