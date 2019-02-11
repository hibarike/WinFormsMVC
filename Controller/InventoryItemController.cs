using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEmpowerment.Model;

namespace WinFormEmpowerment.Controller
{
    public class InventoryItemController
    {
        //Интерфейс отображения
        IInventoryItemView _view;
        //Список елементов
        IList _inventoryItems;
        //Выбраный елемент
        InventoryItem _selectedInventoryItem;

        //Конструктор
        public InventoryItemController(IInventoryItemView inventoryItemView, IList inventoryItems)
        {
            _view = inventoryItemView;
            _inventoryItems = inventoryItems;
            inventoryItemView.SetController(this);
        }

        
        public IList InventoryItems
        {
            get { return ArrayList.ReadOnly(_inventoryItems); }
        }

        //Добавление данных в форму
        private void updateViewDetailValues(InventoryItem inventoryItem)
        {
            _view.ID = inventoryItem.ID;
            _view.NameII = inventoryItem.Name;
            _view.Unit = inventoryItem.Unit;
            _view.NumberOfItemString = inventoryItem.NumberOfItemString;

        }
        //ПОлучение данных из формы
        private void updateInventoryItemWithViewValues(InventoryItem inventoryItem)
        {
            
                    inventoryItem.ID = _view.ID;
                    inventoryItem.Name = _view.NameII;
                    inventoryItem.Unit = _view.Unit;
                    inventoryItem.NumberOfItemString = _view.NumberOfItemString;
                
            
            
           
        }

        //Загрузка формы
        public void LoadView()
        {
            _view.ClearGrid();
            foreach (InventoryItem inventoryItem in _inventoryItems)
                _view.AddInventoryItemToGrid(inventoryItem);

            _view.SetSelectedInventoryItemInGrid((InventoryItem)_inventoryItems[0]);

        }

        //Выбраный элемент изменился
        public void SelectedInventoryItemChanged(string selectedInventoryItemId)
        {
            foreach (InventoryItem inventoryItem in this._inventoryItems)
            {
                if (inventoryItem.ID == selectedInventoryItemId)
                {
                    _selectedInventoryItem = inventoryItem;
                    updateViewDetailValues(inventoryItem);
                    _view.SetSelectedInventoryItemInGrid(inventoryItem);
                    this._view.CanModifyID = false;
                    break;
                }
            }
        }
        //Добавление элемента
        public void AddNewInventoryItem()
        {
            _selectedInventoryItem = new InventoryItem(""/*№ п\п*/,
                                     "" /*Наименование*/,
                                     ""  /*ед. измерения*/,
                                     "" /*колчество прописью*/
                                     );

            this.updateViewDetailValues(_selectedInventoryItem);
            this._view.CanModifyID = true;
        }

        //Удаление элемента
        public void RemoveInventoryItem()
        {
            string id = this._view.GetIdOfSelectedInventoryItemInGrid();
            InventoryItem inventoryItemToRemove = null;

            if (id != "")
            {
                foreach (InventoryItem inventoryItem in this._inventoryItems)
                {
                    if (inventoryItem.ID == id)
                    {
                        inventoryItemToRemove = inventoryItem;
                        break;
                    }
                }

                if (inventoryItemToRemove != null)
                {
                    int newSelectedIndex = this._inventoryItems.IndexOf(inventoryItemToRemove);
                    this._inventoryItems.Remove(inventoryItemToRemove);
                    this._view.RemoveInventoryItemFromGrid(inventoryItemToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < _inventoryItems.Count)
                    {
                        this._view.SetSelectedInventoryItemInGrid((InventoryItem)_inventoryItems[newSelectedIndex]);
                    }
                }
            }
        }

        //Сохранение изменений
        public void Save()
        {
            if (_view.ID != "")
            {
                updateInventoryItemWithViewValues(_selectedInventoryItem);

                

                if (!this._inventoryItems.Contains(_selectedInventoryItem) )
                {

                    bool checkId = false;

                    foreach (InventoryItem inventory in this._inventoryItems)
                    {
                        if (inventory.ID == _view.ID)
                        {
                            checkId = true;
                            break;
                        }

                    }
                    if (!checkId)
                    {
                        // Добавить новую ТМЦ
                        this._inventoryItems.Add(_selectedInventoryItem);
                        this._view.AddInventoryItemToGrid(_selectedInventoryItem);
                    }
                    
                }
                else
                {
                    // Обновить существующее
                    this._view.UpdateGridWithChangedInventoryItem(_selectedInventoryItem);
                }
                _view.SetSelectedInventoryItemInGrid(_selectedInventoryItem);
                this._view.CanModifyID = false;
            }
        }

    }
}
