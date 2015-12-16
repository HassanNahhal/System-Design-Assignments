using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentSysDev4
{
    /// <summary>
    /// Here we use the Factory design pattern to create planes.  Each plane has a 
    /// model, we allow the use of a simple integer model number.  In a full system,
    /// planes would likely be picked from a list based on a database table.  
    /// </summary>
    public interface IPlane
    {

        //void method();
        string GetModel();

    }

    /// <summary>
    /// This class defines a plane which extends the IPlane interface; 
    /// other plane classes in this file have the same basic code,
    /// the different model numbers are specified for each one.  
    /// This makes it possible to add more individual properties unique
    /// to a model of plane.  
    /// </summary>
    class Boeing777300ER : IPlane
    {
        //public void Method() { }
        string model = "Boeing 777-300ER";
        public string GetModel()
        {
            return model;
        }

    }

    class Boeing777200LR : IPlane
    {
        
        string model = "Boeing 777-200LR";
        public string GetModel()
        {
            return model;
        }
    }

    class AirbusA330300 : IPlane
    {
       
        string model = "Airbus A330-300";
        public string GetModel()
        {
            return model;
        }
    }

    
    class Boeing7879 : IPlane
    {
        
        string model = "Boeing787-9";
        public string GetModel()
        {
            return model;
        }
    }

    
    class Boeing7878 : IPlane
    {
       
        string model = "Boeing787-8";
        public string GetModel()
        {
            return model;
        }
    }


    class EmbraerE175 : IPlane
    {
      
        string model = "EmbraerE175";
        public string GetModel()
        {
            return model;
        }
    }

    class BombardierCRJ705 : IPlane
    {
        
        string model = "Bombardier CRJ705";
        public string GetModel()
        {
            return model;
        }
    }

    class BombardierCRJ200 : IPlane
    {
      
        string model = "Bombardier CRJ200";
        public string GetModel()
        {
            return model;
        }
    }

    class BombardierQ400 : IPlane
    {
       
        string model = "Bombardier Q400";
        public string GetModel()
        {
            return model;
        }
    }

    
    class Boeing767300ER : IPlane
    {
      
        string model = "Boeing 767-300ER";
        public string GetModel()
        {
            return model;
        }
    }

     class AirbusA319100 : IPlane
    {
       
         string model = "Airbus A319-100";
        public string GetModel()
        {
            return model;
        }
    }

    /// <summary>
    /// This Creator class uses a FactoryMethod to determine what 
    /// type of plane object to set up.  
    /// </summary>
    public class PlaneCreator
    {
        public IPlane FactoryMethod(int modelNumber)
        {

            if (modelNumber == 1)
            {
                Boeing777300ER newPlane = new Boeing777300ER();
                return newPlane;

            }
            else if (modelNumber == 2)
            {                
                Boeing777200LR newPlane = new Boeing777200LR();
                return newPlane;
            }
            else if (modelNumber == 3)
            {

                AirbusA330300 newPlane = new AirbusA330300();
                return newPlane;
            }

            else if (modelNumber == 4)
            {
                Boeing7879 newPlane = new Boeing7879();
                return newPlane;

            }
            else if (modelNumber == 5)
            {
                Boeing7878 newPlane = new Boeing7878();
                return newPlane;
            }
            else if (modelNumber == 6)
            {

                EmbraerE175 newPlane = new EmbraerE175();
                return newPlane;
            }
            else if (modelNumber == 7)
            {

                BombardierCRJ705 newPlane = new BombardierCRJ705();
                return newPlane;
            }

            else if (modelNumber == 8)
            {
                BombardierCRJ200 newPlane = new BombardierCRJ200();
                return newPlane;

            }
            else if (modelNumber == 9)
            {
                BombardierQ400 newPlane = new BombardierQ400();
                return newPlane;
            }
            else if (modelNumber == 10)
            {

                Boeing767300ER newPlane = new Boeing767300ER();
                return newPlane;
            }
            else 
            {
                AirbusA319100 newPlane = new AirbusA319100();
                return newPlane;
            }
           

        }
    }
}