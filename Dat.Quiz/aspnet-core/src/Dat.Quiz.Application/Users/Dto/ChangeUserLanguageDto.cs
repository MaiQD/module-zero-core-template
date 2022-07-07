using System.ComponentModel.DataAnnotations;

namespace Dat.Quiz.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
