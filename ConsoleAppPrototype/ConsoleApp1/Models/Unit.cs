namespace ConsoleApp1.Models
{
    /// <summary>
    /// Class for concrete unit type for product
    /// </summary>
    public class Unit
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBasedOnTime { get; set; }

        public Unit(string name, string description, bool isBasedOnTime)
        {
            this.Name = name;
            this.Description = description;
            this.IsBasedOnTime = isBasedOnTime;
        }

        public Unit Clone()
        {
            return new Unit(Name, Description, IsBasedOnTime);
        }
    }
}
