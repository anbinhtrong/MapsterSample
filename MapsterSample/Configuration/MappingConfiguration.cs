using Mapster;
using MapsterSample.Models;

namespace MapsterSample.Configuration
{
    public static class MappingConfiguration
    {
        public static void Configure()
        {
            TypeAdapterConfig<Product, ProductViewModel>
                .NewConfig()
                .Map(dest => dest.Id, src => src.ProductId)           // ProductId => Id
                .Map(dest => dest.Name, src => src.ProductName)       // ProductName => Name
                .Map(dest => dest.Price, src => src.ProductPrice)     // ProductPrice => Price
                .Compile();

            // Config reverse mapping ProductViewModel => Product
            TypeAdapterConfig<ProductViewModel, Product>
                .NewConfig()
                .Map(dest => dest.ProductId, src => src.Id)
                .Map(dest => dest.ProductName, src => src.Name)
                .Map(dest => dest.ProductPrice, src => src.Price)
                .Compile();
        }
    }
}
