using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Presentation.Authentication;
using Presentation.Models.Requests;

namespace Presentation.Controllers
{
    [Route("users")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View(new CreateUserRequest());
        }

        [HttpPost("add")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CreateUserRequest createUserRequest)
        {
            if (!ModelState.IsValid)
            {
                return View(createUserRequest);
            }

            try
            {
                await _userService.CreateUserAsync(createUserRequest.Username, createUserRequest.Password);
                return RedirectToAction("Index", "Employee");
            }
            catch (InvalidOperationException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(createUserRequest);
            }
        }

        [HttpGet("protected"), BasicAuthorization]
        public IActionResult Protected()
        {
            return Ok();
        }
    }
}