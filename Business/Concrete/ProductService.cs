using System;
using Slugify;
using Business.Abstract;
using Business.Concrete.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using shopEntities.Concrete;

namespace Business.Concrete
{

    
    public class ProductService : IProductService
    {
        private IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.Name != null || product.Name != "")
            {
                SlugHelper helper = new SlugHelper();
                product.Slug = helper.GenerateSlug(product.Name);
            }
            product.Created_at = DateTime.Now;
            try
            {
                _productDal.Add(product);
                return new SuccessResult(Messages.dataAdded);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
                return new SuccessResult(Messages.dataDeleted);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }


        }

        public IDataResult<Product> GetById(int Id)
        {

            try
            {
                return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == Id));
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Product>(ex.Message);
            }
        }

        public IDataResult<List<Product>> GetProducts()
        {
            try
            {
                return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
                
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Product>>(ex.Message);
            }
        }

        public IDataResult<List<Product>> GetListByCategory(int Category_id)
        {
            try
            {
                return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.Category_id == Category_id).ToList());
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Product>>(ex.Message);
            }
        }

        public IResult Update(Product product)
        {
            if (product.Name != null || product.Name !="")
            {
                SlugHelper helper = new SlugHelper();
                product.Slug = helper.GenerateSlug(product.Name);
            }
            product.Updated_at = DateTime.Now;
            try
            {
                _productDal.Update(product);
                return new SuccessResult(Messages.dataUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

    }
}

