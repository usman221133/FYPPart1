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
    
    public partial class CoursesVideosURL
    {
        public int id { get; set; }
        public string CourseURL { get; set; }
        public int Course_id { get; set; }
    
        public virtual TeacherRegisteredCours TeacherRegisteredCours { get; set; }
        public virtual TeacherRegisteredCours TeacherRegisteredCours1 { get; set; }
    }
}