using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyToyShop.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ten khong de trang")]
        public string Name { get; set; }
        public int? Age { get; set; }
    }
}
