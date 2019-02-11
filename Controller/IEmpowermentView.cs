using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEmpowerment.Model;
namespace WinFormEmpowerment.Controller
{// интерфейс для передачи данных между контроллером и формой
    public interface IEmpowermentView
    {
        //Инициализация контроллера
        void SetController(EmpowermentController controller);
        //очистка таблицы
        void ClearGrid();
        //Добавление в таблицу
        void AddEmpowermentToGrid(Empowerment empowerment);
        //Обновление таблицы
        void UpdateGridWithChangedEmpowerment(Empowerment empowerment);
        //Удаление из таблицы
        void RemoveEmpowermentFromGrid(Empowerment empowerment);
        //Получение идентификатора выбраного элемента таблицы
        string GetIdOfSelectedEmpowermentInGrid();
        //Установка выбраного элемента таблицы
        void SetSelectedEmpowermentInGrid(Empowerment empowerment);

        //Доступ к данным класса Empowerment
        int ID { get; set; }
        Contract Contract { get; set; }
        DateTime DateOfIssue { get; set; }
        DateTime DocumentDate { get; set; }
        string DocumentNumber { get; set; }
        IList InventoryItems { get; set; }
        Organisation Organisation { get; set; }
        Person Person { get; set; }
        DateTime ValidUntil { get; set; }
       // bool CanModifyID { set; }
    }
}
