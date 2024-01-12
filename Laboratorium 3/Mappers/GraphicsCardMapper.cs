using Data;
using Laboratorium_3.Models;

namespace Laboratorium_3.Mappers
{
    public class GraphicsCardMapper
    {
        public static GraphicsCard FromEntity(GraphicsCardEntity entity)
        {
            return new GraphicsCard()
            {
                Id = entity.Id,
                Name = entity.Name,
                Memory = entity.Memory,
            };
        }

        public static GraphicsCardEntity ToEntity(GraphicsCard model)
        {
            return new GraphicsCardEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Memory = model.Memory,
            };
        }
    }
}
