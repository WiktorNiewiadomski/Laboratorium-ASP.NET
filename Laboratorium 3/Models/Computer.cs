using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public class Computer
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Priority is required")]
        [Display(Name = "Priority")]
        public Priority Priority { get; set; }

        [Required(ErrorMessage = "Processor is required")]
        [Display(Name = "Processor")]
        public string Processor { get; set; }

        [Required(ErrorMessage = "Storage is required")]
        [Display(Name = "Storage")]
        public string Storage { get; set; }

        [Required(ErrorMessage = "GraphicsCard is required")]
        [Display(Name = "GraphicsCard")]
        public string GraphicsCard { get; set; }

        [Required(ErrorMessage = "Manufacturer is required")]
        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "DateOfManufacture is required")]
        [DataType(DataType.DateTime, ErrorMessage = "It needs to be a date")]
        [Display(Name = "DateOfManufacture")]
        public DateTime DateOfManufacture { get; set; }
     }
}
