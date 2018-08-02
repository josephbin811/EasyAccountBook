using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyAccountBook.Models
{
    public class UserAccountModel: IdentityDbContext<ApplicationUser>
    {
        public UserAccountModel()
        : base("SkillTreeHomework", throwIfV1Schema: false)
        {
        }

        public static UserAccountModel Create()
        {
            return new UserAccountModel();
        }
    }
}