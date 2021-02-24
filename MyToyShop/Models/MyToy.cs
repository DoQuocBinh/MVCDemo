using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyToyShop.Models
{
    public partial class MyToy
    {
        public int ProductId { get; set; }

        [RegularExpression(@"^.{5,}$", ErrorMessage = "Min nhat 5 ky tu")]
        [Required(ErrorMessage = "Name can't be empty!"),
           StringLength(8, MinimumLength = 5, ErrorMessage = "Max is 8 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Khong de trang")]
        [Range(100, 200, ErrorMessage = "Min max: 100-200")]
        public decimal? Price { get; set; }
    }
}
