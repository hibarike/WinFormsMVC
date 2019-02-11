using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WinFormEmpowerment.Model
{
    public class StartItems
    {
        IList empowerments;
        IList persons;
        IList contracts;
        IList organisations;

        StartItems()
        {
            empowerments = new ArrayList();
            IList persons = new ArrayList();
            IList contracts = new ArrayList();
            IList organisations = new ArrayList();
        }
        public void AddPerson(string name, string surname, string patronymic, string serial, int number, DateTime whenGet, string whoGive) {
            persons.Add(new Person(name, surname, patronymic, new Passport(serial, number, whenGet, whoGive)));
        }
        public void AddContract(string contractId) {
            contracts.Add(new Contract(contractId));
        }
        public void AddOrganisation(string nameOrganisation) {
            organisations.Add(new Organisation(nameOrganisation));
        }
        public void AddEmpowerment(DateTime dateOfIssue, DateTime validUntil, string documentNumber, DateTime documentDate, Person person, Organisation organisation, Contract contract, IList inventoryItems) { }
        public void AddInventoryItemToEmpowerment() { }
        

    }
}
