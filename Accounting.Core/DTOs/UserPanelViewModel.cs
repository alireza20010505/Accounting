namespace Accounting.Core.DTOs;

public class InformationUserViewModel
{
    public string UserName { get; set; }

    public DateTime CreateDate { get; set; }

    public string AccountCode { get; set; }

    public string Address { get; set; }

    public long Balance { get; set; } = 0;
}
