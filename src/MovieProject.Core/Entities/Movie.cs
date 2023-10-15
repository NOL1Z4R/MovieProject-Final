using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using EmptyFiles;
using MovieProject.Authorization.Users;
using MovieProject.MovieDetails.Dto;

namespace MovieProject.Entities;

public class Movie:FullAuditedEntity
{
     // public long UserId { get; set; }
     public string Name { get; set; }
     // public long RateId { get; set; }
     public int Rating { get; set; }
     public string Description { get; set; }
     public Categories Category { get; set; }
     
     public ICollection<Rate> Rates {get; set; }
     // [ForeignKey(nameof(RateId))] 
     // public Rate Rate { get; set; }
}