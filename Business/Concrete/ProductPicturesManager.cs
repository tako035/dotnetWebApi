using System;
using Business.Abstract;
using Business.Concrete.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using shopEntities.Concrete;

namespace Business.Concrete
{
    public class ProductPicturesManager: IProductPicturesService
    {

        IProductPicturesDal _productPicturesDal;

        public ProductsPicturesManager(IProductPicturesDal productPicturesDal)
        {
            _productPicturesDal = productPicturesDal;
        }

        public IResult Add(ProductPictures productPictures)
        {
            try
            {
                _productPicturesDal.Add(productPictures);
                return new SuccessResult(Messages.dataAdded);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(ProductPictures productPictures)
        {
            try
            {
                _productPicturesDal.Delete(productPictures);
                return new SuccessResult(Messages.dataDeleted);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<ProductPictures> GetById(int Id)
        {
            try
            {
                return new SuccessDataResult<ProductPictures>(_productPicturesDal.Get((pp) => pp.Id == Id));

            }
            catch (Exception ex)
            {
                return new ErrorDataResult<ProductPictures>(ex.Message);
            }
        }

        public IDataResult<List<ProductPictures>> GetList(ProductPictures productPictures)
        {
            try
            {
                return new SuccessDataResult<List<ProductPictures>(_productPicturesDal.GetList().ToList());
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<ProductPictures>>(ex.Message);
            }
        }

        public IResult Update(ProductPictures productPictures)
        {
            try
            {
                _productPicturesDal.Update(productPictures);
                return new SuccessResult(Messages.dataUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}

