using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentSysDev4
{
    public class Brand
    {
        private string name;
      

        public string Name
        {
            get {return name;}
            set { name = value; }

        }

        public void AddBrand()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBrand()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBrand()
        {
            throw new System.NotImplementedException();
        }

        public void ViewBrand()
        {
            throw new System.NotImplementedException();
        }

        public void AddPlane()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Here we will take a modelNumber and a number of planes to add to a Brand.  
        /// Then we can use methods defined in the PlaneCreator class to add those 
        /// planes to the brand.  PlaneCreator will use the Factory method.  
        /// </summary>
        /// <param name="modelNumber"></param>
        /// <param name="numberToAdd"></param>
        public void AddPlanes(int modelNumber, int numberToAdd)
        {
            for (int x = 0; x < numberToAdd; x++)
            {                
                PlaneCreator myPlaneCreator = new PlaneCreator();
                IPlane ConcretePlane = myPlaneCreator.FactoryMethod(modelNumber);
                Console.WriteLine(this.name + " has plane: " + ConcretePlane.GetModel());
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
    }
}
