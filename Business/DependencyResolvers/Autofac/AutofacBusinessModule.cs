
using System;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.jwt;
using DataAccess.Abstract;
using Castle.DynamicProxy;
using DataAccess.Concrete.EntityFramework;
using Core.Utilities.Interceptors;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<ProductSpecsManager>().As<IProductSpecsService>();
            builder.RegisterType<EfProductSpecsDal>().As<IProductSpecsDal>();

            builder.RegisterType<ProductPicturesManager>().As<IProductPicturesService>();
            builder.RegisterType<EfProductPicturesDal>().As<IProductPicturesDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUSerDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

