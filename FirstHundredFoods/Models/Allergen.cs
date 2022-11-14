namespace FirstHundredFoods.Models
{
    public enum Severity
    {
        mild, moderate, severe
    }

    public class Allergen
    {
        //Major food allergens: milk, eggs, fish, Crustacean shellfish, tree nuts, peanuts, wheat, soybeans, and sesame
        public int ID { get; set; }
        public string Name { get; set; }
        public Severity Severity { get; set; }
    }
}
