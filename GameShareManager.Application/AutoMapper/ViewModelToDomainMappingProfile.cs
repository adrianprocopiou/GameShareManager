using AutoMapper;
using GameShareManager.Application.Filters;
using GameShareManager.Application.Filters.DataTables;
using GameShareManager.Application.ViewModels;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CompanyViewModel, Company>();
            CreateMap<FriendViewModel, Friend>();
            CreateMap<GameViewModel, Game>();
            CreateMap<CompanyAppFilter, CompanyFilter>();
            CreateMap<FriendAppFilter, FriendFilter>();
            CreateMap<GameAppFilter, GameFilter>();
            CreateMap<LoanViewModel, Loan>();
        }

        public override string ProfileName => "ViewModelToDomainMapping";
    }
}