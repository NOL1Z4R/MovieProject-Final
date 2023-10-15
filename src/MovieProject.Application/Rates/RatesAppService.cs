using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieProject.Authorization.Users;
using MovieProject.Entities;
using MovieProject.Rates.Dto;

namespace MovieProject.Rates;

[AbpAuthorize]
[Route("/api/rate")]
public class RatesAppService: MovieProjectAppServiceBase
{
    private readonly IRepository<Rate> _rateRepository;

    public RatesAppService(IRepository<Rate> rateRepository
    )
    {
        _rateRepository = rateRepository;
    }

    [HttpPost]
    public async Task<RateDto> RateMovie(CreateRateDto input)
    {
        var sessionUserId = AbpSession.GetUserId();
        var rate = ObjectMapper.Map<Rate>(input);
        rate.UserId = sessionUserId;
        await _rateRepository.InsertAsync(rate);
        await CurrentUnitOfWork.SaveChangesAsync();
        var rateDto = ObjectMapper.Map<RateDto>(rate);
        return rateDto;
    }

    [HttpGet]
    public async Task<List<RateDto>> GetAllRateMovie()
    {
        
        var rates = _rateRepository.GetAll().Include(r=>r.User);
        var rateDtos = ObjectMapper.Map<List<RateDto>>(rates);
        return rateDtos;
    }
}