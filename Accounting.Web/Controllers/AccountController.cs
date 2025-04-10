using Accounting.Core.DTOs;
using Accounting.Core.Services.Interfaces;
using Accounting.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Web.Controllers;

public class AccountController : Controller
{
    private readonly IUserService _userService;

    public AccountController(IUserService userService)
    {
        _userService = userService;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    
    //TODO Login
    public IActionResult Login(AccountViewModel.LoginViewModel login)
    {
        if (!ModelState.IsValid)
        {
            return View(login);
        }

        if (!_userService.UserExists(login.UserName))
        {
            ModelState.AddModelError("UserName", "نام کاربری معیتبر نمیباشد");
            return View(login);
        }
        return View();
    }

    #region Register

     
    [Route("Register")]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [Route("Register")]
    public IActionResult Register(AccountViewModel.RegisterViewModel register)
    {
        if (!ModelState.IsValid)
        {
            return View(register);
        }
            

        if (_userService.UserExists(register.UserName))
        {
            ModelState.AddModelError("UserName", "نام کاربری تکراری میباشد");
            return View(register);
        }
        if (_userService.ExistCode(register.AccountCode))
        {
            ModelState.AddModelError("AccountCode", "شماره حساب/کارت انتخابی تکراری میباشد");
            return View(register);
        }
        

        User user = new User()
        {
            UserName = register.UserName,
            AccountCode = register.AccountCode,
            Address = register.Address,
            CreateDate = DateTime.Now,
            Password = register.Password,
            UpdateDate = null,
            IsDelete = false
            

        };
        _userService.AddUser(user);
        return View("SuccssesRegister",user);
    }

    #endregion
   
}