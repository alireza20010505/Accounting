using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Entities.Base
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        public DateTime? UpdateDate { get; set; }= DateTime.UtcNow;

        public bool IsDelete { get; set; }= false;
    }
        
    public class BaseEntity : BaseEntity<long>;

}
