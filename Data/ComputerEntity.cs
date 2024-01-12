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
        public ComputerType ComputerType { get; set; }

        
        public int ProcessorId { get; set; }
        public ProcessorEntity Processor { get; set; }

        public int StorageId { get; set; }
        public StorageEntity Storage { get; set; }

        public int GraphicsCardId { get; set; }
        public GraphicsCardEntity GraphicsCard { get; set; }

        [MaxLength(50)]
        [Required]
        public string Manufacturer { get; set; }

        [Column("manufacture_date")]
        [Required]
        public DateTime DateOfManufacture { get; set; }
    }
}
