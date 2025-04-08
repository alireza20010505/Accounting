using Accounting.DataLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    public class UserRoles : BaseEntity
    {
        

        public long UserId { get; set; }

        public long RoleId { get; set; }

        #region Relation

        public Role Role { get; set; }

        public User User { get; set; }

        #endregion
    }
}
