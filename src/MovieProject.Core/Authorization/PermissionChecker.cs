using Abp.Authorization;
using MovieProject.Authorization.Roles;
using MovieProject.Authorization.Users;

namespace MovieProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
