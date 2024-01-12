using Data;

namespace Laboratorium_3.Models
{
    public interface IGraphicsCardService
    {
        int Add(GraphicsCard graphicsCard);
        void Delete(int id);
        void Update(GraphicsCard graphicsCard);
        List<GraphicsCard> FindAll();
        GraphicsCard? FindById(int id);
    }
}
