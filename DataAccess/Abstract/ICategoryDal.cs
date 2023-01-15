using Core.DataAccess;
using Entitites.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //void Add(Category category);
        //void Updater(Category category);    
        //void Delete(Category category);

        //List<Category> GetAll();
        //List<Category> GetAllByCategoryId(int categoryId);
    }
}
