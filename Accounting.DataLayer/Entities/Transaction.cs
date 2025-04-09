using Accounting.DataLayer.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities
{
    public class Transaction:BaseEntity
    {
        public Transaction()
        {
            
        }

        public int TransactionType { get; set; }

        public string Description { get; set; }

        public long Price { get; set; }

        public bool IsFinaly { get; set; } = false;

        #region Relation

        public User User { get; set; }
        public TransectionType TransectionType  { get; set; }

        #endregion




    }
}
