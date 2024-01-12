using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public enum ComputerType
    {
        [Display(Name = "Budżetowy")] Budget = 1,
        [Display(Name = "Gamingowy")] Gaming = 2,
        [Display(Name = "Biznes")] Biznes = 3,
        [Display(Name = "Premium")] Premium = 4
    }
}
