using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using MovieProject.Authorization.Users;

namespace MovieProject.Entities;

public class Rate: FullAuditedEntity
{
    public long UserId { get; set; }
    public int MovieId { get; set; }
    public string Comment{ get; set; }
    public int Rating { get; set; }

    [ForeignKey(nameof(UserId))] 
    public User User { get; set; }

    [ForeignKey(nameof(MovieId))] 
    public Movie Movie { get; set; }

}