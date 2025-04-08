using Accounting.DataLayer.Entities;

namespace Accounting.Core.Services.Interfaces;

public interface IUserService
{
    #region User

      long AddUser(User user);
     
     void DeleteUser(int userId);
     
     void UpdeteUser(User user);
     User GetUserById(int userId);
     
     bool UserExists(int userId);
     
     long GetUserIdByUsername(string username);
     User GetUserByAccountCode(string accountCode);

    #endregion
}