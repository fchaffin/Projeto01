namespace Projeto01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fabricantes", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fabricantes", "Nome", c => c.String());
        }
    }
}
