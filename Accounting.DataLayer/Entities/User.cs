﻿using Accounting.DataLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; }

    public string AccountCode { get; set; }
    
    public string Address { get; set; }
    public string Password { get; set; }

    #region Relation

    public virtual List<UserRoles> UserRoles { get; set; }
    public virtual List<Transaction> Transactions { get; set; }

    #endregion
}