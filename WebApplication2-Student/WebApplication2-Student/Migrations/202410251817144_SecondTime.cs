namespace WebApplication2_Student.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondTime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentT",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        StudentName = c.String(nullable: false),
                        StudentClass = c.String(nullable: false),
                        StudentAge = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentT");
        }
    }
}
