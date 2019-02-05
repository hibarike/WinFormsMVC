using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace WinFormEmpowerment.Model
{
    public class Person
    {
        private string _name;//Имя
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private string _surname;//Фамилия
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        private string _patronymic;//Отчество
        public string Patronymic
        {
            get => _patronymic;
            set => _patronymic = value;
        }

        private IIdentityDocument _identityDocument;//Документ удостоверяющий личность
               
        public IIdentityDocument IdentityDocument
        {
            get => _identityDocument;
            set => _identityDocument = value;
        }

        public Person(string name, string surname, string patronymic, IIdentityDocument identityDocument)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
            _identityDocument = identityDocument;
        }


    }
}