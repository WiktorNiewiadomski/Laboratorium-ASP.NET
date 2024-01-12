using Data;
using Laboratorium_3.Mappers;
using Microsoft.EntityFrameworkCore;

namespace Laboratorium_3.Models
{
    public class EFComputerService : IComputerService
    {
        private AppDbContext _context;

        public EFComputerService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Computer computer)
        {
            var e = _context.Computers.Add(ComputerMapper.ToEntity(computer));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            ComputerEntity? find = _context.Computers.Find(id);
            if (find != null)
            {
                _context.Computers.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Computer> FindAll()
        {
            return _context.Computers
                .Include(c => c.Processor)
                .Include(c => c.Storage)
                .Include(c => c.GraphicsCard)
                .Select(e => ComputerMapper.FromEntity(e))
                .ToList(); ;
        }

        public List<GraphicsCardEntity> FindAllGraphicsCardsForViewModel()
        {
            return _context.GraphicsCards.ToList();
        }

        public List<ProcessorEntity> FindAllProcessorsForViewModel()
        {
            return _context.Processors.ToList();
        }

        public List<StorageEntity> FindAllStoragesForViewModel()
        {
            return _context.Storages.ToList();
        }

        public Computer? FindById(int id)
        {
            return ComputerMapper.FromEntity(_context.Computers
                .Include(c => c.Processor)
                .Include(c => c.Storage)
                .Include(c => c.GraphicsCard)
                .First(c => c.Id == id)
                );
        }

        public void Update(Computer computer)
        {
            _context.Computers.Update(ComputerMapper.ToEntity(computer));
            _context.SaveChanges();
        }
    }
}
