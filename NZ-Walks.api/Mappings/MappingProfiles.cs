using AutoMapper;
using NZ_Walks.api.Models.Domain;
using NZ_Walks.api.Models.DTO;

namespace NZ_Walks.api.Mappings
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Region, RegionResponse>().ReverseMap();
            CreateMap<Region, RegionAddRequest>().ReverseMap();
            CreateMap<Region, RegionResponse>().ReverseMap();


        }
    }
}
