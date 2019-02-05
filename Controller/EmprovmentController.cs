using Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public class EmprovmentController
    {
        List<Empowerment> emprovments;
        void AddEmpowerment(string setEmprovments)
        {
            String[] elements = Regex.Split(setEmprovments, @"\,");
            emprovments.Add(new Empowerment(
                Convert.ToDateTime( elements[0]),
                Convert.ToDateTime( elements[1]),
                Convert.ToInt32( elements[2]),
                Convert.ToDateTime(elements[3]),
                new Person( elements[4]),
               new Organisation( elements[5]),
               new Contract( elements[6])
                ));
            
        }
        void RemoveEmpowerment()
    }
}
