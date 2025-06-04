using SampleApi.core.Entities;
using SampleApli.Appliacation.Dtos;

public interface IProductService
{


    List<ProductDto> GetAll();

    ProductDto Get(int Id);

    ProductDto Add(ProductDto model);


}