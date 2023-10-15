using Abp.Application.Services.Dto;

namespace MovieProject.Rates.Dto;

public class MovieRateDto:EntityDto
{
    public string Comment{ get; set; }
    public int Rating { get; set; }
}