using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentSysDev4
{
    public class Plane
    {
        private int id;
        private string model;
        private string manufacturer;
        private int field;

        public interface IPlane
        {

            //void method();
            string GetModel();

        }


        public Flight Flight
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void ViewPlane()
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePlane()
        {
            throw new System.NotImplementedException();
        }

        public void DeletePlane()
        {
            throw new System.NotImplementedException();
        }

        public void AddPlane(int modelNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}

