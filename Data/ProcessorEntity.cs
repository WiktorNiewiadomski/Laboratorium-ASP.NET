using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("processors")]
    public class ProcessorEntity
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int CoreCount { get; set; }

        [Required]
        public int CacheSize { get; set; }

        public ISet<ComputerEntity> Computers { get; set; }
    }
}
