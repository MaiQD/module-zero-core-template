using System.Collections.Generic;
using Dat.Quiz.Roles.Dto;

namespace Dat.Quiz.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}

