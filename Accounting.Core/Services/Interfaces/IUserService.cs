using Accounting.Core.DTOs;
using Accounting.DataLayer.Entities;

namespace Accounting.Core.Services.Interfaces;

public interface IUserService
{
    #region User

      long AddUser(User user);
     
     void DeleteUser(int userId);
     
     void UpdeteUser(User user);
     User GetUserById(int userId);
     
     bool ExistCode(string code);
     bool UserExists(int userId);
     bool UserExists(string userName);
     long GetUserIdByUsername(string username);
     User GetUserByAccountCode(string accountCode);
     InformationUserViewModel GetUserInformation(int userId);

     #endregion
}