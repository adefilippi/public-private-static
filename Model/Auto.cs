using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicPrivateStatic.Model
{
    public class Auto : Vehicle // Héritage 
    {
        /*****************************************************
        *  STEP 0
        *****************************************************/

        // Bien que les propriétés numberOfWheels, model et brand ne soient pas explicitement définies ici, elles sont quand meme accessibles 
        // Vu que Auto hérite de la classe Vehicle
        // On peut imaginer les propriétés suivantes : 

        // private int numberOfWheels; 
        // private string brand;
        // public string model;

        // Elles sont définies en tant que private ici car le protected de la classe parent ne donne pas de visibilité a ces 
        // variables en dehors des classes enfant. 
        // Model étant public dans la classe parent, il sera accessible depuis n'importe quelle instance de la classe Auto


        /*****************************************************
           *  STEP 6 - Static - propriétés
        *****************************************************/
        public static string typeAuto = "AUTO";

        /*****************************************************
        *  STEP 8 - Const
        *****************************************************/
        public const string constTypeAuto = "AUTO";

        public bool airConditioning = true;

        /*****************************************************
        *  STEP 9 - Private
           Une propriété private n'est accessible qu'a l'intérieur de la classe
        *****************************************************/
        private string registrationNumber = string.Empty;

        /*****************************************************
        *  STEP 2  - Constructeurs
        *****************************************************/
        public Auto(string _brand, string _model, bool haveAirCond = true) :
            // Appelle le constructeur de la classe parente. L'appel a une fonction d'une classe parente
            // se fait toujours via le mot clé "base"
            base(_brand, _model, 4)
        {
            // On peut ici instancier les propriétés supplémentaires de la classe Auto
            airConditioning = haveAirCond;
        }


        /*****************************************************
        *  STEP 5 - Accès aux propriétés protected du parent depuis une fonction public des enfants
        *****************************************************/
        public string GetFullInformations()
        {
            return $"{base.GetVehicleInformations()} - Air conditioning : {airConditioning}";
        }


        /*****************************************************
        *  STEP 7 - Static - fonctions
        *****************************************************/
        public static string TypeAuto()
        {
            return "Auto - function";
        }

        public string GetRegistratioNumber()
        {
            return registrationNumber;
        }

        public void SetRegistratioNumber(string registratioon_number)
        {
            registrationNumber = registratioon_number;
        }
    }
}