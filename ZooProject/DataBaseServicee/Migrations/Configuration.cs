namespace DataBaseServicee.Migrations
{
    using DataBaseServicee.DataContext;
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;



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
                new Model.CategoryOfTickets() { IdOfCategoryTicket = 1, TicketType = "Семеен", price = 8, IsDeleted = 0 },
                new Model.CategoryOfTickets() { IdOfCategoryTicket = 2, TicketType = "Редовен", price = 12, IsDeleted = 0 },
                new Model.CategoryOfTickets() { IdOfCategoryTicket = 3, TicketType = "Ученически", price = 5, IsDeleted = 0 },
                new Model.CategoryOfTickets() { IdOfCategoryTicket = 4, TicketType = "Пенсионер/Дете", price = 0, IsDeleted = 0 }
                );

            context.eventType.AddOrUpdate(x => x.Id,
                new Model.EventType() { Id = 1, Type = "Сутрешен", IsDeleted = 0 },
                new Model.EventType() { Id = 2, Type = "Обеден", IsDeleted = 0 },
                new Model.EventType() { Id = 3, Type = "Вечерен", IsDeleted = 0 }
                );
            context.events.AddOrUpdate(x => x.Id,
                new Model.Events()
                {
                    Id = 1,
                    Date = new DateTime(2022, 05, 12),
                    Name = "Слонски прояви",
                    Description = "Наблудение над слонските действия",
                   
                    IsDeleted = 0
                },
                new Model.Events()
                {
                    Id = 1,
                    Date = new DateTime(2022, 05, 12),
                    Name = "Слонски прояви",
                    Description = "Наблудение над слонските действия",
                },
                new Model.Events()
                {
                    Id = 1,
                    Date = new DateTime(2022, 05, 12),
                    Name = "Слонски прояви",
                    Description = "Наблудение над слонските действия",
                    IsDeleted = 0
                },
                new Model.Events()
                {
                    Id = 2,
                    Date = new DateTime(2022, 05, 12),
                    Name = "Змийски прояви",
                    Description = "Наблудение на змията в средата си как ловува",
                    IsDeleted = 0
                },
                new Model.Events()
                {
                    Id = 2,
                    Date = new DateTime(2022, 05, 12),
                    Name = "Костенурски развлечения",
                    Description = "По всяко време може да се наблюдава, действията на костенурката",
                    IsDeleted = 0
                },
                new Model.Events()
                {
                    Id = 2,
                    Date = new DateTime(2022, 05, 12),
                    Name = "Орела Кирчо",
                    Description = "По всяко време може да се наблюдава Кирчо орелчето",
                    IsDeleted = 0
                },
                new Model.Events()
                {
                    Id = 3,
                    Date = new DateTime(2022,05,12),
                    Name = "Слонска баня",
                    Description = "Вечерта може да се наблудава как слоните се къпят",
                    IsDeleted = 0

                }

                );
            


        }
    }
}
