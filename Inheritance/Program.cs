using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // done Create a class Animal
            // done give this class 4 members that all Animals have in common


            // done Create a class Bird
            // done give this class 4 members that are specific to Bird
            // done Set this class to inherit from your Animal Class

            // done Create a class Reptile
            // done give this class 4 members that are specific to Reptile
            // done Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  done give values to your members using the object of your Bird class
             *  
             * done Creatively display the class member values 
             */

            Bird bird1 = new Bird();                             //instantiate
            bird1.HaveWings = true;                              //dot notation
            bird1.CanFly = true;
            bird1.Feathers = "purple feathers";
            bird1.Teeth = "very sharp teeth that can potential immit hot lemon juice into your tea";
            bird1.Eyes = "eyes that can see through your body but not past your organs";


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            //object initializer
            Reptile reptile2 = new Reptile()
            {
                AreSnakes = true, Eyes = "see in the dark", Feet = "they have none", HasScales= true, IsHidden=true, Name ="anaconda"
            };


            reptile2.Print();


        }
    }
}
