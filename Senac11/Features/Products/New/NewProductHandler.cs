using Senac11.Domain;
using Senac11.Infra.Contexts;

namespace Senac11.Features.Products.New
{
    public class NewProductHandler
    {
        private readonly Senac11Context context;

        public NewProductHandler(Senac11Context context)
        {
            this.context = context;
        }

        public async Task<NewProductResult> Handle(NewProductCommand command)
        {
            Product product = new Product();

            product.Name = command.Name;
            product.Value = command.Value;
            product.IsActive = true;
            product.CreationDate = DateTime.Now;
            product.UpdateDate = DateTime.Now;

            context.Products.Add(product);
            int success = await context.SaveChangesAsync();

            string message;
            if (success == 1)
                message = "Produto cadastrado com sucesso!";
            else
                message = "Falha no processo de gravação!";

            NewProductResult result = new NewProductResult();

            result.Message = message;
            result.Data = product;
            result.Success = (success == 1);

            return result;
        }
    }
}
