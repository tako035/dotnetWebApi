using System;
using Core.Utilities.Results;
using shopEntities.Concrete;

namespace Business.Abstract
{
    public interface IProductSpecsService
    {
        IDataResult<List<ProductSpecs>> GetProductSpecs();

        IDataResult<ProductSpecs> GetById(int id);

        IResult Add(ProductSpecs productSpecs);

        IResult Update(ProductSpecs productSpecs);

        IResult Delete(ProductSpecs productSpecs);
    }
}

