using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
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

        [Required(ErrorMessage = "ComputerType is required")]
        [Display(Name = "ComputerType")]
        public ComputerType ComputerType { get; set; }

        [HiddenInput]
        public int ProcessorId { get; set; }

        [ValidateNever]
        [Display(Name = "Processor")]
        public Processor Processor { get; set; }

        [ValidateNever]
        public List<SelectListItem> Processors { get; set; }

        [HiddenInput]
        public int StorageId { get; set; }

        [ValidateNever]
        [Display(Name = "Storage")]
        public Storage Storage { get; set; }

        [ValidateNever]
        public List<SelectListItem> Storages { get; set; }

        [HiddenInput]
        public int GraphicsCardId { get; set; }

        [ValidateNever]
        [Display(Name = "Graphics Card")]
        public GraphicsCard GraphicsCard { get; set; }

        [ValidateNever]
        public List<SelectListItem> GraphicsCards { get; set; }

        [Required(ErrorMessage = "Manufacturer is required")]
        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "DateOfManufacture is required")]
        [DataType(DataType.DateTime, ErrorMessage = "It needs to be a date")]
        [Display(Name = "Date of manufacture")]
        public DateTime DateOfManufacture { get; set; }
     }
}
