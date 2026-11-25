using ProjectADV16_3.Builders;
using ProjectADV16_3.Entities;

namespace ProjectADV16_3.Productions
{
    public class OilWell : Production
    {
        public OilWell(int id): base(id, "Свердловина")
        {
            this.AddRecipe(
                (new RecipeBuilder()).Create(1, "", 1)
                .AddRequiredResources(ResourceType.Electricity, 5)
                .AddRequiredResources(ResourceType.Coal, 2)
                .AddReceivedResources(ResourceType.Oil, 3)
                .GetResult());
        }

        public override void Produce()
        {

        }
    }
}