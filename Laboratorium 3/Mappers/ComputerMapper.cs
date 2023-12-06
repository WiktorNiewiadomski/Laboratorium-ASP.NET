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
                Priority = (Models.Priority)entity.Priority,
                Processor = entity.Processor,
                Storage = entity.Storage,
                GraphicsCard = entity.GraphicsCard,
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
                Priority = (Data.Priority)model.Priority,
                Processor = model.Processor,
                Storage = model.Storage,
                GraphicsCard = model.GraphicsCard,
                Manufacturer = model.Manufacturer,
                DateOfManufacture = model.DateOfManufacture,
            };
        }
    }
}
