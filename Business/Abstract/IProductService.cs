using Entitites.Concrete;
using Entitites.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByProductId(int productId);
        List<Product> GetByProductPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();

    }
}
