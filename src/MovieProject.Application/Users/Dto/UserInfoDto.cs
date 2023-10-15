using Abp.Application.Services.Dto;

namespace MovieProject.Users.Dto;

public class UserInfoDto:EntityDto
{
    public string UserName { get; set; }
}