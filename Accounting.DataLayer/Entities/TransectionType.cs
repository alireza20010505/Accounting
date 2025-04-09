using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting.DataLayer.Entities;

public class TransectionType
{
    [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int TypeId { get; set; }
    
    public string TypeName { get; set; }


    #region Relation

    public virtual List<Transaction> Transactions { get; set; }

    #endregion
}