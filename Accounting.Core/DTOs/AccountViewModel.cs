using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Accounting.Core.DTOs;

public class AccountViewModel
{
    #region Register

    public class RegisterViewModel
    {
        [Required (ErrorMessage = "ورود نام کاربری الزامیست")]
        [MaxLength(100,ErrorMessage = "نام کاربری طولانی است")]
        [MinLength(5,ErrorMessage = "نام کاربری کوتاه است")]
        public string UserName { get; set; }
        
        [Required (ErrorMessage = "ورود رمز عبور الزامیست")]
        [MinLength(5,ErrorMessage = "کلمه عبور کوتاه است")]
        [MaxLength(100,ErrorMessage = "کلمه عبور طولانی است")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage = "کلمه عبور با تکرار آن مغایرت دارد")]
        public string RePassword { get; set; }
        
        [MinLength(10,ErrorMessage = "شماره حساب/کارت معتبر نیست")]
        [MaxLength(16,ErrorMessage = "شماره حساب/کارت معتبر نیست")]
        [Required(ErrorMessage = "ورود شماره حساب/کارت الزامیست")]
        public string AccountCode { get; set; }
    }

    #endregion

    #region Login

    public class LoginViewModel
    {
        [Required(ErrorMessage = "نام کاربری نمی تواند خالی باشد")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "وارد کردن کلمه عبور الزامیست")]
        public string Password { get; set; }

        public bool RemmemberMe { get; set; }
    }

    #endregion
}