using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Table("storages")]
    public class StorageEntity
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int Size { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }

        public ISet<ComputerEntity> Computers { get; set; }
    }
}
