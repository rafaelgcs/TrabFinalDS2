namespace VWEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _200520190219 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Mensagems", "ComImagem");
            DropColumn("dbo.Mensagems", "Imagem");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mensagems", "Imagem", c => c.String());
            AddColumn("dbo.Mensagems", "ComImagem", c => c.Boolean(nullable: false));
        }
    }
}
