using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MovieProject.Entities;
using MovieProject.Rates.Dto;

namespace MovieProject.MovieDetails.Dto;

public class ShowMovieDto:EntityDto
{
    public string Name { get; set; }
    public int Rating { get; set; }
    public string Description { get; set; }
    // public Categories Category { get; set; }
    public ICollection<MovieRateDto> Rates { get; set; }
}