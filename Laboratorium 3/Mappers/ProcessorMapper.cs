using Data;
using Laboratorium_3.Models;

namespace Laboratorium_3.Mappers
{
    public class ProcessorMapper
    {
        public static Processor FromEntity(ProcessorEntity entity)
        {
            return new Processor()
            {
                Id = entity.Id,
                Name = entity.Name,
                CoreCount = entity.CoreCount,
                CacheSize = entity.CacheSize,
            };
        }

        public static ProcessorEntity ToEntity(Processor model)
        {
            return new ProcessorEntity()
            {
                Id = model.Id,
                Name = model.Name,
                CoreCount = model.CoreCount,
                CacheSize = model.CacheSize,
            };
        }
    }
}
