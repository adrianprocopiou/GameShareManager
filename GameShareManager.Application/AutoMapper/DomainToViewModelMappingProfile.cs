using AutoMapper;
using GameShareManager.Application.ViewModels;
using GameShareManager.Domain.Entities;

namespace GameShareManager.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Company, CompanyViewModel>();
            CreateMap<Friend, FriendViewModel>();
            CreateMap<Game, GameViewModel>();
        }

        public override string ProfileName => "DomainToViewModelMapping";
    }
}