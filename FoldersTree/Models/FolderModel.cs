using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoldersTree.Models
{
    public class FolderModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public int? ParentID { get; set; }

        [ForeignKey("ParentID")]
        public FolderModel ParentFolder { get; set; }

        public string Url { get; set; }
    }
}