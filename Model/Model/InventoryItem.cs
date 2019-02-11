namespace WinFormEmpowerment.Model
{
    public class InventoryItem
    {
        private string _id;//порядковый номер
        public string ID
        {
            get => _id;
            set => _id = value;
        }

        private string _name;//название ТМЦ
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        private string _unit;//единица измерения
        public string Unit
        {
            get => _unit;
            set => _unit = "("+value+")";
        }

        private string _numberOfItemString;//количество прописью
        public string NumberOfItemString
        {
            get => _numberOfItemString;
            set => _numberOfItemString = value;
        }

        private int _numberOfItem;//количество цифрой       
        public int NumberOfItem
        {
            get => _numberOfItem;
            set => _numberOfItem = value;
        }
        

        public InventoryItem(string number, string name, string unit, string numberOfItemString)
        {
            _id = number;
            _name = name;
            _unit = unit;
            _numberOfItemString = numberOfItemString;
            
        }

    }
}