using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MovieProject.Authorization.Users;
using MovieProject.Entities;
using MovieProject.MovieDetails.Dto;
using MovieProject.Users.Dto;

namespace MovieProject.Rates.Dto;

public class RateDto : EntityDto
{
    public string Comment{ get; set; }
    public int Rating { get; set; }
    // public UserDto User { get; set; }
    public UserInfoDto User { get; set; }
    public MovieDto Movie { get; set; }
}