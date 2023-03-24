using AutoMapper;
using WebApplication14.Models;
using WebApplication14.ViewModels;

namespace WebApplication14.AutoMapperProfile
{
    public class PersonsProfile : Profile
    {
        public PersonsProfile()
        {
            CreateMap<Person, PersonsListViewModel>();
            CreateMap<Person, PersonInfoViewModel>();
        }
    }
}
