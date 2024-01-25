using System.Data.Entity.Migrations;
using KlusterIO.Infra.Data.Context;
namespace KlusterIO.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    } 
}