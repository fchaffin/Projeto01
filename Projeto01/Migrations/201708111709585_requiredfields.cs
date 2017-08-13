namespace Projeto01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requiredfields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categorias", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Produtoes", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "Nome", c => c.String());
            AlterColumn("dbo.Categorias", "Nome", c => c.String());
        }
    }
}
