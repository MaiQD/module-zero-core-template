using Abp.Application.Services.Dto;

namespace Dat.Quiz.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


