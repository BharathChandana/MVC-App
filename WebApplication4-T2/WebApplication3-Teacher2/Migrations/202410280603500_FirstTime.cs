namespace WebApplication3_Teacher2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tt",
                c => new
                    {
                        TId = c.Int(nullable: false),
                        TName = c.String(nullable: false),
                        TRole = c.String(nullable: false),
                        TSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tt");
        }
    }
}
