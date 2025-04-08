using Accounting.DataLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    public class Role: BaseEntity
    {
        public Role()
        {

        }

        
        public string RoleTitle { get; set; }

        #region Relation
        public List<UserRoles> UserRoles { get; set; }

        #endregion
    }
}
