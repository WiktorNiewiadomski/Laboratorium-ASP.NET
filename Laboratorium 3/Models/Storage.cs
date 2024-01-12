using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public class Storage
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Size is required")]
        [Display(Name = "Size")]
        public int Size { get; set; }

        [Required(ErrorMessage = "Type is required")]
        [Display(Name = "Type")]
        public string Type { get; set; }
    }
}
