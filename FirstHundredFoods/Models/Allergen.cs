namespace FirstHundredFoods.Models
{
    public enum Severity
    {
        mild, moderate, severe
    }

    public class Allergen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Severity Severity { get; set; }
    }
}
