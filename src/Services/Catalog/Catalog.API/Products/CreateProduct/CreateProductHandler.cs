
namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category, string Description, string Image, decimal Price)
        : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler(IDocumentSession session)
        : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //Create Product Entity  from Command Object
            //Save to DB
            //Return CreateProductResult result

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.Image,
                Price = command.Price
            };

            //TODO Save to DB
            session.Store(product);
            await session.SaveChangesAsync(cancellationToken);

            //Return Result
            return new CreateProductResult(product.Id);
        }
    }
}
