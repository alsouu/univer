using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using univer.Libs.Filters;
using univer.Models.DTO;
using univer.Models.Entities;
using univer.Models.Mapper;
using univer.Services;

namespace univer.Pages
{
    [ServiceFilter(typeof(OnlyAuthorized))]
    public class ProfileModel : PageModel
    {
        public ProfileResponse ProfileResponse { get; set; }
        [BindProperty]
        public EditProfileDto Input { get; set; }

        private AuthService authService;
        private UserService _userService;

        public void Profile(AuthService authService, UserService userService)
        {
            this.authService = authService;
            _userService = userService;
        }

        public async Task OnGet()
        {
            Input = new EditProfileDto();

            var userId = HttpContext.Items["userId"].ToString();
            var user = await authService.GetUserById(long.Parse(userId));
            ProfileResponse = UserEntityMapper.MapUserToProfileResponse(user);
            Page();
        }

        public async Task OnPost()
        {
            var userId = HttpContext.Items["userId"].ToString();
            var user = await authService.GetUserById(long.Parse(userId));

            await _userService.EditProfile(user, Input);
            ProfileResponse = UserEntityMapper.MapUserToProfileResponse(user);
            Redirect("Index");
        }
    }
}
