using Core.DataAccess.EfEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using shopEntities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product, ShopContext>, IProductDal
    {

    }
}

