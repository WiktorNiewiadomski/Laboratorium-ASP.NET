namespace Laboratorium_3.Models
{
    public interface IComputerService
    {
        int Add(Computer book);
        void Delete(int id);
        void Update(Computer book);
        List<Computer> FindAll();
        Computer? FindById(int id);
    }
}
