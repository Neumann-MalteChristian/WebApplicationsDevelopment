namespace BlazingPizza.Server
{
    public static class SeedData
    {
        public static void Initialize(PizzaStoreContext db)
        {
            var toppings = new Topping[]
            {
                new Topping()
                {
                    Name = "Ananas",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Artischocken",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Auberginen",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Basilikum",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Champignons",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Karpern",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Knoblauch",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Lachs(geräuchert)",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Mozzarella",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Oliven",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Paprika",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Parmesankäse",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Peperoni(scharf)",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Rucola",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Salami",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Sardellen",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Schinken",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Spinat",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Thunfisch",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Tomaten(frisch)",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Tomatensauce",
                    Price = 0.80m,
                },
                new Topping()
                {
                    Name = "Zwiebeln",
                    Price = 0.80m,
                },
            };

            var specials = new PizzaSpecial[]
            {
                new PizzaSpecial()
                {
                    Name = "Pizza Margherita",
                    Description = "",
                    BasePrice = 7.50m,
                    ImageUrl = "img/pizzas/margherita.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 2,
                    Name = "Pizza Salami",
                    Description = "",
                    BasePrice = 7.90m,
                    ImageUrl = "img/pizzas/pizza salami.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 3,
                    Name = "Pizza Prosciutto",
                    Description = "",
                    BasePrice = 7.90m,
                    ImageUrl = "img/pizzas/pizza prosciutto.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 4,
                    Name = "Pizza Funghi",
                    Description = "",
                    BasePrice = 7.90m,
                    ImageUrl = "img/pizzas/pizza funghi.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 5,
                    Name = "Pizza Tonno",
                    Description = "",
                    BasePrice = 8.50m,
                    ImageUrl = "img/pizzas/pizza tonno.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 6,
                    Name = "Pizza Contadina",
                    Description = "",
                    BasePrice = 9.50m,
                    ImageUrl = "img/pizzas/PizzaContadia.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 7,
                    Name = "Pizza Salami e Funghi",
                    Description = "",
                    BasePrice = 8.50m,
                    ImageUrl = "img/pizzas/pizza salame e funghi.jpg",
                },
                new PizzaSpecial()
                {
                    Id = 8,
                    Name = "Pizza Prosciutto e Salami",
                    Description = "",
                    BasePrice = 8.50m,
                    ImageUrl = "img/pizzas/pizza prosciutto e salame.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 9,
                    Name = "Pizza Capricciosa",
                    Description = "",
                    BasePrice = 9.50m,
                    ImageUrl = "img/pizzas/PizzaCapricossa.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 10,
                    Name = "Pizza Hawaii",
                    Description = "",
                    BasePrice = 8.50m,
                    ImageUrl = "img/pizzas/pizza hawaii.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 11,
                    Name = "Pizza 4 Stagioni",
                    Description = "",
                    BasePrice = 9.50m,
                    ImageUrl = "img/pizzas/Pizza 4 Stagioni.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 12,
                    Name = "Pizza Pazza",
                    Description = "",
                    BasePrice = 9.50m,
                    ImageUrl = "img/pizzas/pizzaOliven.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 13,
                    Name = "Pizza Diavolo",
                    Description = "",
                    BasePrice = 9.50m,
                    ImageUrl = "img/pizzas/pizzaDiavolo.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 14,
                    Name = "Pizza Rucola",
                    Description = "",
                    BasePrice = 9.90m,
                    ImageUrl = "img/pizzas/PizzaRucola.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 15,
                    Name = "Pizza Bismarck",
                    Description = "",
                    BasePrice = 8.50m,
                    ImageUrl = "img/pizzas/pizza bismarck.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 16,
                    Name = "Pizza Carpese",
                    Description = "",
                    BasePrice = 8.20m,
                    ImageUrl = "img/pizzas/pizza Caprese.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 17,
                    Name = "Pizza Salmone",
                    Description = "",
                    BasePrice = 9.90m,
                    ImageUrl = "img/pizzas/PizzaSalmone.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 18,
                    Name = "Pizza Mafia",
                    Description = "",
                    BasePrice = 9.50m,
                    ImageUrl = "img/pizzas/pizza Mafia.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 19,
                    Name = "Pizza 4 Fromaggi",
                    Description = "",
                    BasePrice = 9.00m,
                    ImageUrl = "img/pizzas/pizza 4 formaggi.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 20,
                    Name = "Pizza alle Verdure",
                    Description = "",
                    BasePrice = 9.90m,
                    ImageUrl = "img/pizzas/PizzaAlleVerdure.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 21,
                    Name = "Pizza Melanzane",
                    Description = "",
                    BasePrice = 9.90m,
                    ImageUrl = "img/pizzas/PizzaMelazane.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 22,
                    Name = "Pizza Napoli",
                    Description = "",
                    BasePrice = 7.90m,
                    ImageUrl = "img/pizzas/pizza napoli.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 23,
                    Name = "Pizza Italia",
                    Description = "",
                    BasePrice = 9.90m,
                    ImageUrl = "img/pizzas/PizzaItalia.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 24,
                    Name = "Pizza Bella Vista",
                    Description = "",
                    BasePrice = 10.00m,
                    ImageUrl = "img/pizzas/pizzaOliven.jpg",
                },
                 new PizzaSpecial()
                {
                    Id = 25,
                    Name = "Pizza Calzone",
                    Description = "",
                    BasePrice = 9.00m,
                    ImageUrl = "img/pizzas/pizzaCalzone.jpg",
                },
            };

            db.Toppings.AddRange(toppings);
            db.Specials.AddRange(specials);
            db.SaveChanges();
        }
    }
}
