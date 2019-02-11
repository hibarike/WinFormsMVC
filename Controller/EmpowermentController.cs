using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormEmpowerment.Model;
namespace WinFormEmpowerment.Controller
{
    public class EmpowermentController
    {
        //Форма отображения
        IEmpowermentView _view;
        //Список элементов
        IList _empowermentItems;
        //Выбраный элемент
        Empowerment _selectedEmpowermentItem;
        public Empowerment SelectedEmpowermentItem { get => _selectedEmpowermentItem; set => _selectedEmpowermentItem = value; }
        public EmpowermentController(IEmpowermentView empowermentView, IList empowerment)
        {
            _view = empowermentView;
            _empowermentItems = empowerment;
            empowermentView.SetController(this);
        }
        
        public IList EmpowermentItems
        {
            get { return ArrayList.ReadOnly(_empowermentItems); }
        }

       
        //Получение данных из формы
        public void updateViewDetailValues(Empowerment empowerment)
        {
            _view.ID = empowerment.ID;
            _view.Contract = empowerment.Contract;
            _view.DateOfIssue = empowerment.DateOfIssue;
            _view.DocumentDate = empowerment.DocumentDate;
            _view.DocumentNumber = empowerment.DocumentNumber;
            _view.Organisation = empowerment.Organisation;
            _view.Person = empowerment.Person;
            _view.ValidUntil = empowerment.ValidUntil;
            _view.InventoryItems.Clear();
            foreach (InventoryItem inv in empowerment.InventoryItems)
                _view.InventoryItems.Add(inv);
        }
        //Добавление данных в форму
        public void updateEmpowermentItemWithViewValues(Empowerment empowerment)
        {

          //  empowerment.ID = _view.ID;
            empowerment.Contract = _view.Contract;
            empowerment.DateOfIssue = _view.DateOfIssue;
            empowerment.DocumentDate = _view.DocumentDate;
            empowerment.DocumentNumber = _view.DocumentNumber;
            
            empowerment.Organisation = _view.Organisation;
            empowerment.Person = _view.Person;
            empowerment.ValidUntil = _view.ValidUntil;
            empowerment.InventoryItems.Clear();
            foreach (InventoryItem inv in _view.InventoryItems)
                empowerment.InventoryItems.Add(inv);



        }

        //Загрузка формы
        public void LoadView()
        {
            _view.ClearGrid();
            foreach (Empowerment empowerments in _empowermentItems)
                _view.AddEmpowermentToGrid(empowerments);

            _view.SetSelectedEmpowermentInGrid((Empowerment)_empowermentItems[0]);

        }
        //Выбраный элемент изменился
        public void SelectedEmpowermentChanged(int selectedEmpovermentId)
        {
            foreach (Empowerment empowermentItem in this._empowermentItems)
            {
                if (empowermentItem.ID == selectedEmpovermentId)
                {
                    SelectedEmpowermentItem = empowermentItem;
                    //SelectedEmpowermentItem.InventoryItems.Clear();
                    //foreach (InventoryItem inv in empowermentItem.InventoryItems)
                    //    SelectedEmpowermentItem.InventoryItems.Add(inv);
                    _view.SetSelectedEmpowermentInGrid(empowermentItem);
                   // this._view.CanModifyID = false;
                    break;
                }
            }
        }
        public string CriticalValid()
        {
            string save ="";
            foreach(Empowerment emp in _empowermentItems)
                if(emp.ValidUntil.Year == DateTime.Now.Year)
                {
                    if (emp.ValidUntil.Month == DateTime.Now.Month)
                    {
                        if (emp.ValidUntil.Day == DateTime.Now.Day+1)
                        {
                            save+= "Действие доверености " + emp.DocumentNumber + " заканчивается завтра\n";
                        }
                        if (emp.ValidUntil.Day == DateTime.Now.Day )
                        {
                            save+= "Действие доверености " + emp.DocumentNumber + " заканчивается сегодня\n";
                        }
                    }
                }
            return save;
        }
        //Добавление элемента
        public void AddNewEmpowerment()
        {
            SelectedEmpowermentItem = new Empowerment(
                                      System.DateTime.Now/*Когда выдано*/,
                                      System.DateTime.Now /*Действительна до*/,
                                     ""  /*№ Документа*/,
                                    System.DateTime.Now /*Дата документа*/,
                                     new Person(
                                         "", /*Имя*/
                                         "",/*Фамилия*/
                                         "",/*Отчество*/
                                         new Passport(
                                             "",/*Серия*/
                                             0,/*Номер*/
                                             System.DateTime.Now,/*Когда выдан*/
                                             ""/*Кем выдан*/
                                             )
                                         ),
                                     new Organisation(
                                         ""/*Организация*/
                                         ),
                                     new Contract(
                                         ""/*Договор*/
                                         ),
                                     new ArrayList()/*Список ТМЦ*/


                                     );

            this.updateViewDetailValues(SelectedEmpowermentItem);
           // this._view.CanModifyID = true;
        }
        //Удаление элемента
        public void RemoveEmpowerment()
        {
            int id = Convert.ToInt32( this._view.GetIdOfSelectedEmpowermentInGrid());
            Empowerment inventoryItemToRemove = null;

            if (id != 0)
            {
                foreach (Empowerment inventoryItem in this._empowermentItems)
                {
                    if (inventoryItem.ID == id)
                    {
                        inventoryItemToRemove = inventoryItem;
                        break;
                    }
                }

                if (inventoryItemToRemove != null)
                {
                    int newSelectedIndex = this._empowermentItems.IndexOf(inventoryItemToRemove);
                    this._empowermentItems.Remove(inventoryItemToRemove);
                    this._view.RemoveEmpowermentFromGrid(inventoryItemToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < _empowermentItems.Count)
                    {
                        this._view.SetSelectedEmpowermentInGrid((Empowerment)_empowermentItems[newSelectedIndex]);
                    }
                }
            }
        }
        //Сохранение изменений
        public void Save()
        {
            if (_view.ID != 0)
            {
                updateEmpowermentItemWithViewValues(SelectedEmpowermentItem);



                if (!this._empowermentItems.Contains(SelectedEmpowermentItem))
                {

                    //bool checkId = false;

                    //foreach (Empowerment empowerment in this._empowermentItems)
                    //{
                    //    if (empowerment.ID == _view.ID+1)
                    //    {
                    //        checkId = true;
                    //        break;
                    //    }

                    //}
                    //if (!checkId)
                    //{
                        // Добавить новую ТМЦ
                        this._empowermentItems.Add(SelectedEmpowermentItem);
                        this._view.AddEmpowermentToGrid(SelectedEmpowermentItem);
                    //}

                }
                else
                {
                    // Обновить существующее
                    this._view.UpdateGridWithChangedEmpowerment(SelectedEmpowermentItem);
                }
                _view.SetSelectedEmpowermentInGrid(SelectedEmpowermentItem);
               // this._view.CanModifyID = false;
            }
        }

    }
}
