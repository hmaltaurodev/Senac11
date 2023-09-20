namespace Senac11.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Value { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
