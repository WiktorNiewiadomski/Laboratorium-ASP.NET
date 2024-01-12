using Data;
using Laboratorium_3.Mappers;

namespace Laboratorium_3.Models
{
    public class EFGraphicsCardService : IGraphicsCardService
    {
        private AppDbContext _context;

        public EFGraphicsCardService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(GraphicsCard graphicsCard)
        {
            var e = _context.GraphicsCards.Add(GraphicsCardMapper.ToEntity(graphicsCard));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            GraphicsCardEntity? find = _context.GraphicsCards.Find(id);
            if (find != null)
            {
                _context.GraphicsCards.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<GraphicsCard> FindAll()
        {
            return _context.GraphicsCards.Select(e => GraphicsCardMapper.FromEntity(e)).ToList(); ;
        }

        public GraphicsCard? FindById(int id)
        {
            return GraphicsCardMapper.FromEntity(_context.GraphicsCards.Find(id));
        }

        public void Update(GraphicsCard graphicsCard)
        {
            _context.GraphicsCards.Update(GraphicsCardMapper.ToEntity(graphicsCard));
            _context.SaveChanges();
        }
    }
}
