using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using zombie.Data.DTOs;
using zombie.Models;

namespace zombie.Profiles;

public class RankingProfile : Profile
{
    public RankingProfile()
    {
        CreateMap<CreateRankingDTO, Ranking>();
        CreateMap<Ranking, ReadRankingDTO>();
    }
}