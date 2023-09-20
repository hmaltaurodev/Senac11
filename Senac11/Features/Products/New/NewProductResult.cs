using Senac11.Domain;

namespace Senac11.Features.Products.New
{
    public class NewProductResult
    {
        public string Message { get; set; }

        public Product Data { get; set; }

        public bool Success { get; set; }
    }
}
