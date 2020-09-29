using System.Linq;
using AutoMapper;
using DateCore.API.Dtos;
using DateCore.API.Models;

namespace DateCore.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {

     public AutoMapperProfiles()
     {
        CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoURL, opt => 
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

        CreateMap<User, UserForDetailedDto>()
            .ForMember(dest => dest.PhotoURL, opt => 
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            
        CreateMap<Photo, PhotosForDetailedDto>();
     }

    }
}