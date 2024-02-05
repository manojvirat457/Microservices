using Microsoft.AspNetCore.Mvc;
using Users.Application.User;
using Users.Model;
using Users.Repository.AddressRepository;
using Users.Repository.UserRepository;

namespace Users.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<UserController> _logger;
        private readonly IUserRepository _userApplication;
        private readonly IAddressRepository _addressRepository;

        public UserController(ILogger<UserController> logger, IUserRepository userApplication, IAddressRepository addressRepository)
        {
            _logger = logger;
            _userApplication = userApplication;
            _addressRepository = addressRepository;
        }

        [HttpGet(Name = "list")]
        public IEnumerable<User> GetAll()
        {
            return _userApplication.GetAllUser().Result;
        }

        public IEnumerable<Address> GetAllAddress()
        {
            return _addressRepository.GetAllAddress().Result;
        }
    }
}
