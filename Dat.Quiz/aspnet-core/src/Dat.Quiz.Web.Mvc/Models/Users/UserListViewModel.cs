using System.Collections.Generic;
using Dat.Quiz.Roles.Dto;

namespace Dat.Quiz.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}

