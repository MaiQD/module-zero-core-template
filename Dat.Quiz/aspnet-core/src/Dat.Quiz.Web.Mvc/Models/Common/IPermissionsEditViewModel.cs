using System.Collections.Generic;
using Dat.Quiz.Roles.Dto;

namespace Dat.Quiz.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}
