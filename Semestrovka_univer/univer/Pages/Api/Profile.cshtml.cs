using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using univer.Models.Mapper;
using univer.Services;

namespace univer.Pages.Api
{
    [ServiceFilter(typeof(AuthorizeFilter))]
        public class Profile : PageModel
        {
            private AuthService authService;
            public Profile(AuthService authService)
            {
                this.authService = authService;
            }

            public async Task<JsonResult> OnGet()
            {
                var userId = long.Parse(HttpContext.Items["userId"].ToString());
                var user = await authService.GetUserById(userId);
                var profileResp = UserEntityMapper.MapUserToProfileResponse(user);
                return new JsonResult(profileResp);
            }
        }
}
