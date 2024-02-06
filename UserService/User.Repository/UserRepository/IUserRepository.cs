using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Model;

namespace Users.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUser();

        void AddUser(User user);
    }
}
