using System;
using Core.Utilities.Results;
using shopEntities.Concrete;

namespace Business.Abstract
{
    public interface IProductPicturesService
    {
        IDataResult<List<ProductPictures>> GetList(ProductPictures productPictures);
        IDataResult<ProductPictures> GetById(int Id);
        IResult Add(ProductPictures productPictures);
        IResult Delete(ProductPictures productPictures);
        IResult Update(ProductPictures productPictures);
    }
}

