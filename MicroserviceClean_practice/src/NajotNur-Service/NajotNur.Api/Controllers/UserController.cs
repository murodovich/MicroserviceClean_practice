using Microsoft.AspNetCore.Mvc;
using NajotNur.Infrastructure.Dtos;
using NajotNur.Infrastructure.Services.UserServices;

namespace NajotNur.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult UserGetAllAsync()
        {
            var result = _userService.GetAll();
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult UserCreateAsync(UserDto user)
        {
            var result = _userService.Create(user);
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult UserGetByIdAsync(int id)
        {
            var result = _userService.GetById(id);
            return Ok(result.Result);
        }
        [HttpPut]
        public IActionResult UserUpdateAsync(int id,UserDto user)
        {
            var result = _userService.Update(id, user);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult DeleteAsync(int id)
        {
            var result = _userService.Delete(id);
            return Ok(result.Result);
        }
    }
}
