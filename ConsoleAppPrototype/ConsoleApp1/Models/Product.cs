namespace ConsoleApp1.Models
{
    /// <summary>
    /// Product class for operating properties, contains prototype realisation of clone
    /// </summary>
    public class Product : BaseProduct
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Product(int id, string name, int size, string color)
            :base(id, name)
        {
            this.Size = size;
            this.Color = color;
        }

        public override Product CloneMemberWise()
        {
            return this.MemberwiseClone() as Product;
        }

        public override Product CloneCtor()
        {
            return new Product(Id, Name, Size, Color) as Product;
        }

        public object Clone() => CloneCtor();
    }
}
