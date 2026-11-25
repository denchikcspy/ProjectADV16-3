using ProjectADV16_3.Entities;


namespace ProjectADV16_3.Builders
{
    public class RecipeBuilder
    {
        Recipe recipe = null;

        public RecipeBuilder Create(int id, string name, int duration)
        {
            recipe = new Recipe(id, name, duration);

            return this;
        }

        public RecipeBuilder AddRequiredResources(ResourceType type, double amount)
        {
            if (!recipe.RequiredResourcesList.ContainsKey(type))
                recipe.RequiredResourcesList.Add(type, amount);

            return this;
        }

        public RecipeBuilder AddReceivedResources(ResourceType type, double amount)
        {
            if (!recipe.ReceivedResourcesList.ContainsKey(type))
                recipe.ReceivedResourcesList.Add(type, amount);

            return this;
        }

        public Recipe GetResult()
        {
            return recipe;
        }
    }
}
