using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var item in productManager.GetProductDetails())
        {
            Console.WriteLine(item.ProductName);
        }
        Console.WriteLine("Hello, World!");
    }
}