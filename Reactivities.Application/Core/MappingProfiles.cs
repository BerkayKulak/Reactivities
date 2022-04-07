using AutoMapper;
using Reactivities.Application.Activities;
using Reactivities.Domain;

namespace Reactivities.Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, Activity>();
            CreateMap<Activity, ActivityDto>();
        }
    }
}
