using Data;

namespace Laboratorium_3.Models
{
    public interface IStorageService
    {
        int Add(Storage storage);
        void Delete(int id);
        void Update(Storage storage);
        List<Storage> FindAll();
        Storage? FindById(int id);
    }
}
