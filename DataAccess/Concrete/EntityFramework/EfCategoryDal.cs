using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitites.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntitiyRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        //public void Add(Category entity)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        var addEntity = context.Entry(entity);
        //        addEntity.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Category entity)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        var deleteEntity = context.Entry(entity);
        //        deleteEntity.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }

        //}

        //public Category Get(Expression<Func<Category, bool>> filter)
        //{

        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        return context.Set<Category>().SingleOrDefault(filter);
        //    }
        //}

        //public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        return filter == null
        //           ? context.Set<Category>().ToList()
        //           : context.Set<Category>().Where(filter).ToList();
        //    }
        //}

        //public void Update(Category entity)
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {
        //        var updateEntitiy = context.Entry(entity);
        //        updateEntitiy.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
    }
}

