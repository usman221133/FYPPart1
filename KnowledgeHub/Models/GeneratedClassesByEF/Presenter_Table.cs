//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnowledgeHub.Models.GeneratedClassesByEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Presenter_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Presenter_Table()
        {
            this.Login_Table = new HashSet<Login_Table>();
        }
    
        public int Presenter_ID { get; set; }
        public string Presenter_Name { get; set; }
        public string Presenter_City { get; set; }
        public string Presenter_Email { get; set; }
        public string Presenter_D_O_Birth { get; set; }
        public string Presenter_Ph_Num { get; set; }
        public string Presenter_Gender { get; set; }
        public byte[] Presenter_Prof_Picture { get; set; }
        public string Presenter_Prof_Description { get; set; }
        public string Presenter_Prof_Experience { get; set; }
        public Nullable<double> Presenter_Prof_Rating { get; set; }
        public string Presenter_Prof_Course_Outline { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Login_Table> Login_Table { get; set; }
    }
}
