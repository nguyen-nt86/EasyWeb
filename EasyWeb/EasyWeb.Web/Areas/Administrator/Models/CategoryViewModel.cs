using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWeb.Web.Areas.Administrator.Models
{
    public class CategoryViewModel
    {
        [Display(Name ="Mã số danh mục")]
        public int CategoryId { get; set; }

        [Display(Name = "Tên danh mục")]
        public string CategoryName { get; set; }
    }
}
