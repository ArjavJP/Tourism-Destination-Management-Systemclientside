using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BAL
{
    public class UserOperations
    {
        private readonly UserRepository _userRepository;

        public UserOperations()
        {
            _userRepository = new UserRepository();
        }

        public DataTable Login(string email, string password)
        {
            return _userRepository.Login(email, password);
        }

        public int UserInsert(UserMst user)
        {
            return _userRepository.UserInsert(user);
        }
    }
}
