using System;
using System.Linq.Expressions;
using Core.DataAccess.EfEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using shopEntities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductSpecsDal : EfEntityRepositoryBase<ProductSpecs, ShopContext>, IProductSpecsDal
    {
    }
}

