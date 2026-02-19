
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserService _userService;

    public AuthController(UserService userService)
    {
        _userService = userService;
    }

    // UC1: Register User
    [HttpPost("register")]
    public IActionResult Register(RegisterDto dto)
    {
        var user = _userService.Register(dto);

        return Ok(new
        {
            status = 200,
            message = "User registered successfully",
            data = user
        });
    }
   
}
