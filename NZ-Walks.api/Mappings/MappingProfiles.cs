using AutoMapper;
using NZ_Walks.api.Models.Domain;
using NZ_Walks.api.Models.DTO.DifficultyDTOs;
using NZ_Walks.api.Models.DTO.RegionDTOs;
using NZ_Walks.api.Models.DTO.WalkDTOs;

namespace NZ_Walks.api.Mappings
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Region, RegionResponse>().ReverseMap();
            CreateMap<Region, RegionAddRequest>().ReverseMap();
            CreateMap<Region, RegionResponse>().ReverseMap();

            CreateMap<Walk,WalkAddRequest>().ReverseMap();
            CreateMap<Walk, WalkResponse>().ReverseMap();
            CreateMap<Walk, WalkUpdateRequest>().ReverseMap();

            CreateMap<Difficulty,DifficultyResponse>().ReverseMap();
        }
    }
}
