namespace VWEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _190520192205 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mensagems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Texto = c.String(),
                        Data = c.DateTime(nullable: false),
                        ComImagem = c.Boolean(nullable: false),
                        Imagem = c.String(),
                        TipoMensagem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mensagems");
        }
    }
}
