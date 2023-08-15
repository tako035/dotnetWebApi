using Core.Utilities.Results;
using shopEntities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetProducts();

        IDataResult<List<Product>> GetListByCategory(int category_id);

        IDataResult<Product> GetById(int id);

        IResult Add(Product product);

        IResult Delete(Product product);

        IResult Update(Product product);
    }
}

