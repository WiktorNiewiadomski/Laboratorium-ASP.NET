using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public class Processor
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CoreCount is required")]
        [Display(Name = "CoreCount")]
        public int CoreCount { get; set; }

        [Required(ErrorMessage = "CacheSize is required")]
        [Display(Name = "CacheSize")]
        public int CacheSize { get; set; }
    }
}
