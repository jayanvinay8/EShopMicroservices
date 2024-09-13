namespace Ordering.Infrastructure.Data.Extensions
{

    internal class InitialData
    {
        public static IEnumerable<Customer> Customers =>
        new List<Customer> {
            Customer.Create(CustomerId.Of(new Guid("58c49479-ec65-4de2-86e7-033c546291aa")),"Vinay","vinaytedla@gmail.com"),
            Customer.Create(CustomerId.Of(new Guid("68c49479-ec65-4de2-86e7-033c546291ab")),"Jaya","jayavinay@outlook.com")
        };


        public static IEnumerable<Product> Products =>

        new List<Product> {
            Product.Create(ProductId.Of(new Guid("98c49479-ec65-4de2-86e7-033c546291aa")),"IPhone X",599),
            Product.Create(ProductId.Of(new Guid("48c49479-ec65-4de2-86e7-033c546291ab")),"Samsung 10",400),
            Product.Create(ProductId.Of(new Guid("38c49479-ec65-4de2-86e7-033c546291ab")),"Huawei Plus",650),
            Product.Create(ProductId.Of(new Guid("28c49479-ec65-4de2-86e7-033c546291ab")),"Xiaomi Mi",450)
        };

        public static IEnumerable<Order> OrdersWithItems
        {
            get
            {
                var address1 = Address.Of("Vinay", "Tedla", "vinaytedla@gmail.com", "Uttarahalli", "India", "Karnataka", "560061");
                var address2 = Address.Of("Jaya", "Tedla", "jayavinay@gmail.com", "Uttarahalli", "India", "Karnataka", "560061");

                var payment1 = Payment.Of("CardVinay", "1234567812345678", "0130", "123", 1);
                var payment2 = Payment.Of("CardJaya", "1234567812345678", "0130", "123", 1);


                var order1 = Order.Create(OrderId.Of(new Guid("78c49479-ec65-4de2-86e7-033c546291aa")), CustomerId.Of(new Guid("58c49479-ec65-4de2-86e7-033c546291aa")), OrderName.Of("ORD_1"), address1, address1, payment1);
                order1.Add(ProductId.Of(new Guid("98c49479-ec65-4de2-86e7-033c546291aa")), 1, 599);
                order1.Add(ProductId.Of(new Guid("48c49479-ec65-4de2-86e7-033c546291ab")), 1, 400);

                var order2 = Order.Create(OrderId.Of(new Guid("88c49479-ec65-4de2-86e7-033c546291aa")), CustomerId.Of(new Guid("68c49479-ec65-4de2-86e7-033c546291ab")), OrderName.Of("ORD_2"), address2, address2, payment2);
                order2.Add(ProductId.Of(new Guid("38c49479-ec65-4de2-86e7-033c546291ab")), 1, 650);
                order2.Add(ProductId.Of(new Guid("28c49479-ec65-4de2-86e7-033c546291ab")), 1, 450);

                var orders = new List<Order> { order1, order2 };

                return orders;
            }
        }

    }
}
