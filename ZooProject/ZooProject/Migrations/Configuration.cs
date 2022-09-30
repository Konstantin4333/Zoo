namespace ZooProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using ZooProject.Data;
    using ZooProject.Service;

    internal sealed class Configuration : DbMigrationsConfiguration<ZooDataContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ZooDataContext context)
        {

            context.categoryOfAnimal.AddOrUpdate(x => x.IdOfCategory,
                new Model.CategoryOfAnimal() { IdOfCategory = 1, Name = "Бозайник" },
                 new Model.CategoryOfAnimal() { IdOfCategory = 2, Name = "Влечуго" },
                  new Model.CategoryOfAnimal() { IdOfCategory = 3, Name = "Земноводно" },
                   new Model.CategoryOfAnimal() { IdOfCategory = 4, Name = "Птици" }
                );



            context.animals.AddOrUpdate(x => x.IdAnimal,
                new Model.Animals()
                {

                    IdAnimal = 1,
                    Name = "Орел",
                    Description = "Най-големи хищник в небето",

                    AnimalImage = File.ReadAllBytes(@"Pictures/orel.jpg"),
                    AnimalCategoryID = 4,

                },
                 new Model.Animals()
                 {
                     IdAnimal = 2,
                     Name = "Слон",
                     Description = "Най-едрото животно",
                     AnimalImage = File.ReadAllBytes(@"Pictures/Слон.jfif"),
                     AnimalCategoryID = 1,

                 },
                    new Model.Animals()
                    {
                        IdAnimal = 3,
                        Name = "Усойница",
                        Description = "Oтровна змия",
                        AnimalImage = File.ReadAllBytes(@"Pictures/usoinica.jpg"),
                        AnimalCategoryID = 2,

                    },
                      new Model.Animals()
                      {
                          IdAnimal = 4,
                          Name = "Костенурка",
                          Description = "Костенурките имат много здрава черупка",
                          AnimalImage = File.ReadAllBytes(@"Pictures/kostenurka.jpg"),
                          AnimalCategoryID = 3,

                      },
                    new Model.Animals()
                    {
                        IdAnimal = 5,
                        Name = "Гущер",
                        Description = "Гущерите са прекрасни.",
                        AnimalImage = File.ReadAllBytes(@"Pictures/gushter.jfif"),
                        AnimalCategoryID = 3,

                    }

                );
            //   context.animals.RemoveRange();

            context.user.AddOrUpdate(x => x.IdUser,
                new Model.User() { IdUser = 1, Name = "admin", Password = "admin" },
                new Model.User() { IdUser = 2, Name = "1", Password = "1" }
                );

            context.categorryOfTickets.AddOrUpdate(x => x.IdOfCategoryTicket,
                new Model.CategoryOfTickets() { IdOfCategoryTicket = 1, TicketType = "Семеен", price = 8 },
                new Model.CategoryOfTickets() { IdOfCategoryTicket = 2, TicketType = "Редовен", price = 12 },
                new Model.CategoryOfTickets() { IdOfCategoryTicket = 3, TicketType = "Ученически", price = 5 },
                new Model.CategoryOfTickets() { IdOfCategoryTicket = 4, TicketType = "Пенсионер/Дете", price = 0 }
                );

            context.eventType.AddOrUpdate(x => x.IdTypeOfEvent,
                new Model.EventType() { IdTypeOfEvent = 1, Type = "Сутрешен" },
                new Model.EventType() { IdTypeOfEvent = 2, Type = "Обеден" },
                new Model.EventType() { IdTypeOfEvent = 3, Type = "Вечерен" }
                );
           
            context.categoryOfAnimal.AddOrUpdate(x => x.IdOfCategory,
            new Model.CategoryOfAnimal() { IsDeleted = false });
            context.categorryOfTickets.AddOrUpdate(x => x.IdOfCategoryTicket,
            new Model.CategoryOfTickets() { IsDeleted = false });
            context.animals.AddOrUpdate(x => x.AnimalCategoryID,
                new Model.Animals() { IsDeleted = false });
            context.eventType.AddOrUpdate(x => x.IdTypeOfEvent,
                new Model.EventType() { IsDeleted = false });
            context.events.AddOrUpdate(x => x.IdOfEvent,
                new Model.Events() { IsDeleted = false });
            context.user.AddOrUpdate(x => x.IdUser,
                new Model.User() { IsDeleted = false });


        }
    }
}
