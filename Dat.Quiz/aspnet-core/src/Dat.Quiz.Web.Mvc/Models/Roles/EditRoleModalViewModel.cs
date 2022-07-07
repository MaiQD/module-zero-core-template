using Abp.AutoMapper;
using Dat.Quiz.Roles.Dto;
using Dat.Quiz.Web.Models.Common;

namespace Dat.Quiz.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}

