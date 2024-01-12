using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public class GraphicsCard
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Memory is required")]
        [Display(Name = "Memory")]
        public int Memory { get; set; }
    }
}
