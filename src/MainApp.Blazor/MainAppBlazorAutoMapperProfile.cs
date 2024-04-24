using AutoMapper;
using DemoModule.Countries;
using DemoModule.Customers;

namespace MainApp.Blazor;

public class MainAppBlazorAutoMapperProfile : Profile
{
    public MainAppBlazorAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Blazor project.
        CreateMap<CustomerDto, CustomerCreateUpdateDto>();
        CreateMap<CountryDto, CountryCreateUpdateDto>();
    }
}
