
using AutoMapper;
using MoviesApp.Services.Dto;



namespace MoviesApp.ViewModels.Actor.AutoMapperProfiles
{
    public class ActorViewModelsProfile: Profile
    {
        public ActorViewModelsProfile()
        {
            CreateMap<ActorDto, InputActorViewModel>().ReverseMap();
            CreateMap<ActorDto, DeleteActorViewModel>();
            CreateMap<ActorDto, EditActorViewModel>().ReverseMap();
            CreateMap<ActorDto, ActorViewModel>();
        }
    }
}