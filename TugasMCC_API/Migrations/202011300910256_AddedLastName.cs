namespace TugasMCC_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "LastName");
        }
    }
}
