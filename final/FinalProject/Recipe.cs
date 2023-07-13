using System;
using System.Collections.Generic;

namespace Final
{
    public class Recipe
    {
        private string _name;
        private List<CookStep> _process = new List<CookStep>();
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Recipe(string name)
        {
            _name = name;
        }

        public void Cook(Recipe cookRecipe)
        {
            //double the recipe?
            bool doubled = this.DoubleRecipe();
            foreach (Ingredient thisIngredient in _ingredients)
            {
                thisIngredient.DoubleSize();
            }

            //go through each step and cook it
            string ready = "";
            foreach (CookStep thisStep in _process)
            {
                if (doubled)
                {
                    Console.WriteLine("Don't forget this recipe is doubled. Any amounts listed should be multiplied by 2.");
                }

                Console.WriteLine(thisStep.GetStep());
                Console.Write("\nPress any key when you are ready to continue. ");
                ready = Console.ReadLine();
            }

            foreach (Ingredient thisIngredient in _ingredients)
            {
                if (doubled)
                {
                    thisIngredient.HalfSize();
                }
            }
        }

        public void AddSteps()
        {
            //Get steps needed to cook recipe
            string instruction = "";
            while (instruction != "quit")
            {
                CookStep newStep = new CookStep();
                Console.Write("Enter a step of the cooking process (Enter \"quit\" to finish): ");
                instruction = Console.ReadLine();
                if (instruction != "quit")
                {
                    newStep.AddInstruction(instruction);
                    _process.Add(newStep);
                }
            }
            Console.WriteLine("");
        }

        public void AddIngredients()
        {
            //Get ingredients needed to cook recipe
            string ingredientName = "";
            while (ingredientName != "quit")
            {
                //get information from user
                Console.Write("Enter an ingredient needed (Enter \"quit\" when finished): ");
                ingredientName = Console.ReadLine();
                if (ingredientName != "quit")
                {
                    Console.Write("Is this ingredient a solid, liquid, or powder? ");
                    string state = Console.ReadLine();
                    Console.Write("What unit of measurement will this ingredient use? (Enter \"solid\" for individual items) ");
                    string unit = Console.ReadLine();
                    Console.Write("How much will you need? (Units are provided in previous step. Enter fractions as a decimal if necessary) ");
                    string amountString = Console.ReadLine();
                    float amount = float.Parse(amountString);

                    //initiates the correct ingredient type
                    Ingredient newIngredient = new Ingredient();
                    if (state == "solid")
                    {
                        newIngredient = new Solid();
                    }

                    else if (state == "liquid")
                    {
                        newIngredient = new Liquid();
                    }

                    else 
                    {
                        newIngredient = new Powder();
                    }

                    newIngredient.SetStuff(ingredientName, unit, amount);
                    _ingredients.Add(newIngredient);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public string GetName()
        {
            //returns the name of the recipe
            return _name;
        }

        public bool DoubleRecipe()
        {
            //can double the size of the recipe if the user desires
            Console.Write("Would you like to double this recipe today? (y/n) ");
            string doubleYNString = Console.ReadLine();
            bool doubleYN = false;
            if (doubleYNString == "y")
            {
                doubleYN = true;
            }

            return doubleYN;
        }

        public string SaveWriteUp()
        {
            //give a string for file to remember this recipe
            string saveString = "";

            //save name
            saveString += _name;
            saveString += "@";

            //save steps
            foreach (CookStep thisStep in _process)
            {
                saveString += thisStep.GetStep();
                saveString += "*";
            }
            saveString += "@";

            //save ingredients
            foreach (Ingredient thisIngredient in _ingredients)
            {
                saveString += thisIngredient.SaveWriteUp();
                saveString += "*";
            }

            return saveString;
        }
    }
}