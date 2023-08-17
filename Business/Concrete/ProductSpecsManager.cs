using System;
using Business.Abstract;
using Business.Concrete.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using shopEntities.Concrete;

namespace Business.Concrete
{
    public class ProductSpecsManager: IProductSpecsService
    {
        IProductSpecsDal _productSpecsDal;

        public ProductSpecsManager(IProductSpecsDal productSpecsDal)
        {
            _productSpecsDal = productSpecsDal;
        }

        public IResult Add(ProductSpecs productSpecs)
        {
            try
            {
                _productSpecsDal.Add(productSpecs);
                return new SuccessResult(Messages.dataAdded);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(ProductSpecs productSpecs)
        {
            try
            {
                _productSpecsDal.Delete(productSpecs);
                return new SuccessResult(Messages.dataDeleted);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<ProductSpecs> GetById(int id)
        {
            try
            {
                return new SuccessDataResult<ProductSpecs>(_productSpecsDal.Get((spec)=> spec.Id == id));
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<ProductSpecs>(ex.Message);
            }
        }

        public IDataResult<List<ProductSpecs>> GetProductSpecs()
        {
            try
            {
                return new SuccessDataResult<List<ProductSpecs>>(_productSpecsDal.GetList().ToList());
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<ProductSpecs>>(ex.Message);
            }
        }

        public IResult Update(ProductSpecs productSpecs)
        {
            try
            {
                _productSpecsDal.Update(productSpecs);
                return new SuccessResult(Messages.dataUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}

