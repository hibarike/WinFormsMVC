using System;

namespace WinFormEmpowerment.Model
{
    public class Contract
    {
        private string _contractId;       
        public string ContractId
        {
            get => _contractId;
            set
            {
                if (value.Length > 10)
                    Console.WriteLine("Ошибка! Номер договора должен быть меньше 11 символов!");
                else
                    _contractId = value;
            }
        }
        public Contract(string contractId)
        {
            _contractId = contractId;
        }
    }
}