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

        public void Cook()
        {
            //double the recipe?
            bool doubled = this.DoubleRecipe();
            if (doubled)
            {
                foreach (Ingredient thisIngredient in _ingredients)
                {
                    thisIngredient.DoubleSize();
                }
            }

            //optional: list ingredients
            Console.Write("Would you like to see which ingredients are needed? (y/n) ");
            string listMaybe = Console.ReadLine();
            if (listMaybe == "y")
            {
                foreach (Ingredient thisIngredient in _ingredients)
                {
                    thisIngredient.IngredientToCook();
                }
                Console.Write("Press any key when you are ready to continue.");
                string areYouActuallyReadingThroughThis = Console.ReadLine();
            }

            //go through each step and cook it
            string ready = "";
            foreach (CookStep thisStep in _process)
            {
                if (doubled)
                {
                    Console.WriteLine("Don't forget this recipe is doubled. Any amounts mentioned should be multiplied by 2.");
                }

                Console.WriteLine(thisStep.GetStep());
                Console.Write("\nPress any key when you are ready to continue. ");
                ready = Console.ReadLine();
            }

            //make sure recipe returns to normal amounts if doubled
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
            //Get steps needed to cook recipe from user
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

        public void StepFromSave(string instruction)
        {
            //get a step from a save
            CookStep newStep = new CookStep();
            newStep.AddInstruction(instruction);
            _process.Add(newStep);
        }

        public void AddIngredients()
        {
            //Get ingredients needed to cook recipe from user
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
                    Console.Write("What unit of measurement will this ingredient use? (ex:lbs, cups, tablespoon, etc.) ");
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

        public void IngredientFromSave(string parseString)
        {
            //get new ingredient from a saved file
            string[] newIngredient = parseString.Split("|");
            string type = newIngredient[0];

            Ingredient thisIngredient = new Ingredient();
            if (type == "solid")
            {
                thisIngredient = new Solid();
            }

            else if (type == "liquid")
            {
                thisIngredient = new Liquid();
            }

            else if (type == "powder")
            {
                thisIngredient = new Powder();
            }

            thisIngredient.SetStuff(newIngredient[1], newIngredient[2], float.Parse(newIngredient[3]));
            _ingredients.Add(thisIngredient);
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
            int stepTotal = _process.Count;
            int currentNum = 0;
            foreach (CookStep thisStep in _process)
            {
                saveString += thisStep.GetStep();
                currentNum += 1;
                if (currentNum < stepTotal)
                {
                    saveString += "*";
                }
            }
            saveString += "@";

            //save ingredients
            int ingredientTotal = _ingredients.Count;
            currentNum = 0;
            foreach (Ingredient thisIngredient in _ingredients)
            {
                saveString += thisIngredient.SaveWriteUp();
                currentNum += 1;
                if (currentNum < ingredientTotal)
                {
                    saveString += "*";
                }
            }

            return saveString;
        }

        public List<Ingredient> GetIngredients()
        {
            return _ingredients;
        }
    }
}