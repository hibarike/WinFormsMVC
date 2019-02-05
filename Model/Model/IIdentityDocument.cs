using System;

namespace WinFormEmpowerment.Model
{
    public interface IIdentityDocument
    {
        int Number { get; set; }
        string Serial { get; set; }
        DateTime WhenGet { get; set; }
        string WhoGive { get; set; }
       
    }
}