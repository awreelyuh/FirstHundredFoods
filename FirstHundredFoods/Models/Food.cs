﻿using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public enum FoodType
    {
        Vegetable, Fruit, Meat, Nut, Grain, Dairy, Seafood, HerbSpice, LegumeBean
    }
    public class Food
    {
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        public string Name { get; set; }
        public bool ContainsAllergen { get; set; }
        public FoodType FoodType { get; set; }

    }
}
