using Session_8_partone.Model;

namespace Session_8_partone.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> product;
        public ProductService()
        {
            product = new List<Product>()
            {
                new Product() {Id=1,Prodname="Nokia",ProdPrice=4000}
            };
        }
        public IEnumerable<Product> GetAllItems()
        {
            return product;
        }

        public object GetProductById(int id)
        {
            return product.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}

