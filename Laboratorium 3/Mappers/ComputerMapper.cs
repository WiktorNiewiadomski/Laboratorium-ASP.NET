using Data;
using Laboratorium_3.Models;

namespace Laboratorium_3.Mappers
{
    public class ComputerMapper
    {
        public static Computer FromEntity(ComputerEntity entity)
        {
            return new Computer()
            {
                Id = entity.Id,
                Name = entity.Name,
                ComputerType = (Models.ComputerType)entity.ComputerType,
                ProcessorId = entity.ProcessorId,
                Processor = ProcessorMapper.FromEntity(entity.Processor),
                StorageId = entity.StorageId,
                Storage = StorageMapper.FromEntity(entity.Storage),
                GraphicsCardId = entity.GraphicsCardId,
                GraphicsCard = GraphicsCardMapper.FromEntity(entity.GraphicsCard),
                Manufacturer = entity.Manufacturer,
                DateOfManufacture = entity.DateOfManufacture,
            };
        }

        public static ComputerEntity ToEntity(Computer model)
        {
            return new ComputerEntity()
            {
                Id = model.Id,
                Name = model.Name,
                ComputerType = (Data.ComputerType)model.ComputerType,
                ProcessorId = model.ProcessorId,
                StorageId = model.StorageId,
                GraphicsCardId = model.GraphicsCardId,
                Manufacturer = model.Manufacturer,
                DateOfManufacture = model.DateOfManufacture,
            };
        }
    }
}
