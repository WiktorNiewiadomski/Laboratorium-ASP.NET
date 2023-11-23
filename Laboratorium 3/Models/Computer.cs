using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public class Computer
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Processor is required")]
        public string Processor { get; set; }
        [Required(ErrorMessage = "Storage is required")]
        public string Storage { get; set; }
        [Required(ErrorMessage = "GraphicsCard is required")]
        public string GraphicsCard { get; set; }
        [Required(ErrorMessage = "Manufacturer is required")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "DateOfManufacture is required")]
        [DataType(DataType.DateTime, ErrorMessage = "It needs to be a date")]
        public DateTime DateOfManufacture { get; set; }
     }
}
