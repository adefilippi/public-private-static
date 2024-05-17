using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicPrivateStatic.Model
{
    public class Moto: Vehicle
    {
        /*****************************************************
        *  STEP 6 - Static - propriétés
        *****************************************************/
        public static string typeMoto = "MOTO";

        /*****************************************************
        *  STEP 8 - Const
        *****************************************************/
        public const string constTypeMoto = "MOTO";

        public bool shifterPro = false;

        /*****************************************************
        *  STEP 2  - Constructeurs
        *****************************************************/
        // Même si vous ne remplissez pas les propriétés de votre classe enfant, 
        // Si vous définissez un constructeur dans votre classe parent, votre classe enfant doit aussi avoir un constructeur
        public Moto(string _brand, string _model) : 
            base(_brand, _model, 2)
        {
        }


        /*****************************************************
        *  STEP 5 - Accès aux propriétés protected du parent depuis une fonction public des enfants
        *****************************************************/
        public string GetFullInformations()
        {
            return $"{base.GetVehicleInformations()} - Shifter pro : {shifterPro}";
        }


        /*****************************************************
        *  STEP 7 - Static - fonctions
        *****************************************************/
        public static string TypeMoto()
        {
            return "Moto - function";
        }
    }
}
