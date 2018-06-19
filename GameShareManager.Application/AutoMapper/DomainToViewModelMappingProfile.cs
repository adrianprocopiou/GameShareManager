using AutoMapper;
using GameShareManager.Application.Filters.DataTables;
using GameShareManager.Application.ViewModels;
using GameShareManager.Domain.Entities;
using GameShareManager.Domain.Filters;

namespace GameShareManager.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Company, CompanyViewModel>();
            CreateMap<Friend, FriendViewModel>();
            CreateMap<Game, GameViewModel>();

            CreateMap<CompanyFilter, CompanyAppFilter>();
        }

        public override string ProfileName => "DomainToViewModelMapping";
    }
}