
using System.Data.Entity;

using ZooProject.Model;

namespace ZooProject.Data
{
    class ZooDataContext : DbContext
    {
        public ZooDataContext() : base(Properties.Settings.Default.DbConnect)
        {

        }


        public DbSet<Animals> animals { get; set; }
        public DbSet<CategoryOfAnimal> categoryOfAnimal { get; set; }
        public DbSet<CategoryOfTickets> categorryOfTickets { get; set; }
        public DbSet<Events> events { get; set; }
        public DbSet<EventType> eventType { get; set; }
        public DbSet<Tickets> tickets { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<UserOrder> userOrder { get; set; }

    }
}
