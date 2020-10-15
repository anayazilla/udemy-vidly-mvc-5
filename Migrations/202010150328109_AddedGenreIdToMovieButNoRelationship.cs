namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenreIdToMovieButNoRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "GenreId");
        }
    }
}
