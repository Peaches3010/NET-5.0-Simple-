using Ecommerce.Contracts.Dtos;
using Ecommerce.Contracts.Dtos.ProductDtos;
using Ecommerce.DatAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Common
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            FromDataAccessorLayer();
            FromPresentationLayer();
        }

        private void FromPresentationLayer()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<ProductDto, Product>().ForMember(x => x.ImageUrl, i => i.Ignore());

            CreateMap<ProductCreateRequest, ProductDto>().ReverseMap()
                                                         .ForMember(x => x.ImageUrl, i => i.Ignore());
            CreateMap<ProductUpdateRequest, ProductDto>().ReverseMap()
                                                         .ForMember(x => x.ImageUrl, i => i.Ignore());

        }

        private void FromDataAccessorLayer()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>();

            CreateMap<Product, ProductCreateRequest>().ReverseMap()
                                                      .ForMember(x => x.ImageUrl, i => i.Ignore());
            CreateMap<Product, ProductUpdateRequest>().ReverseMap()
                                                      .ForMember(x => x.ImageUrl, i => i.Ignore());
        }
    }
}
