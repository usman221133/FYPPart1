using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnowledgeHub.Models.GeneratedClassesByEF;
using System.ComponentModel.DataAnnotations;

namespace KnowledgeHub.Models.ModelClasses
{
    public class LoginTableModel
    {
        public int Login_ID { get; set; }
        public int Viewer_ID { get; set; }
        public int Presenter_ID { get; set; }
        [Required(ErrorMessage ="Username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Login_Password { get; set; }

        public virtual Viewer_Table Viewer_Table { get; set; }
        public virtual Presenter_Table Presenter_Table { get; set; }
    }
}