using System;
using Slugify;
using Business.Abstract;
using Business.Concrete.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using shopEntities.Concrete;

namespace Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        IResult ICategoryService.Add(Category category)
        {
            if (category.name != null || category.name != "")
            {
                SlugHelper helper = new SlugHelper();
                category.slug = helper.GenerateSlug(category.name);
            }
            category.created_at = DateTime.Now;
            try
            {
                _categoryDal.Add(category);
                return new SuccessResult(Messages.dataAdded);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        IResult ICategoryService.Delete(Category category)
        {
            try
            {
                _categoryDal.Delete(category);
                return new SuccessResult(Messages.dataDeleted);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        IDataResult<Category> ICategoryService.GetById(int id)
        {
            try
            {
                return new SuccessDataResult<Category>(_categoryDal.Get(c => c.id == id));
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Category>(ex.Message);
            }
        }

        IDataResult<List<Category>> ICategoryService.GetCategories()
        {
            try
            {
                return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Category>>(ex.Message);
            }
            
        }

        IResult ICategoryService.Update(Category category)
        {
            if (category.name != null || category.name != "")
            {
                SlugHelper helper = new SlugHelper();
                category.slug = helper.GenerateSlug(category.name);
            }
            category.updated_at = DateTime.Now;
            try
            {
                _categoryDal.Update(category);
                return new SuccessResult(Messages.dataUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}

