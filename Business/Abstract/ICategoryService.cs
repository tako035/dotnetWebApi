using Core.Utilities.Results;
using shopEntities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetCategories();

        IDataResult<Category> GetById(int id);

        IResult Add(Category category);

        IResult Update(Category category);

        IResult Delete(Category category);
    }
}

