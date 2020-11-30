namespace TugasMCC_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDepartment : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Employees", newName: "Employee");
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        CustId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CustId);
            
            AddColumn("dbo.Employee", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "DepartmentId");
            AddForeignKey("dbo.Employee", "DepartmentId", "dbo.Department", "CustId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "DepartmentId", "dbo.Department");
            DropIndex("dbo.Employee", new[] { "DepartmentId" });
            DropColumn("dbo.Employee", "DepartmentId");
            DropTable("dbo.Department");
            RenameTable(name: "dbo.Employee", newName: "Employees");
        }
    }
}
