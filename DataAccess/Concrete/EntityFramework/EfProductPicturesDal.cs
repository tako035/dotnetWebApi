using System;
using Core.DataAccess.EfEntityFramework;
using DataAccess.Abstract;
using shopEntities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class EfProductPicturesDal : EfEntityRepositoryBase<ProductPictures , ShopContext>, IProductPicturesDal
    {
        
    }
}

