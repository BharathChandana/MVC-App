namespace WebApplication3_Teacher.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherT",
                c => new
                    {
                        TeacherId = c.Int(nullable: false),
                        TeacherName = c.String(nullable: false),
                        TeacherSubject = c.String(nullable: false),
                        TeacherSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TeacherT");
        }
    }
}
