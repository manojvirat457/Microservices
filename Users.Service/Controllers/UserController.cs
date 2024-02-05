using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        [Route("/GetAll")]
        public List<User> GetAll()
        {
            return _userApplication.GetAllUser().Result;
        }

        [HttpGet]
        [Route("/GetAllAddress")]
        public List<Address> GetAllAddress()
        {
            return _addressRepository.GetAllAddress().Result;
        }

        [HttpPost]
        [Route("/CreateAddress")]
        public string CreateAddress([FromBody]Address address)
        {
            _addressRepository.CreateAddress(address);
            return "Address Saved";
        }

        [HttpPost]
        [Route("/CreateUser")]
        public string CreateUser([FromBody] User user)
        {
            _userApplication.AddUser(user);
            return "User Saved";
        }
    }
}
