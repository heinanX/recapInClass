using recap1217.Data.Models;

namespace recap1217.Data.Interfaces
{
    public interface IUserRepo
    {
        User Login(string username, string password);

    }
}
