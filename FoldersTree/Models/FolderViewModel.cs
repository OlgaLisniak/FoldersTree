using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoldersTree.Models
{
    public class FolderViewModel
    {
        public FolderModel CurrentFolder { get; set; }

        public List<FolderModel> SubFolders { get; set; }
    }
}