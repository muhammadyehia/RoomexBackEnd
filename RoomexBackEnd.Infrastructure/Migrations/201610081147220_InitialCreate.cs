namespace RoomexBackEnd.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Planets",
                c => new
                    {
                        PlanetId = c.Guid(false),
                        Name = c.String(false, 50),
                        Distance = c.Long(false),
                    })
                .PrimaryKey(t => t.PlanetId)
                .Index(t => t.Name, unique: true, name: "IX_Planet_Name");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Planets", "IX_Planet_Name");
            DropTable("dbo.Planets");
        }
    }
}
