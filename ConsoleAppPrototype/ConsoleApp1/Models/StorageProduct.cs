namespace ConsoleApp1.Models
{
    /// <summary>
    ///  /// Product(for working with Storage) class for operating properties, contains prototype realisation of clone
    /// </summary>
    public class StorageProduct : Product
    {
        public string StorageName { get; set; }

        public Unit Unit { get; set; }

        public StorageProduct(int id, string name, string color, int size, string storageName, Unit unit)
            :base(id, name, size, color)
        {
            this.StorageName = storageName;
            this.Unit = unit;
        }

        public override StorageProduct CloneMemberWise()
        {
            return this.MemberwiseClone() as StorageProduct;
        }

        public override StorageProduct CloneCtor()
        {
            return new StorageProduct(Id, Name, Color, Size, StorageName, Unit) as StorageProduct;
        }

        public StorageProduct CloneWithInners()
        {
            var clone = this.MemberwiseClone() as StorageProduct;
            clone.Unit = this.Unit.Clone();
            return clone;
        }

        public object Clone() => CloneCtor();
    }
}
