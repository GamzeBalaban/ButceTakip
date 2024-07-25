using AutoMapper;
using Butce.DtoLayer.BudgetDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class BudgetMapping:Profile
    {
        public BudgetMapping()
        {
            CreateMap<Budget, ResultBudgetDto>().ReverseMap();
            CreateMap<Budget, CreateBudgetDto>().ReverseMap();
            CreateMap<Budget, GetBudgetDto>().ReverseMap();
            CreateMap<Budget, UpdateBudgetDto>().ReverseMap();
        }
    }
}
