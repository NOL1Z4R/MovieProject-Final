using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieProject.Authorization.Users;
using MovieProject.Entities;
using MovieProject.MovieDetails.Dto;
using MovieProject.Rates.Dto;
using MovieProject.Users.Dto;

namespace MovieProject.MovieDetails;

    [ApiController]
    [Route("/api/MovieDetail")]
public class MovieDetailsAppService:MovieProjectAppServiceBase,IDomainService
{
    private readonly IRepository<Movie> _movieRepository;
    private readonly ISmtpEmailSender _smtpEmailSender;

    public MovieDetailsAppService(IRepository<Movie> movieRepository,ISmtpEmailSender smtpEmailSender)
    {
        _movieRepository = movieRepository;
        _smtpEmailSender = smtpEmailSender;
    }

    [HttpGet]
    public async Task<List<ShowMovieDto>> ShowMovie()
    {
        // var sessionId = AbpSession.GetUserId();
        var movies = _movieRepository.GetAll()
            .Include(m=>m.Rates)
            .ToList();
        var movieDtos = ObjectMapper.Map<List<ShowMovieDto>>(movies);
        
        return movieDtos;
    }
    
    
}