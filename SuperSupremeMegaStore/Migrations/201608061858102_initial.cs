namespace SuperSupremeMegaStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customer", "FirstName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "FirstName", c => c.String());
            AlterColumn("dbo.Customer", "LastName", c => c.String());
        }
    }
}
