using PublicPrivateStatic.Model;
using System;

namespace PublicPrivateStatic
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*****************************************************
             *  STEP 2 - Constructeurs
             *****************************************************/
            Auto alpine = new Auto("Alpine", "A110", false);
            Auto bugatti = new Auto("Bugatti", "Chiron");
            
            Moto rs4 = new Moto("Aprilla", "RS4");
            rs4.shifterPro = true;


            /*****************************************************
            *  STEP 3 - Accès aux propriétés publiques du parent
            *****************************************************/
            // Model est public dans ma classe Vehicle, je peux y accéder de n'importe ou dans le code
            // du moment que j'ai une instance (ici a partir de mon instance rs4)
            string motoModel = rs4.model;
            string autoModel = alpine.model;

            
            /*****************************************************
            *  STEP 4 - Accès aux propriétés protected du parent depuis une fonction public du parent
            *****************************************************/
            // La propriété brand de la classe vehicle étant en protected, elle n'est pas directement accessible
            // La ligne suivante ne fonctionnera pas. 
            //string brand = rs4.brand;

            // Si je veux récupérer la valeur de la propriété, je dois définir une fonction public qui récupère la valeur
            string motoBrand = rs4.GetBrand();
            string autoBrand = alpine.GetBrand();

            
            /*****************************************************
            *  STEP 5 - Accès aux propriétés protected du parent depuis une fonction public des enfants
            *****************************************************/
            // De même que pour la marque, je peux définir dans mes classes enfant des fonctions avec le meme nom
            // mais qui font des "actions différentes" 
            Console.WriteLine(rs4.GetFullInformations());
            Console.WriteLine(alpine.GetFullInformations());
            Console.WriteLine(bugatti.GetFullInformations());

            
            /*****************************************************
            *  STEP 6 - Static - propriétés
            *****************************************************/
            // les propriétés typeAuto, typeMoto et typeVehicle sont statiques,
            // je peux récupérer leur valeurs sans instancier de variables de leur type
            Console.WriteLine(Auto.typeAuto);
            Console.WriteLine(Moto.typeMoto);
            Console.WriteLine(Vehicle.typeVehicle);

            // typeVehicle étant public et les classes Auto et Moto étant des enfants de Vehicle, je peux aussi écrire 
            Console.WriteLine(Auto.typeVehicle);
            Console.WriteLine(Moto.typeVehicle);
            
            // Je peux également changer la valeur de typeVehicle à partir de ma classe Auto
            Auto.typeVehicle = "MOTORIZEDVEHICLE";

            // Cela affichera aussi sa nouvelle valeur quand la classe moto errayera d'afficher sa valeur
            Console.WriteLine(Moto.typeVehicle);

            
            /*****************************************************
            *  STEP 7 - Static - fonctions
            *****************************************************/
            Console.WriteLine(Auto.TypeAuto());
            Console.WriteLine(Moto.TypeMoto());
            Console.WriteLine(Vehicle.TypeVehicle());

            // TypeVehicle() étant public et les classes Auto et Moto étant des enfants de Vehicle, je peux aussi écrire 
            Console.WriteLine(Auto.TypeVehicle());
            Console.WriteLine(Moto.TypeVehicle());

            
            /*****************************************************
            *  STEP 8 - Const
            *****************************************************/
            Console.WriteLine(Auto.constTypeAuto);
            Console.WriteLine(Moto.constTypeMoto);
            Console.WriteLine(Vehicle.constTypeVehicle);

            // constTypeVehicle étant public et les classes Auto et Moto étant des enfants de Vehicle, je peux aussi écrire 
            Console.WriteLine(Auto.constTypeVehicle);
            Console.WriteLine(Moto.constTypeVehicle);

            // Je ne peux pas changer la valeur de constTypeVehicle car c'est une constante, elle ne changera jamais;
            // La ligne suivante ne fonctionnera pas.
            //Auto.constTypeVehicle = 3;

            // Il n'existe pas d'équivalent de const pour les fonctions

        }
    }
}
