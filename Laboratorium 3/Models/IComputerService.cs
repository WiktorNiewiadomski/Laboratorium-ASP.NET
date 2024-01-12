using Data;

namespace Laboratorium_3.Models
{
    public interface IComputerService
    {
        int Add(Computer computer);
        void Delete(int id);
        void Update(Computer computer);
        List<Computer> FindAll();
        Computer? FindById(int id);
        List<ProcessorEntity> FindAllProcessorsForViewModel();
        List<StorageEntity> FindAllStoragesForViewModel();
        List<GraphicsCardEntity> FindAllGraphicsCardsForViewModel();
    }
}
