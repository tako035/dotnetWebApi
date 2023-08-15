using System;
using Core.DataAccess.EfEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using shopEntities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ShopContext>, ICategoryDal
    {
        
    }
}

