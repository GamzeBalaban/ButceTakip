using AutoMapper;
using Butce.DtoLayer.AddUser;
using Butce.DtoLayer.AddUserDto;
using Butce.DtoLayer.BudgetAmountDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class BudgetAmountMapping : Profile
    {

        public BudgetAmountMapping()
        {
            CreateMap<BudgetAmount, ResultBudgetAmountDto>().ReverseMap();
            CreateMap<BudgetAmount, CreateBudgetAmountDto>().ReverseMap();

            CreateMap<BudgetAmount, GetBudgetAmountDto>().ReverseMap();

            CreateMap<BudgetAmount, UpdateBudgetAmountDto>().ReverseMap();
        }

    }
}
