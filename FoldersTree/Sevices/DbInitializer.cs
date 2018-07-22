using FoldersTree.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoldersTree
{
    public class DbInitializer : DropCreateDatabaseAlways<FolderM>
    {
        protected override void Seed(FolderM context)
        {
            FolderModel root = new FolderModel {ID = 1, Name = "Creating Digital Images", ParentID = null };
            FolderModel folder1 = new FolderModel { ID = 2, Name = "Resourcess", ParentID = 1, ParentFolder = root };
            FolderModel folder2 = new FolderModel { ID = 3, Name = "Evidence", ParentID = 1, ParentFolder = root };
            FolderModel folder3 = new FolderModel { ID = 4, Name = "Graphic Products", ParentID = 1, ParentFolder = root };

            FolderModel folder1_1 = new FolderModel { ID = 5, Name = "Primary Sources", ParentID = 2, ParentFolder = folder1 };
            FolderModel folder1_2 = new FolderModel { ID = 6, Name = "Secondary Sources", ParentID = 2, ParentFolder = folder1 };

            FolderModel folder3_1 = new FolderModel { ID = 7, Name = "Process", ParentID = 3, ParentFolder = folder3 };
            FolderModel folder3_2 = new FolderModel { ID = 8, Name = "Final Product", ParentID = 3, ParentFolder = folder3 };

            context.Folders.Add(root);
            context.Folders.Add(folder1);
            context.Folders.Add(folder2);
            context.Folders.Add(folder3);
            context.Folders.Add(folder1_1);
            context.Folders.Add(folder1_2);
            context.Folders.Add(folder3_1);
            context.Folders.Add(folder3_2);

            context.SaveChanges();

        }
    }
}