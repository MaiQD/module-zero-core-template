using Abp.Authorization;
using Dat.Quiz.Authorization.Roles;
using Dat.Quiz.Authorization.Users;

namespace Dat.Quiz.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

