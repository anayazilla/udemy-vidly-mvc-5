namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedMovieModelWithGenre : DbMigration
    {
        public override void Up()
        {
            DropColumn("Movies", "Genre");
        }

        public override void Down()
        {
        }
    }
}
