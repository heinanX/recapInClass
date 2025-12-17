using recap1217.Core.Interfaces;
using recap1217.Data.Interfaces;
using recap1217.Data.Models;

namespace recap1217.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public bool Login(string username, string password)
        {

            User user = _userRepo.Login(username, password);
            // Here would be the business logic for login such as validation, logging, etc.
            // a rule like max 3 login attempts can be implemented here

            if (user.Username == username && user.Password == password)
                return true;
            else
                return false;
        }
    }
}
