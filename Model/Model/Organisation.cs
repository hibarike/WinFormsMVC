namespace WinFormEmpowerment.Model
{
    public class Organisation
    {
       private string _nameOrganisation; //Имя организации
         
        public string NameOrganisation
        {
            get => _nameOrganisation;
            set => _nameOrganisation = value;
        }

        public Organisation(string nameOrganisation)
        {
            _nameOrganisation = nameOrganisation;
        }
    }
}