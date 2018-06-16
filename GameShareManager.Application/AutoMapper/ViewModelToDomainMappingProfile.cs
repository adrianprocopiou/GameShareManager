using AutoMapper;
using GameShareManager.Application.ViewModels;
using GameShareManager.Domain.Entities;

namespace GameShareManager.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CompanyViewModel, Company>();
            CreateMap<FriendViewModel, Friend>();
            CreateMap<GameViewModel, Game>();
        }

        public override string ProfileName => "ViewModelToDomainMapping";
    }
}