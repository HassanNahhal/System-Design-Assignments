using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSysDev4
{
    //class FactoryMethod
    //{
   // public interface IPlane
   // {

        //void method();
     //   string GetModel();

  //  }

    class JumobJet : Plane
    {
        //public void Method() { }
        string model = "Jumbo Jet";
        public string GetModel()
        {
            return model;
        }

    }

    class LuxuryJet : Plane
    {
        //public void Method() { }
        string model = "Luxury Jet";
        public string GetModel()
        {
            return model;
        }
    }

    class CharterPlane : Plane
    {
        //public void Method() { }
        string model = "Charter Plane";
        public string GetModel()
        {
            return model;
        }
    }

    /*public class PlaneCreator
    {
        public Plane FactoryMethod(int modelNumber)
        {

            if (modelNumber == 1)
            {
                 
                return newEmployee;

            }
            else if (modelNumber == 2)
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
    }*/
}