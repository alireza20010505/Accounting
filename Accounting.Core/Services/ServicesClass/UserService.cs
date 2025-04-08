using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;

namespace Accounting.Core.Services.Interfaces.ServicesClass;

public class UserService : IUserService
{
    private readonly AccountingContext _context;

    public UserService(AccountingContext context)
    {
        _context = context;
    }


    public long AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return user.Id;
    }

    public void DeleteUser(int userId)
    {
        var user = _context.Users.Find(userId);
        _context.Users.Remove(user);
        _context.SaveChanges();
    }

    public void UpdeteUser(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
        
    }

    public User GetUserById(int userId)
    {
        return _context.Users.FirstOrDefault(u => u.Id == userId);
        
    }

    public bool UserExists(int userId)
    {
        return _context.Users.Any(u => u.Id == userId);
    }

    public long GetUserIdByUsername(string username)
    {
  
        return _context.Users.Single(u => u.UserName == username).Id;
    }

    public User GetUserByAccountCode(string accountCode)
    {
        var user = _context.Users.FirstOrDefault(u => u.AccountCode == accountCode);
        return user;
    }
}