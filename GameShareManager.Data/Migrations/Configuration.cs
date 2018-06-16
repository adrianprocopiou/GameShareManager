using System.Data.Entity.Migrations;
using GameShareManager.Data.Context;

namespace GameShareManager.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<GameShareManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GameShareManagerContext context)
        {
           
        }
    }
}