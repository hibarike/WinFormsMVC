namespace WinFormEmpowerment.Model
{
    public class InventoryItem
    {
       // int number;//порядковый номер
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

        public InventoryItem(string name, string unit, string numberOfItemString, int numberOfItem)
        {
            _name = name;
            _unit = unit;
            _numberOfItemString = numberOfItemString;
            _numberOfItem = numberOfItem;
        }

    }
}