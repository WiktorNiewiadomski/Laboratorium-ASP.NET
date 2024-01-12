using Data;
using Laboratorium_3.Models;

namespace Laboratorium_3.Mappers
{
    public class StorageMapper
    {
        public static Storage FromEntity(StorageEntity entity)
        {
            return new Storage()
            {
                Id = entity.Id,
                Name = entity.Name,
                Size = entity.Size,
                Type = entity.Type,
            };
        }

        public static StorageEntity ToEntity(Storage model)
        {
            return new StorageEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Size = model.Size,
                Type = model.Type,
            };
        }
    }
}
