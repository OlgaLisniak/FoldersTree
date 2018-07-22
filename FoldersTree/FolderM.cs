namespace FoldersTree
{
    using FoldersTree.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FolderM : DbContext
    {
        static FolderM()
        {
            Database.SetInitializer(new DbInitializer());
        }

        public FolderM()
            : base("name=FolderM")
        {
        }

        public DbSet<FolderModel> Folders { get; set; }
    }
}