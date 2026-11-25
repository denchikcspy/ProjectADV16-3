using System;
using System.Collections.Generic;
using System.Text;
using ProjectADV16_3.Entities;

namespace ProjectADV16_3.Productions
{
    public abstract class Production
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Efficiency { get; set; }
        public List<Recipe> RecipeList { get; set; }
        public Recipe? ActiveRecipe { get; set; }

        protected Production(int id, string name, double efficiency = 100.0)
        {
            Id = id;
            Name = name;
            Efficiency = efficiency;
            RecipeList = new List<Recipe>();
            ActiveRecipe = null;
        }

        public void SetActiveRecipe(Recipe recipe)
        {
            if (RecipeList.Contains(recipe))
            {
                ActiveRecipe = recipe;
            }
        }

        public abstract void Produce();
    }
}