using System;

namespace WinFormEmpowerment.Model
{
    public interface IIdentityDocument
    {
        //интерфейс при наличии других Документов идентифицирующих личность
        int Number { get; set; }
        string Serial { get; set; }
        DateTime WhenGet { get; set; }
        string WhoGive { get; set; }
       
    }
}