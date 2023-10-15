using Abp.Application.Services.Dto;
using MovieProject.Rates.Dto;
using MovieProject.Users.Dto;

namespace MovieProject.MovieDetails.Dto;

public class MovieDto:EntityDto
{
    public string Name { get; set; }
}