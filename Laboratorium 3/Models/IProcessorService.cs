using Data;

namespace Laboratorium_3.Models
{
    public interface IProcessorService
    {
        int Add(Processor processor);
        void Delete(int id);
        void Update(Processor processor);
        List<Processor> FindAll();
        Processor? FindById(int id);
    }
}
