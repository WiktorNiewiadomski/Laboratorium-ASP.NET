using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("computers")]
    public class ComputerEntity
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        public Priority Priority { get; set; }

        [MaxLength(50)]
        [Required]
        public string Processor { get; set; }

        [MaxLength(50)]
        [Required]
        public string Storage { get; set; }

        [MaxLength(50)]
        [Required]
        public string GraphicsCard { get; set; }

        [MaxLength(50)]
        [Required]
        public string Manufacturer { get; set; }

        [Column("manufacture_date")]
        [Required]
        public DateTime DateOfManufacture { get; set; }
    }
}
