using System.Collections.Generic;
using AutoMapper;
using MovieProject.Authorization.Users;
using MovieProject.Entities;
using MovieProject.MovieDetails.Dto;

namespace MovieProject.Rates.Dto;

public class RateMapProfile: Profile
{
    public RateMapProfile()
    {
        CreateMap<CreateRateDto, Rate>().ReverseMap(); // sol source sağ destinaiton
        CreateMap<Rate, RateDto>().ReverseMap();
        CreateMap<Rate, MovieRateDto>().ReverseMap();
        CreateMap<CreateRateDto,RateDto>().ReverseMap();
    }
}