namespace ConsoleApp1.Models
{
    /// <summary>
    /// Base product class with based properties realised Cloneable interfaces
    /// </summary>
    public class BaseProduct : ICloneable, IMyClonable
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public BaseProduct(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public virtual BaseProduct CloneCtor()
        {
            return new BaseProduct(this.Id, this.Name);
        }
        public virtual BaseProduct CloneMemberWise()
        {
            return this.MemberwiseClone() as BaseProduct;
        }

        public override string ToString()
        {
            return $"[ Id: {Id}, Name: {Name} ]";
        }

        public object Clone() => CloneCtor();   
    }
}
