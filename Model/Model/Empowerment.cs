using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WinFormEmpowerment.Model
{//Довереность
    public class Empowerment
    {
        //атрибуты документа
        private static int count = 0;
        private int iD;
        public  int ID { get => iD; set => iD = value; }
        
        private DateTime _dateOfIssue;//Дата выдачи
        public DateTime DateOfIssue
        {
            get => _dateOfIssue;
            set
            {
                if (value > System.DateTime.Now)
                    Console.WriteLine("Ошибка! Невозможно поставить дату больше текущей!");
                else
                _dateOfIssue = value;
            }
        }
       

        private DateTime _validUntil;//Дата завершения
        public DateTime ValidUntil
        {
            get => _validUntil;
            set => _validUntil = value;
        }
       
        private string _documentNumber;//Номер документа
        public string DocumentNumber
        {
            get => _documentNumber;
            set => _documentNumber = value;
        }
       

        private DateTime _documentDate;//Дата документа
        public DateTime DocumentDate
        {
            get => _documentDate;
            set => _documentDate = value;
        }
        


        private Person _person;//Кому выдан
        public Person Person
        {
            get => _person;
            set => _person = value;
        }

        
        private Organisation _organisation;//Организация
        public Organisation Organisation
        {
            get => _organisation;
            set => _organisation = value;
        }
       

        private Contract _contract;//Договор
        public Contract Contract
        {
            get => _contract;
            set => _contract = value;
        }
        
        private IList _inventoryItems;//ТМЦ

        public Empowerment(DateTime dateOfIssue, DateTime validUntil, string documentNumber, DateTime documentDate, Person person, Organisation organisation, Contract contract, IList inventoryItems)
        {
            _dateOfIssue = dateOfIssue;
            _validUntil = validUntil;
            _documentNumber = documentNumber;
            _documentDate = documentDate;
            _person = person;
            _organisation = organisation;
            _contract = contract;
            _inventoryItems = inventoryItems;
            

            count++;
            ID = count;
        }

         ~Empowerment()
        {
            
            count--;
        }
        public IList InventoryItems
        {
            get => _inventoryItems;
            set => _inventoryItems = value;
        }
        
    }
}
