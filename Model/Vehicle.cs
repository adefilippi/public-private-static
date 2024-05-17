using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicPrivateStatic.Model
{
    public class Vehicle
    {
        /*****************************************************
        *  STEP 6 - Static - propriétés 
        *****************************************************/
        public static string typeVehicle = "VEHICLE";

        /*****************************************************
        *  STEP 8 - Const
        *****************************************************/
        public const string constTypeVehicle = "VEHICLE";


        protected int numberOfWheels;
        protected string brand;

        /*****************************************************
        *  STEP 3 - Accès aux propriétés publiques du parent
        *****************************************************/
        public string model;


        /*****************************************************
        *  STEP 2  - Constructeurs
        *****************************************************/
        public Vehicle(string _brand, string _model, int _numberOfWheels)
        {
            brand = _brand;
            model = _model;
            numberOfWheels = _numberOfWheels;
        }


        /*****************************************************
        *  STEP 4 - Accès aux propriétés protected du parent depuis une fonction public du parent
        *****************************************************/
        public string GetBrand()
        {
            // La propriété brand étant protected, elle est accessible dans ma classe Vehicle et dans les classes enfant (Auto et Moto)
            // Mais pas a l'extérieur de ces classes. 
            return brand;
        }

        public void SetBrand(string _brand)
        {
            if(_brand == "Audi")
            {

            }
        }

        /*****************************************************
        *  STEP 5 - Accès aux propriétés protected du parent depuis une fonction public des enfants
        *****************************************************/
        protected string GetVehicleInformations()
        {
            return $"Brand : {brand} - Model : {model} - Number of wheels : {numberOfWheels}";
        }

        /*****************************************************
        *  STEP 7 - Static - fonctions
        *****************************************************/
        public static string TypeVehicle()
        {
            return "Vehicle - function";
        }
    }
}
