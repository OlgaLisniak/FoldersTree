using FoldersTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoldersTree.Sevices
{
    public class DBService
    {
        FolderM folderM;

        public DBService()
        {
            folderM = new FolderM();
        }

        public FolderModel GetFirstFolder()
        {
            FolderModel firstFolder = new FolderModel();

            firstFolder = folderM.Folders.FirstOrDefault();

            return firstFolder;
        }

        public List<FolderModel> GetAllFolders()
        {
            List<FolderModel> folders = new List<FolderModel>();

            foreach (var folder in folderM.Folders)
            {
                folders.Add(folder);
            }

            return folders;
        }

        public List<FolderModel> GetSubFolders(int? id)
        {
            List<FolderModel> subFolders = new List<FolderModel>();

            subFolders = folderM.Folders.Where(f => f.ParentID == id).ToList();

            return subFolders;
        }

        public FolderModel GetFolderByName(string name)
        {
            FolderModel folder = folderM.Folders.Where(f => f.Name == name).FirstOrDefault();

            return folder;
        }
    }
}