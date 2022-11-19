using FirstHundredFoods.Models;
using FirstHundredFoods.Pages;
using System.Diagnostics;

namespace FirstHundredFoods.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FirstHundredFoodsContext context)
        {
            if (context.Foods.Any())
            {
                return;   // DB has been seeded
            }

            var foods = new Food[]
            {
                new Food{Name="Asparagus", FoodType=FoodType.Vegetable },
                new Food{Name="Watermelon", FoodType=FoodType.Fruit},
                new Food{Name="Aubergine", FoodType=FoodType.Vegetable },
                new Food{Name="Beetroot", FoodType=FoodType.Vegetable },
                new Food{Name="Bell pepper", FoodType=FoodType.Vegetable},
                new Food{Name="Broccoli", FoodType=FoodType.Vegetable},
                new Food{Name="Egg", ContainsAllergen=true, FoodType=FoodType.Meat}
            };

            context.Foods.AddRange(foods);
            context.SaveChanges();
        }
    }
}
