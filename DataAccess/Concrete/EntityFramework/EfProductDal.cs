using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntitiyRepositoryBase<Product, NorthwindContext>, IProductDal
    {

        //buraya urune ozel oparasyonlari yazacagiz
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
