using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using KnowledgeHub.Models.GeneratedClassesByEF;

namespace KnowledgeHub.Models.ModelClasses
{
    public class PresenterViewerModel
    {


        public int Presenter_ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Presenter_Name { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string Presenter_City { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Presenter_Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Phone# is required")]
        public string Presenter_Ph_Num { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Presenter_Gender { get; set; }
        public byte[] Presenter_Prof_Picture { get; set; }
        public string Presenter_Prof_Description { get; set; }
        public string Presenter_Prof_Experience { get; set; }
        public Nullable<double> Presenter_Prof_Rating { get; set; }
        public string Presenter_Prof_Course_Outline { get; set; }

        [Required(ErrorMessage = "Day is required")]
        public string DOB_Days { get; set; }

        [Required(ErrorMessage = "Month is required")]
        public string DOB_Months { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public string DOB_Year { get; set; }
        public string LoginAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Login_Table> Login_Table { get; set; }

    }
}