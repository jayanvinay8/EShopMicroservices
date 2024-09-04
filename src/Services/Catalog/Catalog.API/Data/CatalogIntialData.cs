using Marten.Schema;

namespace Catalog.API.Data
{
    public class CatalogIntialData : IInitialData
    {
        public async Task Populate(IDocumentStore store, CancellationToken cancellation)
        {
            var session = store.LightweightSession();
            if (await session.Query<Product>().AnyAsync()) return;

            //Marten UPSERT will cater for existing records
            session.Store<Product>(GetPreConfiguredProducts());
            await session.SaveChangesAsync();
        }

        private static IEnumerable<Product> GetPreConfiguredProducts() => new List<Product>
        {
            new Product
            {
                Id=new Guid("01918a78-105f-4ef2-abee-52db115fea9e"),
                Name="IPhone X",
                Description="This phone is the company's biggest change to its flagship models.",
                ImageFile="Product-1.png",
                Price=950.00M,
                Category=new List<string>{"Smart Phone"}
            },
            new Product
            {
                Id=new Guid("01918a78-105f-4ef2-abee-52db225fea9e"),
                Name="Samsung 10",
                Description="This phone is the company's biggest change to its flagship models.",
                ImageFile="Product-2.png",
                Price=840.00M,
                Category=new List<string>{"Smart Phone"}
            },
            new Product
            {
                Id=new Guid("01918a78-105f-4ef2-abee-52db335fea9e"),
                Name="Huawei 10",
                Description="This phone is the company's biggest change to its flagship models.",
                ImageFile="Product-3.png",
                Price=650.00M,
                Category=new List<string>{"White Appliances"}
            },
            new Product
            {
                Id=new Guid("01918a78-105f-4ef2-abee-52db445fea9e"),
                Name="Xiaomi Mi 9",
                Description="This phone is the company's biggest change to its flagship models.",
                ImageFile="Product-4.png",
                Price=470.00M,
                Category=new List<string>{"White Appliances"}
            },
            new Product
            {
                Id=new Guid("01918a78-105f-4ef2-abee-52db555fea9e"),
                Name="HTC U11+ plus",
                Description="This phone is the company's biggest change to its flagship models.",
                ImageFile="Product-5.png",
                Price=300.00M,
                Category=new List<string>{"Smart Phone"}
            },
            new Product
            {
                Id=new Guid("01918a78-105f-4ef2-abee-52db665fea9e"),
                Name="LG G7 ThinQ",
                Description="This applicance is the company's biggest change to its flagship models.",
                ImageFile="Product-6.png",
                Price=240.00M,
                Category=new List<string>{"Home Kitchen"}
            },
            new Product
            {
                Id=new Guid("01918a78-105f-4ef2-abee-52db775fea9e"),
                Name="Panasonic Lumix",
                Description="This applicance is the company's biggest change to its flagship models.",
                ImageFile="Product-7.png",
                Price=240.00M,
                Category=new List<string>{"Camera"}
            }
        };
    }
}
