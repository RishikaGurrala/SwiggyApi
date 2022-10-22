using SwiggyApi.Core.IServices;
using SwiggyApi.Models;

namespace SwiggyApi.Core.Services
{
    public class ProductService:IProductService
     {
        private readonly SwiggyContext Model;
        public ProductService(SwiggyContext model)
        {
            Model = model;
        }

        public string DeleteProduct(int ProductId,Product product)
        {
            try
            {
                if (product != null)
                {
                    Product pro = new Product();
                    var p = Model.Products.FirstOrDefault(p => p.ProductId == ProductId);
                    Model.Remove(pro);
                    Model.SaveChanges();
                    return "Product deleted successfully";
                }
                else
                    return "Product deletion failed";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public string PostProduct(Product product)
        {
            try
            {
                if(product!= null)
                {
                    Model.Products.Add(product);
                    Model.SaveChanges();
                    return "Product Inserted Successfully";
                }
                else
                {
                    return "Product Insertion Failed";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        

        public string PutProduct(int productId, Product product)
        {
            try
            {
                if (product != null)
                {
                    Product prod = new Product();
                    var p = Model.Products.FirstOrDefault(x=> x.ProductId==productId);
                    p.Category=product.Category;
                    p.Name = product.Name;
                    p.Description = product.Description;
                    p.Price = product.Price;
                    p.IsActive = product.IsActive;
                    return "sussessfull";
                }
                else
                {
                    return "product updation failed";
                }
            }
            catch(Exception ex)
            {
             return ex.Message;
            }
        }

        List<Product> IProductService.GetProducts()
        {

            var db = new SwiggyContext();
            return db.Products.ToList();

        }
        
    }
}
