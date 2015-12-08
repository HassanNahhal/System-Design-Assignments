using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSysDev4
{
    //class FactoryMethod
    //{
    public interface IEmployee
    {

        //void method();
        string GetTitle();

    }

    class AdministratorEmployee : IEmployee
    {
        //public void Method() { }
        string title = "Administrator";
        public string GetTitle()
        {
            return title;
        }

    }

    class ManagerEmployee : IEmployee
    {
        //public void Method() { }
        string title = "Manager";
        public string GetTitle()
        {
            return title;
        }
    }

    class ClerkEmployee : IEmployee
    {
        //public void Method() { }
        string title = "Clerk";
        public string GetTitle()
        {
            return title;
        }
    }

    public class Creator
    {
        public IEmployee FactoryMethod(int level)
        {

            if (level == 1)
            {
                AdministratorEmployee newEmployee = new AdministratorEmployee();
                return newEmployee;

            }
            else if (level == 2)
            {
                ManagerEmployee newEmployee = new ManagerEmployee();
                return newEmployee;
            }
            else
            {

                ClerkEmployee newEmployee = new ClerkEmployee();
                return newEmployee;
            }
            //return newAvocado;

        }
    }
}
//}
