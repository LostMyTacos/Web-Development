using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Infrastucture
{
    [HtmlTargetElement("td",Attributes = "identity-role")]
    public class RoleUsersTagHelper:TagHelper
    {
        private UserManager<ApplicationUser> _UserManager;
        private RoleManager<ApplicationRole> _RoleManager;

        public RoleUsersTagHelper(UserManager<ApplicationUser> userManager,RoleManager<ApplicationRole> roleManager)
        {
            _UserManager = userManager;
            _RoleManager = roleManager;
        }

        [HtmlAttributeName("identity-role")]
        public string Role { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            List<string> names = new List<string>();
            ApplicationRole role = await _RoleManager.FindByIdAsync(Role);

            if(role != null)
            {
                foreach (var user in _UserManager.Users)
                {
                    if(user != null && await _UserManager.IsInRoleAsync(user, role.Name))
                    {
                        names.Add(user.UserName);
                    }
                }
            }

            output.Content.SetContent(names.Count == 0 ? "No Users" : string.Join(", ", names));
        }
    }
}
