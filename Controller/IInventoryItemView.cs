using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEmpowerment.Model;

namespace WinFormEmpowerment.Controller
{// интерфейс для передачи данных между контроллером и формой
    public interface IInventoryItemView
    {   //Инициализация контроллера
        void SetController(InventoryItemController controller);
        //очистка таблицы
        void ClearGrid();
        //Добавление в таблицу
        void AddInventoryItemToGrid(InventoryItem inventoryItem);
        //Обновление данных в таблице
        void UpdateGridWithChangedInventoryItem(InventoryItem inventoryItem);
        //Удаление элемента из таблицы
        void RemoveInventoryItemFromGrid(InventoryItem inventoryItem);
        //Получение выбраного элемента таблицы
        string GetIdOfSelectedInventoryItemInGrid();
        //Удаление выбраного элемента таблицы
        void SetSelectedInventoryItemInGrid(InventoryItem inventoryItem);

        //Доступ к данным класа InventoryItem
        string NameII { get; set; }
        string ID { get; set; }
        string NumberOfItemString { get; set; }
        string Unit { get; set; }
        bool CanModifyID { set; }
    }
}
