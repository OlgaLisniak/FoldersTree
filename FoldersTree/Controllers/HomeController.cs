using FoldersTree.Models;
using FoldersTree.Sevices;
using System.Web.Mvc;

namespace FoldersTree.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string urlFolder)
        {
            DBService db = new DBService();
            FolderViewModel folderViewModel = new FolderViewModel();

            if (urlFolder == null)
            {
                folderViewModel.CurrentFolder = db.GetFirstFolder();
            }
            else
            {
                string nameFolder = urlFolder.Substring(urlFolder.LastIndexOf("/") + 1);
                folderViewModel.CurrentFolder = db.GetFolderByName(nameFolder);
            }

            folderViewModel.SubFolders = db.GetSubFolders(folderViewModel.CurrentFolder.ID);

            foreach (var subFolder in folderViewModel.SubFolders)
            {
                subFolder.Url += subFolder.ParentFolder.Name + "/" + subFolder.Name;
            }

            return View("Index", folderViewModel);
        }
    }
}