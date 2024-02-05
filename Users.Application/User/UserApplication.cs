//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Users.Repository.UserRepository;

//namespace Users.Application.User
//{
//    public class UserApplication : IUserRepository
//    {
//        private readonly UserRepository _userRepository;

//        public UserApplication(UserRepository userRepository) 
//        {
//            _userRepository = userRepository;    
//        }

//        public async Task<IEnumerable<Model.User>> GetAllUser()
//        {
//            return await _userRepository.GetAllUser();
//        }
//    }
//}
