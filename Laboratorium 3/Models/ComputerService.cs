using Data;

namespace Laboratorium_3.Models
{
    public class ComputerService : IComputerService
    {
        private Dictionary<int, Computer> _items = new Dictionary<int, Computer>();
        public int Add(Computer item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Computer> FindAll()
        {
            return _items.Values.ToList();
        }

        public List<GraphicsCardEntity> FindAllGraphicsCardsForViewModel()
        {
            throw new NotImplementedException();
        }

        public List<ProcessorEntity> FindAllProcessorsForViewModel()
        {
            throw new NotImplementedException();
        }

        public List<StorageEntity> FindAllStoragesForViewModel()
        {
            throw new NotImplementedException();
        }

        public Computer? FindById(int id)
        {
            return _items[id];
        }

        public void Update(Computer item)
        {
            _items[item.Id] = item;
        }
    }
}
