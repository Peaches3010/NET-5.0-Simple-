using Ecommerce.Business.Interfaces;
using Ecommerce.Business.Repositories;
using Ecommerce.Business.Services;
using Ecommerce.DatAccessor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Ecommerce.Business.Common
{
    public static class ServicesRegister
    {
        public static void AddBusinessLayer(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDataAccessorLayer(configuration);
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductService, ProductService>();

        }
    }
}
