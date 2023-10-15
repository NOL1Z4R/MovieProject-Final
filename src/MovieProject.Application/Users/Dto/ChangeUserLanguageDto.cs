using System.ComponentModel.DataAnnotations;

namespace MovieProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}