﻿namespace FirstHundredFoods.Models
{
    public class Parent
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Baby> Babies { get; set; } = new List<Baby>();
    }
}
