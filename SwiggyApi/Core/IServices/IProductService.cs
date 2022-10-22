using SwiggyApi.Models;

namespace SwiggyApi.Core.IServices
{
    public interface IProductService
    {
        List<Product> GetProducts();
        
        string PostProduct(Product product);
        string DeleteProduct(int ProductId,Product product);
        string PutProduct(int productId,Product product);
    }
}
