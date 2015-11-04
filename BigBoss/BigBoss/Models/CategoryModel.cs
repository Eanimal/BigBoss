using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigBoss.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category name")]
        public string nameCategory { get; set; }

        [Display(Name = "Category description")]
        [Required]
        public string descriptionCategory { get; set; }
    }
}