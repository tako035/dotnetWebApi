using System;
using Core.DataAccess;
using shopEntities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
    }
}

