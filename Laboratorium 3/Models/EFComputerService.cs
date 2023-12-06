using Data;
using Laboratorium_3.Mappers;

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
            }
        }

        public List<Computer> FindAll()
        {
            return _context.Computers.Select(e => ComputerMapper.FromEntity(e)).ToList(); ;
        }

        public Computer? FindById(int id)
        {
            return ComputerMapper.FromEntity(_context.Computers.Find(id));
        }

        public void Update(Computer computer)
        {
            _context.Computers.Update(ComputerMapper.ToEntity(computer));
        }
    }
}
