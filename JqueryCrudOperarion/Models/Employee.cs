//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JqueryCrudOperarion.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public Nullable<int> Salary { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public Employee()
        {
            ImagePath = "~/AppFiles/Images/blogentry-9885-1231080703_thumb.jpg";
        }
    }
}