using Entitites.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetByCategoryId(int categoryId);

    }
}
