using Data;
using Laboratorium_3.Mappers;

namespace Laboratorium_3.Models
{
    public class EFProcessorService : IProcessorService
    {
        private AppDbContext _context;

        public EFProcessorService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Processor processor)
        {
            var e = _context.Processors.Add(ProcessorMapper.ToEntity(processor));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            ProcessorEntity? find = _context.Processors.Find(id);
            if (find != null)
            {
                _context.Processors.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Processor> FindAll()
        {
            return _context.Processors.Select(e => ProcessorMapper.FromEntity(e)).ToList(); ;
        }

        public Processor? FindById(int id)
        {
            return ProcessorMapper.FromEntity(_context.Processors.Find(id));
        }

        public void Update(Processor processor)
        {
            _context.Processors.Update(ProcessorMapper.ToEntity(processor));
            _context.SaveChanges();
        }
    }
}
