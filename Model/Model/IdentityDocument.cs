using System;
using System.Text.RegularExpressions;

namespace WinFormEmpowerment.Model
{
   
    //пасспорт
    public class Passport : IIdentityDocument
    {
        private string _serial;//серия
        public string Serial
        {
            get => _serial;
            set
            {
                if (value.Length > 2)
                    Console.WriteLine("Ошибка! Серия пасспорта должна быть меньше 3 символов!");
                else
                    _serial = value;
            }
        }

       

        private int _number;//номер
        public int Number
        {
            get => _number;
            set
            {
                if (value > 999999)
                    Console.WriteLine("Ошибка! Серия пасспорта должна быть 6 цифр!");
                else
                    _number = value;
            }
        }

       

        private System.DateTime _whenGet;//когда выдан
        public DateTime WhenGet
        {
            get => _whenGet;
            set => _whenGet = value;
        }
        

        private string _whoGive;//кем выдан

      

        public string WhoGive
        {
            get => _whoGive;
            set => _whoGive = value;
        }

        public Passport(string serial, int number, DateTime whenGet, string whoGive)
        {
            _serial = serial;
            _number = number;
            _whenGet = whenGet;
            _whoGive = whoGive;
        }


    }
}