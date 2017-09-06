using Abp.Authorization;
using PhotoShare.Authorization.Roles;
using PhotoShare.Authorization.Users;

namespace PhotoShare.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
