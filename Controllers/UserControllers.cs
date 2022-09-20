using System;

public class Class1()
{
   [Route("api/[controller]")]
   [ApiController]

   public class UserController : ControllerBase
   {
    private UserRepository _userRepository { get; set; }
    public UserController(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {

        return Ok(_userRepository.GetAllUsers()); // retorna el 200 que es el ok y la tista de fake users.
    }

    [HttpGet]
    [Route("GetOne/{Id}")]

    public IActionResult GetOneById(int Id)
    {
        List<User> usersToReturn = _userRepository.GetAllUsers().Where(x => x.Id == Id).ToList();
        if (usersToReturn.Count > 0)
            return Ok(usersToReturn);

        return NotFound("Usuario inexistente");

    }

   }
}

	

