using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Application.User
{
    public interface IUserApplication
    {
        Task<IEnumerable<Model.User>> GetAllUser();
    }
}
