using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using WinFormEmpowerment.Controller;
using WinFormEmpowerment.Model;
namespace WindowsFormsApp1
{
    static class Program
    {
        static public EmpowermentView my;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Person pSome3 = new Person("Другой", "Иван", "Сергеевич", new Passport("АК", 123323, new DateTime(2017,5, 1), "Где то там"));
            Person pSome2 = new Person("Какойтович", "Сергей", "Дмитриевич", new Passport("АР", 123123, new DateTime(2008, 12, 3), "Где то там"));
            Person pSome1 = new Person("Белый", "Борис", "Борисович", new Passport("АН",123123, new DateTime(2007,02,24), "Где то там"));
            Organisation oSome1 = new Organisation("OOO \"Какието разработки\"");
            Organisation oSome2 = new Organisation("OАO \"Какието внедрения\"");
            
            my = new EmpowermentView();
            IList empowerment = new ArrayList();
            empowerment.Add(new Empowerment(
                                     new DateTime(2019, 2, 9)/*Когда выдано*/,
                                     new DateTime(2019, 2, DateTime.Now.Day+1) /*Действительна до*/,
                                     "232151"  /*№ Документа*/,
                                    new DateTime(2017, 5, 9) /*Дата документа*/,
                                    pSome1,
                                     oSome1,
                                     new Contract("12341"/*Договор*/),
                                     new ArrayList()/*Список ТМЦ*/
                            ));
            empowerment.Add(new Empowerment(
                                     new DateTime(2017, 5, 1)/*Когда выдано*/,
                                      new DateTime(2019, 2, DateTime.Now.Day) /*Действительна до*/,
                                     "423532"  /*№ Документа*/,
                                   new DateTime(2017, 5, 1) /*Дата документа*/,
                                    pSome1,
                                     oSome1,
                                     new Contract("12341"/*Договор*/),
                                     new ArrayList()/*Список ТМЦ*/
                            ));
            empowerment.Add(new Empowerment(
                                     new DateTime(2017, 5, 1)/*Когда выдано*/,
                                     new DateTime(2019, 2, DateTime.Now.Day + 2) /*Действительна до*/,
                                     "235213"  /*№ Документа*/,
                                   new DateTime(2017, 5, 1) /*Дата документа*/,
                                    pSome1,
                                     oSome1,
                                     new Contract("12341"/*Договор*/),
                                     new ArrayList()/*Список ТМЦ*/
                            ));

            foreach (Empowerment emp in empowerment)
                emp.InventoryItems.Add(new InventoryItem("Для ТМЦ №"+emp.ID.ToString(),"ПРоверка","Проверка","Проверка"));

            EmpowermentController empowermentController = new EmpowermentController(my, empowerment);
            empowermentController.LoadView();

            Application.Run(my);
        }
    }
}
