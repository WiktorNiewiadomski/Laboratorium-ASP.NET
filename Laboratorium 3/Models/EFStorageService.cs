using Data;
using Laboratorium_3.Mappers;

namespace Laboratorium_3.Models
{
    public class EFStorageService : IStorageService
    {
        private AppDbContext _context;

        public EFStorageService(AppDbContext context)
        {
            _context = context;
        }

        public int Add(Storage storage)
        {
            var e = _context.Storages.Add(StorageMapper.ToEntity(storage));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            StorageEntity? find = _context.Storages.Find(id);
            if (find != null)
            {
                _context.Storages.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Storage> FindAll()
        {
            return _context.Storages.Select(e => StorageMapper.FromEntity(e)).ToList(); ;
        }

        public Storage? FindById(int id)
        {
            return StorageMapper.FromEntity(_context.Storages.Find(id));
        }

        public void Update(Storage storage)
        {
            _context.Storages.Update(StorageMapper.ToEntity(storage));
            _context.SaveChanges();
        }
    }
}
