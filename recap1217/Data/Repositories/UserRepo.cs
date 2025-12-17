using recap1217.Data.Interfaces;
using recap1217.Data.Models;

namespace recap1217.Data.Repositories
{
    public class UserRepo : IUserRepo
    {
        public User Login(string username, string password)
        {

            //Normally we point to a db, now we will just return a dummy user
            //only database logic should be here. the login, not the confirming if such user exists

            var user = new User();
            user.Username = "testUser";
            user.Password = "password123";

            return user;
        }
    }
}
