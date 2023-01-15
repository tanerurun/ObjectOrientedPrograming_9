using Core.DataAccess;
using Entitites.Concrete;
using Entitites.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

        List<ProductDetailDto> GetProductDetails();
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);
        //List<Product> GetAll();
        //List<Product> GetByProductId(int productId);

    }
}
